using Microsoft.Extensions.DependencyInjection;
using SIGCora.DomainService.IServices;
using SIGCora.Infrastructure.GeneralService.Services;

namespace SIGCora.Infrastructure.GeneralService
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddSigCoraInfrastructureGeneralService(this IServiceCollection services)
        {

            services.AddSingleton<ICurrentSessionService, CurrentSessionService>();
            services.AddScoped<IGenerateTokenService, GenerateTokenService>();
            services.AddScoped<IMessageService, MessageService>();
            //services.AddScoped<IJsonSerializerService, JsonSerializerService>();
            //services.AddScoped<IFileStorageService, LocalFileStorageServuce>();

            return services;
        }
    }
}
