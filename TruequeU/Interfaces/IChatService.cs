using TruequeU.Models;

namespace TruequeU.Interfaces
{
    public interface IChatService
    {
        Task<Chat> StartChat(Guid listingId, Guid sellerId, Guid buyerId, string identifier);

        Task<Message> SendMessage(Guid chatId, Guid senderId, string content);

        Task<List<Message>> GetMessages(Guid chatId);
    }
}
