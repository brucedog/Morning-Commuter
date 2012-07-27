using System.Xml;
using BaseInterfaceLibrary.Model;
using BaseInterfaceLibrary.Services;
using Ninject;

namespace Services
{
    public class WundergroundWeatherService : IWundergroundWeatherService
    {
        private readonly IKernel _kernel;
        private ISettings _settings;
        private const string CurrentXml = "current_observation/";

        public WundergroundWeatherService(IKernel kernel)
        {
            _kernel = kernel;
        }

        private ISettings Settings { get { return _settings ?? (_settings = _kernel.Get<IXmlHelper>().LoadSettingsFromXmlFile()); } }

        public IWeather GetWeather()
        {
            XmlDocument xmlConditions = new XmlDocument();
            IWeather weather = _kernel.Get<IWeather>();

            xmlConditions.Load(string.Format("http://api.wunderground.com/api/09d01b49a241dc0d/conditions/q/{0}.xml",
                                        Settings.ZipCode));

            foreach (XmlNode node in xmlConditions)
            {
                if (node.SelectSingleNode(CurrentXml + "temp_f")==null)
                    return weather;
                weather.CurrentTemperature = node.SelectSingleNode(CurrentXml + "temp_f").InnerText;
                weather.CurrentTempC = node.SelectSingleNode(CurrentXml + "temp_c").InnerText;
                weather.Humidity = node.SelectSingleNode(CurrentXml + "relative_humidity").InnerText;
                weather.Condition = node.SelectSingleNode(CurrentXml + "weather").InnerText;
                weather.FeelsLikeF = node.SelectSingleNode(CurrentXml + "feelslike_f").InnerText;
                weather.FeelsLikeC = node.SelectSingleNode(CurrentXml + "feelslike_c").InnerText;
                weather.HeatIndexC = node.SelectSingleNode(CurrentXml + "heat_index_c").InnerText;
                weather.HeatIndexF = node.SelectSingleNode(CurrentXml + "heat_index_f").InnerText;
                weather.WindChillF = node.SelectSingleNode(CurrentXml + "windchill_f").InnerText;
                weather.WindChillC = node.SelectSingleNode(CurrentXml + "windchill_c").InnerText;
                weather.PrecipToday = node.SelectSingleNode(CurrentXml + "precip_today_in").InnerText;                
            }

            return weather;
        }
    }
}