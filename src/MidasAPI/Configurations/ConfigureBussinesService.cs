using MidasBussines;

namespace MidasAPI.Configurations;

public static class ConfigureBussinesService
{
    public static IServiceCollection AddBusinessServices(this IServiceCollection services){
        //Interfaces & Repositories
        services.AddScoped<IProvinceRepository, ProvinceRepository>();
        services.AddScoped<ICityRepository, CityRepository>();

        //Services
        services.AddScoped<ProvinceService>();
        services.AddScoped<CityService>();
        
        return services;
    }
}
