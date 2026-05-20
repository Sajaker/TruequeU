using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Claims;
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

        [HttpPost]
        [Authorize(Roles = "Admin,User")]
        public async Task<IActionResult> CreateListing([FromBody] Listing listing)
        {
            var identityUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (identityUserId == null)
                return Unauthorized();

            var created = await _listingService.Create(listing, identityUserId);

            if (created == null)
                return BadRequest();

            return Ok(created);
        }

        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<IActionResult> getById(Guid id)
        {
            var listing = await _listingService.getById(id);
            //Se refactoriza condicion por una operación ternaria o si corto
            return listing != null ? Ok(listing) : NotFound("No listing found");
        }
        [HttpGet("search")]
        [AllowAnonymous]
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

        [HttpGet("image")]
        [AllowAnonymous]
        public async Task<IActionResult> getImagesByListing(Guid listing_id)
        {
            var images = await _listingService.getImagesByListing(listing_id);
            //Se refactoriza condicion por una operación ternaria o si corto
            return images != null ? Ok(images) : NotFound();
        }

        [HttpPost("image")]
        [Authorize(Roles = "Admin,User")]
        public async Task<IActionResult> AddImage([FromBody] Images newImg)
        {
            string identifier = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var createdImg = await _listingService.addImage(newImg, identifier);
            return Ok(createdImg);
        }

        [HttpDelete("image")]
        [Authorize(Roles = "Admin,User")]
        public async Task<IActionResult> deleteImage(Guid image_id)
        {
            string identifier = User.FindFirstValue(ClaimTypes.NameIdentifier);
            await _listingService.deleteImage(image_id, identifier);
            return Ok();
        }
    }
}
