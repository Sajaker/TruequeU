using Microsoft.AspNetCore.Mvc;
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
        public ActionResult<Favorite> AddFavorite([FromQuery] int userId, [FromQuery] int listingId)
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
        public ActionResult RemoveFavorite([FromQuery] int userId, [FromQuery] int listingId)
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
        public ActionResult<List<Listing>> GetFavorites(int userId)
        {
            var favorites = _favoriteService.GetFavorites(userId);
            return Ok(favorites);
        }
    }
}
