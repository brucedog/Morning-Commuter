using System.Collections.Generic;

namespace BaseInterfaceLibrary.ViewModel
{
    public interface ISettingsViewModel
    {
        string StartAddress { get; set; }

        string EndAddress { get; set; }

        string ZipCode { get; set; }

        bool UseEnglishUnits { get; set; }

        string SelectedSelectedModeOfTransportation { get; set; }
        
        List<string > ModesOfTransportation { get; }
    }
}