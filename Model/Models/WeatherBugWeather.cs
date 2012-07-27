using System;
using System.Collections.Generic;
using BaseInterfaceLibrary.Model;

namespace Model.Models
{
    public class WeatherBugWeather : WeatherBase, IWeatherBug
    {
        public WeatherBugWeather(string currentTemp, string currentWeatherSummary)
            : base(currentTemp, "0", "0", currentWeatherSummary)
        {
        }

        public WeatherBugWeather(string feelsLike, string currentTemp, string highTempForToday, string lowTempForToday, string currentWeatherSummary, string rainToday,
            string windspeed, string windSpeedUnit, string windDirection, string rainRate, string dewPoint, string humidity, string pressure, DateTime sunRise, DateTime sunSet) 
            : base(currentTemp, highTempForToday, lowTempForToday, currentWeatherSummary)
        {            
            FeelsLike = feelsLike;
            WindSpeed = windspeed;
            WindSpeedUnit = windSpeedUnit;
            WindDirection = windDirection;
            RainToday = rainToday;
            RainRate = rainRate;
            DewPoint = dewPoint;
            Humidity = humidity;
            Pressure = pressure;
            SunRise = sunRise.ToShortTimeString();
            SunSet = sunSet.ToShortTimeString();
        }

        public string WindSpeedUnit { get; set; }

        public string FeelsLike { get; set; }

        public string Pressure { get; set; }

        public string DewPoint { get; set; }

        public string WindSpeed { get; set; }
        
        public string WindDirection { get; set; }

        public string RainToday { get; set; }

        public string RainRate { get; set; }

        public string Humidity { get; set; }

        public string SunRise { get; set; }

        public string SunSet { get; set; }

        public List<IWeatherAlert> WeatherAlerts { get; set; }
    }
}