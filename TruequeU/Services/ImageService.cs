using TruequeU.DAO;
using TruequeU.Interfaces;
using TruequeU.Models;
using Microsoft.EntityFrameworkCore;

namespace TruequeU.Services
{
    public class ImageService : iImageService
    {
        private readonly ApplicationDbContext _context;

        public ImageService(ApplicationDbContext context)
        {
            _context = context;
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
