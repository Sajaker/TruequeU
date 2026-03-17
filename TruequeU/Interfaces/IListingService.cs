using TruequeU.Models;

namespace TruequeU.Interfaces
{
    public interface IListingService
    {
        Task<Listing> Create(Listing listing);
        Task<bool> UpdateStatus(Guid id, String status);

        Task<List<Listing>> GetAll();

        Task<Listing> getById(Guid id);

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
