namespace API;
//zamieniamy  json na obiekt C# //definiuje strukturę obiektu, który przechowuje dane o pogodzie pobrane z API OpenWeatherMap
class WeatherData
{
    public Main main { get; set; }
    public string Name { get; set; }//nazwa miasta
}
//get- pozwala odczytac wartość, np console.writeline, set- pozwala zmienic wartosc 
class Main
{
    public double temp { get; set; }//temperatura w st C
    public double pressure { get; set; }//cisnienie
    public double humidity { get; set; }//wilgotnosc
}
