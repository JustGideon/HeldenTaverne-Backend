using Microsoft.EntityFrameworkCore;
using Attribute = JSFC.HeldenTaverne.Domain.MasterData.Attribute.Attribute;

namespace JSFC.HeldenTaverne.Persistence.Config;

internal static class AttributeConfig
{
    internal static void Create(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Attribute>()
            .HasKey(x => x);
    }

    internal static void HasData(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Attribute>()
            .HasData(
                new Attribute("MU", "Mut"),
                new Attribute("KL", "Klugheit"),
                new Attribute("IN", "Intuition"),
                new Attribute("CH", "Charisma"),
                new Attribute("FF", "Fingerfertigkeit"),
                new Attribute("GE", "Gewandtheit"),
                new Attribute("KO", "Konstitution"),
                new Attribute("KK", "Körperkraft"));
    }
}