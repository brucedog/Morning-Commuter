using System.Configuration;

namespace Services
{
    public class WorldWeatherOnlineService : WeatherServiceBase
    {
        private const string CurrentXml = "current_observation/";
        private string _apiKey;
        private string getWeatherUrl = "http://api.worldweatheronline.com/free/v1/weather.ashx?q={0}&format=json&num_of_days=5&key={1}";
        // TODO 
        private string getWeatherAlertUrl = "http://api.worldweatheronline.com/free/v1/weather.ashx?q={0}&format=json&num_of_days=5&key={1}";
        private string getWeatherForecastUrl = "http://api.worldweatheronline.com/free/v1/weather.ashx?q={0}&format=json&num_of_days=5&key={1}";

        public WorldWeatherOnlineService()
        {
            _apiKey = ConfigurationManager.AppSettings.Get("WeatherAPIKey");
        }

        public override string GetForecastByUsZipCode(string zipCode)
        {
            string result = MakeWebRequest(string.Format(getWeatherForecastUrl, zipCode, _apiKey));

            return result;
        }

        public override string GetCurrentWeather(string zipCode)
        {
            string result = MakeWebRequest(string.Format(getWeatherUrl, zipCode, _apiKey));

            return result;
        }

        public override string GetWeatherAlerts(string zipCode)
        {
            string result = MakeWebRequest(string.Format(getWeatherAlertUrl, zipCode, _apiKey));

            return result;
        }
    }
}