using IPGeolocation;
using Microsoft.Extensions.Configuration;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class IpGeoLocationServiceCollectionExtensions
    {
        public static IServiceCollection AddIpGeoLocation(this IServiceCollection services, IConfiguration config)
        {
            var ipGeoLocationSection = config.GetSection(IpGeoLocationOptions.IpGeoLocation);
            if (!ipGeoLocationSection.Exists())
            {
                throw new Exception($"Missing {IpGeoLocationOptions.IpGeoLocation} configuration.");
            }
            services.Configure<IpGeoLocationOptions>(ipGeoLocationSection);

            services.AddSingleton<IIpGeoLocationApi, IPGeolocationAPI>();

            return services;
        }
    }
}
