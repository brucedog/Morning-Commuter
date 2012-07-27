using System.Collections.Generic;
using System.Linq;
using BaseInterfaceLibrary.Factory;
using BaseInterfaceLibrary.Model;
using Model.Models;
using Services.WeatherBugWebService;

namespace Factory
{
    public class WeatherFactory : IWeatherFactory
    {
        private readonly WeatherBugWebServices _webService;
        private const string ApiWeatherBugKey = "A6338994343";

        public WeatherFactory()
        {
            _webService = new WeatherBugWebServices();
        }

        public IWeatherBug CreateWeatherBugCompactModel(string zipCode, bool isEnglishUnit)
        {            
            var results = _webService.GetLiveCompactWeatherByUSZipCode(zipCode, isEnglishUnit ? UnitType.English : UnitType.Metric, ApiWeatherBugKey);
            
            IWeatherBug weatherBug = new WeatherBugWeather(results.Temperature, results.CurrDesc)
                                         {WeatherAlerts = CreateWeatherAlerts(zipCode)};

            return weatherBug;
        }

        public List<IWeatherForecast> CreateWeatherForecastList(string zipCode, bool isEnglishUnit)
        {
            var results = _webService.GetForecastByUSZipCode(zipCode, isEnglishUnit ? UnitType.English : UnitType.Metric, ApiWeatherBugKey);

            return results.Select(apiForecastData => new WeatherForecast(apiForecastData.Title, apiForecastData.Description, apiForecastData.TempHigh, apiForecastData.TempLow, apiForecastData.Prediction)).Cast<IWeatherForecast>().ToList();
        }

        public IWeatherBug CreateWeatherBugDetailModel(string zipcode, bool isEnglishUnit)
        {            
            var results = _webService.GetLiveWeatherByUSZipCode(zipcode, isEnglishUnit ? UnitType.English : UnitType.Metric, ApiWeatherBugKey);
           
            IWeatherBug weatherBug = new WeatherBugWeather(results.FeelsLike,
                                                           results.Temperature,
                                                           results.TemperatureHigh,
                                                           results.TemperatureLow, 
                                                           results.CurrDesc,
                                                           results.RainToday,
                                                           results.WindSpeed,
                                                           results.WindSpeedUnit,
                                                           results.WindDirection, 
                                                           results.RainRate,
                                                           results.DewPoint,
                                                           results.Humidity,
                                                           results.Pressure,
                                                           results.Sunrise,
                                                           results.Sunset)
                                         {
                                             WeatherAlerts = CreateWeatherAlerts(zipcode)
                                         };          

            return weatherBug;
        }

        public List<IWeatherAlert> CreateWeatherAlerts(string zipcode)
        {
            var results = _webService.GetAlertsDataList(zipcode, ApiWeatherBugKey);   
            IEnumerable<IWeatherAlert> alerts = from alertList in results
                                         select new WeatherAlert(alertList.ExpiryDateTime, alertList.ExpiryTimeZone,
                                                                   alertList.IssueDateTime, alertList.IssueTimeZone,
                                                                   alertList.Message, alertList.Title, alertList.Type);
            return alerts.ToList();
        }

        public IWeather CreateGoogleWeatherModel()
        {
            //XDocument xDocument = XDocument.Load(string.Format(WeatherUrls.GoogleWeatherUrl, "15217"));
            //var test = from weather in xDocument.Element("xml_api_reply").Element("weather").Descendants("current_conditions")
            //           select weather.Attribute("data");
            //IEnumerable<IGoogleWeather> weatherBug = from weather in xDocument.Descendants("current_conditions")
            //                                         select new GoogleWeather(SafeDoubleParse(weather.Attribute("temp_f").Value),
            //                                             SafeDoubleParse(weather.Attribute("tetemp_fmp").Value),
            //                                             SafeDoubleParse(weather.Attribute("temp_f").Value),
            //                                             weather.Attribute("condition").Value);
            throw new System.NotImplementedException();
        }

        private double SafeDoubleParse(string parseString)
        {
            double doubleParse;
            double.TryParse(parseString, out doubleParse);

            return doubleParse;
        }
    }
}