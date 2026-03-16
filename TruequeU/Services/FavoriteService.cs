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

        public Favorite AddFavorite(int userId, int listingId)
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
            _context.SaveChanges();
            return favorite;
        }

        public void RemoveFavorite(int userId, int listingId)
        {
            var favorite = _context.Favorites
                .FirstOrDefault(f => f.UserId == userId && f.ListingId == listingId);

            if (favorite == null)
                throw new Exception("Este listing no está en tus favoritos.");

            _context.Favorites.Remove(favorite);
            _context.SaveChanges();
        }

        public List<Listing> GetFavorites(int userId)
        {
            // Traemos los listings favoritos del usuario con sus datos completos
            return _context.Favorites
                .Where(f => f.UserId == userId)
                .Include(f => f.Listing)
                .Select(f => f.Listing)
                .ToList();
        }
    }
}
