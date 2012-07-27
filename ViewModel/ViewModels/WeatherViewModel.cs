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

        public WeatherViewModel(IKernel kernel, ISettings model,
            IWindowManager windowManager)
        {
            Settings = model;
            _kernel = kernel;
            _windowManger = windowManager;
            _weatherFactory = _kernel.Get<IWeatherFactory>();
            IsEnglishUnits = kernel.Get<IXmlHelper>().LoadSettingsFromXmlFile().UseEnglishUnits;
            _refreshWeatherData = new Timer { Interval = 1500000, Enabled = true };
            _refreshWeatherData.Elapsed += RefreshWeatherData;
        }

        #region properties

        public bool ProxyImageLoaded
        {
            get { return _proxyImageLoaded; }
            private set
            {
                _proxyImageLoaded = value;
                NotifyOfPropertyChange(() => ProxyImageLoaded);
            }
        }

        public IWeather WundergroundWeather
        {
            get { return _wundergroundWeather ?? (_wundergroundWeather = _kernel.Get<IWundergroundWeatherService>().GetWeather()); }
            set
            {
                _wundergroundWeather = value;
                NotifyOfPropertyChange(() => WundergroundWeather);
            }
            
        }

        public IWeatherBug Weather
        {
            get { return _weatherBug ?? (_weatherBug = _weatherFactory.CreateWeatherBugDetailModel(Settings.ZipCode, true)); }
            set
            {
                _weatherBug = value;
                NotifyOfPropertyChange(() => Weather);
            }
        }

        public string RainToday
        {
            get { return WundergroundWeather.PrecipToday; }
        }
        
        public string Humidity
        {
            get { return WundergroundWeather.Humidity; }
        }

        public string FeelsLike
        {
            get { return (IsEnglishUnits ? WundergroundWeather.FeelsLikeF : WundergroundWeather.FeelsLikeC) + TemperatureUnitType; }
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
            Weather = _weatherFactory.CreateWeatherBugDetailModel(Settings.ZipCode, true);
            WundergroundWeather = _kernel.Get<IWundergroundWeatherService>().GetWeather();
            NotifyOfPropertyChange(() => HasWeatherAlerts);
            NotifyOfPropertyChange(() => HighTemperatureForToday);
            NotifyOfPropertyChange(() => LowTemperatureForToday);
            NotifyOfPropertyChange(() => FeelsLike);
            NotifyOfPropertyChange(() => Humidity);
            NotifyOfPropertyChange(() => RainToday);
        }

        private void RefreshWeatherData(object source, ElapsedEventArgs e)
        {
            RefreshWeatherData();
        }
    }
} 