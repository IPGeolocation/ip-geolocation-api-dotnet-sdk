using System;
using System.Collections.Generic;

namespace IPGeolocation;

public sealed class IpGeolocationResponse
{
    public IpGeolocationResponse(
        string? ip = null,
        string? hostname = null,
        string? domain = null,
        IpLocation? location = null,
        CountryMetadata? countryMetadata = null,
        CurrencyInfo? currency = null,
        NetworkInfo? network = null,
        AsnInfo? asn = null,
        CompanyInfo? company = null,
        IpTimeZone? timeZone = null,
        SecurityInfo? security = null,
        UserAgentInfo? userAgent = null,
        AbuseContact? abuse = null)
    {
        Ip = ip;
        Hostname = hostname;
        Domain = domain;
        Location = location;
        CountryMetadata = countryMetadata;
        Currency = currency;
        Network = network;
        Asn = asn;
        Company = company;
        TimeZone = timeZone;
        Security = security;
        UserAgent = userAgent;
        Abuse = abuse;
    }

    public string? Ip { get; }
    public string? Hostname { get; }
    public string? Domain { get; }
    public IpLocation? Location { get; }
    public CountryMetadata? CountryMetadata { get; }
    public CurrencyInfo? Currency { get; }
    public NetworkInfo? Network { get; }
    public AsnInfo? Asn { get; }
    public CompanyInfo? Company { get; }
    public IpTimeZone? TimeZone { get; }
    public SecurityInfo? Security { get; }
    public UserAgentInfo? UserAgent { get; }
    public AbuseContact? Abuse { get; }
}

public sealed class IpLocation
{
    public IpLocation(
        string? continentCode = null,
        string? continentName = null,
        string? countryCode2 = null,
        string? countryCode3 = null,
        string? countryName = null,
        string? countryNameOfficial = null,
        string? countryCapital = null,
        string? stateProv = null,
        string? stateCode = null,
        string? district = null,
        string? city = null,
        string? locality = null,
        string? accuracyRadius = null,
        string? confidence = null,
        string? dmaCode = null,
        string? zipcode = null,
        string? latitude = null,
        string? longitude = null,
        bool? isEu = null,
        string? countryFlag = null,
        string? geonameId = null,
        string? countryEmoji = null)
    {
        ContinentCode = continentCode;
        ContinentName = continentName;
        CountryCode2 = countryCode2;
        CountryCode3 = countryCode3;
        CountryName = countryName;
        CountryNameOfficial = countryNameOfficial;
        CountryCapital = countryCapital;
        StateProv = stateProv;
        StateCode = stateCode;
        District = district;
        City = city;
        Locality = locality;
        AccuracyRadius = accuracyRadius;
        Confidence = confidence;
        DmaCode = dmaCode;
        Zipcode = zipcode;
        Latitude = latitude;
        Longitude = longitude;
        IsEu = isEu;
        CountryFlag = countryFlag;
        GeonameId = geonameId;
        CountryEmoji = countryEmoji;
    }

    public string? ContinentCode { get; }
    public string? ContinentName { get; }
    public string? CountryCode2 { get; }
    public string? CountryCode3 { get; }
    public string? CountryName { get; }
    public string? CountryNameOfficial { get; }
    public string? CountryCapital { get; }
    public string? StateProv { get; }
    public string? StateCode { get; }
    public string? District { get; }
    public string? City { get; }
    public string? Locality { get; }
    public string? AccuracyRadius { get; }
    public string? Confidence { get; }
    public string? DmaCode { get; }
    public string? Zipcode { get; }
    public string? Latitude { get; }
    public string? Longitude { get; }
    public bool? IsEu { get; }
    public string? CountryFlag { get; }
    public string? GeonameId { get; }
    public string? CountryEmoji { get; }
}

public sealed class CountryMetadata
{
    public CountryMetadata(string? callingCode = null, string? tld = null, IReadOnlyList<string>? languages = null)
    {
        CallingCode = callingCode;
        Tld = tld;
        Languages = languages;
    }

    public string? CallingCode { get; }
    public string? Tld { get; }
    public IReadOnlyList<string>? Languages { get; }
}

public sealed class CurrencyInfo
{
    public CurrencyInfo(string? code = null, string? name = null, string? symbol = null)
    {
        Code = code;
        Name = name;
        Symbol = symbol;
    }

    public string? Code { get; }
    public string? Name { get; }
    public string? Symbol { get; }
}

public sealed class NetworkInfo
{
    public NetworkInfo(
        string? connectionType = null,
        string? route = null,
        bool? isAnycast = null)
    {
        ConnectionType = connectionType;
        Route = route;
        IsAnycast = isAnycast;
    }

    public string? ConnectionType { get; }
    public string? Route { get; }
    public bool? IsAnycast { get; }
}

