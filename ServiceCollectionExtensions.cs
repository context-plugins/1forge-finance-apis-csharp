using System;
using System.Net.Http;
using Microsoft.Extensions.DependencyInjection;

namespace ForgeFinanceApis1;

public static class ServiceCollectionExtensions
{
    extension(IServiceCollection services)
    {
        public IServiceCollection AddForgeFinanceApis1Client(Action<ForgeFinanceApis1ClientOptions>? configure = null)
        {
            var options = new ForgeFinanceApis1ClientOptions();
            configure?.Invoke(options);
            services.AddHttpClient();
            services.AddSingleton(sp =>
                {
                    var httpClientFactory = sp.GetRequiredService<IHttpClientFactory>();
                    var httpClient = httpClientFactory.CreateClient();
                    return new ForgeFinanceApis1Client(httpClient, options);
                });
            return services;
        }
    }
}
