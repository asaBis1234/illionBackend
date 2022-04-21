using Illion0.Interface;
using Illion0.Services;

namespace Illion0.ServiceExtension
{
    public static class CustomerServiceConfigExtension
    {
        public static IServiceCollection AddConfig(this IServiceCollection services, IConfiguration config)
        {
            services.AddTransient<IIllion,SIllion>();
            services.AddSingleton<IIllionToken, SIllionToken>();
            return services;
        }
    }
}
