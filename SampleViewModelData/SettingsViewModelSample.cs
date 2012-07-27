using System;
using System.Collections.Generic;
using BaseInterfaceLibrary;
using BaseInterfaceLibrary.ViewModel;

namespace SampleViewModelData
{
    public class SettingsViewModelSample : ISettingsViewModel
    {
        public SettingsViewModelSample()
        {
            StartAddress = "123 count street";
            EndAddress = "8 end street";
            ZipCode = "15211";
            UseEnglishUnits = true;
            SelectedSelectedModeOfTransportation = "Walk";
        }

        public string StartAddress { get; set; }
        
        public string EndAddress { get; set; }
        
        public string ZipCode { get; set; }

        public bool UseEnglishUnits { get; set; }

        public string SelectedSelectedModeOfTransportation { get; set; }

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
    }
}