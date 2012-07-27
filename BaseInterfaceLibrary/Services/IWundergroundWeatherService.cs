using BaseInterfaceLibrary.Model;

namespace BaseInterfaceLibrary.Services
{
    public interface IWundergroundWeatherService
    {
        IWeather GetWeather();
    }
}