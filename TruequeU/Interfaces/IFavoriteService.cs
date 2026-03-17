using TruequeU.Models;

namespace TruequeU.Interfaces
{
    public interface IFavoriteService
    {
        // Agrega un listing a favoritos de un usuario
        Task<Favorite> AddFavorite(Guid userId, Guid listingId);

        // Quita un listing de favoritos de un usuario
        Task RemoveFavorite(Guid userId, Guid listingId);

        // Obtiene todos los listings favoritos de un usuario
        Task<List<Listing>> GetFavorites(Guid userId, string identifier);
    }
}