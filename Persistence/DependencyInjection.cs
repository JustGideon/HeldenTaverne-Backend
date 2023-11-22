using JSFC.HeldenTaverne.Domain.Common.Persistence;
using JSFC.HeldenTaverne.Domain.UserData.Users;
using JSFC.HeldenTaverne.Persistence.Implementations;
using JSFC.HeldenTaverne.Persistence.Implementations.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace JSFC.HeldenTaverne.Persistence;

public static class DependencyInjection
{
    public static IServiceCollection AddPersistence(this IServiceCollection services)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(
                // "server=localhost;database=dsa5_character_manager;user=root;password=password",
                "server=85.214.119.101;database=helden_taverne;user=sa;password=1LiiEKO1L;TrustServerCertificate=true",
                b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)), ServiceLifetime.Singleton);

        services.AddScoped<IUserRepository, UserRepoistory>();
        services.AddScoped<IUnitOfWork, UnitOfWork>();

        return services;
    }
}