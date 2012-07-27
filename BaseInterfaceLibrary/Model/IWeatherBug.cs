using System.Collections.Generic;

namespace BaseInterfaceLibrary.Model
{
    public interface IWeatherBug : IWeatherBase
    {
        string FeelsLike { get; set; }
        
        string WindSpeedUnit { get; set; }

        string Pressure { get; set; }

        string DewPoint { get; set; }

        string WindSpeed { get; set; }

        string WindDirection { get; set; }

        string RainToday { get; set; }

        string RainRate { get; set; }

        string Humidity { get; set; }

        string SunRise { get; set; }

        string SunSet { get; set; }

        List<IWeatherAlert> WeatherAlerts { get; set; }
    }
}