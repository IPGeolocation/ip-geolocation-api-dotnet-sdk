# IPGeolocation .NET SDK

Official .NET SDK for the IPGeolocation.io IP Location API.

Look up IPv4, IPv6, and domains with `/v3/ipgeo` and `/v3/ipgeo-bulk`. Get geolocation, company, ASN, timezone, network, hostname, abuse, user-agent, and security data from one API.

- .NET Standard 2.1 package
- Async client built on `HttpClient`
- Typed responses plus raw JSON and XML methods

## Table of Contents

- [Install](#install)
- [Quick Start](#quick-start)
- [At a Glance](#at-a-glance)
- [Get Your API Key](#get-your-api-key)
- [Authentication](#authentication)
- [Plan Behavior](#plan-behavior)
- [Client Configuration](#client-configuration)
- [Available Methods](#available-methods)
- [Request Options](#request-options)
- [Examples](#examples)
- [Response Metadata](#response-metadata)
- [Errors](#errors)
- [Troubleshooting](#troubleshooting)
- [Frequently Asked Questions](#frequently-asked-questions)
- [Links](#links)

## Install

```bash
dotnet add package IPGeoLocation.IPGeolocation
```

```powershell
Install-Package IPGeoLocation.IPGeolocation
```

```xml
<PackageReference Include="IPGeoLocation.IPGeolocation" Version="3.0.0" />
```

- NuGet package: `IPGeoLocation.IPGeolocation`
- Package page: <https://www.nuget.org/packages/IPGeoLocation.IPGeolocation>
- GitHub repository: <https://github.com/IPGeolocation/ip-geolocation-api-dotnet-sdk>

## Quick Start

```csharp
using System;
using IPGeolocation;

var apiKey = Environment.GetEnvironmentVariable("IPGEO_API_KEY")
    ?? throw new InvalidOperationException("Set IPGEO_API_KEY first.");

using var client = new IpGeolocationClient(new IpGeolocationClientConfig(apiKey: apiKey));

var response = await client.LookupIpGeolocationAsync(
    new LookupIpGeolocationRequest(ip: "8.8.8.8"));

Console.WriteLine(response.Data.Ip); // 8.8.8.8
Console.WriteLine(response.Data.Location?.CountryName); // United States
Console.WriteLine(response.Data.Location?.City);
Console.WriteLine(response.Data.TimeZone?.Name);
Console.WriteLine(response.Metadata.CreditsCharged ?? 0);
```

Use `LookupIpGeolocationRequest` and `BulkLookupIpGeolocationRequest` when you want request validation before the call is sent.

## At a Glance

| Item | Value |
|------|-------|
| Package | `IPGeoLocation.IPGeolocation` |
| Namespace | `IPGeolocation` |
| Supported Endpoints | `/v3/ipgeo`, `/v3/ipgeo-bulk` |
| Supported Inputs | IPv4, IPv6, domain |
| Main Data Returned | Geolocation, company, ASN, timezone, network, hostname, abuse, user-agent, currency, security |
| Authentication | API key, request-origin auth for `/v3/ipgeo` only |
| Response Formats | Structured JSON, raw JSON, raw XML |
| Bulk Limit | Up to 50,000 IPs or domains per request |
| Transport | `HttpClient` |

## Get Your API Key

Create an IPGeolocation account and copy an API key from your dashboard.

1. Sign up: <https://app.ipgeolocation.io/signup>
2. Verify your email if prompted
3. Sign in: <https://app.ipgeolocation.io/login>
4. Open your dashboard: <https://app.ipgeolocation.io/dashboard>
5. Copy an API key from the `API Keys` section

For server-side code, keep the API key in an environment variable or secret manager. For browser-based single lookups on paid plans, use request-origin auth instead of exposing an API key in frontend code.

## Authentication

### API Key

```csharp
using IPGeolocation;

using var client = new IpGeolocationClient(
    new IpGeolocationClientConfig(apiKey: Environment.GetEnvironmentVariable("IPGEO_API_KEY")));
```

### Request-Origin Auth

```csharp
using IPGeolocation;

using var client = new IpGeolocationClient(
    new IpGeolocationClientConfig(requestOrigin: "https://app.example.com"));
```

`requestOrigin` must be an absolute `http` or `https` origin with no path, query string, fragment, or userinfo.

> [!IMPORTANT]
> Request-origin auth does not work with `/v3/ipgeo-bulk`. Bulk lookup always requires `apiKey`.

> [!NOTE]
> If you set both `apiKey` and `requestOrigin`, single lookup still uses the API key. The API key is sent as the `apiKey` query parameter, so avoid logging full request URLs.

## Plan Behavior

Feature availability depends on your plan and request parameters.

| Capability | Free | Paid |
|------------|------|------|
| Single IPv4 and IPv6 lookup | Supported | Supported |
| Domain lookup | Not supported | Supported |
| Bulk lookup | Not supported | Supported |
| Non-English `lang` | Not supported | Supported |
| Request-origin auth | Not supported | Supported for `/v3/ipgeo` only |
| Optional modules via `include` | Not supported | Supported |
| `include: ["*"]` | Base response only | All plan-available modules |

Paid plans still need `include` for optional modules. `fields` and `excludes` only trim the response. They do not turn modules on or unlock paid data.

## Client Configuration

| Field | Type | Default | Notes |
|-------|------|---------|-------|
| `apiKey` | `string?` | unset | Required for bulk lookup. Optional for single lookup if `requestOrigin` is set. |
| `requestOrigin` | `string?` | unset | Must be an absolute `http` or `https` origin. |
| `baseUrl` | `string` | `https://api.ipgeolocation.io` | Override the API base URL. |
| `connectTimeout` | `TimeSpan` | `10` seconds | Time to open the connection. |
| `readTimeout` | `TimeSpan` | `30` seconds | Time to wait while reading the response body. |

The client constructor accepts an `IpGeolocationClientConfig`. Timeouts are validated before the request is sent.

## Available Methods

| Method | Returns | Notes |
|--------|---------|-------|
| `LookupIpGeolocationAsync(request = null, cancellationToken = default)` | `Task<ApiResponse<IpGeolocationResponse>>` | Single lookup. Typed JSON response. |
| `LookupIpGeolocationRawAsync(request = null, cancellationToken = default)` | `Task<ApiResponse<string>>` | Single lookup. Raw JSON or XML string. |
| `BulkLookupIpGeolocationAsync(request, cancellationToken = default)` | `Task<ApiResponse<IReadOnlyList<BulkLookupResult>>>` | Bulk lookup. Typed JSON response. |
| `BulkLookupIpGeolocationRawAsync(request, cancellationToken = default)` | `Task<ApiResponse<string>>` | Bulk lookup. Raw JSON or XML string. |
| `Dispose()` | `void` | Closes the client and releases its transport. |

> [!NOTE]
> Typed methods support JSON only. Use the raw methods when you need XML output.

## Request Options

| Field | Applies To | Notes |
|-------|------------|-------|
| `ip` | Single lookup | IPv4, IPv6, or domain. Omit it for caller IP lookup. |
| `ips` | Bulk lookup | Collection of 1 to 50,000 IPs or domains. |
| `lang` | Single and bulk | One of `en`, `de`, `ru`, `ja`, `fr`, `cn`, `es`, `cs`, `it`, `ko`, `fa`, `pt`. |
| `include` | Single and bulk | Collection of module names such as `security`, `abuse`, `user_agent`, `hostname`, `liveHostname`, `hostnameFallbackLive`, `geo_accuracy`, `dma_code`, or `*`. |
| `fields` | Single and bulk | Collection of field paths to keep, for example `location.country_name` or `security.threat_score`. |
| `excludes` | Single and bulk | Collection of field paths to remove from the response. |
| `userAgent` | Single and bulk | Overrides the outbound `User-Agent` header. |
| `headers` | Single and bulk | Extra request headers as `IReadOnlyDictionary<string, string>`. |
| `output` | Single and bulk | `ResponseFormat.Json` or `ResponseFormat.Xml`. Typed methods require JSON. |

## Examples

The examples below assume you already have a configured client in scope:

```csharp
using System;
using IPGeolocation;

var apiKey = Environment.GetEnvironmentVariable("IPGEO_API_KEY")
    ?? throw new InvalidOperationException("Set IPGEO_API_KEY first.");

using var client = new IpGeolocationClient(new IpGeolocationClientConfig(apiKey: apiKey));
```

### Caller IP

Omit `ip` to look up the public IP of the machine making the request.

```csharp
var response = await client.LookupIpGeolocationAsync();
Console.WriteLine(response.Data.Ip);
```

### Domain Lookup

Domain lookup is a paid-plan feature.

```csharp
var response = await client.LookupIpGeolocationAsync(
    new LookupIpGeolocationRequest(ip: "ipgeolocation.io"));

Console.WriteLine(response.Data.Ip);
Console.WriteLine(response.Data.Domain); // ipgeolocation.io
Console.WriteLine(response.Data.Location?.CountryName);
```

### Security and Abuse

```csharp
var response = await client.LookupIpGeolocationAsync(
    new LookupIpGeolocationRequest(
        ip: "9.9.9.9",
        include: new[] { "security", "abuse" }));

Console.WriteLine(response.Data.Security?.ThreatScore);
Console.WriteLine(response.Data.Abuse?.Emails?[0]);
```

### User-Agent Parsing

To parse a visitor user-agent string, pass `include: ["user_agent"]` and send the visitor string in the request `User-Agent` header.

```csharp
using System.Collections.Generic;

const string visitorUa =
    "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_11_2) AppleWebKit/601.3.9 (KHTML, like Gecko) Version/9.0.2 Safari/601.3.9";

var response = await client.LookupIpGeolocationAsync(
    new LookupIpGeolocationRequest(
        ip: "115.240.90.163",
        include: new[] { "user_agent" },
        headers: new Dictionary<string, string> { ["User-Agent"] = visitorUa }));

Console.WriteLine(response.Data.UserAgent?.Name);
Console.WriteLine(response.Data.UserAgent?.OperatingSystem?.Name);
```

> [!NOTE]
> The `userAgent` request field overrides the SDK's default outbound `User-Agent` header. It takes precedence over `headers["User-Agent"]`.

### Filtered Response

```csharp
var response = await client.LookupIpGeolocationAsync(
    new LookupIpGeolocationRequest(
        ip: "8.8.8.8",
        include: new[] { "security" },
        fields: new[] { "location.country_name", "security.threat_score", "security.is_vpn" },
        excludes: new[] { "currency" }));

Console.WriteLine(response.Data.Location?.CountryName);
Console.WriteLine(response.Data.Security?.ThreatScore);
Console.WriteLine(response.Data.Security?.IsVpn);
Console.WriteLine(response.Data.Currency is null); // True
```

### Raw XML

```csharp
var response = await client.LookupIpGeolocationRawAsync(
    new LookupIpGeolocationRequest(
        ip: "8.8.8.8",
        output: ResponseFormat.Xml));

Console.WriteLine(response.Data);
```

### Bulk Lookup

```csharp
var response = await client.BulkLookupIpGeolocationAsync(
    new BulkLookupIpGeolocationRequest(new[] { "8.8.8.8", "1.1.1.1" }));

foreach (var result in response.Data)
{
    if (result is BulkLookupSuccess success)
    {
        Console.WriteLine(success.Data.Ip);
        continue;
    }

    if (result is BulkLookupError error)
    {
        Console.WriteLine(error.Error.Message);
    }
}
```

### Raw Bulk JSON

```csharp
var response = await client.BulkLookupIpGeolocationRawAsync(
    new BulkLookupIpGeolocationRequest(new[] { "8.8.8.8", "1.1.1.1" }));

Console.WriteLine(response.Data);
```

## Response Metadata

Every method returns `ApiResponse<T>`, where:

- `Data` contains the typed object or raw response string
- `Metadata` contains response details such as:
  - `CreditsCharged`
  - `SuccessfulRecords`
  - `StatusCode`
  - `DurationMs`
  - `RawHeaders`

Example:

```csharp
Console.WriteLine(response.Metadata.StatusCode);
Console.WriteLine(response.Metadata.DurationMs);
Console.WriteLine(response.Metadata.FirstHeaderValue("content-type"));
```

## Errors

The SDK throws typed exceptions instead of returning error objects for failed HTTP responses.

| Exception | When it happens |
|-----------|-----------------|
| `ValidationException` | Invalid config, invalid request values, or typed XML request |
| `RequestTimeoutException` | Connect timeout or read timeout |
| `TransportException` | Network or transport failure |
| `SerializationException` | Request or response serialization failure |
| `ApiException` | API returned a non-2xx response |

`ApiException` has status-specific subclasses:

- `BadRequestException`
- `UnauthorizedException`
- `ForbiddenException`
- `NotFoundException`
- `MethodNotAllowedException`
- `ContentTooLargeException`
- `UnsupportedMediaTypeException`
- `LockedException`
- `TooManyRequestsException`
- `CustomStatus499Exception`
- `InternalServerErrorException`

Example:

```csharp
try
{
    var response = await client.LookupIpGeolocationAsync(
        new LookupIpGeolocationRequest(output: ResponseFormat.Xml));
}
catch (ValidationException error)
{
    Console.WriteLine(error.Message);
}
catch (ApiException error)
{
    Console.WriteLine((int)error.StatusCode);
    Console.WriteLine(error.Message);
}
```

## Troubleshooting

- Bulk lookup always requires `apiKey`. `requestOrigin` is not enough.
- Typed methods only support JSON. Use the raw methods for XML.
- If you need security, abuse, user-agent, or hostname data, include those modules explicitly.
- `fields` and `excludes` filter the response. They do not unlock paid data.
- `requestOrigin` must be an origin only. Do not include a path, query string, fragment, or userinfo.

## Frequently Asked Questions

<details>
<summary>Can I use this SDK without an API key?</summary>

Only for single lookup with paid-plan request-origin auth. Bulk lookup always requires an API key.
</details>

<details>
<summary>Can I request XML and still get typed models?</summary>

No. Typed methods only support JSON. Use `LookupIpGeolocationRawAsync` or `BulkLookupIpGeolocationRawAsync` for XML.
</details>

<details>
<summary>Does domain lookup work on the free plan?</summary>

No. Domain lookup is a paid-plan feature.
</details>

<details>
<summary>How do I get security, abuse, hostname, or user-agent data?</summary>

Pass the right modules in `include`, for example `security`, `abuse`, `hostname`, or `user_agent`.
</details>

## Links

- Homepage: <https://ipgeolocation.io>
- IP Location API product page: <https://ipgeolocation.io/ip-location-api.html>
- Documentation: <https://ipgeolocation.io/documentation/ip-location-api.html>
- NuGet package: <https://www.nuget.org/packages/IPGeoLocation.IPGeolocation>
- GitHub repository: <https://github.com/IPGeolocation/ip-geolocation-api-dotnet-sdk>
