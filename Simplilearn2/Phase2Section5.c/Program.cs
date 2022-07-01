// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
var httpClient = new HttpClient();
var apiClient = new WeatherForecast.WeatherForecastClient("http://localhost:5137/", httpClient);
var forecasts = apiClient.GetWeatherForecastAsync().Result;

foreach (var forecast in forecasts)
{
    Console.WriteLine($"{forecast.TemperatureF} : {forecast.Summary}");
}