using BaseInterfaceLibrary.Model;
using BaseInterfaceLibrary.ViewModel;

namespace SampleViewModelData
{
    public class MainWindowViewModelSample : IMainWindowViewModel
    {
        public MainWindowViewModelSample()
        {
            Weather = new WeatherBaseViewModelSample();
        }

        public IWeatherViewModel Weather { get; private set; }
        
        public ITravelViewModel Travel { get; private set; }

        public ISettings Settings { get; set; }

        public bool ShowWeather { get; set; }
        
        public bool ShowTravel { get; set; }

        public bool IsLoading { get; set; }
    }
}