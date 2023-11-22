using JSFC.HeldenTaverne.Domain.UserData.Users;
using JSFC.HeldenTaverne.Persistence.Config;
using Microsoft.EntityFrameworkCore;

namespace JSFC.HeldenTaverne.Persistence;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<User>? Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        UserConfig.Create(modelBuilder);
    }
}