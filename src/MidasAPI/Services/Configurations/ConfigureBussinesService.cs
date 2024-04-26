using MidasAPI.Services;
using MidasBussines.Interfaces;
using MidasBussines.Repositories;

namespace MidasAPI.Services.Configurations;

public static class ConfigureBussinesService
{
    public static IServiceCollection AddBusinessServices(this IServiceCollection services)
    {
        //Interfaces & Repositories
        services.AddScoped<IUserRepository, UserRepository>();
        //Services
        services.AddScoped<UserService>();

        return services;
    }
}
