using BaseInterfaceLibrary.Model;

namespace BaseInterfaceLibrary.Services
{
    public interface IXmlHelper
    {
        ISettings LoadSettingsFromXmlFile();

        void SaveSettingsXmlFile(ISettings settings);
    }
}