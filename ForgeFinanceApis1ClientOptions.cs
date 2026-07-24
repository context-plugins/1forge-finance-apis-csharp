using ForgeFinanceApis1.Core.Configuration;
using ForgeFinanceApis1.Servers;

namespace ForgeFinanceApis1;

public class ForgeFinanceApis1ClientOptions
{
    public ServerEnvironment Environment { get; set; } = ServerEnvironment.Default();
    public RetryOptions Retry { get; set; } = RetryOptions.Default();
    public ServerOptions Server { get; set; } = new();
}
