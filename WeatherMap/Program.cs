using System;
using System.IO;
using Newtonsoft.Json.Linq;
using WeatherMap;


string key = File.ReadAllText("appsettings.json"); // this read all the text within the appsetting.json
string APIKey = JObject.Parse(key).GetValue("APIKey").ToString();

Console.WriteLine("Hellp, Please enter your Zipcode: ");
var zipCode = Console.ReadLine();  // want to keep it a string to implement it with the weather app api

//var apiCall = $"https://api.openweathermap.org/data/2.5/weather?zip={zipCode}&units=imperial&appid={APIKey}";

var apiCall = $"https://api.openweathermap.org/data/2.5/weather?zip={zipCode}&appid={APIKey}&units=imperial";

Console.WriteLine();

Console.WriteLine($" It is currently {WeatherMapping.GetTemp(apiCall)} degress F in your location.");