public sealed class AsnInfo
{
    public AsnInfo(
        string? asNumber = null,
        string? organization = null,
        string? country = null,
        string? type = null,
        string? domain = null,
        string? dateAllocated = null,
        string? rir = null)
    {
        AsNumber = asNumber;
        Organization = organization;
        Country = country;
        Type = type;
        Domain = domain;
        DateAllocated = dateAllocated;
        Rir = rir;
    }

    public string? AsNumber { get; }
    public string? Organization { get; }
    public string? Country { get; }
    public string? Type { get; }
    public string? Domain { get; }
    public string? DateAllocated { get; }
    public string? Rir { get; }
}

public sealed class CompanyInfo
{
    public CompanyInfo(string? name = null, string? type = null, string? domain = null)
    {
        Name = name;
        Type = type;
        Domain = domain;
    }

    public string? Name { get; }
    public string? Type { get; }
    public string? Domain { get; }
}

public sealed class IpTimeZone
{
    public IpTimeZone(
        string? name = null,
        double? offset = null,
        double? offsetWithDst = null,
        string? currentTime = null,
        double? currentTimeUnix = null,
        string? currentTzAbbreviation = null,
        string? currentTzFullName = null,
        string? standardTzAbbreviation = null,
        string? standardTzFullName = null,
        bool? isDst = null,
        double? dstSavings = null,
        bool? dstExists = null,
        string? dstTzAbbreviation = null,
        string? dstTzFullName = null,
        DstTransition? dstStart = null,
        DstTransition? dstEnd = null)
    {
        Name = name;
        Offset = offset;
        OffsetWithDst = offsetWithDst;
        CurrentTime = currentTime;
        CurrentTimeUnix = currentTimeUnix;
        CurrentTzAbbreviation = currentTzAbbreviation;
        CurrentTzFullName = currentTzFullName;
        StandardTzAbbreviation = standardTzAbbreviation;
        StandardTzFullName = standardTzFullName;
        IsDst = isDst;
        DstSavings = dstSavings;
        DstExists = dstExists;
        DstTzAbbreviation = dstTzAbbreviation;
        DstTzFullName = dstTzFullName;
        DstStart = dstStart;
        DstEnd = dstEnd;
    }

    public string? Name { get; }
    public double? Offset { get; }
    public double? OffsetWithDst { get; }
    public string? CurrentTime { get; }
    public double? CurrentTimeUnix { get; }
    public string? CurrentTzAbbreviation { get; }
    public string? CurrentTzFullName { get; }
    public string? StandardTzAbbreviation { get; }
    public string? StandardTzFullName { get; }
    public bool? IsDst { get; }
    public double? DstSavings { get; }
    public bool? DstExists { get; }
    public string? DstTzAbbreviation { get; }
    public string? DstTzFullName { get; }
    public DstTransition? DstStart { get; }
    public DstTransition? DstEnd { get; }
}

public sealed class DstTransition
{
    public DstTransition(
        string? utcTime = null,
        string? duration = null,
        bool? gap = null,
        string? dateTimeAfter = null,
        string? dateTimeBefore = null,
        bool? overlap = null)
    {
        UtcTime = utcTime;
        Duration = duration;
        Gap = gap;
        DateTimeAfter = dateTimeAfter;
        DateTimeBefore = dateTimeBefore;
        Overlap = overlap;
    }

    public string? UtcTime { get; }
    public string? Duration { get; }
    public bool? Gap { get; }
    public string? DateTimeAfter { get; }
    public string? DateTimeBefore { get; }
    public bool? Overlap { get; }
}

public sealed class SecurityInfo
{
    public SecurityInfo(
        double? threatScore = null,
        bool? isTor = null,
        bool? isProxy = null,
        IReadOnlyList<string>? proxyProviderNames = null,
        double? proxyConfidenceScore = null,
        string? proxyLastSeen = null,
        bool? isResidentialProxy = null,
        bool? isVpn = null,
        IReadOnlyList<string>? vpnProviderNames = null,
        double? vpnConfidenceScore = null,
        string? vpnLastSeen = null,
        bool? isRelay = null,
        string? relayProviderName = null,
        bool? isAnonymous = null,
        bool? isKnownAttacker = null,
        bool? isBot = null,
        bool? isSpam = null,
        bool? isCloudProvider = null,
        string? cloudProviderName = null)
    {
        ThreatScore = threatScore;
        IsTor = isTor;
        IsProxy = isProxy;
        ProxyProviderNames = proxyProviderNames;
        ProxyConfidenceScore = proxyConfidenceScore;
        ProxyLastSeen = proxyLastSeen;
        IsResidentialProxy = isResidentialProxy;
        IsVpn = isVpn;
        VpnProviderNames = vpnProviderNames;
        VpnConfidenceScore = vpnConfidenceScore;
        VpnLastSeen = vpnLastSeen;
        IsRelay = isRelay;
        RelayProviderName = relayProviderName;
        IsAnonymous = isAnonymous;
        IsKnownAttacker = isKnownAttacker;
        IsBot = isBot;
        IsSpam = isSpam;
        IsCloudProvider = isCloudProvider;
        CloudProviderName = cloudProviderName;
    }

