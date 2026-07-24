using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using ForgeFinanceApis1.Core;
using ForgeFinanceApis1.Core.ErrorResponse;
using ForgeFinanceApis1.Core.Exceptions;
using ForgeFinanceApis1.Core.Request;
using ForgeFinanceApis1.Core.Response;

namespace ForgeFinanceApis1.Api;

public sealed class Finance
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal Finance(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// Symbol List
    /// </summary>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="string"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<IReadOnlyList<string>> GetAListOfSymbolsForWhichWeProvideRealTimeQuotes(CancellationToken ct = default) =>
        _rawClient.Execute(_server.Server1("/symbols"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<string>>(),
            RawErrorResponse.Instance,
            [],
            ct);

    /// <summary>
    /// Get quotes
    /// </summary>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task GetQuotesForAllSymbols(CancellationToken ct = default) =>
        _rawClient.Execute(_server.Server1("/quotes"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            VoidResponse.Instance,
            RawErrorResponse.Instance,
            [],
            ct);
}
