using TruequeU.Models;

namespace TruequeU.Interfaces
{
    public interface ISearchService
    {
        // Busca listings con filtros opcionales
        List<Listing> SearchListings(
            string? keyword,
            string? category,
            decimal? minPrice,
            decimal? maxPrice,
            string? condition,
            string? state,
            DateTime? postedAfter
        );
    }
}
