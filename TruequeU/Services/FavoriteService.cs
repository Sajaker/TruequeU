using TruequeU.DAO;
using TruequeU.Interfaces;
using TruequeU.Models;
using Microsoft.EntityFrameworkCore;

namespace TruequeU.Services
{
    public class FavoriteService : IFavoriteService
    {
        private readonly ApplicationDbContext _context;

        public FavoriteService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Favorite> AddFavorite(Guid userId, Guid listingId)
        {
            // Verificar que el listing existe
            var listing = _context.Listings.Find(listingId);
            if (listing == null)
                throw new Exception("El listing no existe.");

            // Verificar que el usuario existe
            var user = _context.Users.Find(userId);
            if (user == null)
                throw new Exception("El usuario no existe.");

            // Si ya está en favoritos, no lo duplicamos
            var existing = _context.Favorites
                .FirstOrDefault(f => f.UserId == userId && f.ListingId == listingId);

            if (existing != null)
                return existing;

            // Crear el favorito
            var favorite = new Favorite
            {
                UserId = userId,
                ListingId = listingId,
                CreatedAt = DateTime.UtcNow
            };

            _context.Favorites.Add(favorite);
           await _context.SaveChangesAsync();
            return favorite;
        }

        public async Task RemoveFavorite(Guid userId, Guid listingId)
        {
            var favorite = _context.Favorites
                .FirstOrDefault(f => f.UserId == userId && f.ListingId == listingId);

            if (favorite == null)
                throw new Exception("Este listing no está en tus favoritos.");

            _context.Favorites.Remove(favorite);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Listing>> GetFavorites(Guid userId, string identifier)
        {
            if (!await validateIdentity(userId, identifier)) return null;
            // Traemos los listings favoritos del usuario con sus datos completos
            return await _context.Favorites
                .Where(f => f.UserId == userId)
                .Include(f => f.Listing)
                .Select(f => f.Listing)
                .ToListAsync();
        }
        private async Task<bool> validateIdentity(Guid client, string identifier)
        {
            var clientExist = await _context.Users.FindAsync(client);
            return identifier == clientExist?.IdentityUserId;
        }
    }
}
