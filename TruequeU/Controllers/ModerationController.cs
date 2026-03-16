using Microsoft.AspNetCore.Mvc;
using TruequeU.Interfaces;

namespace TruequeU.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ModerationController : ControllerBase
    {
        private readonly IModerationService _moderationService;

        public ModerationController(IModerationService moderationService)
        {
            _moderationService = moderationService;
        }

        [HttpPost("hide-listing")]
        public IActionResult HideListing(int listingId, int adminId, string reason)
        {
            _moderationService.HideListing(listingId, adminId, reason);
            return Ok("Listing hidden");
        }

        [HttpPost("suspend-user")]
        public IActionResult SuspendUser(int userId, int adminId, string reason)
        {
            _moderationService.SuspendUser(userId, adminId, reason);
            return Ok("User suspended");
        }
    }
}
