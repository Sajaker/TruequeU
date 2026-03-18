using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TruequeU.Interfaces;

namespace TruequeU.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(Roles = "Admin")]
    public class ModerationController : ControllerBase
    {
        private readonly IModerationService _moderationService;

        public ModerationController(IModerationService moderationService)
        {
            _moderationService = moderationService;
        }

        [HttpPost("hide-listing")]
        public IActionResult HideListing(Guid listingId, Guid adminId, string reason)
        {
            _moderationService.HideListing(listingId, adminId, reason);
            return Ok("Listing hidden");
        }

        [HttpPost("suspend-user")]
        public IActionResult SuspendUser(Guid userId, Guid adminId, string reason)
        {
            _moderationService.SuspendUser(userId, adminId, reason);
            return Ok("User suspended");
        }
    }
}
