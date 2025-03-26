using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
namespace API;
//obsługa zapytania API
class WeatherAPI
{
    private static readonly HttpClient client = new HttpClient();//obiekt do wykonania rzadan http static zeby uniknac wielokrotnego tworzenia nowych polaczen 
    private const string apiKey = "6bf5480812943946635562298e42df3d"; //klucz API

    public static async Task<WeatherData> GetWeatherAsync(string city)
    {
        string url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}&units=metric";//url z podanym miastem i API

        HttpResponseMessage response = await client.GetAsync(url);//wysylamy zapytanie get do API
        response.EnsureSuccessStatusCode();

        string jsonResponse = await response.Content.ReadAsStringAsync();//pobieramy odpowiedz jako tekst
        return JsonSerializer.Deserialize<WeatherData>(jsonResponse);//deserializacja json do obiektu WeatherData
    }
}