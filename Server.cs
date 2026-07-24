using ForgeFinanceApis1.Core.Models;
using ForgeFinanceApis1.Servers;

namespace ForgeFinanceApis1;

public class Server
{
    private readonly ServerEnvironment _environment;
    private readonly ServerOptions _options;

    internal Server(ServerEnvironment environment, ServerOptions options)
    {
        _environment = environment;
        _options = options;
    }

    internal UrlTemplate Server1(string path) => _options.Server1.Resolve(_environment, path);
    internal UrlTemplate Server2(string path) => _options.Server2.Resolve(_environment, path);
}
