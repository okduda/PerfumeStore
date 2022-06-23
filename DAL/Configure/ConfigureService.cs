using DAL.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DAL.Configure
{
    public static class ConfigureService
    {
        public static void Configure(IServiceCollection service, string connectionString)
        {
            service.AddDbContext<PerfumeContext>(options => options.UseSqlServer(connectionString));

            service.AddScoped<IBrandRepository, BrandRepository>();
            service.AddScoped<ICategoryRepository, CategoryRepository>();
            service.AddScoped<ICategoryItemRepository, CategoryItemRepository>();
            service.AddScoped<IOrderItemRepository, OrderItemRepository>();
            service.AddScoped<IOrderRepository, OrderRepository>(); 
            service.AddScoped<IPerfumeRepository, PerfumeRepository>(); 
            service.AddScoped<IRoleRepository, RoleRepository>();
            service.AddScoped<IUserRepository, UserRepository>();   
            service.AddScoped<IUserRoleRepository, UserRoleRepository>();
        }
    }
}
