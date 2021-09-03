using System;

namespace weather_forcast_backend
{
    public class Todo
    {

        public int Id { get; set; }
        public double Temp { get; set; }
        public double FeelsLike { get; set; }
        public double TempMin { get; set; }
        public double TempMax { get; set; }
        public int Pressure { get; set; }
        public int Humidity { get; set; }
        public string Note { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
