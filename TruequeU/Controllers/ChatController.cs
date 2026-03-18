using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using TruequeU.Interfaces;
using TruequeU.Models;

namespace TruequeU.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(Roles = "Admin,User")]
    public class ChatController : ControllerBase
    {
        private readonly IChatService _chatService;

        public ChatController(IChatService chatService)
        {
            _chatService = chatService;
        }

        [HttpPost("start")]
        public ActionResult<Chat> StartChat(Guid listingId, Guid buyerId, Guid sellerId)
        {
            string identifier = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var chat = _chatService.StartChat(listingId, sellerId, buyerId, identifier);
            return Ok(chat);
        }

        [HttpPost("send")]
        public ActionResult<Message> SendMessage( Guid chatId, Guid senderId, string content)
        {
            var message = _chatService.SendMessage(chatId, senderId, content);
            return Ok(message);
        }

        [HttpGet("{chatId}")]
        public ActionResult<List<Message>> GetMessages(Guid chatId)
        {
            var messages = _chatService.GetMessages(chatId);
            return Ok(messages);
        }
    }
}
