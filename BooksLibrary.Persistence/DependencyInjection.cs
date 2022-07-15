using BooksLibrary.Application.Common.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BooksLibrary.Persistence;

public static class DependencyInjection
{
    public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<BooksDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("BooksDb"), b => b.MigrationsAssembly("BooksLibrary.Api")));
        services.AddScoped<IBooksDbContext, BooksDbContext>();
        
        return services;
    }
}