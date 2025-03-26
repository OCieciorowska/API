namespace API;
//zamieniamy  json na obiekt C#
class WeatherData
{
    public Main main { get; set; }
    public string Name { get; set; }//nazwa miasta
}

class Main
{
    public double temp { get; set; }//temperatura w st C
    public double pressure { get; set; }//cisnienie
    public double humidity { get; set; }//wilgotnosc
}
