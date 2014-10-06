using System.Configuration;

namespace Services
{
    public class WundergroundWeatherService : WeatherServiceBase
    {
        private string weatherAlertUrl = "http://api.wunderground.com/api/{0}/alerts/q/{1}.json";
        private string weatherUrl = "http://api.wunderground.com/api/{0}/conditions/q/{1}.json";
        private readonly string _apiKey;

        public WundergroundWeatherService()
        {
            _apiKey = ConfigurationManager.AppSettings.Get("WeatherDotComApiKey");
        }

        public override string GetCurrentWeather(string zipCode)
        {
            string result = MakeWebRequest(string.Format(weatherUrl, _apiKey, zipCode));

            return result;
        }

        public override string GetForecastByUsZipCode(string zipCode)
        {
            string result = MakeWebRequest(string.Format(weatherUrl, _apiKey, zipCode));

            return result;
        }

        public override string GetWeatherAlerts(string zipCode)
        {
            string result = MakeWebRequest(string.Format(weatherAlertUrl, _apiKey, zipCode));

            return result;
        }
    }
}
