using ForgeFinanceApis1.Servers;

namespace ForgeFinanceApis1;

public class ServerOptions
{
    public Server1Options Server1 { get; set; } = new();
    public Server2Options Server2 { get; set; } = new();
}
