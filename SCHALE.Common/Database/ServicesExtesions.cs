using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace SCHALE.Common.Database
{
    public static class ServicesExtesions
    {
        public static void AddSQLServerProvider(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<SCHALEContext>(o =>
            {
                o.UseSqlServer(connectionString, b =>
                {
                    b.EnableRetryOnFailure(5, TimeSpan.FromSeconds(10), null);
                })
                .UseLazyLoadingProxies();
            }, ServiceLifetime.Singleton, ServiceLifetime.Singleton);
        }
        
        public static void AddMySQLProvider(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<SCHALEContext>(o =>
            {
                o.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString), b =>
                {
                    b.EnableRetryOnFailure(5, TimeSpan.FromSeconds(10), null);
                })
                .UseLazyLoadingProxies();
            }, ServiceLifetime.Singleton, ServiceLifetime.Singleton);
        }
    }
}
