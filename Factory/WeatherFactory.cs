using System.Collections.Generic;
using System.Linq;
using BaseInterfaceLibrary.Factory;
using BaseInterfaceLibrary.Model;
using BaseInterfaceLibrary.Services;
using Model.Models;
using Newtonsoft.Json.Linq;
using Ninject;

namespace Factory
{
    public class WeatherFactory : IWeatherFactory
    {
        private readonly IKernel _kernel;
        private readonly IWeatherService _worldWeatherOnlineService;

        public WeatherFactory(IKernel kernel)
        {
            _kernel = kernel;
            _worldWeatherOnlineService = _kernel.Get<IWeatherService>();
        }

        public IWeather CreateCurrentWeather(string zipCode, bool isEnglishUnit)
        {
            var results = _worldWeatherOnlineService.GetCurrentWeather(zipCode);

            return JsonToWeather(results); 
        }

        public List<IWeatherForecast> CreateWeatherForecastList(string zipCode, bool isEnglishUnit)
        {
            var results = _worldWeatherOnlineService.GetForecastByUsZipCode(zipCode);

            return JsonToWeatherForecast(results);
        }

        public List<IWeatherAlert> CreateWeatherAlerts(string zipcode)
        {
            var weatherAlerts = _worldWeatherOnlineService.GetWeatherAlerts(zipcode);

            return JsonToWeatherAlert(weatherAlerts);
        }

        private List<IWeatherForecast> JsonToWeatherForecast(string result)
        {
            List<IWeatherForecast> weatherForecast = new List<IWeatherForecast>();

            if (string.IsNullOrWhiteSpace(result))
                return weatherForecast;

            JObject jsonObject = JObject.Parse(result);
            // TODO 
            return weatherForecast;
        }

        private List<IWeatherAlert> JsonToWeatherAlert(string result)
        {
            List<IWeatherAlert> weatherAlert = new List<IWeatherAlert>();

            if (string.IsNullOrWhiteSpace(result))
                return weatherAlert;

            JObject jsonObject = JObject.Parse(result);
            // TODO 
            return weatherAlert;
        }

        private IWeather JsonToWeather(string result)
        {
            IWeather weather = _kernel.Get<IWeather>();

            if (string.IsNullOrWhiteSpace(result))
                return weather;

            JObject jsonObject = JObject.Parse(result);

            weather.CurrentWeatherSummary = (string)jsonObject["current_observation"]["weather"];
            weather.FeelsLikeF = (string)jsonObject["current_observation"]["feelslike_f"];
            weather.FeelsLikeC = (string)jsonObject["current_observation"]["feelslike_c"];
            weather.Humidity = (string)jsonObject["current_observation"]["humidity"];
            weather.PrecipToday = (string)jsonObject["current_observation"]["precip_today_in"];
            weather.CurrentTemperature = (string)jsonObject["current_observation"]["temp_f"];
            weather.WeatherAlerts = new List<IWeatherAlert>();
            weather.Pressure = (string)jsonObject["current_observation"]["pressure_in"];
            weather.Wind = (string)jsonObject["current_observation"]["wind_mph"];
            weather.WindDirection = (string)jsonObject["current_observation"]["wind_dir"];
            weather.UV = (string)jsonObject["current_observation"]["UV"];
            weather.HeatIndexC = (string)jsonObject["current_observation"]["heat_index_c"];
            weather.HeatIndexF = (string)jsonObject["current_observation"]["heat_index_f"];

            return weather;
        }
    }
}