using Microsoft.EntityFrameworkCore;
using TruequeU.DAO;
using TruequeU.Interfaces;
using TruequeU.Models;

namespace TruequeU.Services
{
    public class ChatService : IChatService
    {
        private readonly ApplicationDbContext _context;

        public ChatService(ApplicationDbContext context)
        {
            _context = context;
        }

        // =========================================
        // INICIAR CHAT
        // =========================================
        public async Task<Chat?> StartChat(
            Guid listingId,
            string identityUserId)
        {
            // Buscar listing
            var listing = await _context.Listings
                .FirstOrDefaultAsync(l => l.Id == listingId);

            if (listing == null)
                return null;

            // Seller sale del listing
            var sellerId = listing.UserId;

            // Buyer sale del JWT
            var buyer = await _context.Users
                .FirstOrDefaultAsync(u =>
                    u.IdentityUserId == identityUserId);

            if (buyer == null)
                return null;

            var buyerId = buyer.Id;

            // Evitar chats consigo mismo
            if (buyerId == sellerId)
                return null;

            // Verificar si ya existe chat
            var existingChat = await _context.Chats
                .FirstOrDefaultAsync(c =>
                    c.ListingId == listingId &&
                    c.BuyerId == buyerId);

            if (existingChat != null)
                return existingChat;

            // Crear nuevo chat
            var newChat = new Chat
            {
                ListingId = listingId,
                BuyerId = buyerId,
                SellerId = sellerId
            };

            _context.Chats.Add(newChat);

            await _context.SaveChangesAsync();

            return newChat;
        }

        // =========================================
        // ENVIAR MENSAJE
        // =========================================
        public async Task<Message?> SendMessage(
            Guid chatId,
            string identityUserId,
            string content)
        {
            // Buscar chat
            var chat = await _context.Chats
                .FirstOrDefaultAsync(c => c.Id == chatId);

            if (chat == null)
                return null;

            // Buscar usuario autenticado
            var sender = await _context.Users
                .FirstOrDefaultAsync(u =>
                    u.IdentityUserId == identityUserId);

            if (sender == null)
                return null;

            var senderId = sender.Id;

            // Verificar que pertenezca al chat
            if (senderId != chat.BuyerId &&
                senderId != chat.SellerId)
                return null;

            // Crear mensaje
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

        // =========================================
        // OBTENER MENSAJES
        // =========================================
        public async Task<List<Message>> GetMessages(Guid chatId)
        {
            return await _context.Messages
                .Where(m => m.ChatId == chatId)
                .OrderBy(m => m.SentAt)
                .ToListAsync();
        }

        public async Task<List<Chat>> GetUserChats(string identityUserId)
        {
            // Buscar usuario autenticado
            var user = await _context.Users
                .FirstOrDefaultAsync(
                    u => u.IdentityUserId == identityUserId
                );

            if (user == null)
                return new List<Chat>();

            // Obtener chats donde el usuario
            // sea comprador o vendedor
            var chats = await _context.Chats

                .Include(c => c.Listing)
                    .ThenInclude(l => l.Images)

                .Include(c => c.Buyer)

                .Include(c => c.Seller)

                .Include(c => c.Messages)

                .Where(c =>
                    c.BuyerId == user.Id ||
                    c.SellerId == user.Id
                )

                .OrderByDescending(c =>
                    c.Messages
                        .OrderByDescending(m => m.SentAt)
                        .Select(m => m.SentAt)
                        .FirstOrDefault()
                )

                .ToListAsync();

            return chats;
        }
    }
}