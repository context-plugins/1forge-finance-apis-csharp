# Reference

> Source: [ForgeFinanceApis1Client](ForgeFinanceApis1Client.cs)

## Finance

> Source: [Finance](Api/Finance.cs)

<details>
<summary><code>Task&lt;IReadOnlyList&lt;string&gt;&gt; GetAListOfSymbolsForWhichWeProvideRealTimeQuotes(CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Symbol List

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Finance.GetAListOfSymbolsForWhichWeProvideRealTimeQuotes();
    // TODO: Handle 'response' of type IReadOnlyList<string>
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;string&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task GetQuotesForAllSymbols(CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get quotes

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.Finance.GetQuotesForAllSymbols();
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Forex

> Source: [Forex](Api/Forex.cs)

<details>
<summary><code>Task&lt;IReadOnlyList&lt;string&gt;&gt; GetAListOfSymbolsForWhichWeProvideRealTimeQuotes(CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Symbol List

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Forex.GetAListOfSymbolsForWhichWeProvideRealTimeQuotes();
    // TODO: Handle 'response' of type IReadOnlyList<string>
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;string&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task GetQuotesForAllSymbols(CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get quotes

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.Forex.GetQuotesForAllSymbols();
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Quotes

> Source: [Quotes](Api/Quotes.cs)

<details>
<summary><code>Task&lt;IReadOnlyList&lt;string&gt;&gt; GetAListOfSymbolsForWhichWeProvideRealTimeQuotes(CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Symbol List

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Quotes.GetAListOfSymbolsForWhichWeProvideRealTimeQuotes();
    // TODO: Handle 'response' of type IReadOnlyList<string>
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;string&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task GetQuotesForAllSymbols(CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get quotes

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.Quotes.GetQuotesForAllSymbols();
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

