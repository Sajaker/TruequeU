using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using TruequeU.Interfaces;
using TruequeU.Models;

namespace TruequeU.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FavoritesController : ControllerBase
    {
        private readonly IFavoriteService _favoriteService;

        public FavoritesController(IFavoriteService favoriteService)
        {
            _favoriteService = favoriteService;
        }

        // POST api/favorites?userId=1&listingId=5
        // Agrega un listing a favoritos
        [HttpPost]
        public ActionResult<Favorite> AddFavorite([FromQuery] Guid userId, [FromQuery] Guid listingId)
        {
            try
            {
                var favorite = _favoriteService.AddFavorite(userId, listingId);
                return Ok(favorite);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/favorites?userId=1&listingId=5
        // Quita un listing de favoritos
        [HttpDelete]
        public ActionResult RemoveFavorite([FromQuery] Guid userId, [FromQuery] Guid listingId)
        {
            try
            {
                _favoriteService.RemoveFavorite(userId, listingId);
                return Ok("Listing eliminado de favoritos.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/favorites/1
        // Obtiene todos los listings favoritos de un usuario
        [HttpGet("{userId}")]
        public ActionResult<List<Listing>> GetFavorites(Guid userId)
        {
            string identifier = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var favorites = _favoriteService.GetFavorites(userId, identifier);
            return Ok(favorites);
        }
    }
}
