using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TruequeU.Interfaces;
using TruequeU.Models;

namespace TruequeU.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    //// con este DataAnnotation solo se dejará ejecutar los endpoint a los JWT que sea de Admin
    //// Si se quiere agregar ás roles se separa por comas Admin,User,Colab
    //[Authorize(Roles = "Admin")]

    public class ListingController : Controller
    {
        private readonly IListingService _listingService;

        public ListingController(IListingService listingService)
        {
            _listingService = listingService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        // Este DataAnnotation sirve para que este endpoint en específico no requiera de autenticación
        // Por defecto el authorize toma todos los endpoints que no tengan este indicativo
        [AllowAnonymous]
        public async Task<IActionResult> GetAll() => Ok(await _listingService.GetAll());

        [HttpGet("{id}")]
        public async Task<IActionResult> getById(Guid id)
        {
            var listing = await _listingService.getById(id);
            //Se refactoriza condicion por una operación ternaria o si corto
            return listing != null ? Ok(listing) : NotFound("No listing found");
        }
        [HttpGet("{search}")]
        public ActionResult<List<Listing>> Search(
            [FromQuery] string? keyword,
            [FromQuery] string? category,
            [FromQuery] decimal? minPrice,
            [FromQuery] decimal? maxPrice,
            [FromQuery] string? condition,
            [FromQuery] string? state,
            [FromQuery] DateTime? postedAfter)
        {
            var results = _listingService.SearchListings(
                keyword, category, minPrice, maxPrice, condition, state, postedAfter);

            return Ok(results);
            // GET api/search
            // Ejemplo de uso:
            //   /api/search?keyword=bicicleta&category=Deportes&minPrice=10&maxPrice=100&condition=Usado&state=Available
            // Todos los parámetros son opcionales. Si no mandas ninguno, devuelve todos los listings visibles.
        }
    }
}
