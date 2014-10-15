using System.Collections.Generic;
using System.Linq;
using BaseInterfaceLibrary.Factory;
using BaseInterfaceLibrary.Model;
using BaseInterfaceLibrary.Services;
using Model.Models;
using Model.Models.Wunderground;
using Newtonsoft.Json;
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
            if (string.IsNullOrWhiteSpace(zipCode))
                return new Weather {WeatherAlerts = new List<IWeatherAlert>()};

            var results = _worldWeatherOnlineService.GetCurrentWeather(zipCode);

            return JsonToWeather(results); 
        }

        public List<IWeatherForecast> CreateWeatherForecastList(string zipCode, bool isEnglishUnit)
        {
            if (string.IsNullOrWhiteSpace(zipCode))
                return new List<IWeatherForecast>();

            var results = _worldWeatherOnlineService.GetForecastByUsZipCode(zipCode);

            return JsonToWeatherForecast(results);
        }

        public List<IWeatherAlert> CreateWeatherAlerts(string zipCode)
        {
            if (string.IsNullOrWhiteSpace(zipCode))
                return new List<IWeatherAlert>();

            var weatherAlerts = _worldWeatherOnlineService.GetWeatherAlerts(zipCode);

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

            var jsonObject = JsonConvert.DeserializeObject<RootObject>(result);

            if (jsonObject.current_observation == null)
                return weather;

            weather.CurrentWeatherSummary = jsonObject.current_observation.weather;
            weather.FeelsLikeF = jsonObject.current_observation.feelslike_f;
            weather.FeelsLikeC = jsonObject.current_observation.feelslike_c;            
            weather.Humidity = jsonObject.current_observation.relative_humidity;
            weather.PrecipToday = jsonObject.current_observation.precip_today_in;
            weather.CurrentTemperature = jsonObject.current_observation.temp_f.ToString();
            weather.WeatherAlerts = new List<IWeatherAlert>();
            weather.Pressure = jsonObject.current_observation.pressure_in;
            weather.Wind = jsonObject.current_observation.wind_mph.ToString();
            weather.WindDirection = jsonObject.current_observation.wind_dir;
            weather.UV = jsonObject.current_observation.UV;
            weather.HeatIndexC = jsonObject.current_observation.heat_index_c.ToString();
            weather.HeatIndexF = jsonObject.current_observation.heat_index_f.ToString();

            return weather;
        }
    }
}