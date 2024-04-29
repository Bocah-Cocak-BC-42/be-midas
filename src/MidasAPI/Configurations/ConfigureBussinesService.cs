using MidasAPI.Services;
using MidasBussines;
using MidasBussines.Interfaces;
using MidasBussines.Repositories;

namespace MidasAPI.Configurations;

public static class ConfigureBussinesService
{
    public static IServiceCollection AddBusinessServices(this IServiceCollection services){
        //Interfaces & Repositories
        services.AddScoped<IRoleRepository, RoleRepository>();
        services.AddScoped<IAuthRepository, AuthRepository>();
        services.AddScoped<IUserRepository, UserRepository>();

        //Services
        services.AddScoped<RoleServices>();
        services.AddScoped<AuthService>();
        services.AddScoped<UserService>();
        
        return services;
    }
}
