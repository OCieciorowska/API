using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
namespace API;
//obsługa zapytania API
class WeatherAPI
{
    private static readonly HttpClient client = new HttpClient();//Tworzy jedno połączenie HTTP (oszczędza zasoby).
    private const string apiKey = "6bf5480812943946635562298e42df3d"; // Klucz API do uwierzytelnienia w OpenWeatherMap.

    public static async Task<WeatherData> GetWeatherAsync(string city)
    {
        string url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}&units=metric";//url z podanym miastem i API

        HttpResponseMessage response = await client.GetAsync(url);//Wysyła zapytanie do API.
        response.EnsureSuccessStatusCode();//Sprawdza, czy odpowiedź nie zawiera błędu.

        string jsonResponse = await response.Content.ReadAsStringAsync();//pobieramy odpowiedz jako tekst
        return JsonSerializer.Deserialize<WeatherData>(jsonResponse);//deserializacja json do obiektu WeatherData
    }
}