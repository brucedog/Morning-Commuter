using System.Xml;
using BaseInterfaceLibrary.Model;
using BaseInterfaceLibrary.Services;
using Ninject;

namespace Services
{
    public class GoogleWeatherService : IGoogleWeatherService
    {
        private readonly IKernel _kernel;

        public GoogleWeatherService(IKernel kernel)
        {
            _kernel = kernel;
        }

        public IWeather GetWeather()
        {
            XmlDocument xmlConditions = new XmlDocument();
            IWeather weather = _kernel.Get<IWeather>();

            xmlConditions.Load(string.Format("http://www.google.com/ig/api?weather={0}", _kernel.Get<ISettings>().ZipCode));

            if (xmlConditions.SelectSingleNode("xml_api_reply/weather/problem_cause") != null)            
                return null;

            foreach (XmlNode node in xmlConditions.SelectNodes("/xml_api_reply/weather/current_conditions"))
            {
                weather.CurrentWeatherSummary = node.SelectSingleNode("condition").Attributes["data"].InnerText;
                weather.CurrentTemperature = node.SelectSingleNode("temp_f").Attributes["data"].InnerText;
                weather.Humidity = node.SelectSingleNode("humidity ").Attributes["data"].InnerText;
            }

            foreach (XmlNode node in xmlConditions.SelectNodes("/xml_api_reply/weather/forecast_conditions"))
            {
                weather.HighTemperatureForToday = node.SelectSingleNode("high").Attributes["data"].InnerText;
                weather.LowTemperatureForToday = node.SelectSingleNode("low").Attributes["data"].InnerText;
                break;
            }

            return weather;
        }
    }
}