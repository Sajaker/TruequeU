using TruequeU.Models;

namespace TruequeU.Interfaces
{
    public interface IModerationService
    {
        void HideListing(Guid listingId, Guid adminId, string reason);

        void SuspendUser(Guid userId, Guid adminId, string reason);
    }
}
