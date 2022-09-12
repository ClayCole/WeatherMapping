using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace WeatherMap
{
    public class WeatherMapping
    {
        public static double GetTemp (string apiCall)
        {
            var client = new HttpClient(); // basically  a broswer that can search the web

            var response = client.GetStringAsync(apiCall).Result;

            var temp = double.Parse(JObject.Parse(response)["main"]["temp"].ToString());

            return temp;

        }
    }
}

