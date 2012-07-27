using System.Collections.Generic;
using BaseInterfaceLibrary.Model;
using BaseInterfaceLibrary.Services;
using BaseInterfaceLibrary.ViewModel;
using Caliburn.Micro;
using Ninject;

namespace ViewModel.ViewModels
{
    public class SettingsViewModel : Screen, ISettingsViewModel
    {
        private readonly IKernel _kernel;
        private bool _useEnglishUnits;
        private string _zipCode;
        private string _endAddress;
        private string _startAddress;
        private string _selectedModeOfTransportation;

        public SettingsViewModel(IKernel kernel)
        {
            DisplayName = "Settings";
            _kernel = kernel;
            var settings = _kernel.Get<IXmlHelper>().LoadSettingsFromXmlFile();
            StartAddress = settings.Commute.From;
            EndAddress = settings.Commute.To;
            ZipCode = settings.ZipCode;
            UseEnglishUnits = settings.UseEnglishUnits;
            SelectedSelectedModeOfTransportation = settings.Commute.TravelingBy;
        }

        public string StartAddress
        {
            get { return _startAddress; }
            set
            {
                _startAddress = value;
                NotifyOfPropertyChange(()=>StartAddress);
            }
        }

        public string EndAddress
        {
            get { return _endAddress; }
            set
            {
                _endAddress = value;
                NotifyOfPropertyChange(() => EndAddress);
            }
        }

        public string ZipCode
        {
            get { return _zipCode; }
            set
            {
                _zipCode = value;
                NotifyOfPropertyChange(() => ZipCode);
            }
        }

        public bool UseEnglishUnits
        {
            get { return _useEnglishUnits; }
            set
            {
                _useEnglishUnits = value;
                NotifyOfPropertyChange(() => UseEnglishUnits);
            }
        }

        public List<string> ModesOfTransportation
        {
            get
            {
                return new List<string>
                           {
                               "Car",
                               "Bike",
                               "MassTransit",
                               "Walk"
                           };
            }
        }

        public string SelectedSelectedModeOfTransportation
        {
            get { return _selectedModeOfTransportation; }
            set
            {
                _selectedModeOfTransportation = value;
                NotifyOfPropertyChange(() => SelectedSelectedModeOfTransportation);
            }
        }

        public void CloseSettingsWindow()
        {
            ISettings settings = _kernel.Get<ISettings>();
            settings.Commute.From = StartAddress;
            settings.Commute.To = EndAddress;
            settings.ZipCode = ZipCode;
            settings.UseEnglishUnits = UseEnglishUnits;
            settings.Commute.TravelingBy = SelectedSelectedModeOfTransportation;

            _kernel.Get<IXmlHelper>().SaveSettingsXmlFile(settings);
            TryClose();
        }
    }
}