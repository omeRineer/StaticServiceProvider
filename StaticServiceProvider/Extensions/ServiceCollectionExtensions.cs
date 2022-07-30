using Microsoft.Extensions.DependencyInjection;

namespace StaticServiceProvider.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddServiceTool(this IServiceCollection services)
        {
            StaticServiceProvider.ServiceTool.StaticServiceProvider.CreateServiceProvider(services);
        }
    }
}
