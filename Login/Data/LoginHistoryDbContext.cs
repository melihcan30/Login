using Login.Models;
using Microsoft.EntityFrameworkCore;

namespace Login.Data
{
    public class LoginHistoryDbContext : DbContext
    {
        public LoginHistoryDbContext(DbContextOptions<LoginHistoryDbContext> options) : base(options) { }

        public DbSet<LoginHistory> LoginHistories { get; set; }
    }
}
