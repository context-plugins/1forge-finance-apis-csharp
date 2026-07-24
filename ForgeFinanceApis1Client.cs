using System.Net.Http;
using ForgeFinanceApis1.Api;
using ForgeFinanceApis1.Core;
using ForgeFinanceApis1.Core.Models;

namespace ForgeFinanceApis1;

/// <summary>
/// Stock and Forex Data and Realtime Quotes
/// </summary>
public sealed class ForgeFinanceApis1Client
{
    public ForgeFinanceApis1Client(HttpClient httpClient, ForgeFinanceApis1ClientOptions options)
    {
        var server = new Server(options.Environment, options.Server);
        var queryParameterFactory = new QueryParameterFactory([]);
        var templateParamsFactory = new TemplateParamsFactory([]);
        var urlFactory = new UriFactory(queryParameterFactory, templateParamsFactory);
        var httpStatusPolicy = new HttpStatusPolicy([]);
        var headersFactory =
            new HeadersFactory([new HeaderParam("User-Agent", "ForgeFinanceApis1Client/0.0.1 CSharp"),
                    new HeaderParam("X-APIMatic-Lang", "CSharp"),
                    new HeaderParam("X-APIMatic-Package-Version", "0.0.1"),
                    new HeaderParam("X-APIMatic-Gen-Version", "4.0.0"),
                    new HeaderParam("X-APIMatic-OS", RuntimeEnvironment.Os),
                    new HeaderParam("X-APIMatic-Runtime", RuntimeEnvironment.Runtime)]);
        var resiliencePipelineFactory = new ResiliencePipelineFactory(options.Retry);
        var rawClient =
            new RawClient(httpClient, urlFactory, httpStatusPolicy, headersFactory, resiliencePipelineFactory);
        Finance = new Finance(rawClient, server);
        Forex = new Forex(rawClient, server);
        Quotes = new Quotes(rawClient, server);
    }

    public Finance Finance { get; }

    public Forex Forex { get; }

    public Quotes Quotes { get; }
}
