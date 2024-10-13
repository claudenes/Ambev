using Ambev.Application.Interfaces;
using Ambev.Application.Mappings;
using Ambev.Application.Services;
using Ambev.Domain.Interfaces;
using Ambev.Infra.Data.Context;
using Ambev.Infra.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Ambev.Infra.IoC
{
    public static class DependencyInjection
    {
       
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            ConfigureEntityFrameWork(services);
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IFilialRepository, FilialRepository>();
            services.AddScoped<IVendaRepository, VendaRepository>();
            services.AddAutoMapper(typeof(DomainToDtoMappingProfile));

            var myhandlers = AppDomain.CurrentDomain.Load("Ambev.Application");

            return services;
        }
        private static void ConfigureEntityFrameWork(this  IServiceCollection services)
        {
            string connectionString = "";

            connectionString = @"Data Source=DESKTOP-OAG94LR\SQLEXPRESS;Initial Catalog=AMBEV;Integrated Security=True;";

            services.AddDbContext<ApplicationDbContext>(options =>
            {

                options.UseSqlServer(connectionString,
                    b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)); options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            });

        }
        public static IServiceCollection AddServices(this IServiceCollection services) 
        {
            
            services.AddScoped<IVendaService, VendaService>();
            services.AddAutoMapper(typeof(DomainToDtoMappingProfile));
            return services;
        }
    }
    
}
