# IPGeolocation.Api.AstronomyApi

All URIs are relative to *https://api.ipgeolocation.io/v2*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAstronomyDetails**](AstronomyApi.md#getastronomydetails) | **GET** /astronomy |  |

<a id="getastronomydetails"></a>
# **GetAstronomyDetails**
> AstronomyResponse GetAstronomyDetails (string ip = null, string location = null, string lat = null, string varLong = null, string date = null, double elevation = null, string output = null, string lang = null)



The Astronomy API provides the location-based rise and set times for the Sun and Moon along with the current position, distance from earth, and azimuth of the Sun and the Moon for a specific date at the queried time. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using IPGeolocation.Api;
using IPGeolocation.Client;
using IPGeolocation.Model;

namespace Example
{
    public class GetAstronomyDetailsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ipgeolocation.io/v2";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("apiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("apiKey", "Bearer");

            var apiInstance = new AstronomyApi(config);
            var ip = 8.8.8.8;  // string | query paramter 'ip'. If not provided, will be your network IP (optional) 
            var location = New York, US;  // string | query paramter 'location'. If not provided, will be your ip location (optional) 
            var lat = 40.76473;  // string | query paramter 'lat'. (optional) 
            var varLong = -74.00084;  // string | query paramter 'long'. (optional) 
            var date = 2025-04-22;  // string | The date (YYYY-MM-DD) to lookup for. default will be the current date (optional) 
            var elevation = 9;  // double | query parameter 'elevation' (optional) 
            var output = json;  // string | Desired output format. (optional) 
            var lang = en;  // string | By default, the API responds in English. You can change the response language by passing the language code as a query parameter `lang`. Multi language feature is available only for `paid users`. (optional) 

            try
            {
                AstronomyResponse result = apiInstance.GetAstronomyDetails(ip, location, lat, varLong, date, elevation, output, lang);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AstronomyApi.GetAstronomyDetails: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAstronomyDetailsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AstronomyResponse> response = apiInstance.GetAstronomyDetailsWithHttpInfo(ip, location, lat, varLong, date, elevation, output, lang);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AstronomyApi.GetAstronomyDetailsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ip** | **string** | query paramter &#39;ip&#39;. If not provided, will be your network IP | [optional]  |
| **location** | **string** | query paramter &#39;location&#39;. If not provided, will be your ip location | [optional]  |
| **lat** | **string** | query paramter &#39;lat&#39;. | [optional]  |
| **varLong** | **string** | query paramter &#39;long&#39;. | [optional]  |
| **date** | **string** | The date (YYYY-MM-DD) to lookup for. default will be the current date | [optional]  |
| **elevation** | **double** | query parameter &#39;elevation&#39; | [optional]  |
| **output** | **string** | Desired output format. | [optional]  |
| **lang** | **string** | By default, the API responds in English. You can change the response language by passing the language code as a query parameter &#x60;lang&#x60;. Multi language feature is available only for &#x60;paid users&#x60;. | [optional]  |

### Return type

[**AstronomyResponse**](AstronomyResponse.md)

### Authorization

[ApiKeyAuth](../../README.md#authentication-setup)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Bad Request – Possible reasons include:   - Invalid or not found location/address   - Special characters in API key or value   - Invalid date format (expected: yyyy-MM-dd)   - IP not found in the database  |  -  |
| **401** | Unauthorized – Possible reasons include:   - Missing or invalid API key   - Account unverified, locked, or disabled   - Accessing API with an unauthorized key   - Subscription expired or downgraded  |  -  |
| **405** | Method Not Allowed – Only GET is allowed for &#x60;/astronomy&#x60; endpoint |  -  |
| **429** | Too Many Requests – API usage limits exceeded for current plan |  -  |
| **499** | Client Closed Request – Client terminated connection before completion |  -  |
| **500** | Internal Server Error – Something went wrong on our end |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

