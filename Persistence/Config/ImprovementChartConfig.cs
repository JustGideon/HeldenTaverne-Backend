using JSFC.HeldenTaverne.Domain.MasterData.ImprovementFactor;
using Microsoft.EntityFrameworkCore;

namespace JSFC.HeldenTaverne.Persistence.Config;

internal class ImprovementChartConfig
{
    internal static void Create(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ImprovementFactor>()
            .HasKey(x => x.Id);
    }

    internal static void HasData(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ImprovementFactor>()
            .HasData(
                new ImprovementFactor
                {
                    Id = 'A',
                    CostTo0 = 1,
                    CostTo12 = 1,
                    CostTo13 = 2,
                    CostTo14 = 3,
                    CostTo15 = 4,
                    CostTo16 = 5,
                    CostTo17 = 6,
                    CostTo18 = 7,
                    CostTo19 = 8,
                    CostTo20 = 9,
                    CostTo21 = 10,
                    CostTo22 = 11,
                    CostTo23 = 12,
                    CostTo24 = 13,
                    CostTo25 = 14
                },
                new ImprovementFactor
                {
                    Id = 'B',
                    CostTo0 = 2,
                    CostTo12 = 2,
                    CostTo13 = 4,
                    CostTo14 = 6,
                    CostTo15 = 8,
                    CostTo16 = 10,
                    CostTo17 = 12,
                    CostTo18 = 14,
                    CostTo19 = 16,
                    CostTo20 = 18,
                    CostTo21 = 20,
                    CostTo22 = 22,
                    CostTo23 = 24,
                    CostTo24 = 26,
                    CostTo25 = 28
                },
                new ImprovementFactor
                {
                    Id = 'C',
                    CostTo0 = 3,
                    CostTo12 = 3,
                    CostTo13 = 6,
                    CostTo14 = 9,
                    CostTo15 = 12,
                    CostTo16 = 15,
                    CostTo17 = 18,
                    CostTo18 = 21,
                    CostTo19 = 24,
                    CostTo20 = 27,
                    CostTo21 = 30,
                    CostTo22 = 33,
                    CostTo23 = 36,
                    CostTo24 = 39,
                    CostTo25 = 42
                },
                new ImprovementFactor
                {
                    Id = 'D',
                    CostTo0 = 4,
                    CostTo12 = 4,
                    CostTo13 = 8,
                    CostTo14 = 12,
                    CostTo15 = 16,
                    CostTo16 = 20,
                    CostTo17 = 24,
                    CostTo18 = 28,
                    CostTo19 = 32,
                    CostTo20 = 36,
                    CostTo21 = 40,
                    CostTo22 = 44,
                    CostTo23 = 48,
                    CostTo24 = 52,
                    CostTo25 = 56
                },
                new ImprovementFactor
                {
                    Id = 'E',
                    CostTo0 = 0,
                    CostTo12 = 15,
                    CostTo13 = 15,
                    CostTo14 = 15,
                    CostTo15 = 30,
                    CostTo16 = 45,
                    CostTo17 = 60,
                    CostTo18 = 75,
                    CostTo19 = 90,
                    CostTo20 = 105,
                    CostTo21 = 120,
                    CostTo22 = 135,
                    CostTo23 = 150,
                    CostTo24 = 165,
                    CostTo25 = 180
                });
    }
}