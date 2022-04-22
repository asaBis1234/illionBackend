using Illion0.Context;
using Illion0.Interface;
using Illion0.Services;
using Microsoft.EntityFrameworkCore;

namespace Illion0.ServiceExtension
{
    public static class CustomerServiceConfigExtension
    {
        public static IServiceCollection AddConfig(this IServiceCollection services, IConfiguration config)
        {
            

            services.AddTransient<IIllion,SIllion>();
            services.AddSingleton<IIllionToken, SIllionToken>();
          services.AddScoped<IDataBaseUpdate, SDataBaseUpdate>();
            return services;
        }
    }
}
