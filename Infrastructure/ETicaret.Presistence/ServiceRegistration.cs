using ETicaret.Application.Repositories.Shop;
using ETicaret.Application.Repositories.Users;
using ETicaret.Presistence.Contexts;
using ETicaret.Presistence.Repositories.Shop;
using ETicaret.Presistence.Repositories.Users;
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
            services.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
            services.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();
            services.AddScoped<ICategoryReadRepository, CategoryReadRepository>();
            services.AddScoped<ICategoryWriteRepository, CategoryWriteRepository>();
            services.AddScoped<IProductReadRepository, ProductReadRepository>();
            services.AddScoped<IProductWriteRepository, ProductWriteRepository>();
            services.AddScoped<IOrderReadRepository, OrderReadRepository>();
            services.AddScoped<IOrderWriteRepository, OrderWriteRepository>();
        }
    }
}
