using ForgeFinanceApis1.Core.Models;

namespace ForgeFinanceApis1.Servers;

public class Server1Options
{
    public ProductionOptions Production { get; set; } = new();

    internal UrlTemplate Resolve(ServerEnvironment environment, string path) =>
        environment.Match(() => new UrlTemplate(Production.BaseUrl, path, []));

    public class ProductionOptions
    {
        public string BaseUrl { get; set; } = "https://1forge.com/forex-quotes";
    }
}
