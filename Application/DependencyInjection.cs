using JSFC.HeldenTaverne.Application.User;
using JSFC.HeldenTaverne.Application.UserService;
using Microsoft.Extensions.DependencyInjection;

namespace JSFC.HeldenTaverne.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IUserCommand, UserCommand>();

        return services;
    }
}