# IP Geolocation API .NET SDK

## Introduction
IPGeolocation API is the solution to identify country code (ISO2 and ISO3 standard), country name, continent code, continent name, country capital, state/province, district, city, zip code, latitude and longitude of city, is country belongs to Europian Union, calling code, top level domain (TLD), languages, country flag, internet service provider (ISP), connection type, organization, geoname ID, currency code, currency name, time zone ID, time zone offset, current time in the time zone, is time zone in daylight saving time, and total daylight savings. This document provides important information to help you get up to speed with IPGeolocation API using IP Geolocation API C# SDK.

Developers can use this C# SDK for software and web projects related to, but not limited to:

* Display native language and currency
* Redirect based on the country
* Digital rights management
* Web log stats and analysis
* Auto-selection of country, state/province and city on forms
* Filter access from countries you do not do business with
* Geo-targeting for increased sales and click-through

## System Requirements
IP Geolocation API C# SDK has been developed and tested on .NET Core on Ubuntu.
Note: Internet connection is required to run this component.

## Quick Start Guide
In this document, you will go through the basic steps to use IP Geolocation API C# SDK.
Note: This SDK requires a valid IPGeolocation API key. Sign up if you don’t have one.

## Installation
### Package Manager
```cli
$ Install-Package IpGeoLocation.IpGeoLocation -Version 1.0.2
```

### .NET CLI
```cli
$ dotnet add package IpGeoLocation.IpGeoLocation --version 1.0.2
```

### Paket CLI
```cli
$ paket add IpGeoLocation.IpGeoLocation --version 1.0.2
```

## IP Geolocation API C# SDK Basic Usage
### Setup API
```c#
// Create IPGeolocationAPI object, passing your valid API key
IPGeolocationAPI api = new IPGeolocationAPI("YOUR_API_KEY");
```

### Geolocation Lookup
```c#
// Query geolocation for IP address (1.1.1.1) and fields (geo, time_zone and currency)
GeolocationParams geoParams = new GeolocationParams();
geoParams.SetIp("1.1.1.1");
geoParams.SetFields("geo,time_zone,currency");

Geolocation geolocation = api.GetGeolocation(geoParams);

// Check if geolocation lookup was successful
if(geolocation.GetStatus() == 200)
{
    Console.WriteLine(geolocation.GetCountryName());
    Console.WriteLine(geolocation.GetCurrency().GetName());
    Console.WriteLine(geolocation.GetTimezone().GetCurrentTime());
}
else
{
    Console.WriteLine(geolocation.GetMessage());
}

// Query geolocation for IP address (1.1.1.1) and all fields
GeolocationParams geoParams = new GeolocationParams();
geoParams.SetIp("1.1.1.1");

Geolocation geolocation = api.GetGeolocation(geoParams);

if(geolocation.GetStatus() == 200)
{
    Console.WriteLine(geolocation.GetIp());
    Console.WriteLine(geolocation.GetCountryName());
}
else
{
    Console.WriteLine(geolocation.GetMessage());
}

// Query geolocation for the calling machine's IP address for all fields
Geolocation geolocation = api.GetGeolocation();

if(geolocation.GetStatus() == 200)
{
    Console.WriteLine(geolocation.GetCountryCode2());
    Console.WriteLine(geolocation.GetTimezone().GetCurrentTime());
}
else
{
    Console.WriteLine(geolocation.GetMessage());
}
```

### Bulk Geolocations Lookup
```c#
// Query geolocations for multiple IP addresses and all fields
String[] ips = new String[]{"1.1.1.1", "2.2.2.2", "3.3.3.3"};
GeolocationParams geoParams = new GeolocationParams();
geoParams.SetIps(ips);

List<Geolocation> geolocations = api.GetBulkGeolocation(geoParams);

Console.WriteLine(geolocations.Count);
Console.WriteLine(geolocations[0].GetCountryName());
Console.WriteLine(geolocations[1].GetLanguages());
Console.WriteLine(geolocations[2].GetTimezone().GetCurrentTime());

// Query geolocations for multiple IP addresses but only geo field
String[] ips = new String[]{"1.1.1.1", "2.2.2.2", "3.3.3.3"};
GeolocationParams geoParams = new GeolocationParams();
geoParams.SetIps(ips);
geoParams.SetFields("geo");

List<Geolocation> geolocations = api.GetBulkGeolocation(geoParams);

Console.WriteLine(geolocations.Count);
Console.WriteLine(geolocations[0].GetCountryCode2());
Console.WriteLine(geolocations[1].GetCountryName());
Console.WriteLine(geolocations[2].GetLatitude());
```

