using System;
using BaseInterfaceLibrary.Model;
using BaseInterfaceLibrary.ViewModel;
using Model.Models;

namespace SampleViewModelData
{
    public class WeatherAlertViewModelSample : IWeatherAlertViewModel
    {
        private readonly IWeatherAlert _alert;

        public WeatherAlertViewModelSample()
        {
            _alert = new WeatherAlert(DateTime.Now.AddHours(2),"", DateTime.Now, "ETC", "Bad Weather","Weather Alert", "crap");
        }

        public string Title { get { return _alert.Title; } }

        public string Message { get { return _alert.Message; } }

        public string Type { get { return _alert.Type; } }

        public string ExpireTime { get { return _alert.Expire.ToShortTimeString(); } }

        public string TimeIssued { get { return _alert.Issued.ToShortTimeString(); } }
    }
}