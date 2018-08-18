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
            if(Strings.IsNullOrEmpty(apiKey)) 
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
            return new Geolocation(apiResponse);
        }

        private JObject GetGeolocationResponse(GeolocationParams geolocationParams)
        {
            String urlParams = BuildGeolocationUrlParams(geolocationParams);
            return GetApiResponse("ipgeo", urlParams);
        }

        private String BuildGeolocationUrlParams(GeolocationParams geolocationParams)
        {
            String urlParams = "apiKey=" + apiKey;
            if (geolocationParams != null) {
                String ip = geolocationParams.GetIp();
				if (ip != null && !ip.Equals(""))
                {
					urlParams = urlParams + "&ip=" + ip;
                }
                String fields = geolocationParams.GetFields();
				if (fields != null && !fields.Equals(""))
                {
					urlParams = urlParams + "&fields=" + fields;
                }
            }
            return urlParams;
        }

        public Timezone GetTimezone()
        {
            JObject apiResponse = GetTimezoneResponse(null);
            return new Timezone(apiResponse);
        }

        public Timezone GetTimezone(TimezoneParams timezoneParams)
        {
            JObject apiResponse = GetTimezoneResponse(timezoneParams);
            return new Timezone(apiResponse);
        }

        private String BuildTimezoneUrlParams(TimezoneParams timezoneParams)
        {
            String urlParams = "apiKey=" + apiKey;

            if (timezoneParams != null) {
                String param = timezoneParams.GetIp();
                if (!param.Equals(""))
                {
                    urlParams = urlParams + "&ip=" + param;
                }

                param = timezoneParams.GetTimezone();
                if (!param.Equals(""))
                {
                    urlParams = urlParams + "&tz=" + param;
                }

                Double latitude = timezoneParams.GetLatitude();
                Double longitude = timezoneParams.GetLongitude();
                if (latitude >= 1000.0 && longitude >= 1000.0)
                {
                    urlParams = urlParams + "&lat=" + latitude + "&long=" + longitude;
                }
            }
            return urlParams;
        }

        private JObject GetApiResponse(String api, String urlParams)
        { 
             HttpWebResponse webresponse = null;
             JObject response = null;
             int responseStatusCode = 0;
             try{
                String url = "https://api.ipgeolocation.io/" + api + "?" + urlParams;
                HttpWebRequest webrequest = (HttpWebRequest)WebRequest.Create(url);
                webrequest.Method = "GET";
                webrequest.ContentType = "application/json";
                webresponse = (HttpWebResponse)webrequest.GetResponse();
                Encoding enc = System.Text.Encoding.GetEncoding("utf-8");
                StreamReader responseStream = new StreamReader(webresponse.GetResponseStream(), enc);
                string result = string.Empty;
                result = responseStream.ReadToEnd();
                response = JObject.Parse(result);
                responseStatusCode = (int)webresponse.StatusCode;
                response.Add("status", responseStatusCode);
                webresponse.Close();
                }catch(WebException ex){
                    
                 if(responseStatusCode == 0){
                     response = new JObject();
                     response.Add("status", 422);
                     response.Add("message", "Internet is not connected!");
                 }else{
                    using (var stream = ex.Response.GetResponseStream())
                    using (var reader = new StreamReader(stream))
                    { 
                        response.Add("message", reader.ReadToEnd().ToString());
                    }
                 }
                }
            return response;
        }

        public List<Geolocation> GetBulkGeolocation(GeolocationParams geolocationParams)
        {   
            Dictionary<string,Object> json = new Dictionary<string,Object>();
            json.Add("ips",geolocationParams.GetIps());
            string jsonStr = JsonConvert.SerializeObject(json);
            String urlParams = BuildGeolocationUrlParams(geolocationParams);
            List<JObject> apiResponse = GetBulkApiResponse(jsonStr, urlParams);
            List<Geolocation> geolocations = new List<Geolocation>();
            foreach (JObject response in apiResponse)
            {
                geolocations.Add(new Geolocation(response));
            }
            return geolocations;
        }

        private List<JObject> GetBulkApiResponse(string ipsJson, String urlParams)
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
            catch(WebException ex)
            {   if(responseStatusCode == 0){
                   responseString = "{\"message\":\"Internet is not connected\"}";
                   responseStatusCode = 422;
                }else{
                    using (var stream = ex.Response.GetResponseStream())
                    using (var reader = new StreamReader(stream))
                    { 
                        responseString = reader.ReadToEnd().ToString();
                    }
                }

            }
            return ConvertStringToListMap(responseStatusCode, responseString);
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

            if(responseCode != 200)
            {
               response = "["+response+"]";
               list = JsonConvert.DeserializeObject<List<JObject>>(response);
            }
            else
            {
               list = JsonConvert.DeserializeObject<List<JObject>>(response);
            }

            foreach(JObject map in list){
                map.Add("status", responseCode);
                finalResult.Add(map);
            }
            return finalResult;
        }

        public String GetApiKey()
        {
            return this.apiKey;
        }
    }
}
