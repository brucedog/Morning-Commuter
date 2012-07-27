using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using BaseInterfaceLibrary.Model;
using BaseInterfaceLibrary.Services;
using Model.Models;
using Ninject;

namespace Services.Helper
{
    public class XmlHelper : IXmlHelper
    {
        private ISettings _settingsCache;
        private readonly string _target = Directory.GetCurrentDirectory() + "\\config.xml";
        private readonly IKernel _kernel;
        private const string Settings = "Settings";
        private const string ZipeCode = "ZipeCode";
        private const string TravelingFrom = "TravelingFrom";
        private const string TravlingTo = "TravelingTo";
        private const string UseEnglishUnits = "UseEnglishUnits";
        private const string TravlingBy = "TravlingBy";
        
        public XmlHelper(IKernel kernel)
        {
            _kernel = kernel;
            _settingsCache = _kernel.Get<ISettings>();
        }

        public ISettings LoadSettingsFromXmlFile()
        {
            if (_settingsCache.Commute != null
                && !string.IsNullOrWhiteSpace(_settingsCache.ZipCode))
                return _settingsCache;

            if (!DoesXmlFileExist())
            {
                _settingsCache = _kernel.Get<ISettings>();
                return _settingsCache;
            }

            using (XmlReader xmlTextReader = new XmlTextReader(_target))
            {
                _settingsCache = (from address in XDocument.Load(xmlTextReader).Elements(Settings)
                 select new Settings(_kernel)
                            {
                                ZipCode = address.Element(ZipeCode).Value,
                                UseEnglishUnits = address.Element(UseEnglishUnits).Value.Equals("True"),
                                Commute = new Commute
                                    {
                                        From = address.Element(TravelingFrom).Value,
                                        To = address.Element(TravlingTo).Value,
                                        TravelingBy = address.Element(TravlingBy).Value
                                    }                                
                            }).FirstOrDefault();                
            }

            return _settingsCache;
        }

        public void SaveSettingsXmlFile(ISettings settings)
        {
            if (DoesXmlFileExist())
            {
                File.Delete(_target);
            }

            using (XmlWriter xmlWriter = XmlWriter.Create(_target))
            {
                xmlWriter.WriteStartElement(Settings);
                xmlWriter.WriteElementString(ZipeCode, settings.ZipCode);
                xmlWriter.WriteElementString(TravelingFrom, settings.Commute.From);
                xmlWriter.WriteElementString(TravlingTo, settings.Commute.To);
                xmlWriter.WriteElementString(UseEnglishUnits, settings.UseEnglishUnits.ToString());
                xmlWriter.WriteElementString(TravlingBy, settings.Commute.TravelingBy);
                xmlWriter.WriteEndElement();
                xmlWriter.WriteEndDocument();
            }

            _settingsCache = settings;
        }

        private bool DoesXmlFileExist()
        {
            if (File.Exists(_target))
            {
                return true;
            }

            using (XmlWriter xmlWriter = XmlWriter.Create(_target))
            {
                xmlWriter.WriteStartElement(Settings);
                xmlWriter.WriteElementString(ZipeCode, string.Empty);
                xmlWriter.WriteElementString(TravelingFrom, string.Empty);
                xmlWriter.WriteElementString(TravlingTo, string.Empty);
                xmlWriter.WriteElementString(UseEnglishUnits, string.Empty);
                xmlWriter.WriteElementString(TravlingBy, string.Empty);
                xmlWriter.WriteEndElement();
                xmlWriter.WriteEndDocument();
            }

            return false;
        }
    }
}