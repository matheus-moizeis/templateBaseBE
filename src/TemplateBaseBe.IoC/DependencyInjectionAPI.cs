using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TemplateBaseBe.Data.Context;
using TemplateBaseBe.Data.Repositories;
using TemplateBaseBe.Domain.Interfaces;

namespace TemplateBaseBe.IoC;

public static class DependencyInjectionExtension
{

    public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        AddDbContext(services, configuration);
        AddRepositories(services);
    }


    private static void AddDbContext(IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<TemplateBaseBeContext>(options =>
            options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"),
            b => b.MigrationsAssembly(typeof(TemplateBaseBeContext).Assembly.FullName)));
    }

    private static void AddRepositories(IServiceCollection services)
    {
        services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
        services.AddScoped<ICategoryRepository, CategoryRepository>();
        services.AddScoped<IProductRepository, ProductRepository>();
    }
}
