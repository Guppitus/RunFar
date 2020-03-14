using System;

namespace myMicroservice
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Pee {get; set;}

        public string[] Summary { get; set; }
    }
}
