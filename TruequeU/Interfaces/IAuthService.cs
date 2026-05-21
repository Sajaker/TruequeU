using Microsoft.AspNetCore.Identity;

namespace TruequeU.Interfaces
{
    public interface IAuthService
    {
        Task<IdentityResult> Register(string email, string password, string role);
        Task<string?> Login(string email, string password);
        Task<Guid?> GetUserIdFromTokenAsync(string identityId);
        
    }
}
