using System.Collections.Generic;
using BaseInterfaceLibrary.Model;

namespace BaseInterfaceLibrary.Factory
{
    public interface IWeatherFactory
    {
        IWeather CreateCurrentWeather(string zipCode, bool isEnglishUnit);
       
        List<IWeatherForecast> CreateWeatherForecastList(string zipCode, bool isEnglishUnit);
        
        List<IWeatherAlert> CreateWeatherAlerts(string zipcode);
    }
}