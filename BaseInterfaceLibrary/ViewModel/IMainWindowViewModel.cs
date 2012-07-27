using BaseInterfaceLibrary.Model;

namespace BaseInterfaceLibrary.ViewModel
{
    public interface IMainWindowViewModel
    {
        IWeatherViewModel Weather { get; }

        ITravelViewModel Travel { get; }
        
        ISettings Settings { get; set; }

        bool ShowWeather { get; set; }
        
        bool ShowTravel { get; set; }

        bool IsLoading { get; set; }
    }
}