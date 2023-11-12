using Microsoft.Extensions.DependencyInjection;
using MultipleOfEleven.Application.Services.Multiple;
using MultipleOfEleven.Domain.Services.Multiple;

namespace MultipleOfEleven.Infra.Ioc
{
    public class Bootstrap
    {
        public static async Task Start(IServiceCollection services)
        {
            services.AddTransient<IMultipleApplication, MultipleApplication>();
            services.AddTransient<IMultipleService, MultipleService>();
        }
    }
}