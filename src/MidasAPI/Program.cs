using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.FileProviders;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using MidasAPI.Services.Configurations;
using MidasDataAccess;
using Swashbuckle.AspNetCore.Filters;

namespace MidasAPI;

public class Program
{
    public static void Main(string[] args)
    {
        var  MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
        var builder = WebApplication.CreateBuilder(args);
        IServiceCollection services = builder.Services;
        ConfigurationManager configuration = builder.Configuration;
        Dependencies.ConfigureService(configuration, services);
        services.AddControllers();
        services.AddBusinessServices();
        services.AddSwaggerGen(options => {
            options.SwaggerDoc("v1", new OpenApiInfo(){Title ="Midas API"});
            options.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme{
                Description = "Enter the token with the `Bearer: ` prefix, e.g. 'Bearer abcde12345'",
                In = ParameterLocation.Header,
                Name = "Authorization",
                Type = SecuritySchemeType.ApiKey,
            });
            options.OperationFilter<SecurityRequirementsOperationFilter>();
        });
        services.AddCors(options =>
        {
            options.AddPolicy(name: MyAllowSpecificOrigins,
                            policy  =>
                            {
                                policy.WithOrigins("http://localhost:5173").AllowAnyHeader().AllowAnyMethod();
                            });
        });
        services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer( option => {
                option.TokenValidationParameters = new TokenValidationParameters(){
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(
                        Encoding.UTF8.GetBytes(configuration.GetSection("AppSettings:Token").Value??"")
                    ),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });
        services.AddAuthorization();

        var app = builder.Build();
        app.UseRouting();
        app.MapControllers();
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }
        app.UseCors(MyAllowSpecificOrigins);
        app.UseStaticFiles(new StaticFileOptions
        {
            FileProvider = new PhysicalFileProvider(
                Path.Combine(builder.Environment.ContentRootPath, "Files")),
            RequestPath = "/Files"
        });
        app.UseAuthentication();
        app.UseAuthorization();

        app.Run();
    }
}
