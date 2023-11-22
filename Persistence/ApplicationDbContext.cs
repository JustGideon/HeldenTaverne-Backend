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

    // public DbSet<Attribute>? Attributes { get; set; }
    // public DbSet<Magic>? Casts { get; set; }
    public DbSet<User>? Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // MagicConfig.Create(modelBuilder);
        // MagicConfig.HasData(modelBuilder);
        UserConfig.Create(modelBuilder);
    }
}