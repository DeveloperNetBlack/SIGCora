using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace SIGCora.ApplicationService
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddSigCoraApplicationService(this IServiceCollection services)
        {
            
            services.AddMediatR(cfg=>
            {
                cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly());
            });

            return services;
        }
    }
}
