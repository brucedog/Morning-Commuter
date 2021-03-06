﻿using BaseInterfaceLibrary.Model;

namespace BaseInterfaceLibrary.ViewModel
{
    public interface IWeatherViewModel
    {
        bool HasWeatherAlerts { get; }

        bool IsEnglishUnits { get; set; }

        bool ProxyImageLoaded { get; set; }

        IWeather Weather { get; set; }
        
        void RefreshWeatherData();

        string RainToday { get; }
        
        string Humidity { get; }
        
        string FeelsLike { get; }
        
        string LowTemperatureForToday { get; }
        
        string HighTemperatureForToday { get; }
        
        string CurrentTemperature { get; }
        
        string CurrentWeatherSummary { get; }
        
        void AlertWindow();
        
        void ForecastWindow();
    }
}