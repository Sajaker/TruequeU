using TruequeU.DAO;
using TruequeU.Interfaces;
using TruequeU.Models;

namespace TruequeU.Services
{
    public class SearchService : ISearchService
    {
        private readonly ApplicationDbContext _context;

        public SearchService(ApplicationDbContext context)
        {
            _context = context;
        }

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
    }
}
