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
            Weather = new Weather();
            ProxyImageLoaded = false;
        }

        public bool ProxyImageLoaded { get; set; }

        public IWeather Weather { get; set; }
        
        public bool HasWeatherAlerts { get { return true; } }

        public bool IsEnglishUnits { get; set; }
        
        public void RefreshWeatherData(){}

        public string RainToday { get { return ""; } }

        public string Humidity
        {
            get { return Weather.Humidity; }
        }

        public string FeelsLike { get { return ""; } }

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