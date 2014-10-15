using System.Timers;
using BaseInterfaceLibrary.Factory;
using BaseInterfaceLibrary.Model;
using BaseInterfaceLibrary.Services;
using BaseInterfaceLibrary.ViewModel;
using Caliburn.Micro;
using Ninject;
using Timer = System.Timers.Timer;

namespace ViewModel.ViewModels
{
    public class WeatherViewModel : Screen, IWeatherViewModel
    {
        private IWeatherBug _weatherBug;
        private IWeather _wundergroundWeather;
        private readonly IWeatherFactory _weatherFactory;
        private readonly Timer _refreshWeatherData;
        private bool _proxyImageLoaded;
        private readonly IKernel _kernel;
        private readonly IWindowManager _windowManger;

        public WeatherViewModel(IKernel kernel,
            IWindowManager windowManager)
        {
            _kernel = kernel;
            _windowManger = windowManager;
            _weatherFactory = _kernel.Get<IWeatherFactory>();
            Settings = kernel.Get<IXmlHelper>().LoadSettingsFromXmlFile();
            _refreshWeatherData = new Timer { Interval = 1500000, Enabled = true };
            _refreshWeatherData.Elapsed += RefreshWeatherData;
        }

        #region properties

        public bool ProxyImageLoaded
        {
            get { return _proxyImageLoaded; }
            set
            {
                _proxyImageLoaded = value;
                NotifyOfPropertyChange(() => ProxyImageLoaded);
            }
        }

        public IWeather Weather
        {
            get { return _wundergroundWeather ?? (Weather = _weatherFactory.CreateCurrentWeather(Settings.ZipCode, IsEnglishUnits)); }
            set
            {
                _wundergroundWeather = value;
                NotifyOfPropertyChange(() => Weather);
                NotifyOfPropertyChange(() => HasWeatherAlerts);
                NotifyOfPropertyChange(() => HighTemperatureForToday);
                NotifyOfPropertyChange(() => LowTemperatureForToday);
                NotifyOfPropertyChange(() => FeelsLike);
                NotifyOfPropertyChange(() => Humidity);
                NotifyOfPropertyChange(() => RainToday);
                NotifyOfPropertyChange(() => CurrentWeatherSummary);
                NotifyOfPropertyChange(() => CurrentTemperature);
            }
        }

        public string RainToday
        {
            get { return Weather.PrecipToday; }
        }
        
        public string Humidity
        {
            get { return Weather.Humidity; }
        }

        public string FeelsLike
        {
            get { return (IsEnglishUnits ? Weather.FeelsLikeF : Weather.FeelsLikeC) + TemperatureUnitType; }
        }

        public string LowTemperatureForToday
        {
            get { return Weather.LowTemperatureForToday + TemperatureUnitType; }
        }

        public string HighTemperatureForToday
        {
            get { return Weather.HighTemperatureForToday + TemperatureUnitType; }
        }

        public string CurrentTemperature
        {
            get { return Weather.CurrentTemperature; }
        }

        public string CurrentWeatherSummary
        {
            get { return Weather.CurrentWeatherSummary; }
        }

        public ISettings Settings { get; set; }

        public string TemperatureUnitType
        {
            get { return IsEnglishUnits ? "ºF" : "ºC"; }
        }

        public bool HasWeatherAlerts
        {
            get { return Weather.WeatherAlerts.Count > 0; }
        }

        public bool IsEnglishUnits { get; set; }

        #endregion

        public void AlertWindow()
        {
            _windowManger.ShowDialog(_kernel.Get<IWeatherAlertViewModel>());
        }

        public void ForecastWindow()
        {
            _windowManger.ShowDialog(_kernel.Get<IWeatherDetailsViewModel>());
        }

        public void RefreshWeatherData()
        {
            Weather = _weatherFactory.CreateCurrentWeather(Settings.ZipCode, true);
            NotifyOfPropertyChange(() => HasWeatherAlerts);
            NotifyOfPropertyChange(() => HighTemperatureForToday);
            NotifyOfPropertyChange(() => LowTemperatureForToday);
            NotifyOfPropertyChange(() => FeelsLike);
            NotifyOfPropertyChange(() => Humidity);
            NotifyOfPropertyChange(() => RainToday);
            NotifyOfPropertyChange(() => CurrentWeatherSummary);
            NotifyOfPropertyChange(() => CurrentTemperature);
        }

        private void RefreshWeatherData(object source, ElapsedEventArgs e)
        {
            RefreshWeatherData();
        }
    }
} 