# 1Forge Finance APIs

[![Built with APIMatic][apimatic-badge]][apimatic-url] [![License: MIT][license-badge]][license-url]

The 1Forge Finance APIs SDK for .NET provides access to the 1Forge Finance APIs REST APIs from .NET applications.

Stock and Forex Data and Realtime Quotes

---

## Installation

Add the .NET SDK as a project reference into your solution:

```bash
dotnet add reference <path-to-sdk>/ForgeFinanceApis1.csproj
```

---

## Quick Start

### Dependency Injection

Register the client with `IServiceCollection` and resolve it from the container. The `HttpClient` is managed by `IHttpClientFactory`. Configure the client's behavior through [ForgeFinanceApis1ClientOptions](ForgeFinanceApis1ClientOptions.cs).

```csharp
services.AddForgeFinanceApis1Client(options =>
    {
        options.Environment = ServerEnvironment.Production;
        // TODO: configure more client options here
    });
```

### Direct Instantiation

Create the client by passing an `HttpClient` you manage yourself. Configure the client's behavior through [ForgeFinanceApis1ClientOptions](ForgeFinanceApis1ClientOptions.cs).

```csharp
var httpClient = new HttpClient();
// TODO: configure more client options here
var options =
    new ForgeFinanceApis1ClientOptions
    {
        Environment = ServerEnvironment.Production,
    };
var client = new ForgeFinanceApis1Client(httpClient, options);
```

---

## Usage

For code examples and error responses, see [API Reference](api-reference.md).

## Best Practices

> [!TIP]
> Use a **single `ForgeFinanceApis1Client` instance** for the lifetime of your application and
> reuse it across all requests. Creating a new instance per request might exhaust the
> connection pool.

## License

This SDK is distributed under the [MIT License](LICENSE).

---

## Support

Refer to the [API reference](api-reference.md) for detailed information on available operations with code samples.

For further assistance, please contact support at contact@1forge.com.

---

[license-url]: LICENSE
[license-badge]: https://img.shields.io/badge/License-MIT-blue.svg
[apimatic-url]: https://www.apimatic.io
[apimatic-badge]: https://www.apimatic.io/hubfs/Built-with-APIMatic-badge.svg