### Time Zone API
```c#
// Query time zone information by time zone ID
TimezoneParams tzParams = new TimezoneParams();
tzParams.SetTimezone(“America/New_York”);

Timezone tz = api.GetTimezone(tzParams);

if(tz.GetStatus() == 200)
{
    Console.WriteLine(tz.GetDateTimeWti());
    Console.WriteLine(tz.GetDateTimeTxt());
}
else
{
    Console.WriteLine(tz.GetMessage());
}

// Query time zone information by latitude and longitude of the location
TimezoneParams tzParams = new TimezoneParams();
tzParams.SetLocation(37.1838139, -123.8105225);

Timezone tz = api.GetTimezone(tzParams);

if(tz.GetStatus() == 200)
{
    Console.WriteLine(tz.GetTimezone());
}
else
{
    Console.WriteLine(tz.GetMessage());
}

// Query time zone information for IP address (1.1.1.1)
TimezoneParams tzParams = new TimezoneParams();
tzParams.SetIp("1.1.1.1");

Timezone tz = api.GetTimezone(tzParams);

if(tz.GetStatus() == 200)
{
    Console.WriteLine(tz.GetTimezone());
}
else
{
    Console.WriteLine(tz.GetMessage());
}

// Query time zone information for calling machine’s IP address
Timezone tz = api.GetTimezone();

if(tz.getMessage())
{
    Console.WriteLine(tz.GetTimezone());
    Console.WriteLine(tz.GetDateTimeYmd());
}
else
{
    Console.WriteLine(tz.GetMessage());
}
```

## IP Geolocation API C# SDK Objects Reference
IP Geolocation API C# SDK has following classes that you can use to fully leverage it.

### Class: IPGeolocation.IPGeolocationAPI

|Method|Description|Return Type|
|------|-----------|-----------|
|IPGeolocationAPI(String apiKey)|Construct the IPGeolocationAPI object. It takes a valid apiKey as parameter and throws ArgumentException if apiKey is empty or null.||
|GetGeolocation()|This function to query Geolocation API.|Geolocation|
|GetGeolocation(GeolocationParams params)|This function to query Geolocation API based on the parameters passed.|Geolocation|
|GetTimezone()|This function to query Timezone API based on calling machine's IP address.|Timezone|
|GetTimezone(TimezoneParams params)|This function to query Timezone API based on the parameters passed.|Timezone|
|GetBulkGeolocation(GeolocationParams params)|This function to query Geolocation API to lookup multiple IP addresses (max. 50).|List<Geolocation>|
|GetApiKey()|This function to get the API key that you set to query the IPGeolocation API.|String|

### Class: IPGeolocation.GeolocationParams
|Method|Description|Return Type|
|------|-----------|-----------|
|SetIp(String ip)|Sets IP address to lookup geolocation.|void|
|GetIp()|Get IP address set to lookup geolocation.|String|
|SetFields(String fields)|Set fields to lookup geolocation.|void|
|GetFields()|Get fields set to lookup geolocation.|String|
|SetIps(String[] ips)|Set IP addresses to lookup multiple geolocations. Throws ArgumentException if no. of IP addresses are more than 50. Note: Multiple IP addresses lookup is only available for paid users.|void|
|GetIps()|Get IP addresses set to lookup bulk geolocations.|String[]|

### Class: IPGeolocation.Geolocation
|Method|Description|Return Type|
|------|-----------|-----------|
|GetStatus()|Returns HTTP status of the geolocation query. 200 is the successful query status.|Integer|
|GetMessage()|Returns error message, if the query was not successful.|String|
|GetIp()|Returns IP address of the geolocation.|String|
|GetContinentCode()|Returns 2-letters continent code.|String|
|GetContinentName()|Returns continent name.|String|
|GetCountryCode2()|Returns 2-letters country code.|String|
|GetCountryCode3()|Returns 3-letters country code.|String|
|GetCountryName()|Returns country name.|String|
|GetCountryCapital()|Returns country capital.|String|
|GetStateProvince()|Returns state/province.|String|
|GetDistrict()|Returns district.|String|
|GetCity()|Returns city.|String|
|GetZipcode()|Returns zip code.|String|
|GetLatitude()|Returns latitude of the city.|Double|
|GetLongitude()|Returns longitude of the city.|Double|
|isEu()|Returns is the country in European Union.|Boolean|
|GetCallingCode()|Returns country calling code.|String|
|GetCountryTld()|Returns country’s top level domain like '.au' for Australia.|String|
|GetLanguages()|Returns languages spoken in the country.|String|
|GetCountryFlag()|Returns a URL to country’s flag.|String|
|GetIsp()|Returns ISP name.|String|
|GetConnectionType()|Returns connection type of the IP address.|String|
|GetOrganization()|Returns organization using the IP address.|String|
|GetGeonameId()|Returns geoname ID from geonames.org database.|String|
|GetCurrency()|Returns currency information of the country.|GeolocationCurrency|
|GetTimezone()|Returns time zone information of the country.|GeolocationTimezone|

