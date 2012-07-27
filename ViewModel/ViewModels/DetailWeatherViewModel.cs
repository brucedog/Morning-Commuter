using BaseInterfaceLibrary.Model;
using BaseInterfaceLibrary.ViewModel;

namespace ViewModel.ViewModels
{
    public class DetailWeatherViewModel : IDetailWeatherViewModel
    {
        private readonly IWeatherBug _weather;

        public DetailWeatherViewModel(IWeatherBug weather)
        {
            _weather = weather;
        }

        public string FeelsLike { get { return _weather.FeelsLike; } }

        public string Humidity { get { return _weather.Humidity; } }
        
        public string Pressure { get { return _weather.Pressure; } }

        public string WindSpeed { get { return _weather.WindSpeed; } }

        public string RainToday { get { return _weather.RainToday; } }
    }
}