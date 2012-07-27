using BaseInterfaceLibrary.Model;

namespace Model.Models
{
    public class WeatherForecast : IWeatherForecast
    {
        public WeatherForecast(string title, string description, string tempHigh, string tempLow, string prediction)
        {
            Day = title;
            Description = description;
            HighTemperature = tempHigh;
            LowTemperature = tempLow;
            Predicition = prediction;
        }

        public string Day { get; private set; }

        public string Description { get; private set; }

        public string HighTemperature { get; private set; }
        
        public string LowTemperature { get; private set; }
        
        public string Predicition { get; private set; }
    }
}