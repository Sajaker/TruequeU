using System.Diagnostics;
using TruequeU.DAO;
using TruequeU.Models;
using Microsoft.EntityFrameworkCore;
using TruequeU.Interfaces;

namespace TruequeU.Services
{
    public class UserService:IUserService
    {
        private readonly ApplicationDbContext _context;

        public UserService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<User>> GetAll()
        {
            return await _context.Users.Where(e => e.IsSuspended == false).ToListAsync();
        }

        public async Task<User> getById(Guid id) => await _context.Users.FindAsync(id);


        public async Task<User> Create(User newUser)
        {
            //Agregamos el registro a la lista
            _context.Users.Add(newUser);
            await _context.SaveChangesAsync();
            return newUser;
        }


    }
}
