using TruequeU.DAO;
using TruequeU.Interfaces;
using TruequeU.Models;

namespace TruequeU.Services
{
    public class ModerationService : IModerationService
    {
        private readonly ApplicationDbContext _context;

        public ModerationService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void HideListing(int listingId, int adminId, string reason)
        {
            var listing = _context.Listings.Find(listingId);

            if (listing == null)
                throw new Exception("Listing not found");

            listing.IsHidden = true;

            var action = new ModerationAction
            {
                AdminId = adminId,
                ListingId = listingId,
                ActionType = "HideListing",
                Reason = reason,
                CreatedAt = DateTime.UtcNow
            };

            _context.ModerationActions.Add(action);
            _context.SaveChanges();
        }

        public void SuspendUser(int userId, int adminId, string reason)
        {
            var user = _context.Users.Find(userId);

            if (user == null)
                throw new Exception("User not found");

            user.IsSuspended = true;

            var action = new ModerationAction
            {
                AdminId = adminId,
                TargetUserId = userId,
                ActionType = "SuspendUser",
                Reason = reason,
                CreatedAt = DateTime.UtcNow
            };

            _context.ModerationActions.Add(action);
            _context.SaveChanges();
        }
    }
}
