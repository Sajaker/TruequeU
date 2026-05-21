using Microsoft.AspNetCore.Identity;
using TruequeU.Models;

namespace TruequeU.Interfaces
{
    public interface IChatService
    {
        Task<Chat?> StartChat(Guid listingId, string identityUserId);
        Task<Message?> SendMessage(Guid chatId, string identityUserId, string content);
        Task<List<Message>> GetMessages(Guid chatId);
        Task<List<Chat?>> GetUserChats(string identityUserId);
    }
}