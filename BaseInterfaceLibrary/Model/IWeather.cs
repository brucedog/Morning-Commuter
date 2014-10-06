using System.Collections.Generic;

namespace BaseInterfaceLibrary.Model
{
    public interface IWeather : IWeatherBase
    {
        string Humidity { get; set; }

        string FeelsLikeF { get; set; }

        string FeelsLikeC { get; set; }
        
        string Condition { get; set; }

        string HeatIndexF { get; set; }

        string HeatIndexC { get; set; }

        string PrecipToday { get; set; }

        string Pressure { get; set; }

        string Wind { get; set; }

        string WindDirection { get; set; }

        string UV { get; set; }

        List<IWeatherAlert> WeatherAlerts { get; set; }
    }
}