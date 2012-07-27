using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;
using BaseInterfaceLibrary.Model;
using BaseInterfaceLibrary.Services;
using BaseInterfaceLibrary.ViewModel;
using Caliburn.Micro;
using Ninject;

namespace ViewModel.ViewModels
{
    public class TravelViewModel : Screen, ITravelViewModel
    {
        private readonly Timer _clockTimer;
        private string _currentTime;
        private ICommute _commute;
        private readonly IKernel _kernel;
        private readonly IWindowManager _windowManager;

        public TravelViewModel(IKernel kernel, IWindowManager windowManager)
        {
            DisplayName = "Commute";
            _kernel = kernel;
            _windowManager = windowManager;
            ISettings settings = kernel.Get<IXmlHelper>().LoadSettingsFromXmlFile();
            UseEnglishUnits = settings.UseEnglishUnits;
            Commute = kernel.Get<IGoogleMapService>().GetCommute();
            
            _clockTimer = new Timer
                              {
                                  Interval = 30000, 
                                  Enabled = true
                              };

            _clockTimer.Elapsed += UpdateClock;
        }

        #region properties 

        public bool UseEnglishUnits { get; set; }

        public string From { get { return "From: " + Commute.From; } }

        public string To { get { return "To: " + Commute.To; } }

        public string TravelingBy { get { return "Traveling by: " + Commute.TravelingBy; } }

        public string ExceptedArrivalTime
        {
            get { return "Expected arrival time: " + DateTime.Now.Add(Commute.ArrivalTime).ToShortTimeString(); }
        }

        public List<string> Warnings
        {
            get { return Commute.Warnings.ToList(); }
        }

        public bool HasWarnings
        {
            get { return Commute.Warnings.Length > 0; }
        }

        public string CurrentTime
        {
            get
            {
                return string.IsNullOrWhiteSpace(_currentTime) ? DateTime.Now.ToShortTimeString() : _currentTime;
            }
            private set
            {
                _currentTime = value;
                NotifyOfPropertyChange(() => CurrentTime);
            }
        }

        public ICommute Commute
        {
            get
            {
                return _commute ?? (_commute = _kernel.Get<ICommute>());
            }
            set
            {
                _commute = value;
                NotifyOfPropertyChange(() => Commute);
            }
        }

        #endregion

        public void CloseCommand()
        {
            TryClose();    
        }

        public void ShowDirections()
        {
            _windowManager.ShowDialog(_kernel.Get<ITravelDirectionsViewModel>());
        }
        
        private void UpdateClock(object sender, ElapsedEventArgs e)
        {
            CurrentTime = DateTime.Now.ToShortTimeString();
            NotifyOfPropertyChange(() => ExceptedArrivalTime);
        }
    }
}