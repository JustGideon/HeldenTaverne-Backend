using JSFC.HeldenTaverne.Domain.UserData.Users;
using Microsoft.EntityFrameworkCore;

namespace JSFC.HeldenTaverne.Persistence.Config;

internal static class UserConfig
{
    internal static void Create(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>()
            .HasKey(x => x.Id);

        modelBuilder.Entity<User>()
            .HasIndex(x => x.Username)
            .IsUnique();
        modelBuilder.Entity<User>()
            .Property(x => x.Username)
            .IsRequired();
    }
}