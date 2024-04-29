using MidasBussines;

namespace MidasAPI.Configurations;

public static class ConfigureBussinesService
{
    public static IServiceCollection AddBusinessServices(this IServiceCollection services)
    {
        //Interfaces & Repositories
        services.AddScoped<IProvinceRepository, ProvinceRepository>();
        services.AddScoped<ICityRepository, CityRepository>();
        services.AddScoped<ISubdistrictRepository, SubdistrictRepository>();
        services.AddScoped<IVillageRepository, VillageRepository>();

        //Services
        services.AddScoped<ProvinceService>();
        services.AddScoped<CityService>();
        services.AddScoped<SubdistrictServices>();
        services.AddScoped<VillageServices>();

        return services;
    }
}
