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
        public Chat StartChat(int listingId, int buyerId)
        {
            var listing = _context.Listings.Find(listingId);

            if (listing == null)
                throw new Exception("Listing not found");

            // Revisar si ya existe un chat para este listing y comprador
            var existingChat = _context.Chats
                .FirstOrDefault(c => c.ListingId == listingId && c.BuyerId == buyerId);

            if (existingChat != null)
                return existingChat;

            var chat = new Chat
            {
                ListingId = listingId,
                BuyerId = buyerId,
                SellerId = listing.UserId
            };

            _context.Chats.Add(chat);
            _context.SaveChanges();

            return chat;
        }

        // Enviar mensaje
        public Message SendMessage(int chatId, int senderId, string content)
        {
            var chat = _context.Chats.Find(chatId);

            if (chat == null)
                throw new Exception("Chat not found");

            var message = new Message
            {
                ChatId = chatId,
                SenderId = senderId,
                Content = content,
                SentAt = DateTime.UtcNow
            };

            _context.Messages.Add(message);
            _context.SaveChanges();

            return message;
        }

        // Obtener todos los mensajes de un chat
        public List<Message> GetMessages(int chatId)
        {
            return _context.Messages
                .Where(m => m.ChatId == chatId)
                .OrderBy(m => m.SentAt)
                .ToList();
        }

        // Obtener chat por listing y comprador
        public Chat GetChatByListing(int listingId, int buyerId)
        {
            return _context.Chats
                .Include(c => c.Messages)
                .FirstOrDefault(c => c.ListingId == listingId && c.BuyerId == buyerId);
        }

        public Chat StartChat(int listingId, int buyerId, int sellerId)
        {
            var chat = new Chat
            {
                ListingId = listingId,
                BuyerId = buyerId,
                SellerId = sellerId,
                Messages = new List<Message>()
            };

            _context.Chats.Add(chat);
            _context.SaveChanges();

            return chat;
        }
    }
}
