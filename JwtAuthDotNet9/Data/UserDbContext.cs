using JwtAuthDotNet9.Domain.Auth;
using Microsoft.EntityFrameworkCore;

namespace JwtAuthDotNet9.Data
{
    public class UserDbContext(DbContextOptions<UserDbContext> options) : DbContext(options)
    {
        public DbSet<User> Users { get; set; }
    }
}
