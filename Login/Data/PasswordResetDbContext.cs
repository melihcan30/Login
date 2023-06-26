using Login.Models;
using Microsoft.EntityFrameworkCore;

namespace Login.Data
{
    public class PasswordResetDbContext : DbContext
    {
        public PasswordResetDbContext(DbContextOptions<PasswordResetDbContext> options) : base(options) { }

        public DbSet<PasswordReset> PasswordChanges { get; set; }
    }
}
