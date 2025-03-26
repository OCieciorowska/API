namespace API;

class Program
{
    static async Task Main(string[] args)
    {
        Console.Write("Podaj nazwę miasta: ");
        string city = Console.ReadLine();//czytamy z konsoli nazwe miasta

        try
        {
            WeatherData weather = await WeatherAPI.GetWeatherAsync(city);//wywolujemy metode by pobrac dane z API
            Console.WriteLine($"Pogoda w {weather.Name}: {weather.main.temp}°C, Wilgotność: {weather.main.humidity}%, Ciśnienie: {weather.main.pressure} hPa");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Błąd: {ex.Message}");
        }
    }
}