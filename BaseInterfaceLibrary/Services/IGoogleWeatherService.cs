using BaseInterfaceLibrary.Model;

namespace BaseInterfaceLibrary.Services
{
    public interface IGoogleWeatherService
    {
        IWeather GetWeather();
    }
}