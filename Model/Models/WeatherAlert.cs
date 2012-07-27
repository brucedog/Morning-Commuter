using System;
using BaseInterfaceLibrary.Model;

namespace Model.Models
{
    public class WeatherAlert : IWeatherAlert
    {
        public WeatherAlert(DateTime expire, string expireTimeZone, DateTime issued, 
            string issuedZone, string message, string title, string type)
        {
            Expire = expire;
            ExpireTimeZone = expireTimeZone;
            Issued = issued;
            IssuedZone = issuedZone;
            Message = message;
            Title = title;
            Type = type;
        }

        public DateTime Expire { get; private set; }
        
        public string ExpireTimeZone { get; private set; }
        
        public DateTime Issued { get; private set; }
        
        public string IssuedZone { get; private set; }
        
        public string Message { get; private set; }
        
        public string Title { get; private set; }
        
        public string Type { get; private set; }
    }
}