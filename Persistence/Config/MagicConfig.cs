using JSFC.HeldenTaverne.Domain.MasterData.MagicAggr;
using Microsoft.EntityFrameworkCore;

namespace JSFC.HeldenTaverne.Persistence.Config;

internal static class MagicConfig
{
    internal static void Create(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Magic>()
            .HasKey(x => x.Id);
    }

    internal static void HasData(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Magic>()
            .HasData(
                new Magic { Name = "Ablativum" });
    }
}