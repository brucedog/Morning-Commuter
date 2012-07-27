using BaseInterfaceLibrary.Model;
using BaseInterfaceLibrary.ViewModel;
using Caliburn.Micro;

namespace ViewModel.ViewModels
{
    public class WeatherAlertViewModel : Screen, IWeatherAlertViewModel
    {
        private readonly IWeatherAlert _alert;

        public WeatherAlertViewModel(IWeatherAlert model)
        {
            DisplayName = "Weather alerts";
            _alert = model;
        }

        public string Title { get { return _alert.Title; } }

        public string Message { get { return _alert.Message; } }

        public string Type { get { return _alert.Type; } }

        public string ExpireTime { get { return _alert.Expire.ToShortTimeString(); } }

        public string TimeIssued { get { return _alert.Issued.ToShortTimeString(); } }

        public void CloseWeatherAlertWindow()
        {
            TryClose();
        }
    }
}