# IP Geolocation API .NET SDK

## Introduction
[IPGeolocation API](https://ipgeolocation.io) is the solution to identify country code (ISO2 and ISO3 standard), country name, continent code, continent name, country capital, state/province, district, city, zip code, latitude and longitude of city, is country belongs to Europian Union, calling code, top level domain (TLD), languages, country flag, internet service provider (ISP), connection type, organization, geoname ID, currency code, currency name, time zone ID, time zone offset, current time in the time zone, is time zone in daylight saving time, total daylight savings and user agent details. This document provides important information to help you get up to speed with IPGeolocation API using IP Geolocation API C# SDK.

Developers can use this C# SDK for software and web projects related to, but not limited to:

1. Display native language and currency
2. Redirect based on the country
3. Digital rights management
4. Web log stats and analysis
5. Auto-selection of country, state/province and city on forms
6. Filter access from countries you do not do business with
7. Geo-targeting for increased sales and click-through

## Quick Start Guide

You need a valid 'IPGeolocation API key' to use this SDK. [Sign up](https://ipgeolocation.io/signup) here and get your free API key if you don't have one.

**Note:** Complete documentation to use this SDK is also available at [IP Geolocation API .NET SDK Documentation](https://ipgeolocation.io/documentation/ip-geolocation-api-c-sharp-dot-net-sdk-201809031216).

## System Requirements

IP Geolocation API C# SDK has been developed and tested on .NET Core on Ubuntu.  
Note: Internet connection is required to run this component.

## Installation
### Package Manager
```cli
$ Install-Package IpGeoLocation.IpGeoLocation -Version 1.1.0
```

### .NET CLI
```cli
$ dotnet add package IpGeoLocation.IpGeoLocation --version 1.1.0
```

### Paket CLI
```cli
$ paket add IpGeoLocation.IpGeoLocation --version 1.1.0
```

## Documentation
Use the following URL to visit documentation
[https://ipgeolocation.io/documentation.html](https://ipgeolocation.io/documentation.html)

## Basic Usage
### Setup API
```c#
// Create IPGeolocationAPI object, passing your valid API key
IPGeolocationAPI api = new IPGeolocationAPI("YOUR_API_KEY");
```

### Geolocation Lookup
```c#
// Get geolocation for IP address (1.1.1.1) and fields (geo, time_zone and currency)
GeolocationParams geoParams = new GeolocationParams();
geoParams.SetIPAddress("1.1.1.1");
geoParams.SetFields("geo,time_zone,currency");
geoParams.SetIncludeSecurity(true);

Dictionary<String, Object> response = api.GetGeolocation(geoParams);

// Check if geolocation lookup was successful
if(response["status"] == 200)
{
    Geolocation geolocation = (Geolocation) response["response"];
    Console.WriteLine(geolocation.GetCountryName());
    Console.WriteLine(geolocation.GetCurrency().GetName());
    Console.WriteLine(geolocation.GetTimezone().GetCurrentTime());

    Console.WriteLine(geolocation.GetTimezone().GetCurrentTime());
    Console.WriteLine(geolocation.GetGeolocationSecurity().GetTor());
    Console.WriteLine(geolocation.GetGeolocationSecurity().GetProxy());
    Console.WriteLine(geolocation.GetGeolocationSecurity().GetProxyType());
    Console.WriteLine(geolocation.GetGeolocationSecurity().GetAnonymous());
    Console.WriteLine(geolocation.GetGeolocationSecurity().GetThreatScore());
    Console.WriteLine(geolocation.GetGeolocationSecurity().GetCloudProvider());
    Console.WriteLine(geolocation.GetUserAgent().GetUserAgentDevice().GetName());
}
else
{
    Console.WriteLine(response["message"]);
}

// Get geolocation in Russian** for IP address (1.1.1.1) and all fields
GeolocationParams geoParams = new GeolocationParams();
geoParams.SetIPAddress("1.1.1.1");
geoParams.SetLang("ru");

Dictionary<String, Object> response = api.GetGeolocation(geoParams);

// Check if geolocation lookup was successful
if(response["status"] == 200)
{
    Geolocation geolocation = (Geolocation) response["response"];
    Console.WriteLine(geolocation.GetIPAddress());
    Console.WriteLine(geolocation.GetCountryName());
}
else
{
    Console.WriteLine(response["message"]);
}

// Query geolocation for the calling machine's IP address for all fields
Dictionary<String, Object> response = api.GetGeolocation();

if(response["status"] == 200)
{
    Geolocation geolocation = (Geolocation) response["response"];
    Console.WriteLine(geolocation.GetCountryCode2());
    Console.WriteLine(geolocation.GetTimezone().GetCurrentTime());
}
else
{
    Console.WriteLine(response["message"]);
}
```

### Bulk Geolocations Lookup
```c#
// Query geolocation in German** for multiple IP addresses and all fields
String[] ips = new String[]{"1.1.1.1", "2.2.2.2", "3.3.3.3"};
GeolocationParams geoParams = new GeolocationParams();
geoParams.SetIPAddresses(ips);
geoParams.SetLang("de");

Dictionary<String, Object> response = api.GetBulkGeolocation(geoParams);

if(response["status"] == 200)
{

List<Geolocation> geolocations = (List<Geolocation>) response["response"];
Console.WriteLine(geolocations.Count);
Console.WriteLine(geolocations[0].GetCountryName());
Console.WriteLine(geolocations[1].GetLanguages());
Console.WriteLine(geolocations[2].GetTimezone().GetCurrentTime());
}
else
{
    Console.WriteLine(response["message"]);
}

// Query geolocations for multiple IP addresses but only geo field
String[] ips = new String[]{"1.1.1.1", "2.2.2.2", "3.3.3.3"};
GeolocationParams geoParams = new GeolocationParams();
geoParams.SetIPAddresses(ips);
geoParams.SetFields("geo");

Dictionary<String, Object> response = api.GetBulkGeolocation(geoParams);

if(response["status"] == 200)
{
    List<Geolocation> geolocations = (List<Geolocation>) response["response"];
    Console.WriteLine(geolocations.Count);
    Console.WriteLine(geolocations[0].GetCountryCode2());
    Console.WriteLine(geolocations[0].GetCountryName());
    Console.WriteLine(geolocations[0].GetLatitude());
}
else
{
    Console.WriteLine(response["message"]);
}
```

### Timezone API
```c#
// Query time zone information by time zone ID
TimezoneParams tzParams = new TimezoneParams();
tzParams.SetTimezone("America/New_York");

Dictionary<String, Object> response = api.GetTimezone(tzParams);

if(response["status"] == 200)
{
    Timezone tz = (Timezone) response["response"];
    Console.WriteLine(tz.GetDateTimeWti());
    Console.WriteLine(tz.GetDateTimeTxt());
}
else
{
    Console.WriteLine(response["message"]);
}

// Query time zone information by latitude and longitude of the location
TimezoneParams tzParams = new TimezoneParams();
tzParams.SetCoordinates(37.1838139, -123.8105225);

Dictionary<String, Object> response = api.GetTimezone(tzParams);

if(response["status"] == 200)
{
    Timezone tz = (Timezone) response["response"];
    Console.WriteLine(tz.GetTimezone());
}
else
{
    Console.WriteLine(response["message"]);
}

// Get time zone information for IP address (1.1.1.1) and geolocation information Japanese**
TimezoneParams tzParams = new TimezoneParams();
tzParams.SetIPAddress("1.1.1.1");
tzParams.SetLang("ja");

Dictionary<String, Object> response = api.GetTimezone(tzParams);

if(response["status"] == 200)
{
    Timezone tz = (Timezone) response["response"];
    Console.WriteLine(tz.GetTimezone());
}
else
{
    Console.WriteLine(response["message"]);
}

// Query time zone information for calling machine’s IP address
Dictionary<String, Object> response = api.GetTimezone();

if(response["status"] == 200)
{
    Timezone tz = (Timezone) response["response"];
    Console.WriteLine(tz.GetTimezone());
    Console.WriteLine(tz.GetDateTimeYmd());
}
else
{
    Console.WriteLine(response["message"]);
}
```

** IPGeolocation provides geolocation information in the following languages:
* English (en)
* German (de)
* Russian (ru)
* Japanese (ja)
* French (fr)
* Chinese Simplified (cn)
* Spanish (es)
* Czech (cs)
* Italian (it)

By default, geolocation information is returned in English. Response in a language other than English is available to paid users only.

## IP Geolocation API C# SDK Objects Reference

IP Geolocation API C# SDK has following classes that you can use to fully leverage it.

### Class: IPGeolocation.IPGeolocationAPI

| Method | Description | Return Type |
| ------ | ----------- | ----------- |
| IPGeolocationAPI(String apiKey)                         | Constructs the IPGeolocationAPI object and takes a valid apiKey as parameter. It throws ArgumentException for empty/null apiKey. ||
| GetApiKey()                                             | This function to get the API key that you set to query the IPGeolocation API.         | String                        |
| GetGeolocation()                                        | This function to query Geolocation API.                                               | Dictionary\<String, Object\>  |
| GetGeolocation(GeolocationParams geolocationParams)     | This function to query Geolocation API based on the parameters passed.                | Dictionary\<String, Object\>  |
| GetBulkGeolocation(GeolocationParams geolocationParams) | This function to query Geolocation API to lookup multiple IP addresses (max. 50).     | Dictionary\<String, Object\>  |
| GetTimezone()                                           | This function to query Timezone API based on calling machine's IP address.            | Dictionary\<String, Object\>  |
| GetTimezone(TimezoneParams timezoneParams)              | This function to query Timezone API based on the parameters passed.                   | Dictionary\<String, Object\>  |
| GetUserAgent(String uaString)                           | This function to query UserAgent API.                                                 | Dictionary\<String, Object\>  |
| GetBulkUserAgent(List<String> uaStrings)                | This function to query UserAgent API to lookup multiple user-agent strings (max. 50). | Dictionary\<String, Object\>  |

### Class: IPGeolocation.GeolocationParams

| Method | Description | Return Type |
| ------ | ----------- | ----------- |
| SetIPAddress(String ipAddress)                               | Sets IP address to lookup geolocation.                       | void     |
| GetDomain()                                                  | Get domain name when domain name is passed.                  | String   |
| GetHostname()                                                | Get hostname for the IP address.                             | String   |
| GetIPAddress()                                               | Get IP address set to lookup geolocation.                    | String   |
| SetIPAddresses(String[] ipAddresses) | Set IP addresses to lookup multiple geo-locations. Throws IllegalArgumentException if no. of IP addresses are more than 50. **Note:** Multiple IP addresses lookup is only available for paid users.                                                                         | void     |
| GetIPAddresses()                                             | Get IP addresses set to lookup bulk geolocations.                               | String[] |
| SetLang(String lang)                                         | Set language parameter to lookup geolocation.                                   | void     |
| GetLang()                                                    | Get language set to lookup geolocation.                                         | String   |
| SetFields(String fields)                                     | Set fields to lookup geolocation.                                               | void     |
| GetFields()                                                  | Get fields set to lookup geolocation.                                           | String   |
| SetIncludeHostname(Boolean includeHostname)                  | This URL parameter enables the IPGeolocation API to lookup hostname from our IP-Hostname database and returns the same IP address if there is no hostname found for the queried IP address. Lookup thru IP-Hostname database is faster than other options but is experimental and under process and can produce unwanted output.                            | void     |
| IsIncludeHostname()                                          | Returns Boolean object whether hostname is included in response or not.         | Boolean  |
| SetIncludeHostname(Boolean includeHostnameFallbackLive)      | This URL parameter enables the IPGeolocation API to lookup hostname from our IP-Hostname database and if there is no hostname found for the queried IP address, then lookup thru the live sources. This option has been introduced for faster and accurate lookup.                            | void     |
| IsIncludeHostnameFallbackLive()                              | Returns Boolean object whether hostname with fall-back-live is included in response or not.  | Boolean  |
| SetIncludeLiveHostname(Boolean includeLiveHostname)          | This URL parameter enables the IPGeolocation API to lookup hostname from live sources. Lookup thru live sources is accurate but can introduce more latency to your query to IPGeolocation API.                            | void     |
| IsIncludeLiveHostname()                                      | Returns Boolean object whether live hostname is included in response or not.    | Boolean  |
| SetIncludeSecurity(Boolean includeSecurity)                  | Set includeSecurity to true to get Security object as well.                     | void     |
| IsIncludeSecurity()                                          | Returns Boolean object whether Security object is included in response or not.  | Boolean  |
| SetIncludeUserAgentDetail(Boolean includeUserAgentDetail)    | Set includeUserAgentDetail to true to get UserAgent object as well.             | void     |
| IsIncludeUserAgentDetail()                                   | Returns Boolean object whether UserAgent object is included in response or not. | Boolean  |
| SetExcludes(String excludes)                                 | Set fields (as a comma separated value) to exclude from response.               | void     |
| GetExcludes()                                                | Get fields (as a comma separated value) that have been excluded from response.  | String   |

### Class: IPGeolocation.Geolocation

| Method | Description | Return Type |
| ------ | ----------- | ----------- |
| GetDomain()              | Returns the domain name when domain is searched.                                  | String              |
| GetHostname()            | Returns hostname of the ip address.                                               | String              |
| GetIPAddress()           | Returns IP address of the geolocation.                                            | String              |
| GetContinentCode()       | Returns 2-letters continent code.                                                 | String              |
| GetContinentName()       | Returns continent name.                                                           | String              |
| GetCountryCode2()        | Returns 2-letters country code.                                                   | String              |
| GetCountryCode3()        | Returns 3-letters country code.                                                   | String              |
| GetCountryName()         | Returns country name.                                                             | String              |
| GetCountryCapital()      | Returns country capital.                                                          | String              |
| GetStateProvince()       | Returns state/province.                                                           | String              |
| GetDistrict()            | Returns district.                                                                 | String              |
| GetCity()                | Returns city.                                                                     | String              |
| GetZipCode()             | Returns zip code.                                                                 | String              |
| GetLatitude()            | Returns latitude of the city.                                                     | Double              |
| GetLongitude()           | Returns longitude of the city.                                                    | Double              |
| IsEU()                   | Returns is the country in European Union.                                         | Boolean             |
| GetCallingCode()         | Returns country calling code.                                                     | String              |
| GetCountryTLD()          | Returns country's top level domain like '.au' for Australia.                      | String              |
| GetLanguages()           | Returns languages spoken in the country.                                          | String              |
| GetCountryFlag()         | Returns a URL to country's flag.                                                  | String              |
| GetISP()                 | Returns ISP name.                                                                 | String              |
| GetConnectionType()      | Returns connection type of the IP address.                                        | String              |
| GetOrganization()        | Returns organization of the IP address.                                           | String              |
| GetAsn()                 | Returns AS number of the IP address.                                              | String              |
| GetGeonameID()           | Returns geoname ID from geonames.org database.                                    | String              |
| GetCurrency()            | Returns currency information of the country.                                      | GeolocationCurrency |
| GetTimezone()            | Returns time zone information of the country.                                     | GeolocationTimezone |
| GetGeolocationSecurity() | Returns security details of the ip address.                                       | GeolocationSecurity |
| GetUserAgent()           | Returns user agent object to get user agent details.                              | UserAgent           |

### Class: IPGeolocation.GeolocationCurrency

| Method | Description | Return Type |
| ------ | ----------- | ----------- |
| GetCode()   | Returns 3-letters currency code. | String |
| GetName()   | Returns currency name.           | String |
| GetSymbol() | Returns currency symbol.         | String |


### Class: io.ipgeolocation.api.GeolocationSecurity

| Method | Description | Return Type |
| ------ | ----------- | ----------- |
| GetThreatScore()  | Returns threat score for the ip address                          | Integer  |
| IsTor()           | Returns Boolean object whether the ip is using tor or not.       | Boolean  |
| IsProxy()         | Returns Boolean object whether the ip is using proxy or not.     | Boolean  |
| GetProxyType()    | Returns the type of proxy used by ip address                     | String   |
| IsAnonymous()     | Returns Boolean object whether the ip is anonymous or not.       | Boolean  |
| IsKnownAttacker() | Returns Boolean object whether the ip is known attacker or not.  | Boolean  |
| IsBot()           | Returns Boolean object whether the ip is bot or not.             | Boolean  |
| IsSpam()          | Returns Boolean object whether the ip is spam or not.            | Boolean  |
| IsCloudProvider() | Returns Boolean object whether the ip is cloud provider or not.  | Boolean  |

### Class: IPGeolocation.GeolocationTimezone

| Method | Description | Return Type |
| ------ | ----------- | ----------- |
| GetName()            | Returns standard time zone ID like "America/New_York".                    | String  |
| GetOffset()          | Returns time zone offset from UTC.                                        | Double  |
| GetCurrentTime()     | Returns current date-time string in the format "yyyy-MM-dd HH:mm:ss.SSSZ" | String  |
| GetCurrentTimeUnix() | Returns current date-time as a unix time                                  | Double  |
| IsDST()              | Returns is the country observing daylight saving time.                    | Boolean |
| GetDSTSavings()      | Returns daylight savings time (in hours).                                 | Double  |

### Class: IPGeolocation.TimezoneParams

| Method | Description | Return Type |
| ------ | ----------- | ----------- |
| SetTimezone(String timezone)                      | Sets time zone ID to query time zone information.                         | void   |
| GetTimezone()                                     | Get time zone ID set to query time zone information.                      | String |
| SetIPAddress(String ip)                           | Sets IP address to query time zone information.                           | void   |
| GetIPAddress()                                    | Get IP address set to query time zone information.                        | String |
| SetCoordinates(Double latitude, Double longitude) | Sets latitude and longitude of a location to query time zone information. | void   |
| GetLatitude()                                     | Returns latitude set to query time zone information.                      | Double |
| GetLongitude()                                    | Returns longitude set to query time zone information.                     | Double |
| SetLocation(String location)                      | Set location parameter to get timezone details.                           | void   |
| GetLocation()                                     | Get location parameter value to get timezone details.                     | String |
| SetLang(String lang)                              | Set language parameter to lookup geolocation. Default is 'en'.            | void   |
| GetLang()                                         | Get language set to lookup geolocation.                                   | String |

### Class: IPGeolocation.Timezone

| Method | Description | Return Type |
| ------ | ----------- | ----------- |
| GetTimezone()              | Returns time zone ID like "America/New_York".                                          | String      |
| GetTimezoneOffset()        | Returns time zone offset from UTC.                                                     | Double      |
| GetTimezoneOffsetWithDST() | Returns time zone offset with dst value from UTC.                                      | Double      |
| GetDate()                  | Returns current date in the format "yyyy-MM-dd".                                       | String      |
| GetDateTime()              | Returns date-time string in the format "yyyy-MM-dd HH:mm:ss".                          | String      |
| GetDateTimeTxt()           | Returns date-time string in the format "EEEE, MMMM dd, yyyy HH:mm:ss".                 | String      |
| GetDateTimeWti()           | Returns date-time string in the format "EEE, dd MMM yyyy HH:mm:ss Z".                  | String      |
| GetDateTimeYmd()           | Returns date-time string in the format "yyyy-MM-dd'T'HH:mm:ssZ".                       | String      |
| GetDateTimeUnix()          | Returns current date-time as unix time.                                                | Integer     |
| GetTime24()                | Returns current time in the format "HH:mm:ss".                                         | String      |
| GetTime12()                | Returns current time in the format "hh:mm:ss aa".                                      | String      |
| GetWeek()                  | Returns current week of the year.                                                      | Integer     |
| GetMonth()                 | Returns current month of the year.                                                     | Integer     |
| GetYear()                  | Returns current year.                                                                  | Integer     |
| GetYearAbbr()              | Returns 2-letters year abbreviation like "18".                                         | String      |
| IsDST()                    | Returns is the country observing Daylight Saving time.                                 | Boolean     |
| GetDSTSavings()            | Returns daylight savings time (in hours).                                              | Double      |
| GetTimezoneGeo()           | Returns geolocation of timezone if you lookup timezone information from an IP address. | TimezoneGeo |

### Class: IPGeolocation.TimezoneGeo

| Method | Description | Return Type |
| ------ | ----------- | ----------- |
| GetCountryCode2()  | Returns 2-letters country code. | String |
| GetCountryCode3()  | Returns 3-letters country code. | String |
| GetCountryName()   | Returns country name.           | String |
| GetStateProvince() | Returns state/province.         | String |
| GetDistrict()      | Returns district.               | String |
| GetCity()          | Returns city.                   | String |
| GetZipCode()       | Returns zip code.               | String |
| GetLatitude()      | Returns latitude of the city.   | Double |
| GetLongitude()     | Returns longitude of the city.  | Double |

### Class: IPGeolocation.UserAgent

| Method | Description | Return Type |
| ------ | ----------- | ----------- |
| GetUserAgentString() | Returns user-agent string.                     | String                   |
| GetName()            | Returns name of the user agent.                | String                   |
| GetType()            | Returns type of the user agent.                | String                   |
| GetVersion()         | Returns version of the user agent.             | String                   |
| GetVersionMajor()    | Returns version major of the user agent.       | String                   |
| GetDevice()          | Returns user-agent's device details.           | UserAgentDevice          |
| GetEngine()          | Returns user-agent's engine details.           | UserAgentEngine          |
| GetOperatingSystem() | Returns user-agent's operating system details. | UserAgentOperatingSystem |

### Class: IPGeolocation.UserAgentDevice

| Method | Description | Return Type |
| ------ | ----------- | ----------- |
| GetName()  | Returns user-agent's device name. | String |
| GetType()  | Returns user-agent's type name.   | String |
| GetBrand() | Returns user-agent's brand name.  | String |
| GetCpu()   | Returns user-agent's CPU name.    | String |

### Class: IPGeolocation.UserAgentEngine

| Method | Description | Return Type |
| ------ | ----------- | ----------- |
| GetName()         | Returns user-agent's engine name.          | String |
| GetType()         | Returns user-agent's engine type.          | String |
| GetVersion()      | Returns user-agent's engine version.       | String |
| GetVersionMajor() | Returns user-agent's engine version major. | String |

### Class: IPGeolocation.UserAgentOperatingSystem

| Method | Description | Return Type |
| ------ | ----------- | ----------- |
| GetName()         | Returns user-agent's operating system name.           | String |
| GetType()         | Returns user-agent's operating system type.           | String |
| GetVersion()      | Returns user-agent's operating system version.        | String |
| GetVersionMajor() | Returns user-agent's operating system version major.  | String |

