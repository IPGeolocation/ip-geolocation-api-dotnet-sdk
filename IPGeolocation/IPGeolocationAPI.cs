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
        public String GetApiKey()
        {
            return this.apiKey;
        }

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

        public Geolocation GetGeolocation()
        {
            JObject apiResponse = GetGeolocationResponse(null);
            return new Geolocation(apiResponse);
        }

        public Geolocation GetGeolocation(GeolocationParams geolocationParams)
        {
            JObject apiResponse = GetGeolocationResponse(geolocationParams);
            Console.WriteLine(apiResponse);
            return new Geolocation(apiResponse);
        }

        private JObject GetGeolocationResponse(GeolocationParams geolocationParams)
        {
            String urlParams = BuildGeolocationUrlParams(geolocationParams);
            return GetApiResponse("ipgeo", urlParams);
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
                if (geolocationParams.IsIncludeHostname()) {
                    urlParams.Append("&include=hostname");
                }
                if (geolocationParams.IsIncludeSecurity()) {
                    if (geolocationParams.IsIncludeHostname()) {
                        urlParams.Append(",security");
                    } else
                    {
                        urlParams.Append("&include=security");
                    }
                }
                if (geolocationParams.IsIncludeUserAgentDetail()) {
                    if (geolocationParams.IsIncludeHostname() || geolocationParams.IsIncludeSecurity()) {
                        urlParams.Append(",useragent");
                    } else
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

        private JObject GetApiResponse(String api, String urlParams)
        {
            String url = "https://api.ipgeolocation.io/" + api + "?" + urlParams;
            HttpWebRequest webrequest = (HttpWebRequest)WebRequest.Create(url);
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

        public List<Geolocation> GetBulkGeolocation(GeolocationParams geolocationParams)
        {
            Dictionary<String, Object> json = new Dictionary<String, Object>();
            json.Add("ips", geolocationParams.GetIPAddresses());
            String jsonStr = JsonConvert.SerializeObject(json);
            String urlParams = BuildGeolocationUrlParams(geolocationParams);
            List<JObject> apiResponse = GetBulkApiResponse(jsonStr, urlParams);
            List<Geolocation> geolocations = new List<Geolocation>();
            foreach (JObject response in apiResponse)
            {
                geolocations.Add(new Geolocation(response));
            }
            return geolocations;
        }

        private List<JObject> GetBulkApiResponse(String ipsJson, String urlParams)
        {
            var responseString = "";
            int responseStatusCode = 0;
            try
            {
                String url = "https://api.ipgeolocation.io/ipgeo-bulk" + "?" + urlParams;
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

        public Timezone GetTimezone()
        {
            JObject apiResponse = GetTimezoneResponse(null);
            return new Timezone(apiResponse);
        }

        public Timezone GetTimezone(TimezoneParams timezoneParams)
        {
            JObject apiResponse = GetTimezoneResponse(timezoneParams);
            Console.WriteLine(apiResponse);
            return new Timezone(apiResponse);
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

        private JObject GetTimezoneResponse(TimezoneParams timezoneParams)
        {
            String urlParams = BuildTimezoneUrlParams(timezoneParams);
            return GetApiResponse("timezone", urlParams);
        }

        private List<JObject> ConvertStringToListMap(int responseCode, String response)
        {
            List<JObject> finalResult = new List<JObject>();
            List<JObject> list;
            if (responseCode != 200)
            {
                response = "[" + response + "]";
                Console.WriteLine("Passing: " + response);
                list = JsonConvert.DeserializeObject<List<JObject>>(response);
            }
            else
            {
                Console.WriteLine("Passing: " + response);
                list = JsonConvert.DeserializeObject<List<JObject>>(response);
            }
            foreach (JObject map in list)
            {
                map.Add("status", responseCode);
                finalResult.Add(map);
            }
            return finalResult;
        }

        public UserAgent GetUserAgent(String uaString)
        {
            Dictionary<String, Object> json = new Dictionary<String, Object>();
            json.Add("uaString", uaString);
            String jsonStr = JsonConvert.SerializeObject(json);
            String url = "https://api.ipgeolocation.io/user-agent?apiKey=" + apiKey;
            JObject apiResponse = GetUserAgentApiResponse(jsonStr, url);
            return new UserAgent(apiResponse);
        }

        public List<UserAgent> GetBulkUserAgent(List<String> uaStrings)
        {
            Dictionary<String, Object> json = new Dictionary<String, Object>();
            json.Add("uaStrings", uaStrings);
            String jsonStr = JsonConvert.SerializeObject(json);
            String url = "https://api.ipgeolocation.io/user-agent-bulk?apiKey=" + apiKey;
            List<JObject> apiResponse = GetBulkUserAgentApiResponse(jsonStr, url);
            List<UserAgent> userAgents = new List<UserAgent>();
            foreach (JObject response in apiResponse)
            {
                userAgents.Add(new UserAgent(response));
            }
            return userAgents;
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
            return ConvertStringToListMapUserAgent(responseStatusCode, responseString);
        }

        private JObject ConvertStringToListMapUserAgent(int responseCode, String response)
        {
            List<JObject> finalResult = new List<JObject>();
            JObject jsonObject;
            if (responseCode != 200)
            {
                jsonObject = JsonConvert.DeserializeObject<JObject>(response);
            }
            else
            {
                jsonObject = JsonConvert.DeserializeObject<JObject>(response);
            }
            Console.WriteLine("Passing: " + jsonObject);
            return jsonObject;
        }

        private List<JObject> GetBulkUserAgentApiResponse(String jsonString, String url)
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
            return ConvertStringToListMapBulkUserAgent(responseStatusCode, responseString);
        }

        private List<JObject> ConvertStringToListMapBulkUserAgent(int responseCode, String response)
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
    }
}
