using System.ComponentModel;
using System.Windows.Threading;
using BaseInterfaceLibrary.Model;
using BaseInterfaceLibrary.Services;
using BaseInterfaceLibrary.ViewModel;
using Caliburn.Micro;
using Ninject;

namespace ViewModel.ViewModels
{
    public class MainWindowViewModel : Screen, IMainWindowViewModel
    {
        private IWeatherViewModel _weatherViewModel;
        private ITravelViewModel _travelViewModel;
        private ISettings _settings;
        private readonly IWindowManager _windowManager;
        private readonly IKernel _kernel;
        private bool _isLoading = true;
        private bool _isDoneLoading;
        private bool _showTravel;
        private readonly BackgroundWorker _worker;

        public MainWindowViewModel(IKernel kernel, IWindowManager windowManager)
        {
            DisplayName = "Morning";
            _windowManager = windowManager;
            _kernel = kernel;
            Settings = kernel.Get<IXmlHelper>().LoadSettingsFromXmlFile();
            _worker = new BackgroundWorker { WorkerReportsProgress = true };

            LoadData();
        }

        #region properties

        public ITravelViewModel Travel
        {
            get { return _travelViewModel; }
            set
            {
                _travelViewModel = value;
                NotifyOfPropertyChange(()=>Travel);
            }
        }

        public IWeatherViewModel Weather
        {
            get { return _weatherViewModel; }
            set
            {
                _weatherViewModel = value;
                NotifyOfPropertyChange(() => Weather);
            }
        }

        public ISettings Settings
        {
            get { return _settings; }
            set
            {
                _settings = value;
                NotifyOfPropertyChange(() => Settings);
            }
        }

        public bool ShowTravel
        {
            get { return _showTravel; }
            set
            {
                _showTravel = value;
                NotifyOfPropertyChange(()=>ShowTravel);
            }
        }

        public bool IsLoading
        {
            get { return _isLoading; }
            set
            {
                _isLoading = value;
                NotifyOfPropertyChange(() => IsLoading);
            }
        }

        public bool ShowWeather
        {
            get { return _isDoneLoading; }
            set
            {
                _isDoneLoading = value;
                NotifyOfPropertyChange(() => ShowWeather);
            }
        }

        #endregion

        public void CloseCommand()
        {
            TryClose();
        }

        public void SettingsCommand()
        {
            _windowManager.ShowDialog(_kernel.Get<ISettingsViewModel>(), null);
            _weatherViewModel.RefreshWeatherData();
        }

        /// <summary>
        /// load all the data in the background so the user doesnt think the app is frozen
        /// </summary>
        private void LoadData()
        {
            _worker.DoWork += (s, a) =>
            {
                Weather = _kernel.Get<IWeatherViewModel>();
                Travel = _kernel.Get<ITravelViewModel>();
                Dispatcher.CurrentDispatcher.InvokeShutdown();
            };

            _worker.RunWorkerCompleted += (s, args) =>
                {
                    Weather.ProxyImageLoaded = false;
                    IsLoading = false;
                    ShowWeather = true;
                    ShowTravel = true;
                };
            _worker.RunWorkerAsync("get data");
        }
    }
}