using Microsoft.AspNetCore.Mvc;
using TruequeU.Interfaces;
using TruequeU.Models;

namespace TruequeU.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ChatController : ControllerBase
    {
        private readonly IChatService _chatService;

        public ChatController(IChatService chatService)
        {
            _chatService = chatService;
        }

        [HttpPost("start")]
        public ActionResult<Chat> StartChat(int listingId, int buyerId, int sellerId)
        {
            var chat = _chatService.StartChat(listingId, buyerId, sellerId);
            return Ok(chat);
        }

        [HttpPost("send")]
        public ActionResult<Message> SendMessage(int chatId, int senderId, string content)
        {
            var message = _chatService.SendMessage(chatId, senderId, content);
            return Ok(message);
        }

        [HttpGet("{chatId}")]
        public ActionResult<List<Message>> GetMessages(int chatId)
        {
            var messages = _chatService.GetMessages(chatId);
            return Ok(messages);
        }
    }
}
