using TruequeU.Models;

namespace TruequeU.Interfaces
{
    public interface IModerationService
    {
        void HideListing(int listingId, int adminId, string reason);

        void SuspendUser(int userId, int adminId, string reason);
    }
}
