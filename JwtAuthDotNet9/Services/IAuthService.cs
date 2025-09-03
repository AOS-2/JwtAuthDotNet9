using JwtAuthDotNet9.Domain.Auth;
using JwtAuthDotNet9.Domain.Dto;

namespace JwtAuthDotNet9.Services
{
    public interface IAuthService
    {
        Task<User?> RegisterAsync(UserDto request);
        Task<string?> LoginAsync(UserDto request);
    }
}
