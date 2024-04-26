using MidasBussines;

namespace MidasAPI.Configurations;

public static class ConfigureBussinesService
{
    public static IServiceCollection AddBusinessServices(this IServiceCollection services){
        //Interfaces & Repositories
        services.AddScoped<IFileManagementRepository, FileManagementRepository>();
        //Services
        services.AddScoped<FileManagementServices>();
        return services;
    }
}
