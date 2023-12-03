using Logistica.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Logistica.Persistence.Repositories
{
    public static class ServiceExtensions
    {
        public static void ConfigurePersistenceApp(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("Sqlite");

            services.AddDbContext<AppDbContext>(opts => opts.UseSqlite(connectionString));

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IAddressRepository, AddressRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IPurchaseNotificationRepository, PurchaseNotificationRepository>();
            services.AddScoped<IReceiverRepository, ReceiverRepository>();
            services.AddScoped<IShippingRepository, ShippingRepository>();
            services.AddScoped<IKafkaProducer, KafkaProducer > ();
        }
    }
}
