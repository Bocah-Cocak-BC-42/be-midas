using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MidasDataAccess.Models;

namespace MidasDataAccess;

public class Dependencies
{
    public static void ConfigureService(IConfiguration configuration, IServiceCollection services)
    {
        services.AddDbContext<MidasContext>(
            option => option.UseSqlServer(configuration.GetConnectionString("MidasConnection"))
        );
    }
}
