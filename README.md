# IP Geolocation API .NET SDK

## Overview
The official **.NET Library (C# SDK)** for **[IPGeolocation.io](https://ipgeolocation.io)**'s set of APIs, provides a quick, developer friendly, way to access IP Location, Security, Timezone, Astronomy, ASN, Abuse Contact, and useragent data. Lookup your own IP or provide any IPv4, IPv6 or domain name to get structured results in C#, without the need for manual handling HTTP clients, serialization, or authentication.

- [IP Location API](https://ipgeolocation.io/ip-location-api.html): Get all-in-one unified solution for **location** (city, locality, state, country, etc.), **currency**, **network** (AS number, ASN name, organization, asn type, date of allocation, company/ISP name, company type, company domain), **timezone** , **useragent** string parsing, **security** (threat score, is_tor, is_bot, proxy_provider, cloud_provider), and **abuse contact** (route/CIDR network, country, address, email, phone numbers) information.
- [IP Security API](https://ipgeolocation.io/ip-security-api.html): Get security, network, location, hostname, timezone and useragent parsing.
- [ASN API](https://ipgeolocation.io/asn-api.html): Get ASN details along with peers, upstreams, downstreams, routes, and raw WHOIS.
- [Abuse Contact API](https://ipgeolocation.io/ip-abuse-contact-api.html): Get abuse emails, phone numbers, kind, organization, route/CIDR network and country.
- [Astronomy API](https://ipgeolocation.io/astronomy-api.html): Get sunrise, sunset, moonrise, moonset, moon phases with precise twilight period times in combination with location information.
- [Timezone API](https://ipgeolocation.io/timezone-api.html): Get timezone name, multiple time formats, daylight saving status and its details along with location information.
- [Timezone Convert API](https://ipgeolocation.io/timezone-api.html): Convert time between timezone names, geo coordinates, location addresses, IATA codes, ICAO codes, or UN/LOCODE.
- [User Agent API](https://ipgeolocation.io/user-agent-api.html): Get browser, Operating System, and device info from single or multiple Useragent string parsing.

This library aims to empower developers to integrate threat intelligence, personalization, fraud prevention, compliance, and analytics features directly into .NET applications. Whether you're enriching signup forms with ip geolocation data, localizing content, embedding threat intelligence, or converting time zones for distributed systems, the library provides a high-performance, scalable implementation leveraging .NET's modern HTTP stack and async programming model.

Based on:
- API version: 2.0

**Official Release:**
- Available on [**NuGet Gallery**](https://www.nuget.org/packages/IPGeoLocation.IPGeolocation)
- Source Code: [**GitHub Repository**](https://github.com/IPGeolocation/ip-geolocation-api-dotnet-sdk)

## Table of Contents

1. [Requirements](#requirements)
2. [Installation](#installation)
   - [Using .NET CLI](#using-net-cli)
   - [Using NuGet Package Manager](#using-nuget-package-manager)
   - [Using Paket CLI](#using-paket-cli)
3. [API Plan Tiers and Documentation](#api-plan-tiers-and-documentation)
4. [API Endpoints](#api-endpoints)
5. [Fields and Methods Availability](#fields-and-methods-availability)
6. [Authentication Setup](#authentication-setup)
   - [How to Get Your API Key](#how-to-get-your-api-key)
   - [ApiKeyAuth](#apikeyauth)
7. [IP Geolocation Examples](#ip-geolocation-examples)
   - [Developer (Free) Plan Examples](#developer-free-plan-examples)
   - [Standard Plan Examples](#standard-plan-examples)
   - [Advanced Plan Examples](#advanced-plan-example)
   - [Bulk IP Geolocation Example](#bulk-ip-geolocation-example)
8. [IP Security Examples](#ip-security-examples)
   - [Get Default Fields](#get-default-security-info)
   - [Include Multiple Optional Fields](#include-multiple-optional-fields)
   - [Request with Field Filtering](#request-with-field-filtering)
   - [Bulk IP Security Request](#bulk-ip-security-request)
9. [ASN API Examples](#asn-api-examples)
   - [Get ASN Information by IP Address](#get-asn-information-by-ip-address)
   - [Get ASN Information by ASN Number](#get-asn-information-by-asn-number)
   - [Combine All objects using Include](#combine-all-objects-using-include)
10. [Abuse Contact API Examples](#abuse-contact-api-examples)
    - [Lookup Abuse Contact by IP](#lookup-abuse-contact-by-ip)
    - [Lookup Abuse Contact with Specific Fields](#lookup-abuse-contact-with-specific-fields)
    - [Lookup Abuse Contact while Excluding Fields](#lookup-abuse-contact-while-excluding-fields)
11. [Timezone API Examples](#timezone-api-examples)
    - [Get Timezone by IP Address](#get-timezone-by-ip-address)
    - [Get Timezone by Timezone Name](#get-timezone-by-timezone-name)
    - [Get Timezone from Any Address](#get-timezone-from-any-address)
    - [Get Timezone from Location Coordinates](#get-timezone-from-location-coordinates)
    - [Get Timezone and Airport Details from IATA Code](#get-timezone-and-airport-details-from-iata-code)
    - [Get Timezone and City Details from UN/LOCODE](#get-timezone-and-city-details-from-unlocode)
12. [Timezone Converter Examples](#timezone-converter-api-examples)
    - [Convert Current Time from One Timezone to Another](#convert-current-time-from-one-timezone-to-another)
13. [User Agent API Examples](#user-agent-api-examples)
    - [Parse a Basic User Agent String](#parse-a-basic-user-agent-string)
    - [Bulk User Agent Parsing Example](#bulk-user-agent-parsing-example)
14. [Astronomy API Examples](#astronomy-api-examples)
    - [Lookup Astronomy by Coordinates](#lookup-astronomy-info-by-coordinates)
    - [Lookup Astronomy by IP Address](#lookup-astronomy-api-by-ip-address)
    - [Lookup Astronomy by Location String](#lookup-astronomy-api-by-location-string)
    - [Lookup Astronomy for Specific Date](#lookup-astronomy-api-for-specific-date)
    - [Lookup Location Info in Different Language](#lookup-location-info-in-different-language)
15. [Documentation for Models](#models)

## Requirements
- ✅ .NET 6.0+
- ✅ .NET 7.0
- ✅ .NET 8.0
- ✅ .NET Standard 2.1
- API Key from [IPGeolocation.io](https://ipgeolocation.io)

> [!NOTE]
> ❌ Not compatible with .NET Framework (which only supports .NET Standard 2.0)

## Installation
### Using .NET CLI
```bash
dotnet add package IPGeoLocation.IPGeolocation --version 2.0.0
```

### Using NuGet Package Manager
```bash
NuGet\Install-Package IPGeoLocation.IPGeolocation -Version 2.0.0
```

### Using Paket CLI
```bash
paket add IPGeoLocation.IPGeolocation -Version 2.0.0
```

## API Plan Tiers and Documentation

The documentation below corresponds to the four available API tier plans:

- **Developer Plan** (Free): [Full Documentation](https://ipgeolocation.io/ip-location-api.html#Free)
- **Standard Plan**: [Full Documentation](https://ipgeolocation.io/ip-location-api.html#Standard)
- **Advance Plan**: [Full Documentation](https://ipgeolocation.io/ip-location-api.html#Advance)
- **Security Plan**: [Full Documentation](https://ipgeolocation.io/ip-security-api.html#documentation-overview)

For a detailed comparison of what each plan offers, visit the [Pricing Page](https://ipgeolocation.io/pricing.html).

## API Endpoints

All URIs are relative to *https://api.ipgeolocation.io/v2*

| Class               | Method                                                                                                                                                                 | HTTP request              | Description                                                |
|---------------------|------------------------------------------------------------------------------------------------------------------------------------------------------------------------|---------------------------|------------------------------------------------------------|
| *IPGeolocationApi*  | [**getIpGeolocation**](https://github.com/IPGeolocation/ip-geolocation-api-dotnet-sdk/blob/HEAD/docs/apis/IPGeolocationApi.md#getipgeolocation)                        | **GET** /ipgeo            | Get geolocation data for a single IP address               |
| *IPGeolocationApi*  | [**getBulkIpGeolocation**](https://github.com/IPGeolocation/ip-geolocation-api-dotnet-sdk/blob/HEAD/docs/apis/IPGeolocationApi.md#getbulkipgeolocation)                | **POST** /ipgeo-bulk      | Get geolocation data for multiple IP addresses             |
| *IPSecurityApi*     | [**getIpSecurityInfo**](https://github.com/IPGeolocation/ip-geolocation-api-dotnet-sdk/blob/HEAD/docs/apis/IPSecurityApi.md#getipsecurityinfo)                         | **GET** /security         | Get threat intelligence for a single IP address            |
| *IPSecurityApi*     | [**getBulkIpSecurityInfo**](https://github.com/IPGeolocation/ip-geolocation-api-dotnet-sdk/blob/HEAD/docs/apis/IPSecurityApi.md#getbulkipsecurityinfo)                 | **POST** /security-bulk   | Get threat intelligence for multiple IP addresses          |
| *ASNLookupApi*      | [**getAsnInfo**](https://github.com/IPGeolocation/ip-geolocation-api-dotnet-sdk/blob/HEAD/docs/apis/ASNLookupApi.md#getasninfo)                                        | **GET** /asn              | Get details of any ASN number                              |
| *AbuseContactApi*   | [**getAbuseContactInfo**](https://github.com/IPGeolocation/ip-geolocation-api-dotnet-sdk/blob/HEAD/docs/apis/AbuseContactApi.md#getabusecontactinfo)                   | **GET** /abuse            | Retrieve abuse contact data for an IP address              |
| *AstronomyApi*      | [**getAstronomyDetails**](https://github.com/IPGeolocation/ip-geolocation-api-dotnet-sdk/blob/HEAD/docs/apis/AstronomyApi.md#getastronomydetails)                      | **GET** /astronomy        | Get sun and moon timings and positions                     |
| *TimezoneApi*       | [**getTimezoneInfo**](https://github.com/IPGeolocation/ip-geolocation-api-dotnet-sdk/blob/HEAD/docs/apis/TimezoneApi.md#gettimezoneinfo)                               | **GET** /timezone         | Get timezone information based on IP, coordinates, or name |
| *TimeConversionApi* | [**convertTimeBetweenTimezones**](https://github.com/IPGeolocation/ip-geolocation-api-dotnet-sdk/blob/HEAD/docs/apis/TimeConversionApi.md#converttimebetweentimezones) | **GET** /timezone/convert | Convert time from one timezone to another                  |
| *UserAgentApi*      | [**getUserAgentDetails**](https://github.com/IPGeolocation/ip-geolocation-api-dotnet-sdk/blob/HEAD/docs/apis/UserAgentApi.md#getuseragentdetails)                      | **GET** /user-agent       | Parse a single user-agent string                           |
| *UserAgentApi*      | [**parseUserAgentString**](https://github.com/IPGeolocation/ip-geolocation-api-dotnet-sdk/blob/HEAD/docs/apis/UserAgentApi.md#parseuseragentstring)                    | **POST** /user-agent      | Alternate method to parse a single user-agent string       |
| *UserAgentApi*      | [**parseBulkUserAgentStrings**](https://github.com/IPGeolocation/ip-geolocation-api-dotnet-sdk/blob/HEAD/docs/apis/UserAgentApi.md#parsebulkuseragentstrings)          | **POST** /user-agent-bulk | Parse multiple user-agent strings                          |

## Fields and Methods Availability
IP Geolocation offers four plans from billing point of view: **Free, Standard, Security, Advance**. The availability of each method calling from the respective class, over all plans are presented below.

| Class               | Method                                                                                                                                                                  | Free | Standard | Security | Advance |
|---------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------|:----:|:--------:|:--------:|:-------:|
| *IPGeolocationApi*  | [**getIpGeolocation**](https://github.com/IPGeolocation/ip-geolocation-api-dotnet-sdk/blob/HEAD/docs/apis/IPGeolocationApi.md#getipgeolocation)                         |  ✔   |    ✔     |    ✖     |    ✔    |
| *IPGeolocationApi*  | [**getBulkIpGeolocation**](https://github.com/IPGeolocation/ip-geolocation-api-dotnet-sdk/blob/HEAD/docs/apis/IPGeolocationApi.md#getbulkipgeolocation)                 |  ✖   |    ✔     |    ✖     |    ✔    |
| *IPSecurityApi*     | [**getIpSecurityInfo**](https://github.com/IPGeolocation/ip-geolocation-api-dotnet-sdk/blob/HEAD/docs/apis/IPSecurityApi.md#getipsecurityinfo)                          |  ✖   |    ✖     |    ✔     |    ✖    |
| *IPSecurityApi*     | [**getBulkIpSecurityInfo**](https://github.com/IPGeolocation/ip-geolocation-api-dotnet-sdk/blob/HEAD/docs/apis/IPSecurityApi.md#getbulkipsecurityinfo)                  |  ✖   |    ✖     |    ✔     |    ✖    |
| *ASNLookupApi*      | [**getAsnInfo**](https://github.com/IPGeolocation/ip-geolocation-api-dotnet-sdk/blob/HEAD/docs/apis/ASNLookupApi.md#getasninfo)                                         |  ✖   |    ✖     |    ✖     |    ✔    |
| *AbuseContactApi*   | [**getAbuseContactInfo**](https://github.com/IPGeolocation/ip-geolocation-api-dotnet-sdk/blob/HEAD/docs/apis/AbuseContactApi.md#getabusecontactinfo)                    |  ✖   |    ✖     |    ✖     |    ✔    |
| *AstronomyApi*      | [**getAstronomyDetails**](https://github.com/IPGeolocation/ip-geolocation-api-dotnet-sdk/blob/HEAD/docs/apis/AstronomyApi.md#getastronomydetails)                       |  ✔   |    ✔     |    ✔     |    ✔    |
| *TimezoneApi*       | [**getTimezoneInfo**](https://github.com/IPGeolocation/ip-geolocation-api-dotnet-sdk/blob/HEAD/docs/apis/TimezoneApi.md#gettimezoneinfo)                                |  ✔   |    ✔     |    ✔     |    ✔    |
| *TimeConversionApi* | [**convertTimeBetweenTimezones**](https://github.com/IPGeolocation/ip-geolocation-api-dotnet-sdk/blob/HEAD/docs/apis/TimeConversionApi.md#converttimebetweentimezones)  |  ✔   |    ✔     |    ✔     |    ✔    |
| *UserAgentApi*      | [**getUserAgentDetails**](https://github.com/IPGeolocation/ip-geolocation-api-dotnet-sdk/blob/HEAD/docs/apis/UserAgentApi.md#getuseragentdetails)                       |  ✔   |    ✔     |    ✔     |    ✔    |
| *UserAgentApi*      | [**parseUserAgentString**](https://github.com/IPGeolocation/ip-geolocation-api-dotnet-sdk/blob/HEAD/docs/apis/UserAgentApi.md#parseuseragentstring)                     |  ✔   |    ✔     |    ✔     |    ✔    |
| *UserAgentApi*      | [**parseBulkUserAgentStrings**](https://github.com/IPGeolocation/ip-geolocation-api-dotnet-sdk/blob/HEAD/docs/apis/UserAgentApi.md#parsebulkuseragentstrings)           |  ✖   |    ✔     |    ✔     |    ✔    |

> [!TIP]
> The availability of fields in every API endpoint across all API plans is provided in the **_Reference Table_** within each respective API Documentation. e.g., for IPGeolocationApi, please visit [https://ipgeolocation.io/ip-location-api.html#reference-to-ipgeolocation-api-response](https://ipgeolocation.io/ip-location-api.html#reference-to-ipgeolocation-api-response).

## Authentication Setup
You’ll need an API key from [ipgeolocation.io](https://ipgeolocation.io).

### How to Get Your API Key

1. **Sign up** here: [https://app.ipgeolocation.io/signup](https://app.ipgeolocation.io/signup)
2. **(optional)** Verify your email, if you signed up using email.
3. **Log in** to your account: [https://app.ipgeolocation.io/login](https://app.ipgeolocation.io/login)
4. After logging in, navigate to your **Dashboard** to find your API key: [https://app.ipgeolocation.io/dashboard](https://app.ipgeolocation.io/dashboard)

<a id="ApiKeyAuth"></a>
### ApiKeyAuth

Once you've obtained the api key, authenticate globally via dependency injection:
```csharp
using IPGeolocation.Client;
using IPGeolocation.Extensions;
using Microsoft.Extensions.Hosting;

var _host = Host.CreateDefaultBuilder()
    .ConfigureApi((context, services, options) =>
    {
        var token = new ApiKeyToken(
            "YOUR_API_KEY"
        );

        options.AddTokens(token);
        options.AddApiHttpClients(client => client.BaseAddress = new Uri("https://api.ipgeolocation.io/v2"));
    })
    .Build();
```

## IP Geolocation Examples

This section demonstrates usage of the `GetIpGeolocationAsync` method from the SDK across **Free**, **Standard**, and **Advanced** subscription tiers. You can customize the request using parameters like `fields`, `include`, and `excludes`.

**Parameters**

- `fields`: Use this parameter to include specific fields in the response.
- `excludes`: Use this parameter to omit specific fields from the response.
- `include`: Use this parameter to add optional modules to the response, such as:
  - `security`
  - `user_agent`
  - `hostname`
  - `liveHostname`
  - `hostnameFallbackLive`
  - `abuse`
  - `dma`
  - `time_zone`

For full API details, refer to the [IP Geolocation API Documentation](https://ipgeolocation.io/ip-location-api.html#documentation-overview)

The `ip` parameter in the SDK can accept any valid IPv4 address, IPv6 address, or domain name. If the `ip` parameter is omitted, the API will return information about the public IP address of the device or server where the SDK is executed.

### Developer (Free) Plan Examples

#### Get Default Fields

```csharp
using IPGeolocation.Api;
using Microsoft.Extensions.DependencyInjection;
using System.Text.Json;
using IPGeolocation.Model;

var ipGeolocationApi = _host.Services.GetRequiredService<IIPGeolocationApi>();
var response = await ipGeolocationApi.GetIpGeolocationAsync(ip: "8.8.8.8");

Console.WriteLine(JsonSerializer.Serialize(response.Ok(), new JsonSerializerOptions { WriteIndented = true }));
```
Sample Response:
```json
{
  "ip": "8.8.8.8",
  "location": {
    "continent_code": "NA",
    "continent_name": "North America",
    "country_code2": "US",
    "country_code3": "USA",
    "country_name": "United States",
    "country_name_official": "United States of America",
    "country_capital": "Washington, D.C.",
    "state_prov": "California",
    "state_code": "US-CA",
    "district": "Santa Clara",
    "city": "Mountain View",
    "zipcode": "94043-1351",
    "latitude": "37.42240",
    "longitude": "-122.08421",
    "is_eu": false,
    "country_flag": "https://ipgeolocation.io/static/flags/us_64.png",
    "geoname_id": "6301403",
    "country_emoji": "\uD83C\uDDFA\uD83C\uDDF8"
  },
  "country_metadata": {
    "calling_code": "\u002B1",
    "tld": ".us",
    "languages": [
      "en-US",
      "es-US",
      "haw",
      "fr"
    ]
  },
  "currency": {
    "code": "USD",
    "name": "US Dollar",
    "symbol": "$"
  }
}
```

Filtering Specific Fields from the Response (Use of 'exclude' and 'fields').
```csharp
var ipGeolocationApi = _host.Services.GetRequiredService<IIPGeolocationApi>();
var response = await ipGeolocationApi.GetIpGeolocationAsync(
    ip: "8.8.4.4",
    fields: "location",
    excludes: "location.continent_code,location.continent_name"
);

Console.WriteLine(JsonSerializer.Serialize(response.Ok(), new JsonSerializerOptions { WriteIndented = true }));
```
Sample Response:
```json
{
  "ip": "8.8.4.4",
  "location": {
    "country_code2": "US",
    "country_code3": "USA",
    "country_name": "United States",
    "country_name_official": "United States of America",
    "country_capital": "Washington, D.C.",
    "state_prov": "California",
    "state_code": "US-CA",
    "district": "Santa Clara",
    "city": "Mountain View",
    "zipcode": "94043-1351",
    "latitude": "37.42240",
    "longitude": "-122.08421",
    "is_eu": false,
    "country_flag": "https://ipgeolocation.io/static/flags/us_64.png",
    "geoname_id": "6301403",
    "country_emoji": "\uD83C\uDDFA\uD83C\uDDF8"
  }
}
```
### Standard Plan Examples
#### Get Default Fields
```csharp
var ipGeolocationApi = _host.Services.GetRequiredService<IIPGeolocationApi>();
var response = await ipGeolocationApi.GetIpGeolocationAsync(ip: "8.8.8.8");

Console.WriteLine(JsonSerializer.Serialize(response.Ok(), new JsonSerializerOptions { WriteIndented = true }));
```
Sample Response:
```json
{
  "ip": "8.8.8.8",
  "location": {
    "continent_code": "NA",
    "continent_name": "North America",
    "country_code2": "US",
    "country_code3": "USA",
    "country_name": "United States",
    "country_name_official": "United States of America",
    "country_capital": "Washington, D.C.",
    "state_prov": "California",
    "state_code": "US-CA",
    "district": "Santa Clara",
    "city": "Mountain View",
    "zipcode": "94043-1351",
    "latitude": "37.42240",
    "longitude": "-122.08421",
    "is_eu": false,
    "country_flag": "https://ipgeolocation.io/static/flags/us_64.png",
    "geoname_id": "6301403",
    "country_emoji": "\uD83C\uDDFA\uD83C\uDDF8"
  },
  "country_metadata": {
    "calling_code": "\u002B1",
    "tld": ".us",
    "languages": [
      "en-US",
      "es-US",
      "haw",
      "fr"
    ]
  },
  "network": {
    "asn": {
      "as_number": "AS15169",
      "organization": "Google LLC",
      "country": "US"
    },
    "company": {
      "name": "Google LLC"
    }
  },
  "currency": {
    "code": "USD",
    "name": "US Dollar",
    "symbol": "$"
  }
}
```
#### Retrieving Geolocation Data in Multiple Languages
Here is an example to get the geolocation data for IP address '2001:4230:4890::1' in French language(fr):
```csharp
var ipGeolocationApi = _host.Services.GetRequiredService<IIPGeolocationApi>();
var response = await ipGeolocationApi.GetIpGeolocationAsync(ip: "2001:4230:4890::1", lang: "fr");

Console.WriteLine(JsonSerializer.Serialize(response.Ok(), new JsonSerializerOptions { WriteIndented = true }));
```
Sample Response:
```json
{
  "ip": "2001:4230:4890:0:0:0:0:1",
  "location": {
    "continent_code": "AF",
    "continent_name": "Afrique",
    "country_code2": "MU",
    "country_code3": "MUS",
    "country_name": "Maurice",
    "country_name_official": "",
    "country_capital": "Port Louis",
    "state_prov": "Wilhems des plaines",
    "state_code": "MU-PW",
    "district": "Quatre Bornes",
    "city": "Quatre Bornes",
    "zipcode": "72201",
    "latitude": "-20.24304",
    "longitude": "57.49631",
    "is_eu": false,
    "country_flag": "https://ipgeolocation.io/static/flags/mu_64.png",
    "geoname_id": "1106777",
    "country_emoji": "\uD83C\uDDF2\uD83C\uDDFA"
  },
  "country_metadata": {
    "calling_code": "\u002B230",
    "tld": ".mu",
    "languages": [
      "en-MU",
      "bho",
      "fr"
    ]
  },
  "network": {
    "asn": {
      "as_number": "AS0",
      "organization": "",
      "country": ""
    },
    "company": {
      "name": "African Network Information Center AfriNIC Ltd"
    }
  },
  "currency": {
    "code": "MUR",
    "name": "Mauritius Rupee",
    "symbol": "\u20A8"
  }
}
```
####  Include Hostname, Timezone, and User-Agent
```csharp
var ipGeolocationApi = _host.Services.GetRequiredService<IIPGeolocationApi>();
var response = await ipGeolocationApi.GetIpGeolocationAsync(
    ip: "4.5.6.7",
    fields: "location.country_name,location.country_capital",
    include: "user_agent,timezone,hostnameFallbackLive"
);

Console.WriteLine(JsonSerializer.Serialize(response.Ok(), new JsonSerializerOptions { WriteIndented = true }));
```
Sample Response:
```json
{
  "ip": "4.5.6.7",
  "hostname": "4.5.6.7",
  "location": {
    "country_name": "United States",
    "country_capital": "Washington, D.C."
  },
  "time_zone": {
    "name": "America/Chicago",
    "offset": -6,
    "offset_with_dst": -5,
    "current_time": "2025-07-24 06:41:42.528-0500",
    "current_time_unix": 1753357302.528,
    "is_dst": true,
    "dst_savings": 1,
    "dst_exists": true,
    "dst_start": {
      "utc_time": "2025-03-09 TIME 08",
      "duration": "\u002B1H",
      "gap": true,
      "date_time_after": "2025-03-09 TIME 03",
      "date_time_before": "2025-03-09 TIME 02",
      "overlap": false
    },
    "dst_end": {
      "utc_time": "2025-11-02 TIME 07",
      "duration": "-1H",
      "gap": false,
      "date_time_after": "2025-11-02 TIME 01",
      "date_time_before": "2025-11-02 TIME 02",
      "overlap": true
    }
  },
  "user_agent": {
    "user_agent_string": "IPGeolocation.NET-SDK/2.0.0",
    "name": "IPGeolocation.NET-SDK",
    "type": "Special",
    "version": "2.0.0",
    "version_major": "2",
    "device": {
      "name": "Unknown",
      "type": "Unknown",
      "brand": "Unknown",
      "cpu": "Unknown"
    },
    "engine": {
      "name": "Unknown",
      "type": "Unknown",
      "version": "??",
      "version_major": "??"
    },
    "operating_system": {
      "name": "Unknown",
      "type": "Unknown",
      "version": "??",
      "version_major": "??",
      "build": "??"
    }
  }
}
```
> [!NOTE]
> 
> The IP Geolocation API supports hostname lookup for all paid subscriptions. However, this is not included by default. To enable hostname resolution, use the `include` parameter with one of the following options:
> - `hostname`: Performs a quick lookup using the internal hostname database. If no match is found, the IP is returned as-is. This is fast but may produce incomplete results.
> - `liveHostname`: Queries live sources for accurate hostname resolution. This may increase response time.
> - `hostnameFallbackLive`: Attempts the internal database first, and falls back to live sources if no result is found. This option provides a balance of speed and reliability.

### Advanced Plan Example
#### Include DMA, Abuse, and Security Modules

```csharp
var ipGeolocationApi = _host.Services.GetRequiredService<IIPGeolocationApi>();
var response = await ipGeolocationApi.GetIpGeolocationAsync(
    ip: "8.8.8.8",
    excludes: "location.country_flag,location.country_emoji",
    include: "dma,abuse,security"
);

Console.WriteLine(JsonSerializer.Serialize(response.Ok(), new JsonSerializerOptions { WriteIndented = true }));
```
Sample Response:
```json
{
  "ip": "8.8.8.8",
  "location": {
    "continent_code": "NA",
    "continent_name": "North America",
    "country_code2": "US",
    "country_code3": "USA",
    "country_name": "United States",
    "country_name_official": "United States of America",
    "country_capital": "Washington, D.C.",
    "state_prov": "California",
    "state_code": "US-CA",
    "district": "Santa Clara",
    "city": "Mountain View",
    "zipcode": "94043-1351",
    "latitude": "37.42240",
    "longitude": "-122.08421",
    "is_eu": false,
    "geoname_id": "6301403",
    "accuracy_radius": "",
    "locality": "Mountain View",
    "dma_code": "807"
  },
  "country_metadata": {
    "calling_code": "\u002B1",
    "tld": ".us",
    "languages": [
      "en-US",
      "es-US",
      "haw",
      "fr"
    ]
  },
  "network": {
    "asn": {
      "as_number": "AS15169",
      "organization": "Google LLC",
      "country": "US",
      "asn_name": "GOOGLE",
      "type": "BUSINESS",
      "domain": "about.google",
      "date_allocated": "",
      "allocation_status": "assigned",
      "num_of_ipv4_routes": "991",
      "num_of_ipv6_routes": "104",
      "rir": "ARIN"
    },
    "connection_type": "",
    "company": {
      "name": "Google LLC",
      "type": "",
      "domain": ""
    }
  },
  "currency": {
    "code": "USD",
    "name": "US Dollar",
    "symbol": "$"
  },
  "security": {
    "threat_score": 0,
    "is_tor": false,
    "is_proxy": false,
    "proxy_type": "",
    "proxy_provider": "",
    "is_anonymous": false,
    "is_known_attacker": false,
    "is_spam": false,
    "is_bot": false,
    "is_cloud_provider": false,
    "cloud_provider": ""
  },
  "abuse": {
    "route": "8.8.8.0/24",
    "country": "",
    "handle": "ABUSE5250-ARIN",
    "name": "Abuse",
    "organization": "Abuse",
    "role": "abuse",
    "kind": "group",
    "address": "1600 Amphitheatre Parkway\nMountain View\nCA\n94043\nUnited States",
    "emails": [
      "network-abuse@google.com"
    ],
    "phone_numbers": [
      "\u002B1-650-253-0000"
    ]
  }
}
```
These examples demonstrate typical usage of the IP Geolocation API with different subscription tiers. Use `fields` to specify exactly which data to receive, `include` for optional data like security and user agent, and `excludes` to omit specific keys from the response.

> [!NOTE]
> All features available in the Free plan are also included in the Standard and Advanced plans. Similarly, all features of the Standard plan are available in the Advanced plan.

### Bulk IP Geolocation Example
The SDK also supports bulk IP geolocation using `GetBulkIpGeolocationAsync()`. All parameters like `fields`, `include`, and `excludes` are supported.
```csharp
var ipGeolocationApi = _host.Services.GetRequiredService<IIPGeolocationApi>();

var bulkRequest = new BulkIPRequest();
bulkRequest.Ips = new List<string> { "8.8.8.8", "1.1.1.1" };

var response = await ipGeolocationApi.GetBulkIpGeolocationAsync(
    bulkIPRequest: bulkRequest,
    fields: "location.country_name,location.city",
    include: "security,timezone",
    excludes: "location.continent_code"
);

Console.WriteLine(JsonSerializer.Serialize(response.Ok(), new JsonSerializerOptions { WriteIndented = true }));
```
## IP Security Examples

This section demonstrates how to use the IP Security API provided by the SDK. These examples show different ways to query threat intelligence and risk metadata for IP addresses using optional parameters like `fields`, `include`, and `excludes`.

For detailed API specs, refer to the [IP Security API documentation](https://ipgeolocation.io/ip-security-api.html#documentation-overview).

### Get Default Security Info
```csharp
using System;
using System.Text.Json;
using System.Threading.Tasks;
using IPGeolocation.Api;
using IPGeolocation.Model;

var api = _host.Services.GetRequiredService<IIPSecurityApi>();

var response = await api.GetIpSecurityInfoAsync(ip: "2.56.188.34");

Console.WriteLine(JsonSerializer.Serialize(response.Ok(), new JsonSerializerOptions { WriteIndented = true }));
```
Sample Response:
```json
{
  "ip": "2.56.188.34",
  "security": {
    "threat_score": 80,
    "is_tor": false,
    "is_proxy": true,
    "proxy_type": "VPN",
    "proxy_provider": "Nord VPN",
    "is_anonymous": true,
    "is_known_attacker": true,
    "is_spam": false,
    "is_bot": false,
    "is_cloud_provider": true,
    "cloud_provider": "Packethub S.A."
  }
}
```
### Include Multiple Optional Fields
This example shows how to include additional modules like location, network, currency, time_zone, etc., to enrich the response with more context.
```csharp
var api = _host.Services.GetRequiredService<IIPSecurityApi>();
var response = await api.GetIpSecurityInfoAsync(
    ip: "2.56.188.34",
    include: "location,network,currency,time_zone,user_agent,country_metadata,hostname"
);

Console.WriteLine(JsonSerializer.Serialize(response.Ok(), new JsonSerializerOptions { WriteIndented = true }));
```

> [!NOTE]
> You can get all the available fields in standard plan in combination with security data, when subscribed to security plan.

### Request with Field Filtering
```csharp
var api = _host.Services.GetRequiredService<IIPSecurityApi>();
var response = await api.GetIpSecurityInfoAsync(
    ip: "195.154.221.54",
    fields: "is_tor,is_proxy,is_bot,is_spam"
);

Console.WriteLine(JsonSerializer.Serialize(response.Ok(), new JsonSerializerOptions { WriteIndented = true }));
```
Sample Response:
```json
{
  "ip": "195.154.221.54",
  "security": {
    "is_tor": false,
    "is_proxy": true,
    "is_spam": false,
    "is_bot": false
  }
}
```
### Bulk IP Security Request
The SDK supports sending a list of IPs in a single bulk call using `GetBulkIpSecurityInfoAsync()` with support for fields and include.
```csharp
var api = _host.Services.GetRequiredService<IIPSecurityApi>();

BulkIPRequest bulkRequest = new()
{
  Ips = ["2.56.188.34", "2.56.188.35"]
};

var response = await api.GetBulkIpSecurityInfoAsync(
    bulkRequest,
    include: "location,network",
    fields: "security.threat_score,location.country_name"
);

Console.WriteLine(JsonSerializer.Serialize(response.Ok(), new JsonSerializerOptions { WriteIndented = true }));
```
## ASN API Examples
This section demonstrates how to use the `GetAsnInfoAsync()` method from the .NET SDK to retrieve Autonomous System Number (ASN) information.

> [!NOTE] 
> ASN API is only available on the Advanced subscription plans.

For more details on supported fields and their usage, refer to the [ASN API documentation](https://ipgeolocation.io/asn-api.html#documentation-overview).

### Get ASN Information by IP Address
```csharp
using System;
using System.Text.Json;
using IPGeolocation.Api;
using IPGeolocation.Client;
using IPGeolocation.Model;

var api = _host.Services.GetRequiredService<IASNLookupApi>();

var response = await api.GetAsnInfoAsync(ip: "8.8.8.8");

Console.WriteLine(JsonSerializer.Serialize(response.Ok(), new JsonSerializerOptions { WriteIndented = true }));
```
Sample Response:
```json
{
  "ip": "8.8.8.8",
  "asn": {
    "as_number": "AS15169",
    "organization": "Google LLC",
    "country": "US",
    "asn_name": "GOOGLE",
    "type": "BUSINESS",
    "domain": "about.google",
    "date_allocated": "",
    "allocation_status": "assigned",
    "num_of_ipv4_routes": "991",
    "num_of_ipv6_routes": "104",
    "rir": "ARIN"
  }
}
```
### Get ASN Information by ASN Number
```csharp
var api = _host.Services.GetRequiredService<IASNLookupApi>();

var response = await api.GetAsnInfoAsync(asn: 15169);

Console.WriteLine(JsonSerializer.Serialize(response.Ok(), new JsonSerializerOptions { WriteIndented = true }));
```
Sample Response:
```json
{
  "asn": {
    "as_number": "AS15169",
    "organization": "Google LLC",
    "country": "US",
    "asn_name": "GOOGLE",
    "type": "BUSINESS",
    "domain": "about.google",
    "date_allocated": "",
    "allocation_status": "assigned",
    "num_of_ipv4_routes": "991",
    "num_of_ipv6_routes": "104",
    "rir": "ARIN"
  }
}
```
### Combine All Objects Using include
```csharp
var api = _host.Services.GetRequiredService<IASNLookupApi>();

var response = await api.GetAsnInfoAsync(
    asn: 12,
    include: "peers,downstreams,upstreams,routes,whois_response"
);
Console.WriteLine(JsonSerializer.Serialize(response.Ok(), new JsonSerializerOptions { WriteIndented = true }));
```
Sample Response:
```json
{
  "asn": {
    "as_number": "AS12",
    "organization": "New York University",
    "country": "US",
    "asn_name": "NYU-DOMAIN",
    "type": "EDUCATION",
    "domain": "nyu.edu",
    "date_allocated": "",
    "allocation_status": "assigned",
    "num_of_ipv4_routes": "12",
    "num_of_ipv6_routes": "1",
    "rir": "ARIN",
    "routes": [
      "192.76.177.0/24",
      "216.165.96.0/20",
      "...",
      "216.165.120.0/22"
    ],
    "upstreams": [
      {
        "as_number": "AS3269",
        "description": "Telecom Italia S.p.A.",
        "country": "IT"
      },
      "...",
      {
        "as_number": "AS137",
        "description": "Consortium GARR",
        "country": "IT"
      }
    ],
    "downstreams": [
      {
        "as_number": "AS394666",
        "description": "NYU Langone Health",
        "country": "US"
      },
      {
        "as_number": "AS54965",
        "description": "Polytechnic Institute of NYU",
        "country": "US"
      }
    ],
    "peers": [
      {
        "as_number": "AS3269",
        "description": "Telecom Italia S.p.A.",
        "country": "IT"
      },
      "...",
      {
        "as_number": "AS54965",
        "description": "Polytechnic Institute of NYU",
        "country": "US"
      }
    ],
    "whois_response": "<raw-whois-response>"
  }
}
```

## Abuse Contact API Examples
This section demonstrates how to use the `GetAbuseContactInfoAsync()` method of the Abuse Contact API. This API helps security teams, hosting providers, and compliance professionals quickly identify the correct abuse reporting contacts for any IPv4 or IPv6 address. You can retrieve data like the responsible organization, role, contact emails, phone numbers, and address to take appropriate mitigation action against abusive or malicious activity.

> [!NOTE]
> Abuse Contact API is only available in Advanced Plan.

Refer to the official [Abuse Contact API documentation](https://ipgeolocation.io/ip-abuse-contact-api.html#documentation-overview) for details on all available fields.

### Lookup Abuse Contact by IP
```csharp
using System;
using System.Text.Json;
using IPGeolocation.Api;
using IPGeolocation.Model;

var api = _host.Services.GetRequiredService<IAbuseContactApi>();

var response = await api.GetAbuseContactInfoAsync(ip: "1.0.0.0");

Console.WriteLine(JsonSerializer.Serialize(response.Ok(), new JsonSerializerOptions { WriteIndented = true }));
```
Sample Response:
```json
{
  "ip": "1.0.0.0",
  "abuse": {
    "route": "1.0.0.0/24",
    "country": "AU",
    "handle": "IRT-APNICRANDNET-AU",
    "name": "IRT-APNICRANDNET-AU",
    "organization": "",
    "role": "abuse",
    "kind": "group",
    "address": "PO Box 3646\nSouth Brisbane, QLD 4101\nAustralia",
    "emails": [
      "helpdesk@apnic.net"
    ],
    "phone_numbers": [
      "\u002B61 7 3858 3100"
    ]
  }
}
```
### Lookup Abuse Contact with Specific Fields
```csharp
var api = _host.Services.GetRequiredService<IAbuseContactApi>();

var response = await api.GetAbuseContactInfoAsync(
    ip: "1.2.3.4",
    fields: "abuse.role,abuse.emails"
);

Console.WriteLine(JsonSerializer.Serialize(response.Ok(), new JsonSerializerOptions { WriteIndented = true }));
```
Sample Response:
```json
{
  "ip": "1.2.3.4",
  "abuse": {
    "role": "abuse",
    "emails": [
      "helpdesk@apnic.net"
    ]
  }
}
```
### Lookup Abuse Contact while Excluding Fields
```csharp
var api = _host.Services.GetRequiredService<IAbuseContactApi>();

var response = await api.GetAbuseContactInfoAsync(
    ip: "9.9.9.9",
    excludes: "abuse.handle,abuse.emails"
);

Console.WriteLine(JsonSerializer.Serialize(response.Ok(), new JsonSerializerOptions { WriteIndented = true }));
```
Sample Response:
```json
{
  "ip": "9.9.9.9",
  "abuse": {
    "route": "9.9.9.0/24",
    "country": "",
    "name": "Quad9 Abuse",
    "organization": "Quad9 Abuse",
    "role": "abuse",
    "kind": "group",
    "address": "1442 A Walnut Street Ste 501\nBerkeley\nCA\n94709\nUnited States",
    "phone_numbers": [
      "\u002B1-415-831-3129"
    ]
  }
}
```

## Timezone API Examples
This section demonstrates how to use the `GetTimezoneInfoAsync()` method from the .NET SDK to retrieve time zone and current time information for various input types.

You can query using various types of inputs: Time Zone name, Latitude/Longitude, Address, IP, IATA/ICAO/UN LOCODE, or even no input (defaults to caller's IP).

For full API specifications, refer to the [Timezone API documentation](https://ipgeolocation.io/timezone-api.html#documentation-overview).

### Get Timezone by IP Address
```csharp
using System;
using System.Text.Json;
using IPGeolocation.Api;
using IPGeolocation.Model;

var api = _host.Services.GetRequiredService<ITimezoneApi>();

var response = await api.GetTimezoneInfoAsync(ip: "8.8.8.8");

Console.WriteLine(JsonSerializer.Serialize(response.Ok(), new JsonSerializerOptions { WriteIndented = true }));
```
Sample Response:
```json
{
  "ip": "8.8.8.8",
  "location": {
    "continent_code": "NA",
    "continent_name": "North America",
    "country_code2": "US",
    "country_code3": "USA",
    "country_name": "United States",
    "country_name_official": "United States of America",
    "is_eu": false,
    "state_prov": "California",
    "state_code": "US-CA",
    "district": "Santa Clara",
    "city": "Mountain View",
    "locality": null,
    "zipcode": "94043-1351",
    "latitude": "37.42240",
    "longitude": "-122.08421"
  },
  "time_zone": {
    "name": "America/Los_Angeles",
    "offset": -8,
    "offset_with_dst": -7,
    "date": "2025-07-28T00:00:00+00:00",
    "date_time": "2025-07-28 02:52:42",
    "date_time_txt": "Monday, July 28, 2025 02:52:42",
    "date_time_wti": "Mon, 28 Jul 2025 02:52:42 -0700",
    "date_time_ymd": "2025-07-28T09:52:42+00:00",
    "date_time_unix": 1753696362.031,
    "time_24": "02:52:42",
    "time_12": "02:52:42 AM",
    "week": 31,
    "month": 7,
    "year": 2025,
    "year_abbr": "25",
    "is_dst": true,
    "dst_savings": 1,
    "dst_exists": true,
    "dst_start": {
      "utc_time": "2025-03-09 TIME 10",
      "duration": "\u002B1H",
      "gap": true,
      "date_time_after": "2025-03-09 TIME 03",
      "date_time_before": "2025-03-09 TIME 02",
      "overlap": false
    },
    "dst_end": {
      "utc_time": "2025-11-02 TIME 09",
      "duration": "-1H",
      "gap": false,
      "date_time_after": "2025-11-02 TIME 01",
      "date_time_before": "2025-11-02 TIME 02",
      "overlap": true
    }
  }
}
```

> [!NOTE]
> The Time Zone API is available to all users. However, multi-language support is only available for paid users.

### Get Timezone by Timezone Name
```csharp
var api = _host.Services.GetRequiredService<ITimezoneApi>();

var response = await api.GetTimezoneInfoAsync(tz: "Europe/London");

Console.WriteLine(JsonSerializer.Serialize(response.Ok(), new JsonSerializerOptions { WriteIndented = true }));
```
Sample Response:
```json
{
  "time_zone": {
    "name": "Europe/London",
    "offset": 0,
    "offset_with_dst": 1,
    "date": "2025-07-28T00:00:00+00:00",
    "date_time": "2025-07-28 11:05:31",
    "date_time_txt": "Monday, July 28, 2025 11:05:31",
    "date_time_wti": "Mon, 28 Jul 2025 11:05:31 \u002B0100",
    "date_time_ymd": "2025-07-28T10:05:31+00:00",
    "date_time_unix": 1753697131.049,
    "time_24": "11:05:31",
    "time_12": "11:05:31 AM",
    "week": 31,
    "month": 7,
    "year": 2025,
    "year_abbr": "25",
    "is_dst": true,
    "dst_savings": 1,
    "dst_exists": true,
    "dst_start": {
      "utc_time": "2025-03-30 TIME 01",
      "duration": "\u002B1H",
      "gap": true,
      "date_time_after": "2025-03-30 TIME 02",
      "date_time_before": "2025-03-30 TIME 01",
      "overlap": false
    },
    "dst_end": {
      "utc_time": "2025-10-26 TIME 01",
      "duration": "-1H",
      "gap": false,
      "date_time_after": "2025-10-26 TIME 01",
      "date_time_before": "2025-10-26 TIME 02",
      "overlap": true
    }
  }
}
```
### Get Timezone from Any Address
```csharp
var api = _host.Services.GetRequiredService<ITimezoneApi>();

var response = await api.GetTimezoneInfoAsync(location: "Munich, Germany");

Console.WriteLine(JsonSerializer.Serialize(response.Ok(), new JsonSerializerOptions { WriteIndented = true }));
```
Sample Response:
```json
{
  "location": {
    "location_string": "Munich, Germany",
    "country_name": "Germany",
    "state_prov": "Bavaria",
    "city": "Munich",
    "locality": "",
    "latitude": "48.13711",
    "longitude": "11.57538"
  },
  "time_zone": {
    "name": "Europe/Berlin",
    "offset": 1,
    "offset_with_dst": 2,
    "date": "2025-07-28T00:00:00+00:00",
    "date_time": "2025-07-28 12:07:45",
    "date_time_txt": "Monday, July 28, 2025 12:07:45",
    "date_time_wti": "Mon, 28 Jul 2025 12:07:45 \u002B0200",
    "date_time_ymd": "2025-07-28T10:07:45+00:00",
    "date_time_unix": 1753697265.804,
    "time_24": "12:07:45",
    "time_12": "12:07:45 PM",
    "week": 31,
    "month": 7,
    "year": 2025,
    "year_abbr": "25",
    "is_dst": true,
    "dst_savings": 1,
    "dst_exists": true,
    "dst_start": {
      "utc_time": "2025-03-30 TIME 01",
      "duration": "\u002B1H",
      "gap": true,
      "date_time_after": "2025-03-30 TIME 03",
      "date_time_before": "2025-03-30 TIME 02",
      "overlap": false
    },
    "dst_end": {
      "utc_time": "2025-10-26 TIME 01",
      "duration": "-1H",
      "gap": false,
      "date_time_after": "2025-10-26 TIME 02",
      "date_time_before": "2025-10-26 TIME 03",
      "overlap": true
    }
  }
}
```
### Get Timezone from Location Coordinates
```csharp
var api = _host.Services.GetRequiredService<ITimezoneApi>();

var response = await api.GetTimezoneInfoAsync(lat: 48.8566F, varLong: 2.3522F);

Console.WriteLine(JsonSerializer.Serialize(response.Ok(), new JsonSerializerOptions { WriteIndented = true }));
```
Sample Response:
```json
{
  "time_zone": {
    "name": "Europe/Paris",
    "offset": 1,
    "offset_with_dst": 2,
    "date": "2025-07-28T00:00:00+00:00",
    "date_time": "2025-07-28 12:11:05",
    "date_time_txt": "Monday, July 28, 2025 12:11:05",
    "date_time_wti": "Mon, 28 Jul 2025 12:11:05 \u002B0200",
    "date_time_ymd": "2025-07-28T10:11:05+00:00",
    "date_time_unix": 1753697465.681,
    "time_24": "12:11:05",
    "time_12": "12:11:05 PM",
    "week": 31,
    "month": 7,
    "year": 2025,
    "year_abbr": "25",
    "is_dst": true,
    "dst_savings": 1,
    "dst_exists": true,
    "dst_start": {
      "utc_time": "2025-03-30 TIME 01",
      "duration": "\u002B1H",
      "gap": true,
      "date_time_after": "2025-03-30 TIME 03",
      "date_time_before": "2025-03-30 TIME 02",
      "overlap": false
    },
    "dst_end": {
      "utc_time": "2025-10-26 TIME 01",
      "duration": "-1H",
      "gap": false,
      "date_time_after": "2025-10-26 TIME 02",
      "date_time_before": "2025-10-26 TIME 03",
      "overlap": true
    }
  }
}
```
### Get Timezone and Airport Details from IATA Code
```csharp
var api = _host.Services.GetRequiredService<ITimezoneApi>();

var response = await api.GetTimezoneInfoAsync(iataCode: "ZRH");

Console.WriteLine(JsonSerializer.Serialize(response.Ok(), new JsonSerializerOptions { WriteIndented = true }));
```
Sample Response:
```json
{
  "airport_details": {
    "type": "large_airport",
    "name": "Zurich Airport",
    "latitude": "47.45806",
    "longitude": "8.54806",
    "elevation_ft": 1417,
    "continent_code": "EU",
    "country_code": "CH",
    "state_code": "CH-ZH",
    "city": "Zurich",
    "iata_code": "ZRH",
    "icao_code": "LSZH",
    "faa_code": ""
  },
  "time_zone": {
    "name": "Europe/Zurich",
    "offset": 1,
    "offset_with_dst": 2,
    "date": "2025-07-28T00:00:00+00:00",
    "date_time": "2025-07-28 12:13:14",
    "date_time_txt": "Monday, July 28, 2025 12:13:14",
    "date_time_wti": "Mon, 28 Jul 2025 12:13:14 \u002B0200",
    "date_time_ymd": "2025-07-28T10:13:14+00:00",
    "date_time_unix": 1753697594.724,
    "time_24": "12:13:14",
    "time_12": "12:13:14 PM",
    "week": 31,
    "month": 7,
    "year": 2025,
    "year_abbr": "25",
    "is_dst": true,
    "dst_savings": 1,
    "dst_exists": true,
    "dst_start": {
      "utc_time": "2025-03-30 TIME 01",
      "duration": "\u002B1H",
      "gap": true,
      "date_time_after": "2025-03-30 TIME 03",
      "date_time_before": "2025-03-30 TIME 02",
      "overlap": false
    },
    "dst_end": {
      "utc_time": "2025-10-26 TIME 01",
      "duration": "-1H",
      "gap": false,
      "date_time_after": "2025-10-26 TIME 02",
      "date_time_before": "2025-10-26 TIME 03",
      "overlap": true
    }
  }
}
```
> [!TIP]
> Similarly, you can fetch Airport Details and Timezone using any ICAO code as well.

### Get Timezone and City Details from UN/LOCODE
```csharp
var response = await api.GetTimezoneInfoAsync(loCode: "ESBCN");

Console.WriteLine(JsonSerializer.Serialize(response.Ok(), new JsonSerializerOptions { WriteIndented = true }));
```
Sample Response:
```json
{
  "lo_code_details": {
    "lo_code": "ESBCN",
    "city": "Barcelona",
    "state_code": "",
    "country_code": "ES",
    "country_name": "",
    "location_type": "Port, Rail Terminal, Road Terminal, Airport, Postal Exchange",
    "latitude": "41.38289",
    "longitude": "2.17743"
  },
  "location": null,
  "time_zone": {
    "name": "Europe/Madrid",
    "offset": 1,
    "offset_with_dst": 2,
    "date": "2025-07-28T00:00:00+00:00",
    "date_time": "2025-07-28 12:17:35",
    "date_time_txt": "Monday, July 28, 2025 12:17:35",
    "date_time_wti": "Mon, 28 Jul 2025 12:17:35 \u002B0200",
    "date_time_ymd": "2025-07-28T10:17:35+00:00",
    "date_time_unix": 1753697855.438,
    "time_24": "12:17:35",
    "time_12": "12:17:35 PM",
    "week": 31,
    "month": 7,
    "year": 2025,
    "year_abbr": "25",
    "is_dst": true,
    "dst_savings": 1,
    "dst_exists": true,
    "dst_start": {
      "utc_time": "2025-03-30 TIME 01",
      "duration": "\u002B1H",
      "gap": true,
      "date_time_after": "2025-03-30 TIME 03",
      "date_time_before": "2025-03-30 TIME 02",
      "overlap": false
    },
    "dst_end": {
      "utc_time": "2025-10-26 TIME 01",
      "duration": "-1H",
      "gap": false,
      "date_time_after": "2025-10-26 TIME 02",
      "date_time_before": "2025-10-26 TIME 03",
      "overlap": true
    }
  }
}
```
## Timezone Converter API Examples
This section provides usage examples of the `ConvertTimeBetweenTimezonesAsync()` method from the SDK. The Timezone Converter API allows you to convert a specific time from one timezone to another using timezone identifiers, coordinates, or location codes.

For full API reference, see the [Timezone Converter API Documentation](https://ipgeolocation.io/timezone-api.html#convert-time-bw-time-zones).

### Convert Current Time from One Timezone to Another
```csharp
using System;
using System.Text.Json;
using IPGeolocation.Api;
using IPGeolocation.Model;

var api = _host.Services.GetRequiredService<ITimeConversionApi>();

var response = await api.ConvertTimeBetweenTimezonesAsync(
    tzFrom: "America/New_York",
    tzTo: "Asia/Tokyo"
);
Console.WriteLine(JsonSerializer.Serialize(response.Ok(), new JsonSerializerOptions { WriteIndented = true }));
```
Sample Response:
```json
{
  "original_time": "2025-07-28 06:37:29",
  "converted_time": "2025-07-28 19:37:29",
  "diff_hour": 13,
  "diff_min": 780
}
```
You can convert time from any timezone to another using:

 - Coordinate (latitude & longitude)
 - Locations (city or address)
 - IATA codes
 - ICAO codes
 - UN/LOCODE

Simply provide the appropriate source and target parameters in the method.

## User Agent API Examples
This section provides usage examples of the `GetUserAgentDetailsAsync()` and GetBulkUserAgentAsync methods from the .NET SDK. The User Agent API extracts and classifies information from user agent strings, including browser, engine, device, OS, and type metadata.

For complete details, see the User Agent API documentation.

### Parse a Basic User Agent String
```csharp
using System;
using System.Text.Json;
using IPGeolocation.Api;
using IPGeolocation.Model;

var api = _host.Services.GetRequiredService<IUserAgentApi>();

var response = await api.GetUserAgentDetailsAsync(
    userAgent: "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/125.0.0.0 Safari/537.36"
);

Console.WriteLine(JsonSerializer.Serialize(response.Ok(), new JsonSerializerOptions { WriteIndented = true }));
```
Sample Response:
```json
{
  "user_agent_string": "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/125.0.0.0 Safari/537.36",
  "name": "Chrome",
  "type": "Browser",
  "version": "125",
  "version_major": "125",
  "device": {
    "name": "Desktop",
    "type": "Desktop",
    "brand": "Unknown",
    "cpu": "Intel x86_64"
  },
  "engine": {
    "name": "Blink",
    "type": "Browser",
    "version": "125",
    "version_major": "125"
  },
  "operating_system": {
    "name": "Windows NT",
    "type": "Desktop",
    "version": "??",
    "version_major": "??",
    "build": "??"
  }
}
```

> [!NOTE]
> If you don't pass any userAgent, the API returns data based on the device's user agent.

### Bulk User Agent Parsing Example
The SDK also supports bulk parsing using the `ParseBulkUserAgentStringsAsync()` method. You can parse multiple user agent strings in a single request.
```csharp
var api = _host.Services.GetRequiredService<IUserAgentApi>();

BulkUserAgentRequest bulkUserAgentRequest = new()
{
  UaStrings = ["Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/125.0.0.0 Safari/537.36", "Mozilla/5.0 (iPhone; CPU iPhone OS 16_0 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/16.0 Mobile/15E148 Safari/604.1"]
};

var response = await api.ParseBulkUserAgentStringsAsync(bulkUserAgentRequest: bulkUserAgentRequest);

Console.WriteLine(JsonSerializer.Serialize(response.Ok(), new JsonSerializerOptions { WriteIndented = true }));
```

## Astronomy API Examples
This section provides usage examples of the `GetAstronomyDetailsAsync()` method from the SDK, allowing developers to fetch sun and moon timings and position data based on coordinates, IP, or location string.

Refer to the official [Astronomy API documentation](https://ipgeolocation.io/astronomy-api.html#documentation-overview) for more details.

### Lookup Astronomy Info by Coordinates
```csharp
using System;
using System.Text.Json;
using IPGeolocation.Api;
using IPGeolocation.Model;

var api = _host.Services.GetRequiredService<IAstronomyApi>();

var response = await api.GetAstronomyDetailsAsync(
    lat: "40.7128",
    varLong: "-74.0060"
);

Console.WriteLine(JsonSerializer.Serialize(response.Ok(), new JsonSerializerOptions { WriteIndented = true }));
```
Sample Response:
```json
{
  "location": {
    "country_name": "",
    "state_prov": "New York",
    "city": "New York",
    "locality": "",
    "latitude": "40.71280",
    "longitude": "-74.00600",
    "elevation": "6"
  },
  "astronomy": {
    "date": "2025-07-28",
    "current_time": "07:39:25.857",
    "mid_night": "01:02",
    "night_end": "03:56",
    "morning": {
      "astronomical_twilight_begin": "03:56",
      "astronomical_twilight_end": "04:39",
      "nautical_twilight_begin": "04:39",
      "nautical_twilight_end": "05:18",
      "civil_twilight_begin": "05:18",
      "civil_twilight_end": "05:48",
      "blue_hour_begin": "05:05",
      "blue_hour_end": "05:30",
      "golden_hour_begin": "05:30",
      "golden_hour_end": "06:28"
    },
    "sunrise": "05:48",
    "sunset": "20:15",
    "evening": {
      "golden_hour_begin": "19:36",
      "golden_hour_end": "20:34",
      "blue_hour_begin": "20:34",
      "blue_hour_end": "20:58",
      "civil_twilight_begin": "20:15",
      "civil_twilight_end": "20:46",
      "nautical_twilight_begin": "20:46",
      "nautical_twilight_end": "21:24",
      "astronomical_twilight_begin": "21:24",
      "astronomical_twilight_end": "22:07"
    },
    "night_begin": "22:07",
    "sun_status": "-",
    "solar_noon": "13:02",
    "day_length": "14:26",
    "sun_altitude": 19.00187046130002,
    "sun_distance": 151931858.71621194,
    "sun_azimuth": 81.1108254930794,
    "moon_phase": "WAXING_CRESCENT",
    "moonrise": "09:49",
    "moonset": "22:20",
    "moon_status": "-",
    "moon_altitude": -22.545016457413194,
    "moon_distance": 392992.5364140531,
    "moon_azimuth": 63.49091214788473,
    "moon_parallactic_angle": -42.81395612950803,
    "moon_illumination_percentage": "14.63",
    "moon_angle": 44.97239607122072
  }
}
```
### Lookup Astronomy API by IP Address
```csharp
var api = _host.Services.GetRequiredService<IAstronomyApi>();

var response = await api.GetAstronomyDetailsAsync(
    ip: "8.8.8.8"
);

Console.WriteLine(JsonSerializer.Serialize(response.Ok(), new JsonSerializerOptions { WriteIndented = true }));
```
Sample Response:
```json
{
  "ip": "8.8.8.8",
  "location": {
    "continent_code": "NA",
    "continent_name": "North America",
    "country_code2": "US",
    "country_code3": "USA",
    "country_name": "United States",
    "country_name_official": "United States of America",
    "is_eu": false,
    "state_prov": "California",
    "state_code": "US-CA",
    "district": "Santa Clara",
    "city": "Mountain View",
    "locality": "Charleston Terrace",
    "zipcode": "94043-1351",
    "latitude": "37.42240",
    "longitude": "-122.08421",
    "elevation": "3"
  },
  "astronomy": {
    "date": "2025-07-28",
    "current_time": "04:41:26.394",
    "mid_night": "01:15",
    "night_end": "04:26",
    "morning": {
      "astronomical_twilight_begin": "04:26",
      "astronomical_twilight_end": "05:04",
      "nautical_twilight_begin": "05:04",
      "nautical_twilight_end": "05:40",
      "civil_twilight_begin": "05:40",
      "civil_twilight_end": "06:09",
      "blue_hour_begin": "05:29",
      "blue_hour_end": "05:52",
      "golden_hour_begin": "05:52",
      "golden_hour_end": "06:46"
    },
    "sunrise": "06:09",
    "sunset": "20:19",
    "evening": {
      "golden_hour_begin": "19:42",
      "golden_hour_end": "20:37",
      "blue_hour_begin": "20:37",
      "blue_hour_end": "21:00",
      "civil_twilight_begin": "20:19",
      "civil_twilight_end": "20:48",
      "nautical_twilight_begin": "20:48",
      "nautical_twilight_end": "21:24",
      "astronomical_twilight_begin": "21:24",
      "astronomical_twilight_end": "22:03"
    },
    "night_begin": "22:03",
    "sun_status": "-",
    "solar_noon": "13:14",
    "day_length": "14:10",
    "sun_altitude": -15.671101747287796,
    "sun_distance": 151931858.71621194,
    "sun_azimuth": 50.4143830554159,
    "moon_phase": "WAXING_CRESCENT",
    "moonrise": "10:10",
    "moonset": "22:35",
    "moon_status": "-",
    "moon_altitude": -48.28723721558242,
    "moon_distance": 392998.88399571925,
    "moon_azimuth": 12.524793229334932,
    "moon_parallactic_angle": -9.936777293515336,
    "moon_illumination_percentage": "14.64",
    "moon_angle": 44.98851599731005
  }
}
```
### Lookup Astronomy API by Location String
```csharp
var api = _host.Services.GetRequiredService<IAstronomyApi>();

var response = await api.GetAstronomyDetailsAsync(
    location: "Milan, Italy"
);

Console.WriteLine(JsonSerializer.Serialize(response.Ok(), new JsonSerializerOptions { WriteIndented = true }));
```
Sample Response:
```json
{
  "location": {
    "location_string": "Milan, Italy",
    "country_name": "Italy",
    "state_prov": "Lombardy",
    "city": "Milan",
    "locality": "",
    "latitude": "45.46419",
    "longitude": "9.18963",
    "elevation": "122"
  },
  "astronomy": {
    "date": "2025-07-28",
    "current_time": "13:42:58.799",
    "mid_night": "01:30",
    "night_end": "03:51",
    "morning": {
      "astronomical_twilight_begin": "03:51",
      "astronomical_twilight_end": "04:44",
      "nautical_twilight_begin": "04:44",
      "nautical_twilight_end": "05:28",
      "civil_twilight_begin": "05:28",
      "civil_twilight_end": "06:00",
      "blue_hour_begin": "05:14",
      "blue_hour_end": "05:42",
      "golden_hour_begin": "05:42",
      "golden_hour_end": "06:45"
    },
    "sunrise": "06:00",
    "sunset": "20:58",
    "evening": {
      "golden_hour_begin": "20:13",
      "golden_hour_end": "21:17",
      "blue_hour_begin": "21:17",
      "blue_hour_end": "21:44",
      "civil_twilight_begin": "20:58",
      "civil_twilight_end": "21:30",
      "nautical_twilight_begin": "21:30",
      "nautical_twilight_end": "22:14",
      "astronomical_twilight_begin": "22:14",
      "astronomical_twilight_end": "23:06"
    },
    "night_begin": "23:06",
    "sun_status": "-",
    "solar_noon": "13:29",
    "day_length": "14:57",
    "sun_altitude": 63.24708973645173,
    "sun_distance": 151931858.71621192,
    "sun_azimuth": 186.94038709300645,
    "moon_phase": "WAXING_CRESCENT",
    "moonrise": "09:57",
    "moonset": "22:45",
    "moon_status": "-",
    "moon_altitude": 35.48879898890679,
    "moon_distance": 393003.74957552383,
    "moon_azimuth": 127.97070506514478,
    "moon_parallactic_angle": -33.63951797483762,
    "moon_illumination_percentage": "14.65",
    "moon_angle": 45.000873301539855
  }
}
```
### Lookup Astronomy API for Specific Date
```csharp
var api = _host.Services.GetRequiredService<IAstronomyApi>();

var response = await api.GetAstronomyDetailsAsync(
    lat: "-27.47",
    varLong: "153.02",
    date: "2025-01-01"
);
 
Console.WriteLine(JsonSerializer.Serialize(response.Ok(), new JsonSerializerOptions { WriteIndented = true }));
```
Sample Response:
```json
{
  "location": {
    "country_name": "Australia",
    "state_prov": "Queensland",
    "city": "Brisbane",
    "locality": "Brisbane",
    "latitude": "-27.47000",
    "longitude": "153.02000",
    "elevation": ""
  },
  "astronomy": {
    "date": "2025-01-01",
    "current_time": "21:46:06.454",
    "mid_night": "23:51",
    "night_end": "03:24",
    "morning": {
      "astronomical_twilight_begin": "03:24",
      "astronomical_twilight_end": "03:57",
      "nautical_twilight_begin": "03:57",
      "nautical_twilight_end": "04:29",
      "civil_twilight_begin": "04:29",
      "civil_twilight_end": "04:56",
      "blue_hour_begin": "04:19",
      "blue_hour_end": "04:40",
      "golden_hour_begin": "04:40",
      "golden_hour_end": "05:30"
    },
    "sunrise": "04:56",
    "sunset": "18:46",
    "evening": {
      "golden_hour_begin": "18:12",
      "golden_hour_end": "19:02",
      "blue_hour_begin": "19:02",
      "blue_hour_end": "19:23",
      "civil_twilight_begin": "18:46",
      "civil_twilight_end": "19:13",
      "nautical_twilight_begin": "19:13",
      "nautical_twilight_end": "19:45",
      "astronomical_twilight_begin": "19:45",
      "astronomical_twilight_end": "20:18"
    },
    "night_begin": "20:18",
    "sun_status": "-",
    "solar_noon": "11:51",
    "day_length": "13:50",
    "sun_altitude": -31.17124718523727,
    "sun_distance": 147102938.88036567,
    "sun_azimuth": 214.0841443735061,
    "moon_phase": "NEW_MOON",
    "moonrise": "05:42",
    "moonset": "20:08",
    "moon_status": "-",
    "moon_altitude": -17.39121672394405,
    "moon_distance": 380326.07103959366,
    "moon_azimuth": 229.56204420965753,
    "moon_parallactic_angle": 132.1947921694531,
    "moon_illumination_percentage": "2.78",
    "moon_angle": 19.20715172104959
  }
}
```
### Lookup Location Info in Different Language
You can also get Astronomy data in other languages as well. Only paid subscriptions can access this feature.
```csharp
var api = _host.Services.GetRequiredService<IAstronomyApi>();

var response = await api.GetAstronomyDetailsAsync(
    ip: "1.1.1.1",
    lang: "fr"
);

Console.WriteLine(JsonSerializer.Serialize(response.Ok(), new JsonSerializerOptions { WriteIndented = true }));
```
Sample Response:
```json
{
  "ip": "1.1.1.1",
  "location": {
    "location_string": null,
    "continent_code": "OC",
    "continent_name": "Oc\u00E9anie",
    "country_code2": "AU",
    "country_code3": "AUS",
    "country_name": "Australie",
    "country_name_official": "",
    "is_eu": false,
    "state_prov": "Queensland",
    "state_code": "AU-QLD",
    "district": "Brisbane",
    "city": "Brisbane Sud",
    "locality": "",
    "zipcode": "4101",
    "latitude": "-27.47306",
    "longitude": "153.01421",
    "elevation": ""
  },
  "astronomy": {
    "date": "2025-07-28",
    "current_time": "21:49:02.623",
    "mid_night": "23:54",
    "...": "",
    "moon_angle": 45.04952396653247
  }
}
```

## Models
- [ASNConnection](https://github.com/IPGeolocation/ip-geolocation-api-dotnet-sdk/blob/HEAD/docs/models/ASNConnection.md)
- [ASNResponse](https://github.com/IPGeolocation/ip-geolocation-api-dotnet-sdk/blob/HEAD/docs/models/ASNResponse.md)
- [ASNResponseAsn](https://github.com/IPGeolocation/ip-geolocation-api-dotnet-sdk/blob/HEAD/docs/models/ASNResponseAsn.md)
- [Abuse](https://github.com/IPGeolocation/ip-geolocation-api-dotnet-sdk/blob/HEAD/docs/models/Abuse.md)
- [AbuseResponse](https://github.com/IPGeolocation/ip-geolocation-api-dotnet-sdk/blob/HEAD/docs/models/AbuseResponse.md)
- [AstronomyEvening](https://github.com/IPGeolocation/ip-geolocation-api-dotnet-sdk/blob/HEAD/docs/models/AstronomyEvening.md)
- [AstronomyLocation](https://github.com/IPGeolocation/ip-geolocation-api-dotnet-sdk/blob/HEAD/docs/models/AstronomyLocation.md)
- [AstronomyMorning](https://github.com/IPGeolocation/ip-geolocation-api-dotnet-sdk/blob/HEAD/docs/models/AstronomyMorning.md)
- [Astronomy](https://github.com/IPGeolocation/ip-geolocation-api-dotnet-sdk/blob/HEAD/docs/models/Astronomy.md)
- [AstronomyResponse](https://github.com/IPGeolocation/ip-geolocation-api-dotnet-sdk/blob/HEAD/docs/models/AstronomyResponse.md)
- [CountryMetadata](https://github.com/IPGeolocation/ip-geolocation-api-dotnet-sdk/blob/HEAD/docs/models/CountryMetadata.md)
- [Currency](https://github.com/IPGeolocation/ip-geolocation-api-dotnet-sdk/blob/HEAD/docs/models/Currency.md)
- [ErrorResponse](https://github.com/IPGeolocation/ip-geolocation-api-dotnet-sdk/blob/HEAD/docs/models/ErrorResponse.md)
- [GeolocationResponse](https://github.com/IPGeolocation/ip-geolocation-api-dotnet-sdk/blob/HEAD/docs/models/GeolocationResponse.md)
- [BulkIPGeolocationResponse](https://github.com/IPGeolocation/ip-geolocation-api-dotnet-sdk/blob/HEAD/docs/models/BulkGeolocationResponse.md)
- [BulkIPGeolocationResponse1](https://github.com/IPGeolocation/ip-geolocation-api-dotnet-sdk/blob/HEAD/docs/models/BulkGeolocationResponse1.md)
- [BulkIPRequest](https://github.com/IPGeolocation/ip-geolocation-api-dotnet-sdk/blob/HEAD/docs/models/BulkIPRequest.md)
- [BulkIPSecurityResponse](https://github.com/IPGeolocation/ip-geolocation-api-dotnet-sdk/blob/HEAD/docs/models/BulkIPSecurityResponse.md)
- [BulkIPSecurityResponse1](https://github.com/IPGeolocation/ip-geolocation-api-dotnet-sdk/blob/HEAD/docs/models/BulkIPSecurityResponse1.md)
- [Location](https://github.com/IPGeolocation/ip-geolocation-api-dotnet-sdk/blob/HEAD/docs/models/Location.md)
- [LocationMinimal](https://github.com/IPGeolocation/ip-geolocation-api-dotnet-sdk/blob/HEAD/docs/models/LocationMinimal.md)
- [Network](https://github.com/IPGeolocation/ip-geolocation-api-dotnet-sdk/blob/HEAD/docs/models/Network.md)
- [NetworkAsn](https://github.com/IPGeolocation/ip-geolocation-api-dotnet-sdk/blob/HEAD/docs/models/NetworkAsn.md)
- [NetworkCompany](https://github.com/IPGeolocation/ip-geolocation-api-dotnet-sdk/blob/HEAD/docs/models/NetworkCompany.md)
- [NetworkMinimal](https://github.com/IPGeolocation/ip-geolocation-api-dotnet-sdk/blob/HEAD/docs/models/NetworkMinimal.md)
- [NetworkMinimalAsn](https://github.com/IPGeolocation/ip-geolocation-api-dotnet-sdk/blob/HEAD/docs/models/NetworkMinimalAsn.md)
- [NetworkMinimalCompany](https://github.com/IPGeolocation/ip-geolocation-api-dotnet-sdk/blob/HEAD/docs/models/NetworkMinimalCompany.md)
- [BulkUserAgentRequest](https://github.com/IPGeolocation/ip-geolocation-api-dotnet-sdk/blob/HEAD/docs/models/BulkUserAgentRequest.md)
- [UserAgentRequest](https://github.com/IPGeolocation/ip-geolocation-api-dotnet-sdk/blob/HEAD/docs/models/UserAgentRequest.md)
- [Security](https://github.com/IPGeolocation/ip-geolocation-api-dotnet-sdk/blob/HEAD/docs/models/Security.md)
- [SecurityAPIResponse](https://github.com/IPGeolocation/ip-geolocation-api-dotnet-sdk/blob/HEAD/docs/models/SecurityAPIResponse.md)
- [TimeConversionResponse](https://github.com/IPGeolocation/ip-geolocation-api-dotnet-sdk/blob/HEAD/docs/models/TimeConversionResponse.md)
- [TimeZoneDetailedResponse](https://github.com/IPGeolocation/ip-geolocation-api-dotnet-sdk/blob/HEAD/docs/models/TimeZoneDetailedResponse.md)
- [TimeZoneDstEnd](https://github.com/IPGeolocation/ip-geolocation-api-dotnet-sdk/blob/HEAD/docs/models/TimeZoneDstEnd.md)
- [TimeZoneDstStart](https://github.com/IPGeolocation/ip-geolocation-api-dotnet-sdk/blob/HEAD/docs/models/TimeZoneDstStart.md)
- [TimezoneAirport](https://github.com/IPGeolocation/ip-geolocation-api-dotnet-sdk/blob/HEAD/docs/models/TimezoneAirport.md)
- [TimezoneDetail](https://github.com/IPGeolocation/ip-geolocation-api-dotnet-sdk/blob/HEAD/docs/models/TimezoneDetail.md)
- [TimezoneDetailDstEnd](https://github.com/IPGeolocation/ip-geolocation-api-dotnet-sdk/blob/HEAD/docs/models/TimezoneDetailDstEnd.md)
- [TimezoneDetailDstStart](https://github.com/IPGeolocation/ip-geolocation-api-dotnet-sdk/blob/HEAD/docs/models/TimezoneDetailDstStart.md)
- [TimezoneLocation](https://github.com/IPGeolocation/ip-geolocation-api-dotnet-sdk/blob/HEAD/docs/models/TimezoneLocation.md)
- [TimezoneLocode](https://github.com/IPGeolocation/ip-geolocation-api-dotnet-sdk/blob/HEAD/docs/models/TimezoneLocode.md)
- [UserAgentData](https://github.com/IPGeolocation/ip-geolocation-api-dotnet-sdk/blob/HEAD/docs/models/UserAgentData.md)
- [UserAgentDataDevice](https://github.com/IPGeolocation/ip-geolocation-api-dotnet-sdk/blob/HEAD/docs/models/UserAgentDataDevice.md)
- [UserAgentDataEngine](https://github.com/IPGeolocation/ip-geolocation-api-dotnet-sdk/blob/HEAD/docs/models/UserAgentDataEngine.md)
- [UserAgentDataOperatingSystem](https://github.com/IPGeolocation/ip-geolocation-api-dotnet-sdk/blob/HEAD/docs/models/UserAgentDataOperatingSystem.md)
