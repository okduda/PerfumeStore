using BusinessLayer.Services;
using BusinessLayer.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace BusinessLayer.Configure
{
    public static class ConfigureService
    {
        public static void Configure(IServiceCollection service, string connectionString)
        {
            DAL.Configure.ConfigureService.Configure(service, connectionString);

            service.AddScoped<IBrandService, BrandService>();
            service.AddScoped<ICategoryService, CategoryService>();
            service.AddScoped<IUserService, UserService>();
            service.AddScoped<IRoleService, RoleService>();
            service.AddScoped<IPerfumeService, PerfumeService>();
        }

    }
}