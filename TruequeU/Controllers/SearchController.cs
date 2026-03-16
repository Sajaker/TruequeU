using Microsoft.AspNetCore.Mvc;
using TruequeU.Interfaces;
using TruequeU.Models;

namespace TruequeU.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SearchController : ControllerBase
    {
        private readonly ISearchService _searchService;

        public SearchController(ISearchService searchService)
        {
            _searchService = searchService;
        }

        // GET api/search
        // Ejemplo de uso:
        //   /api/search?keyword=bicicleta&category=Deportes&minPrice=10&maxPrice=100&condition=Usado&state=Available
        // Todos los parámetros son opcionales. Si no mandas ninguno, devuelve todos los listings visibles.
        [HttpGet]
        public ActionResult<List<Listing>> Search(
            [FromQuery] string? keyword,
            [FromQuery] string? category,
            [FromQuery] decimal? minPrice,
            [FromQuery] decimal? maxPrice,
            [FromQuery] string? condition,
            [FromQuery] string? state,
            [FromQuery] DateTime? postedAfter)
        {
            var results = _searchService.SearchListings(
                keyword, category, minPrice, maxPrice, condition, state, postedAfter);

            return Ok(results);
        }
    }
}
