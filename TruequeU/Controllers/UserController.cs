using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TruequeU.Interfaces;
using TruequeU.Models;

namespace TruequeU.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        // Este DataAnnotation sirve para que este endpoint en específico no requiera de autenticación
        // Por defecto el authorize toma todos los endpoints que no tengan este indicativo
        [AllowAnonymous]
        public async Task<IActionResult> GetAll() => Ok(await _userService.GetAll());

        [HttpGet("{id}")]
        public async Task<IActionResult> getById(Guid id)
        {
            var usuario = await _userService.getById(id);
            //Se refactoriza condicion por una operación ternaria o si corto
            return usuario != null ? Ok(usuario) : NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] User newUser)
        {

            var createdUser = await _userService.Create(newUser);
            return CreatedAtAction(nameof(getById), new { id = createdUser.Id }, createdUser);
        }

    }
}
