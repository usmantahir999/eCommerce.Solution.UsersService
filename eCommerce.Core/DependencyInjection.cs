using Microsoft.Extensions.DependencyInjection;

namespace eCommerce.Core
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddCore(this IServiceCollection services)
        {
            //TO DO: Add services to the IoC container
            //Core services often include data access, caching and other low-level components.

            return services;
        }
    }
}
