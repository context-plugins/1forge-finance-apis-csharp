using System.Net.Http;

namespace ForgeFinanceApis1.Core.Request;

internal interface IRequest
{
    HttpContent Get();

    bool CanRetry { get; }
}