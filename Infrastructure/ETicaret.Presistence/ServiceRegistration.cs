using ETicaret.Presistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ETicaret.Presistence
{
    public static class ServiceRegistration
    {
        public static void AddPresistenceServices(this IServiceCollection services)
        {
            var connString = services.BuildServiceProvider().GetService<IConfiguration>()!.GetConnectionString("PostgreSQL");
            services.AddDbContext<ETicaretDbContext>(options => options.UseNpgsql(connString));

        }
    }
}
