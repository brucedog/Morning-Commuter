using System;
using BaseInterfaceLibrary.Model;
using BaseInterfaceLibrary.ViewModel;
using Model.Models;

namespace SampleViewModelData
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

        public bool ProxyImageLoaded { get; set; }

        public IWeather WundergroundWeather { get; set; }
        
        public bool HasWeatherAlerts { get { return true; } }

        public bool IsEnglishUnits { get; set; }

        public IWeatherBug Weather { get; set; }
        
        public void RefreshWeatherData(){}

        public string RainToday { get { return Weather.RainToday; } }

        public string Humidity
        {
            get { return Weather.Humidity; }
        }

        public string FeelsLike { get { return Weather.FeelsLike; } }

        public string LowTemperatureForToday { get { return Weather.LowTemperatureForToday; } }

        public string HighTemperatureForToday { get { return Weather.HighTemperatureForToday; } }

        public string CurrentTemperature { get { return Weather.CurrentTemperature; } }

        public string CurrentWeatherSummary { get { return Weather.CurrentWeatherSummary; } }
        
        public void AlertWindow()
        {
            throw new NotImplementedException();
        }

        public void ForecastWindow()
        {
            throw new NotImplementedException();
        }
    }
}