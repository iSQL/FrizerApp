using FrizerApp.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace FrizerApp.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<RegistrationModel> Registrations { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<TokenInfo> TokenInfo { get; set; }
    }
}
