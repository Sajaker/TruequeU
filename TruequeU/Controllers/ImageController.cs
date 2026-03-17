using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Claims;
using TruequeU.Interfaces;
using TruequeU.Models;

namespace TruequeU.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ImageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        private readonly iImageService _imgService;

        public ImageController(iImageService imgService)
        {
            _imgService = imgService;
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> getImagesByListing(Guid listing_id)
        {
            var images = await _imgService.getImagesByListing(listing_id);
            //Se refactoriza condicion por una operación ternaria o si corto
            return images != null ? Ok(images) : NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> AddImage([FromBody] Images newImg)
        {
            string identifier = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var createdImg = await _imgService.addImage(newImg, identifier);
            return Ok(createdImg);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> deleteImage(Guid image_id)
        {
            string identifier = User.FindFirstValue(ClaimTypes.NameIdentifier);
            await _imgService.deleteImage(image_id, identifier);
            return Ok();
        }
    }
}
