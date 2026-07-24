using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using ForgeFinanceApis1.Core.ErrorResponse;

namespace ForgeFinanceApis1.Core.Response;

public sealed class RawErrorBodyResponse : IResponse<RawError>
{
    public static RawErrorBodyResponse Instance { get; } = new();

    private RawErrorBodyResponse() { }

    public ValueTask<RawError> Map(HttpResponseMessage httpResponseMessage, CancellationToken cancellationToken) =>
        new(RawError.Create(httpResponseMessage, cancellationToken));
}
