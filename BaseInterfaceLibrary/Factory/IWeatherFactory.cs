using System.Collections.Generic;
using BaseInterfaceLibrary.Model;

namespace BaseInterfaceLibrary.Factory
{
    public interface IWeatherFactory
    {
        IWeatherBug CreateWeatherBugCompactModel(string zipCode, bool isEnglishUnit);
       
        List<IWeatherForecast> CreateWeatherForecastList(string zipCode, bool isEnglishUnit);
        
        IWeatherBug CreateWeatherBugDetailModel(string zipcode, bool isEnglishUnit);
        
        List<IWeatherAlert> CreateWeatherAlerts(string zipcode);
        
        IWeather CreateGoogleWeatherModel();
    }
}