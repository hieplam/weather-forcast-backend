namespace weather_forcast_backend
{

    public class OpenWeatherModel
    {
        public Main main { get; set; }
        public string name { get; set; }
    }
    public class Main
    {
        public double temp { get; set; }
        public double feels_like { get; set; }
        public double temp_min { get; set; }
        public double temp_max { get; set; }
        public int pressure { get; set; }
        public int humidity { get; set; }
    }


}
