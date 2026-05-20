using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using TruequeU.DAO;
using TruequeU.Interfaces;
using TruequeU.Models;

namespace TruequeU.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(Roles = "Admin,User")]
    public class FavoritesController : ControllerBase
    {
        private readonly IFavoriteService _favoriteService;
        private readonly ApplicationDbContext _context;

        public FavoritesController(
            IFavoriteService favoriteService,
            ApplicationDbContext context)
        {
            _favoriteService = favoriteService;
            _context = context;
        }

        // POST api/favorites/{listingId}
        // Agrega un listing a favoritos
        [HttpPost("{listingId}")]
        public async Task<ActionResult<Favorite>> AddFavorite(
            Guid listingId)
        {
            try
            {
                string? identityId = User.FindFirstValue(
                    ClaimTypes.NameIdentifier
                );

                if (string.IsNullOrEmpty(identityId))
                {
                    return Unauthorized();
                }

                var user = await _context.Users
                    .FirstOrDefaultAsync(u =>
                        u.IdentityUserId == identityId);

                if (user == null)
                {
                    return NotFound("Usuario no encontrado.");
                }

                var favorite = await _favoriteService
                    .AddFavorite(user.Id, listingId);

                return Ok(favorite);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/favorites/{listingId}
        // Quita un listing de favoritos
        [HttpDelete("{listingId}")]
        public async Task<ActionResult> RemoveFavorite(
            Guid listingId)
        {
            try
            {
                string? identityId = User.FindFirstValue(
                    ClaimTypes.NameIdentifier
                );

                if (string.IsNullOrEmpty(identityId))
                {
                    return Unauthorized();
                }

                var user = await _context.Users
                    .FirstOrDefaultAsync(u =>
                        u.IdentityUserId == identityId);

                if (user == null)
                {
                    return NotFound("Usuario no encontrado.");
                }

                await _favoriteService.RemoveFavorite(
                    user.Id,
                    listingId,
                    identityId
                );

                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/favorites
        // Obtiene favoritos del usuario autenticado
        [HttpGet]
        public async Task<ActionResult<List<Listing>>> GetFavorites()
        {
            try
            {
                string? identityId = User.FindFirstValue(
                    ClaimTypes.NameIdentifier
                );

                if (string.IsNullOrEmpty(identityId))
                {
                    return Unauthorized();
                }

                var user = await _context.Users
                .FirstOrDefaultAsync(u =>
                    u.IdentityUserId != null &&
                    u.IdentityUserId == identityId);

                if (user == null)
                {
                    return NotFound("Usuario no encontrado.");
                }

                var favorites = await _favoriteService
                    .GetFavorites(user.Id, identityId);

                return Ok(favorites);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}