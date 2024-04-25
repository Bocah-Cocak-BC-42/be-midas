using MidasBussines;

namespace MidasAPI.Configurations;

public static class ConfigureBussinesService
{
    public static IServiceCollection AddBusinessServices(this IServiceCollection services){
        //Interfaces & Repositories
        services.AddScoped<IRoleRepository, RoleRepository>();

        //Services
        services.AddScoped<RoleServices>();
        
        return services;
    }
}
