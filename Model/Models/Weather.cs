using System.Collections.Generic;
using BaseInterfaceLibrary.Model;

namespace Model.Models
{
    public class Weather : WeatherBase, IWeather
    {
        public Weather()
            : base("0", "0", "0", "0")
        { }

        public Weather(string currentTemp, string highTempForToday, string lowTempForToday, string currentWeatherSummary) 
            : base(currentTemp, highTempForToday, lowTempForToday, currentWeatherSummary)
        {
        }

        public string Humidity { get; set; }

        public string FeelsLikeF { get; set; }

        public string FeelsLikeC { get; set; }

        public string Condition { get; set; }
        
        public string CurrentTempC { get; set; }
        
        public string HeatIndexF { get; set; }
        
        public string HeatIndexC { get; set; }
        
        public string WindChillF { get; set; }
        
        public string WindChillC { get; set; }
        
        public string PrecipToday { get; set; }
        
        public string Pressure { get; set; }
        
        public string Wind { get; set; }
        
        public string WindDirection { get; set; }
        
        public string UV { get; set; }

        public List<IWeatherAlert> WeatherAlerts { get; set; }
    }
}