### Class: IPGeolocation.GeolocationCurrency
|Method|Description|Return Type|
|------|-----------|-----------|
|GetCode()|Returns 3-letters currency code.|String|
|GetName()|Returns currency name.|String|

### Class: IPGeolocation.GeolocationTimezone
|Method|Description|Return Type|
|------|-----------|-----------|
|GetName()|Returns standard time zone ID like “America/New_York”.|String|
|GetOffset()|Returns time zone offset from UTC.|Double|
|GetCurrentTime()|Returns current date-time string in the format “yyyy-MM-dd HH:mm:ss.SSSZ”.|String|
|isDST()|Returns is the country observing daylight saving time.|Boolean|
|GetDstSavings()|Returns daylight savings time (in hours).|Double|

### Class: IPGeolocation.TimezoneParams
|Method|Description|Return Type|
|------|-----------|-----------|
|SetTimezone(String timezone)|Sets time zone ID to query time zone information.|void|
|GetTimezone()|Get time zone ID set to query time zone information.|String|
|SetIp(String ip)|Sets IP address to query time zone information.|void|
|GetIp()|Get IP address set to query time zone information.|String|
|SetLocation(Double latitude, Double longitude)|Sets latitude and longitude of a location to query time zone information.|void|
|GetLatitude()|Returns latitude set to query time zone information.|Double|
|GetLongitude()|Returns longitude set to query time zone information.|Double|

### Class: IPGeolocation.Timezone
|Method|Description|Return Type|
|------|-----------|-----------|
|GetStatus()|Returns HTTP status of the geolocation query. 200 is the successful query status.|Integer|
|GetMessage()|Returns error message, if the query was not successful.|String|
|GetTimezone()|Returns time zone ID like “America/New_York”.|String|
|GetTimezoneOffset()|Returns time zone offset from UTC.|Double|
|GetDate()|Returns current date in the format “yyyy-MM-dd”.|String|
|GetDateTime()|Returns date-time string in the format “yyyy-MM-dd HH:mm:ss”.|String|
|GetDateTimeTxt()|Returns date-time string in the format “EEEE, MMMM dd, yyyy HH:mm:ss”.|String|
|GetDateTimeWti()|Returns date-time string in the format “EEE, dd MMM yyyy HH:mm:ss Z”.|String|
|GetDateTimeYmd()|Returns date-time string in the format “yyyy-MM-dd'T'HH:mm:ssZ”.|String|
|GetTime24()|Returns current time in the format “HH:mm:ss”.|String|
|GetTime12()|Returns current time in the format “hh:mm:ss aa”.|String|
|GetWeek()|Returns current week of the year.|String|
|GetMonth()|Returns current month of the year.|String|
|GetYear()|Returns current year.|String|
|GetYearAbbr()|Returns 2-letters year abbreviation like “18”.|String|
|isDst()|Returns is the country observing Daylight Saving time.|Boolean|
|GetDstSavings()|Returns daylight savings time (in hours).|Double|
|GetTimezoneGeo()|Returns geolocation of timezone if you lookup timezone information from an IP address.|TimezoneGeo|

### Class: IPGeolocation.TimezoneGeo
|Method|Description|Return Type|
|------|-----------|-----------|
|GetCountryCode2()|Returns 2-letters country code.|String|
|GetCountryCode3()|Returns 3-letters country code.|String|
|GetCountryName()|Returns country name.|String|
|GetStateProvince()|Returns state/province.|String|
|GetDistrict()|Returns district.|String|
|GetCity()|Returns city.|String|
|GetZipcode()|Returns zip code.|String|
|GetLatitude()|Returns latitude of the city.|Double|
|GetLongitude()|Returns longitude of the city.|Double|
