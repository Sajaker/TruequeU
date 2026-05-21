using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        // =========================
        // INICIAR CHAT
        // =========================
        [HttpPost("start")]
        public async Task<ActionResult<Chat>> StartChat(
    [FromQuery] Guid listingId)
        {
            string? identityUserId =
                User.FindFirstValue(
                    ClaimTypes.NameIdentifier
                );

            if (identityUserId == null)
                return Unauthorized();

            var chat = await _chatService
                .StartChat(
                    listingId,
                    identityUserId
                );

            if (chat == null)
                return BadRequest(
                    "No se pudo crear el chat."
                );

            return Ok(chat);
        }

        // =========================
        // ENVIAR MENSAJE
        // =========================
        [HttpPost("send")]
        public async Task<ActionResult<Message>> SendMessage(
              [FromQuery] Guid chatId,
              [FromQuery] string content)
        {
            // Obtener usuario autenticado desde JWT
            string? identityUserId =
                User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (identityUserId == null)
                return Unauthorized();

            var message = await _chatService
                .SendMessage(chatId, identityUserId, content);

            if (message == null)
                return BadRequest("No se pudo enviar el mensaje.");

            return Ok(message);
        }

        // =========================
        // OBTENER MENSAJES
        // =========================
        [HttpGet("{chatId}")]
        public async Task<ActionResult<List<Message>>> GetMessages(Guid chatId)
        {
            var messages = await _chatService.GetMessages(chatId);

            return Ok(messages);
        }
        //Lista de Chats

        [HttpGet]
        public async Task<ActionResult<List<Chat>>> GetChats()
        {
            string? identityUserId =
                User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (identityUserId == null)
                return Unauthorized();

            var chats = await _chatService
                .GetUserChats(identityUserId);

            return Ok(chats);
        }

    }
}