using Microsoft.Extensions.DependencyInjection;
using System;

namespace StaticServiceProvider.ServiceTool
{
    public static class StaticServiceProvider
    {
        public static IServiceProvider ServiceProvider { get; private set; }
        public static IServiceCollection CreateServiceProvider(IServiceCollection serviceCollection)
        {
            ServiceProvider = serviceCollection.BuildServiceProvider();
            return serviceCollection;
        }
        public static TService GetService<TService>()
        {
            var service=ServiceProvider.GetService<TService>();
            return service;
        }
    }
}
