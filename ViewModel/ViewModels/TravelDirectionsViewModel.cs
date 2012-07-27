using System.Windows.Controls;
using System.Windows.Documents;
using BaseInterfaceLibrary.Services;
using BaseInterfaceLibrary.ViewModel;
using Caliburn.Micro;
using Ninject;

namespace ViewModel.ViewModels
{
    public class TravelDirectionsViewModel : Screen, ITravelDirectionsViewModel
    {
        private readonly IKernel _kernel;
        private string _webAddress;

        public TravelDirectionsViewModel(IKernel kernel)
        {
            DisplayName = "Directions";
            _kernel = kernel;
        }

        public void CloseCommand()
        {
            TryClose();
        }

        public void PrintCommand()
        {
            PrintDialog printDlg = new PrintDialog();
            FlowDocument doc = new FlowDocument(new Paragraph(new Run(WebAddress))) {Name = "Directions"};
            IDocumentPaginatorSource idpSource = doc;
            printDlg.PrintDocument(idpSource.DocumentPaginator, "Directions Printing.");  
        }

        public string WebAddress
        {
            get
            {
                return string.IsNullOrWhiteSpace(_webAddress) ? 
                    (_webAddress = _kernel.Get<IGoogleMapService>().GetDirections()) : _webAddress;
            }
        }
    }
}