    public double? ThreatScore { get; }
    public bool? IsTor { get; }
    public bool? IsProxy { get; }
    public IReadOnlyList<string>? ProxyProviderNames { get; }
    public double? ProxyConfidenceScore { get; }
    public string? ProxyLastSeen { get; }
    public bool? IsResidentialProxy { get; }
    public bool? IsVpn { get; }
    public IReadOnlyList<string>? VpnProviderNames { get; }
    public double? VpnConfidenceScore { get; }
    public string? VpnLastSeen { get; }
    public bool? IsRelay { get; }
    public string? RelayProviderName { get; }
    public bool? IsAnonymous { get; }
    public bool? IsKnownAttacker { get; }
    public bool? IsBot { get; }
    public bool? IsSpam { get; }
    public bool? IsCloudProvider { get; }
    public string? CloudProviderName { get; }
}

public sealed class AbuseContact
{
    public AbuseContact(
        string? route = null,
        string? country = null,
        string? name = null,
        string? organization = null,
        string? kind = null,
        string? address = null,
        IReadOnlyList<string>? emails = null,
        IReadOnlyList<string>? phoneNumbers = null)
    {
        Route = route;
        Country = country;
        Name = name;
        Organization = organization;
        Kind = kind;
        Address = address;
        Emails = emails;
        PhoneNumbers = phoneNumbers;
    }

    public string? Route { get; }
    public string? Country { get; }
    public string? Name { get; }
    public string? Organization { get; }
    public string? Kind { get; }
    public string? Address { get; }
    public IReadOnlyList<string>? Emails { get; }
    public IReadOnlyList<string>? PhoneNumbers { get; }
}

public sealed class UserAgentInfo
{
    public UserAgentInfo(
        string? name = null,
        string? type = null,
        string? version = null,
        string? versionMajor = null,
        UserAgentDevice? device = null,
        UserAgentEngine? engine = null,
        UserAgentOperatingSystem? operatingSystem = null)
    {
        Name = name;
        Type = type;
        Version = version;
        VersionMajor = versionMajor;
        Device = device;
        Engine = engine;
        OperatingSystem = operatingSystem;
    }

    public string? Name { get; }
    public string? Type { get; }
    public string? Version { get; }
    public string? VersionMajor { get; }
    public UserAgentDevice? Device { get; }
    public UserAgentEngine? Engine { get; }
    public UserAgentOperatingSystem? OperatingSystem { get; }
}

public sealed class UserAgentDevice
{
    public UserAgentDevice(string? name = null, string? type = null, string? brand = null, string? cpu = null)
    {
        Name = name;
        Type = type;
        Brand = brand;
        Cpu = cpu;
    }

    public string? Name { get; }
    public string? Type { get; }
    public string? Brand { get; }
    public string? Cpu { get; }
}

public sealed class UserAgentEngine
{
    public UserAgentEngine(string? name = null, string? type = null, string? version = null, string? versionMajor = null)
    {
        Name = name;
        Type = type;
        Version = version;
        VersionMajor = versionMajor;
    }

    public string? Name { get; }
    public string? Type { get; }
    public string? Version { get; }
    public string? VersionMajor { get; }
}

public sealed class UserAgentOperatingSystem
{
    public UserAgentOperatingSystem(string? name = null, string? version = null)
    {
        Name = name;
        Version = version;
    }

    public string? Name { get; }
    public string? Version { get; }
}

public abstract class BulkLookupResult
{
    public abstract bool IsSuccess { get; }
}

public sealed class BulkLookupSuccess : BulkLookupResult
{
    public BulkLookupSuccess(IpGeolocationResponse data)
    {
        Data = data ?? throw new ArgumentNullException(nameof(data));
    }

    public override bool IsSuccess => true;

    public IpGeolocationResponse Data { get; }
}

public sealed class BulkLookupError : BulkLookupResult
{
    public BulkLookupError(BulkLookupErrorDetails error)
    {
        Error = error ?? throw new ArgumentNullException(nameof(error));
    }

    public override bool IsSuccess => false;

    public BulkLookupErrorDetails Error { get; }
}

public sealed class BulkLookupErrorDetails
{
    public BulkLookupErrorDetails(string message)
    {
        if (string.IsNullOrWhiteSpace(message))
        {
            throw new ArgumentException("message must not be blank", nameof(message));
        }

        Message = message;
    }

    public string Message { get; }
}
