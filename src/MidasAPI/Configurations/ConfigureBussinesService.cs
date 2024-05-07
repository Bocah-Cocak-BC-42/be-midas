using MidasAPI.Services;
using MidasBussines.Interfaces;
using MidasBussines.Repositories;

namespace MidasAPI.Configurations;

public static class ConfigureBussinesService
{
    public static IServiceCollection AddBusinessServices(this IServiceCollection services)
    {
        //Interfaces & Repositories
        services.AddScoped<IRoleRepository, RoleRepository>();
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IProvinceRepository, ProvinceRepository>();
        services.AddScoped<ICityRepository, CityRepository>();
        services.AddScoped<ISubdistrictRepository, SubdistrictRepository>();
        services.AddScoped<IVillageRepository, VillageRepository>();
        services.AddScoped<IBankRepository,BankRepository>();
        services.AddScoped<IBusinessSectorRepository,BusinessSectorRepository>();
        services.AddScoped<IBranchOfficeRepository,BranchOfficeRepository>();
        services.AddScoped<IFileManagementRepository, FileManagementRepository>();
        services.AddScoped<IAssociateUserBranchRepository,AssociateUserBranchRepository>();


        //Services
        services.AddScoped<RoleServices>();
        services.AddScoped<AuthService>();
        services.AddScoped<UserService>();
        services.AddScoped<ProvinceService>();
        services.AddScoped<CityService>();
        services.AddScoped<SubdistrictServices>();
        services.AddScoped<VillageServices>();
        services.AddScoped<BusinessSectorService>();
        services.AddScoped<BankService>();
        services.AddScoped<FileManagementServices>();
        services.AddScoped<BranchOfficeService>();
        services.AddScoped<AssociateUserBranchService>();
        
        return services;
    }
}
