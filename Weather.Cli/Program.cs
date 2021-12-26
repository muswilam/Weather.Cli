using System.Net;
using System.Net.Http.Json;
using Weather.Cli.Contracts;

const string apiKey = "";

var httpClient = new HttpClient()
{
    BaseAddress = new Uri("https://api.openweathermap.org/")
};

var city = args.AsQueryable().FirstOrDefault();

Start:
if (city == default)
{
    Console.Write("City name: ");
    city = Console.ReadLine()!.Trim();
}

var response = await httpClient.GetAsync($"data/2.5/weather?q={city}&appid={apiKey}&units=metric&cnt=1");

if (response.StatusCode == HttpStatusCode.NotFound)
{
    Console.WriteLine($"Weather not found for city: {city}");
    city = default;
    goto Start;
}

var currentWeather = await response.Content.ReadFromJsonAsync<WeatherResponse>();

Console.WriteLine($"Current weather in {city}");
Console.WriteLine($"City: {currentWeather!.Name}");
Console.WriteLine($"Country: {currentWeather.Sys.Country}");
Console.WriteLine($"Weather: {currentWeather.Weather[0].Description}");
Console.WriteLine($"Temperature: {currentWeather.Main.Temp}°C");
Console.WriteLine($"Humidity: {currentWeather.Main.Hunidity}%");
Console.WriteLine($"Pressure: {currentWeather.Main.Pressure}hPa");
Console.WriteLine($"Wind: {currentWeather.Wind.Speed}m/s, {currentWeather.Wind.Degree}°");
Console.WriteLine($"Clouds: {currentWeather.Clouds.All}%");
