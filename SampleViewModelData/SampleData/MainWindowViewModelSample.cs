using BaseInterfaceLibrary.ViewModel;

namespace View.SampleData
{
    public class MainWindowViewModelSample : IMainWindowViewModel
    {
        public MainWindowViewModelSample()
        {
            Weather = new WeatherBaseViewModelSample();
            Travel = new TravelViewModelSample();
            SettingsViewModel = new SettingsViewModelSample();
        }

        public IWeatherViewModel Weather { get; private set; }

        public ISettingsViewModel SettingsViewModel { get; private set; }

        public ITravelViewModel Travel { get; private set; }
    }
}