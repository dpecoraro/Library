using Core;
using Core.IRepository;
using Core.IServices;
using Infrastructure.Repository;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Services.Adapters;
using Services.Ports;

namespace Library
{
    public static class ConfigureExtension
    {
        public static void ConfigureRepositories(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IUserRepository, UserRepository>();
        }

        public static void ConfigureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<Appsettings>(configuration.GetSection("Appsettings"));

            services.AddScoped<ITokenService, TokenService>();

            services.AddScoped<IUserService, UserService>();
        }

        public static void ConfigurePackages(this IServiceCollection services, IConfiguration configuration)
        {
            var settings = configuration.GetSection("Appsettings").Get<Appsettings>();

            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(settings.Security.GetKey),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });
        }
    }
}
