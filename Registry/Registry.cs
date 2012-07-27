using BaseInterfaceLibrary.Factory;
using BaseInterfaceLibrary.Model;
using BaseInterfaceLibrary.Services;
using BaseInterfaceLibrary.ViewModel;
using Factory;
using Model.Models;
using Ninject.Modules;
using Services;
using Services.Helper;
using Services.WeatherBugWebService;
using ViewModel.ViewModels;

namespace Registry
{
    public class Registry : NinjectModule
    {
        public override void Load()
        {
            // services
            Bind<WeatherBugWebServices>().To<WeatherBugWebServices>().InSingletonScope();
            Bind<IXmlHelper>().To<XmlHelper>().InSingletonScope();
            Bind<IWeatherFactory>().To<WeatherFactory>().InSingletonScope();
            Bind<IGoogleMapService>().To<GoogleMapService>().InSingletonScope();
            Bind<IWundergroundWeatherService>().To<WundergroundWeatherService>().InSingletonScope();
            // view models
            Bind<IMainWindowViewModel>().To<MainWindowViewModel>().InSingletonScope();
            Bind<ITravelViewModel>().To<TravelViewModel>().InSingletonScope();
            Bind<IWeatherViewModel>().To<WeatherViewModel>().InSingletonScope();
            Bind<IWeatherDetailsViewModel>().To<WeatherDetailsViewModel>();
            Bind<ITravelDirectionsViewModel>().To<TravelDirectionsViewModel>();
            Bind<IWeatherAlertViewModel>().To<WeatherAlertViewModel>();
            Bind<ISettingsViewModel>().To<SettingsViewModel>();
            // models
            Bind<IWeather>().To<Weather>();
            Bind<IWeatherBug>().To<WeatherBugWeather>();
            Bind<IWeatherAlert>().To<WeatherAlert>();
            Bind<IWeatherForecast>().To<WeatherForecast>();
            Bind<ISettings>().To<Settings>().InSingletonScope();
            Bind<ICommute>().To<Commute>().InSingletonScope();
        }
    }
}
