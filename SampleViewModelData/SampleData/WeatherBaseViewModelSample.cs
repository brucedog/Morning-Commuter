using System;
using BaseInterfaceLibrary.Model;
using BaseInterfaceLibrary.ViewModel;
using Model.Models;

namespace View.SampleData
{
    public class WeatherBaseViewModelSample : IWeatherViewModel
    {
        public WeatherBaseViewModelSample()
        {
            Weather = new WeatherBugWeather("73", "Sunny")
                           {
                               RainToday = "YES",
                               RainRate = ".02",
                               WindSpeed = "100MPH",
                               Pressure = "18PSI",
                               Humidity = "30%",
                               FeelsLike = "64",
                               SunSet = DateTime.Now.AddHours(12).ToShortTimeString(),
                               SunRise = DateTime.Now.ToShortTimeString()
                           };
            ProxyImageLoaded = false;
        }

        public bool ProxyImageLoaded { get; private set; }

        public string TemperatureUnitType { get { return "ºF"; } }

        public bool HasWeatherAlerts { get { return true; } }

        public bool IsEnglishUnits { get; set; }

        public IWeatherBug Weather { get; set; }
    }
}