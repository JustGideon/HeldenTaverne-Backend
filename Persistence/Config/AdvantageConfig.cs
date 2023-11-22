using JSFC.HeldenTaverne.Domain.MasterData;
using Microsoft.EntityFrameworkCore;

namespace JSFC.HeldenTaverne.Persistence.Config;

internal static class AdvantageConfig
{
    internal static void Create(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Advantage>()
            .HasKey(x => x);
    }

    internal static void HasData(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Advantage>()
            .HasData("");
    }
}