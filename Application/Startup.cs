using Application.Interfaces.Repositories;
using Application.Services.AuthorServices;
using Application.Services.TextServices;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class Startup
    {
        public static IServiceCollection AddApplicationDependencies(this IServiceCollection services)
        {
            services.AddScoped<AuthorService>();
            services.AddScoped<TextService>();
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            return services;
        }
    }
}
