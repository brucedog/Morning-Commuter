using BaseInterfaceLibrary.Model;
using Ninject;

namespace Model.Models
{
    public class Settings : ISettings
    {
        private ICommute _commute;
        private readonly IKernel _kernel;

        public Settings(IKernel kernel)
        {
            _kernel = kernel;
        }

        public ICommute Commute
        {
            get { return _commute ?? (_commute = _kernel.Get<ICommute>()); }
            set { _commute = value; }
        }

        public string ZipCode { get; set; }

        public bool UseEnglishUnits { get; set; }
    }
}