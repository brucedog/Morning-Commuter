using BaseInterfaceLibrary.Model;

namespace Model.Models
{
    public abstract class WeatherBase : IWeatherBase
    {
        protected WeatherBase(string currentTemp, string highTempForToday, string lowTempForToday, string currentWeatherSummary)
        {
            CurrentTemperature = currentTemp;
            HighTemperatureForToday = highTempForToday;
            LowTemperatureForToday = lowTempForToday;
            CurrentWeatherSummary = currentWeatherSummary;
        }

        public string CurrentTemperature { get; set; }

        public string HighTemperatureForToday { get; set; }
        
        public string LowTemperatureForToday { get; set; }
        
        public string CurrentWeatherSummary { get; set; }
    }
}