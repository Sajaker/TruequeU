using System.Diagnostics;
using TruequeU.Models;

namespace TruequeU.Interfaces
{
    public interface IUserService
    {
        Task<List<User>> GetAll();
        Task<User?> getById(Guid id);
        Task<User> Create(User user);

    }
}
