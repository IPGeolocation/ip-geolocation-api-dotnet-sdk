namespace IPGeolocation
{
    public interface IIpGeoLocationApi
    {
        String GetApiKey();
        Dictionary<String, Object> GetGeolocation();
        Dictionary<String, Object> GetGeolocation(GeolocationParams geolocationParams);
        Dictionary<String, Object> GetBulkGeolocation(GeolocationParams geolocationParams);
        Dictionary<String, Object> GetTimezone();
        Dictionary<String, Object> GetUserAgent(String uaString);
        Dictionary<String, Object> GetBulkUserAgent(List<String> uaStrings);
    }
}
