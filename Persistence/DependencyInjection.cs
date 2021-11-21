using Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            var connection = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<NoteDbContext>(options =>
            {
                options.UseSqlServer(connection);
            });
            services.AddScoped<INoteDbContext>(provider =>
            provider.GetService<NoteDbContext>());
            return services;
        }
    }
}
