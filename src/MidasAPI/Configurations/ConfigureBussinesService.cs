using MidasBussines;

namespace MidasAPI.Configurations;

public static class ConfigureBussinesService
{
    public static IServiceCollection AddBusinessServices(this IServiceCollection services){
        //Interfaces & Repositories
        services.AddScoped<IBankRepository,BankRepository>();
        services.AddScoped<IBusinessSectorRepository,BusinessSectorRepository>();
        services.AddScoped<IBranchOfficeRepository,BranchOfficeRepository>();
        //Services
        services.AddScoped<BusinessSectorService>();
        services.AddScoped<BankService>();
        return services;
    }
}
