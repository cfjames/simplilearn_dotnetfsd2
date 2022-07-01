// See https://aka.ms/new-console-template for more information
using WeatherForcast;

var httpClient = new HttpClient();
var apiWeatherClient =
    new WeatherForcastClient("http://localhost:5255/", httpClient);
var forcasts =
    apiWeatherClient.GetWeatherForecastAsync().Result;

foreach(var forcast in forcasts)
    Console.WriteLine($"{forcast.TemperatureF} : {forcast.Summary}");
