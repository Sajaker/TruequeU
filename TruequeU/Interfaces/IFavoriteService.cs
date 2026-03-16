using TruequeU.Models;

namespace TruequeU.Interfaces
{
    public interface IFavoriteService
    {
        // Agrega un listing a favoritos de un usuario
        Favorite AddFavorite(int userId, int listingId);

        // Quita un listing de favoritos de un usuario
        void RemoveFavorite(int userId, int listingId);

        // Obtiene todos los listings favoritos de un usuario
        List<Listing> GetFavorites(int userId);
    }
}