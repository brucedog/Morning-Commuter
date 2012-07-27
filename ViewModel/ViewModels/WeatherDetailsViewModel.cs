using BaseInterfaceLibrary.ViewModel;
using Caliburn.Micro;

namespace ViewModel.ViewModels
{
    public class WeatherDetailsViewModel : Screen, IWeatherDetailsViewModel
    {
        public WeatherDetailsViewModel()
        {
            DisplayName = "Weather Details";
        }
    }
}