using System;
using System.Net;
using System.IO;
using System.Text;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace IPGeolocation
{

    public class IPGeolocationAPI
    {

        private String apiKey;

        public IPGeolocationAPI(String apiKey)
        {
            if (Strings.IsNullOrEmpty(apiKey))
            {
                throw new ArgumentException("API key must not be null or empty");
            }
            else
            {
                this.apiKey = apiKey;
            }
        }

        public String GetApiKey()
        {
            return this.apiKey;
        }

        public Dictionary<String, Object> GetGeolocation()
        {
            JObject apiResponse = GetApiResponse("ipgeo", "apiKey=" + apiKey);
            return prepareResponseForUser(apiResponse, "geolocation");
        }

        public Dictionary<String, Object> GetGeolocation(GeolocationParams geolocationParams)
        {
            JObject apiResponse = GetGeolocationResponse(geolocationParams);
            return prepareResponseForUser(apiResponse, "geolocation");
        }

        public Dictionary<String, Object> GetBulkGeolocation(GeolocationParams geolocationParams)
        {
            Dictionary<String, Object> json = new Dictionary<String, Object>();
            json.Add("ips", geolocationParams.GetIPAddresses());

            String jsonStr = JsonConvert.SerializeObject(json);
            String urlParams = BuildGeolocationUrlParams(geolocationParams);
            String url = "https://api.ipgeolocation.io/ipgeo-bulk" + "?" + urlParams;
            List<JObject> apiResponse = GetBulkApiResponse(jsonStr, url);
            
            return prepareBulkResponseForUser(apiResponse, "geolocation");
        }

        public Dictionary<String, Object> GetTimezone()
        {
            JObject apiResponse = GetApiResponse("timezone", "apiKey=" + apiKey);
            return prepareResponseForUser(apiResponse, "timezone");
        }

        public Dictionary<String, Object> GetTimezone(TimezoneParams timezoneParams)
        {
            JObject apiResponse = GetTimezoneResponse(timezoneParams);
            return prepareResponseForUser(apiResponse, "timezone");
        }

        public Dictionary<String, Object> GetUserAgent(String uaString)
        {
            Dictionary<String, Object> json = new Dictionary<String, Object>();
            json.Add("uaString", uaString);

            String jsonStr = JsonConvert.SerializeObject(json);
            String url = "https://api.ipgeolocation.io/user-agent?apiKey=" + apiKey;
            JObject apiResponse = GetUserAgentApiResponse(jsonStr, url);
            
            return prepareResponseForUser(apiResponse, "useragent");
        }

        public Dictionary<String, Object> GetBulkUserAgent(List<String> uaStrings)
        {
            Dictionary<String, Object> json = new Dictionary<String, Object>();
            json.Add("uaStrings", uaStrings);

            String jsonStr = JsonConvert.SerializeObject(json);
            String url = "https://api.ipgeolocation.io/user-agent-bulk?apiKey=" + apiKey;
            List<JObject> apiResponse = GetBulkApiResponse(jsonStr, url);
            
            return prepareBulkResponseForUser(apiResponse, "useragent");
        }

        private String BuildGeolocationUrlParams(GeolocationParams geolocationParams)
        {
            StringBuilder urlParams = new StringBuilder(80);
            urlParams.Append("apiKey=");
            urlParams.Append(apiKey);

            if (geolocationParams != null)
            {
                if (!Strings.IsNullOrEmpty(geolocationParams.GetIPAddress()))
                {
                    urlParams.Append("&ip=");
                    urlParams.Append(geolocationParams.GetIPAddress());
                }

                if (!Strings.IsNullOrEmpty(geolocationParams.GetFields()))
                {
                    urlParams.Append("&fields=");
                    urlParams.Append(geolocationParams.GetFields());
                }
                
                bool includeHost = false;
                
                if (geolocationParams.IsIncludeHostname())
                {
                    urlParams.Append("&include=hostname");
                    includeHost = true;
                }
                else if (geolocationParams.IsIncludeHostnameFallbackLive())
                {
                    urlParams.Append("&include=hostnameFallbackLive");
                    includeHost = true;
                }
                else if (geolocationParams.IsIncludeLiveHostname())
                {
                    urlParams.Append("&include=liveHostname");
                    includeHost = true;
                }
                
                if (geolocationParams.IsIncludeSecurity())
                {
                    if (includeHost)
                    {
                        urlParams.Append(",security");
                    }
                    else
                    {
                        urlParams.Append("&include=security");
                    }
                }
                
                if (geolocationParams.IsIncludeUserAgentDetail())
                {
                    if (includeHost || geolocationParams.IsIncludeSecurity())
                    {
                        urlParams.Append(",useragent");
                    }
                    else
                    {
                        urlParams.Append("&include=useragent");
                    }
                }
                
                if (!Strings.IsNullOrEmpty(geolocationParams.GetLang()))
                {
                    urlParams.Append("&lang=");
                    urlParams.Append(geolocationParams.GetLang());
                }
                
                if (!Strings.IsNullOrEmpty(geolocationParams.GetExcludes()))
                {
                    urlParams.Append("&excludes=");
                    urlParams.Append(geolocationParams.GetExcludes());
                }
            }

            return urlParams.ToString();
        }

        private String BuildTimezoneUrlParams(TimezoneParams timezoneParams)
        {
            StringBuilder urlParams = new StringBuilder(80);
            
            urlParams.Append("apiKey=");
            urlParams.Append(apiKey);
            
            if (timezoneParams != null)
            {
                if (!Strings.IsNullOrEmpty(timezoneParams.GetIPAddress()))
                {
                    urlParams.Append("&ip=");
                    urlParams.Append(timezoneParams.GetIPAddress());
                }
                
                if (!Strings.IsNullOrEmpty(timezoneParams.GetTimezone()))
                {
                    urlParams.Append("&tz=");
                    urlParams.Append(timezoneParams.GetTimezone());
                }
                
                bool latValue = (timezoneParams.GetLatitude() >= -90) && (timezoneParams.GetLatitude() <= 90);
                bool longValue = (timezoneParams.GetLongitude() >= -180) && (timezoneParams.GetLongitude() <= 180);
                
                if (latValue && longValue)
                {
                    urlParams.Append("&lat=");
                    urlParams.Append(timezoneParams.GetLatitude());
                    urlParams.Append("&long=");
                    urlParams.Append(timezoneParams.GetLongitude());
                }
                
                if (!Strings.IsNullOrEmpty(timezoneParams.GetLang()))
                {
                    urlParams.Append("&lang=");
                    urlParams.Append(timezoneParams.GetLang());
                }
                
                if (!Strings.IsNullOrEmpty(timezoneParams.GetLocation()))
                {
                    urlParams.Append("&location=");
                    urlParams.Append(timezoneParams.GetLocation());
                }
            }

            return urlParams.ToString();
        }

        private JObject GetGeolocationResponse(GeolocationParams geolocationParams)
        {
            String urlParams = BuildGeolocationUrlParams(geolocationParams);
            return GetApiResponse("ipgeo", urlParams);
        }

        private JObject GetTimezoneResponse(TimezoneParams timezoneParams)
        {
            String urlParams = BuildTimezoneUrlParams(timezoneParams);
            return GetApiResponse("timezone", urlParams);
        }

        private JObject GetUserAgentApiResponse(String jsonString, String url)
        {
            var responseString = "";
            int responseStatusCode = 0;

            try
            {
                var request = HttpWebRequest.Create(url);
                var data = Encoding.ASCII.GetBytes(jsonString);
                request.Method = "POST";
                request.ContentType = "application/json";
                request.ContentLength = data.Length;

                using (var stream = request.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }
                
                var response = (HttpWebResponse)request.GetResponse();
                
                responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
                responseStatusCode = (int)response.StatusCode;
            }
            catch (WebException ex)
            {
                using (var stream = ex.Response.GetResponseStream())
                using (var reader = new StreamReader(stream))
                {
                    responseString = reader.ReadToEnd().ToString();
                }
            }
            
            JObject finalResponse = ConvertStringToListMapUserAgent(responseStatusCode, responseString);
            finalResponse.Add("status", responseStatusCode);

            return finalResponse;
        }

        private JObject GetApiResponse(String api, String urlParams)
        {
            String url = "https://api.ipgeolocation.io/" + api + "?" + urlParams;
            var webrequest = HttpWebRequest.Create(url);
            webrequest.Method = "GET";
            webrequest.ContentType = "application/json";
            
            HttpWebResponse webresponse = (HttpWebResponse)webrequest.GetResponse();
            Encoding enc = System.Text.Encoding.GetEncoding("utf-8");
            StreamReader responseStream = new StreamReader(webresponse.GetResponseStream(), enc);
            String result = String.Empty;
            result = responseStream.ReadToEnd();
            
            JObject response = JObject.Parse(result);
            response.Add("status", (int)webresponse.StatusCode);
            webresponse.Close();
            
            return response;
        }

        private List<JObject> GetBulkApiResponse(String ipsJson, String url)
        {
            var responseString = "";
            int responseStatusCode = 0;

            try
            {
                var request = HttpWebRequest.Create(url);
                var data = Encoding.ASCII.GetBytes(ipsJson);
                
                request.Method = "POST";
                request.ContentType = "application/json";
                request.ContentLength = data.Length;
                
                using (var stream = request.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }
                
                var response = (HttpWebResponse)request.GetResponse();
                responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
                responseStatusCode = (int)response.StatusCode;
            }
            catch (WebException ex)
            {
                using (var stream = ex.Response.GetResponseStream())
                using (var reader = new StreamReader(stream))
                {
                    responseString = reader.ReadToEnd().ToString();
                }
            }

            return ConvertStringToListMap(responseStatusCode, responseString);
        }

        private List<JObject> ConvertStringToListMap(int responseCode, String response)
        {
            List<JObject> finalResult = new List<JObject>();
            List<JObject> list;

            if (responseCode != 200)
            {
                response = "[" + response + "]";
                list = JsonConvert.DeserializeObject<List<JObject>>(response);
            }
            else
            {
                list = JsonConvert.DeserializeObject<List<JObject>>(response);
            }
            
            foreach (JObject map in list)
            {
                map.Add("status", responseCode);
                finalResult.Add(map);
            }
            
            return finalResult;
        }

        private JObject ConvertStringToListMapUserAgent(int responseCode, String response)
        {
            JObject jsonObject;
            
            if (responseCode != 200)
            {
                jsonObject = JsonConvert.DeserializeObject<JObject>(response);
            }
            else
            {
                jsonObject = JsonConvert.DeserializeObject<JObject>(response);
            }
            
            return jsonObject;
        }

        private Dictionary<String, Object> prepareResponseForUser(JObject apiResponse, String type)
        {
            int httpStatus = apiResponse.GetValue("status").ToObject<int>();
            JToken errorMessageToken = apiResponse.GetValue("message");
            String errorMessage = errorMessageToken != null ? errorMessageToken.ToObject<String>() : null;
            Dictionary<String, Object> response = new Dictionary<String, Object>();

            response.Add("status", httpStatus);
            response.Add("message", errorMessage);

            if (httpStatus == 200 && type.Equals("geolocation"))
            {
                response.Add("response", new Geolocation(apiResponse));
            }
            else if (httpStatus == 200 && type.Equals("timezone"))
            {
                response.Add("response", new Timezone(apiResponse));
            }
            else if (httpStatus == 200 && type.Equals("useragent"))
            {
                response.Add("response", new UserAgent(apiResponse));
            }

            return response;
        }

        private Dictionary<String, Object> prepareBulkResponseForUser(List<JObject> apiResponseList, String type)
        {
            JObject firstApiResponse = apiResponseList[0];
            int httpStatus = firstApiResponse.GetValue("status").ToObject<int>();
            JToken errorMessageToken = firstApiResponse.GetValue("message");
            String errorMessage = errorMessageToken != null ? errorMessageToken.ToObject<String>() : null;
            Dictionary<String, Object> response = new Dictionary<string, object>();

            response.Add("status", httpStatus);
            response.Add("message", errorMessage);

            if (httpStatus == 200 && type.Equals("geolocation"))
            {
                List<Geolocation> list = new List<Geolocation>();

                for (int i = 0; i < apiResponseList.Count; i++)
                {
                    list.Add(new Geolocation(apiResponseList[i]));
                }
                
                response.Add("response", list);
            }
            else if (httpStatus == 200 && type.Equals("useragent"))
            {
                List<UserAgent> list = new List<UserAgent>();

                for (int i = 0; i < apiResponseList.Count; i++)
                {
                    list.Add(new UserAgent(apiResponseList[i]));
                }
                
                response.Add("response", list);
            }

            return response;
        }

    }
}
