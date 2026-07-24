using System;

namespace ForgeFinanceApis1.Core.Exceptions;

public sealed class SdkException<TError> : Exception
{
    public required TError Error { get; init; }
}