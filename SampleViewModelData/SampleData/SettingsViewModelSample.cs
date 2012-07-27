using System.Windows;
using BaseInterfaceLibrary.ViewModel;

namespace View.SampleData
{
    public class SettingsViewModelSample : ISettingsViewModel
    {
        public SettingsViewModelSample()
        {
            Visibility = Visibility.Hidden;            
        }

        public Visibility Visibility { get; set; }        
    }
}