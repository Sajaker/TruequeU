using TruequeU.Models;

namespace TruequeU.Interfaces
{
    public interface IChatService
    {
        Chat StartChat(int listingId, int buyerId, int sellerId);

        Message SendMessage(int chatId, int senderId, string content);

        List<Message> GetMessages(int chatId);
    }
}
