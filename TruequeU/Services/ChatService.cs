using TruequeU.DAO;
using TruequeU.Interfaces;
using TruequeU.Models;
using Microsoft.EntityFrameworkCore;

namespace TruequeU.Services
{
    public class ChatService : IChatService
    {
        private readonly ApplicationDbContext _context;

        public ChatService(ApplicationDbContext context)
        {
            _context = context;
        }

        // Iniciar chat desde un listing
        public async Task<Chat> StartChat(Guid listingId, Guid sellerId, Guid buyerId, string identifier)
        {
            if (!await validateIdentity(buyerId, identifier)) return null; //el comprador inicia el chat
            var chat = new Chat
            {
                ListingId = listingId,
                BuyerId = buyerId,
                SellerId = sellerId,
                Messages = new List<Message>()
            };

            _context.Chats.Add(chat);
            await _context.SaveChangesAsync();

            return chat;
        }

        // Enviar mensaje
        public async Task<Message> SendMessage(Guid chatId, Guid senderId, string content)
        {
            var chat = _context.Chats.Find(chatId);

            if (chat == null)
                throw new Exception("Chat not found");

            if (senderId != chat.BuyerId && senderId!=chat.SellerId)
                throw new Exception("Chat not found");

            var message = new Message
            {
                ChatId = chatId,
                SenderId = senderId,
                Content = content,
                SentAt = DateTime.UtcNow
            };

            _context.Messages.Add(message);
            await _context.SaveChangesAsync();

            return message;
        }

        // Obtener todos los mensajes de un chat
        public async Task<List<Message>> GetMessages(Guid chatId)
        {
            return await _context.Messages
                .Where(m => m.ChatId == chatId)
                .OrderBy(m => m.SentAt)
                .ToListAsync();
        }

        // Obtener chat por listing y comprador
        public async Task<Chat> GetChatByListing(Guid listingId, Guid buyerId)
        {
            return await _context.Chats
                .Include(c => c.Messages)
                .FirstOrDefaultAsync(c => c.ListingId == listingId && c.BuyerId == buyerId);
        }



        private async Task<bool> validateIdentity(Guid client, string identifier)
        {
            var clientExist = await _context.Users.FindAsync(client);
            return identifier == clientExist?.IdentityUserId;
        }
    }
}
