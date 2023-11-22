using JSFC.HeldenTaverne.Domain.MasterData.MagicAggr;
using JSFC.HeldenTaverne.Persistence.Config;
using Microsoft.EntityFrameworkCore;
using Attribute = Org.BouncyCastle.Asn1.Cms.Attribute;

namespace JSFC.HeldenTaverne.Persistence;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<WeatherForecast>? WeatherForecasts { get; set; }

    public DbSet<Attribute>? Attributes { get; set; }
    public DbSet<Magic>? Casts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfiguration()

        WeatherForecastConfig.Create(modelBuilder);

        MagicConfig.Create(modelBuilder);
        MagicConfig.HasData(modelBuilder);
    }
}