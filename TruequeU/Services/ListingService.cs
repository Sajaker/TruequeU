using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Reflection;
using TruequeU.DAO;
using TruequeU.Interfaces;
using TruequeU.Models;
using TruequeU.Services;
using static System.Net.Mime.MediaTypeNames;

namespace TruequeU.Services
{
    public class ListingService:IListingService
    {
        private readonly ApplicationDbContext _context;

        public ListingService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Listing>> GetAll()
        {
            return await _context.Listings.ToListAsync();
        }
        public async Task<Listing> Create(Listing newListing)
        {
            if (newListing.Images == null || newListing.Images.Count < 3)
                return null;

            var images = new List<Images>();

            foreach (var img in newListing.Images)
            {
                var newImg = new Images
                {
                    url = img.url,
                    listing_id = newListing.Id 
                };

                images.Add(newImg);
            }
            newListing.Images = images;

            _context.Listings.Add(newListing);
            await _context.SaveChangesAsync();

            return newListing;
        }
        public async Task<bool> UpdateStatus(Guid id, String status)
        {
            //validar la existencia de la entidad
            var listingExists = await getById(id);
            if (listingExists == null) return false;
            if (status != "Available" && status != "Reserved" && status != "Sold") return false; //no aceptar estados invalidos
            if (listingExists.State == "Sold") return false; //no aceptar cambios si ya esta vendido
            listingExists.State = status;
            await _context.SaveChangesAsync();

            return true;
        }
        public async Task<Listing> getById(Guid id) => await _context.Listings.FindAsync(id);

        public List<Listing> SearchListings(
            string? keyword,
            string? category,
            decimal? minPrice,
            decimal? maxPrice,
            string? condition,
            string? state,
            DateTime? postedAfter)
        {
            // Empezamos con todos los listings que NO están ocultos por moderación
            var query = _context.Listings
                .Where(l => !l.IsHidden);

            // Filtro por palabra clave: busca en título o descripción
            if (!string.IsNullOrWhiteSpace(keyword))
            {
                var kw = keyword.ToLower();
                query = query.Where(l =>
                    l.Title.ToLower().Contains(kw) ||
                    l.Description.ToLower().Contains(kw));
            }

            // Filtro por categoría
            if (!string.IsNullOrWhiteSpace(category))
                query = query.Where(l => l.Category == category);

            // Filtro por precio mínimo
            if (minPrice.HasValue)
                query = query.Where(l => l.Price >= minPrice.Value);

            // Filtro por precio máximo
            if (maxPrice.HasValue)
                query = query.Where(l => l.Price <= maxPrice.Value);

            // Filtro por condición (Nuevo, Usado, etc.)
            if (!string.IsNullOrWhiteSpace(condition))
                query = query.Where(l => l.Condition == condition);

            // Filtro por estado del listing (Available, Reserved, Sold)
            if (!string.IsNullOrWhiteSpace(state))
                query = query.Where(l => l.State == state);

            // Filtro por fecha de publicación
            // NOTA: Listing no tiene CreatedAt aún — ver instrucciones abajo
            // if (postedAfter.HasValue)
            //     query = query.Where(l => l.CreatedAt >= postedAfter.Value);

            return query.ToList();
        }

        public async Task<Images> addImage(Images newImg, string identifier)
        {
            // buscar listing real en DB
            var listing = await _context.Listings
                .FirstOrDefaultAsync(l => l.Id == newImg.listing_id);
            if (listing == null)
                throw new Exception("Listing not found");
            // obtener dueño real
            var owner_id = listing.UserId;
            // validar identidad
            if (!await validateIdentity(owner_id, identifier))
                return null;
            // guardar imagen
            _context.Images.Add(newImg);
            await _context.SaveChangesAsync();
            return newImg;
        }
        public async Task<List<Images>?> getImagesByListing(Guid listing_id)
        {
            return await _context.Images.Include(t => t.ListingAsc).Where(c => c.listing_id == listing_id).ToListAsync();
        }

        public async Task deleteImage(Guid image_id, string identifier)
        {
            var image = await _context.Images
                .Include(i => i.ListingAsc)
                .FirstOrDefaultAsync(e => e.id == image_id);
            if (image == null)
                throw new Exception("Esta imagen no existe.");
            // obtener dueño real del listing
            var owner_id = image.ListingAsc.UserId;
            // validar identidad
            if (!await validateIdentity(owner_id, identifier))
                throw new Exception("Autentificación fallida.");
            _context.Images.Remove(image);
            await _context.SaveChangesAsync();
        }
        //Validacion de Token
        private async Task<bool> validateIdentity(Guid client, string identifier)
        {
            var clientExist = await _context.Users.FindAsync(client);
            return identifier == clientExist?.IdentityUserId;
        }
    }
}
