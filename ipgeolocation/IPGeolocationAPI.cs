using System;
using System.Net;
using System.IO;
using System.Text;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ipgeolocation
{
    public class IPGeolocationAPI
    {
		private String apiKey;

        public IPGeolocationAPI(String apiKey)
        {
            if(Strings.isNullOrEmpty(apiKey)) {
                throw new ArgumentException("API key must not be null or empty");
                } else {
                        this.apiKey = apiKey;
                    }
        }

        public Geolocation getGeolocation()
        {
            JObject apiResponse = getGeolocationResponse(null);
            return new Geolocation(apiResponse);
        }

        public Geolocation getGeolocation(GeolocationParams geolocationParams)
        {
            JObject apiResponse = getGeolocationResponse(geolocationParams);
            return new Geolocation(apiResponse);
        }

        private JObject getGeolocationResponse(GeolocationParams geolocationParams)
        {
            String urlParams = buildGeolocationUrlParams(geolocationParams);
            return getApiResponse("ipgeo", urlParams);
        }

        private String buildGeolocationUrlParams(GeolocationParams geolocationParams)
        {
            String urlParams = "apiKey=" + apiKey;
            if (geolocationParams != null) {
                String param = geolocationParams.getIp();
                if (!param.Equals(""))
                {
                    urlParams = urlParams + "&ip=" + param;
                }
                param = geolocationParams.getFields();
                if (!param.Equals(""))
                {
                    urlParams = urlParams + "&fields=" + param;
                }
            }
            return urlParams;
        }

        public Timezone getTimezone()
        {
            JObject apiResponse = getTimezoneResponse(null);
            return new Timezone(apiResponse);
        }

        public Timezone getTimezone(TimezoneParams timezoneParams)
        {
            JObject apiResponse = getTimezoneResponse(timezoneParams);
            return new Timezone(apiResponse);
        }

        private String buildTimezoneUrlParams(TimezoneParams timezoneParams)
        {
            String urlParams = "apiKey=" + apiKey;

            if (timezoneParams != null) {
                String param = timezoneParams.getIp();
                if (!param.Equals(""))
                {
                    urlParams = urlParams + "&ip=" + param;
                }

                param = timezoneParams.getTimezone();
                if (!param.Equals(""))
                {
                    urlParams = urlParams + "&tz=" + param;
                }

                Double latitude = timezoneParams.getLatitude();
                Double longitude = timezoneParams.getLongitude();
                if (latitude != 1000.0 && longitude != 1000.0)
                {
                    urlParams = urlParams + "&lat=" + latitude + "&long=" + longitude;
                }
            }
            return urlParams;
        }

        private JObject getApiResponse(String api, String urlParams)
        {
            String url = "https://api.ipgeolocation.io/" + api + "?" + urlParams;
            HttpWebRequest webrequest = (HttpWebRequest)WebRequest.Create(url);
            webrequest.Method = "GET";
            webrequest.ContentType = "application/json";
            HttpWebResponse webresponse = (HttpWebResponse)webrequest.GetResponse();
            Encoding enc = System.Text.Encoding.GetEncoding("utf-8");
            StreamReader responseStream = new StreamReader(webresponse.GetResponseStream(), enc);
            string result = string.Empty;
            result = responseStream.ReadToEnd();
            webresponse.Close();
            JObject response = JObject.Parse(result);
            Console.WriteLine(response);
            return response;
        }

        public List<Geolocation> getBulkGeolocation(GeolocationParams geolocationParams)
        {   
            Dictionary<string,Object> json = new Dictionary<string,Object>();
            json.Add("ips",geolocationParams.getIps());
            string jsonStr = JsonConvert.SerializeObject(json);
            String urlParams = buildGeolocationUrlParams(geolocationParams);

            List<JObject> apiResponse = getBulkApiResponse(jsonStr, urlParams);

            List<Geolocation> geolocations = new List<Geolocation>();
            foreach (JObject response in apiResponse)
            {
                geolocations.Add(new Geolocation(response));
            }
            return geolocations;
        }

        private List<JObject> getBulkApiResponse(string ipsJson, String urlParams)
        { 
        var responseString = "";
        int responseStatusCode = 0;
        try{
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
            }catch(WebException ex){
                    using (var stream = ex.Response.GetResponseStream())
                    using (var reader = new StreamReader(stream))
                    {
                        responseString = reader.ReadToEnd().ToString();
                
                    }
            }
            return convertStringToListMap(responseStatusCode, responseString);
        }

        private JObject getTimezoneResponse(TimezoneParams timezoneParams)
        {
            String urlParams = buildTimezoneUrlParams(timezoneParams);
            return getApiResponse("timezone", urlParams);
        }

        private List<JObject> convertStringToListMap(int responseCode, String response)
        {
            List<JObject> finalResult = new List<JObject>();
            List<JObject> list;
            if(responseCode != 200){
               response = "["+response+"]";
               list = JsonConvert.DeserializeObject<List<JObject>>(response);
            }else{
               list = JsonConvert.DeserializeObject<List<JObject>>(response);
            }
            foreach(JObject map in list){
                map.Add("status", responseCode);
                finalResult.Add(map);
            }
            return finalResult;
        }

        public String getApiKey()
        {
            return this.apiKey;
        }
    }
}