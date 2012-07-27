using System;
using System.Linq;
using System.Text;
using BaseInterfaceLibrary.Model;
using BaseInterfaceLibrary.Services;
using GoogleMapsApi;
using GoogleMapsApi.Entities.Directions.Request;
using GoogleMapsApi.Entities.Directions.Response;
using Ninject;

namespace Services
{
    public class GoogleMapService : IGoogleMapService
    {
        private readonly IKernel _kernel;
        private ISettings _settings;

        public GoogleMapService(IKernel kernel)
        {
            _kernel = kernel;
        }

        private ISettings Settings { get { return _settings ?? (_settings = _kernel.Get<IXmlHelper>().LoadSettingsFromXmlFile()); } }

        public ICommute GetCommute()
        {
            ICommute commute = _kernel.Get<ICommute>();
            if (Settings == null
                || Settings.Commute == null
                || string.IsNullOrWhiteSpace(Settings.Commute.To)
                || string.IsNullOrWhiteSpace(Settings.Commute.From))
                return commute;
            
            DirectionsResponse directions = GoogleMaps.Directions.Query(new DirectionsRequest
            {
                Origin = Settings.Commute.From,
                Destination = Settings.Commute.To,
                TravelMode = GetTravelMode()
            });

            if(directions.Status == DirectionsStatusCodes.OK)
            {
                TimeSpan shortestTime = TimeSpan.MaxValue;
                foreach (Route route in directions.Routes)
                {
                    var tripTime = route.TripTime();
                    if (shortestTime > tripTime)
                    {
                        shortestTime = tripTime;
                        commute.Warnings = route.Warnings;
                    }                    
                }

                commute.To = Settings.Commute.To;
                commute.From = Settings.Commute.From;
                commute.TravelingBy = Settings.Commute.TravelingBy;
                commute.ArrivalTime = shortestTime;
            }
            
            return commute;
        }

        public string GetDirections()
        {
            if (Settings == null
                || Settings.Commute == null
                || string.IsNullOrWhiteSpace(Settings.Commute.To)
                || string.IsNullOrWhiteSpace(Settings.Commute.From))
                return string.Empty;

            DirectionsResponse directions = GoogleMaps.Directions.Query(new DirectionsRequest
            {
                Origin = Settings.Commute.From,
                Destination = Settings.Commute.To,
                TravelMode = GetTravelMode()
            });

            if (directions.Status == DirectionsStatusCodes.OK)
            {
                
                TimeSpan shortestTime = TimeSpan.MaxValue;
                Route shortestRoute = new Route();
                foreach (Route route in directions.Routes)
                {
                    var tripTime = route.TripTime();
                    if (shortestTime > tripTime)
                    {
                        shortestRoute = route;
                        shortestTime = tripTime;
                    }
                }

                StringBuilder htmlDirections = new StringBuilder();
                int counter = 1;
                foreach (Step step in shortestRoute.Legs.SelectMany(leg => leg.Steps))
                {
                    htmlDirections.AppendLine(string.Format("{0}: {1} <br />", counter, step.HtmlInstructions));
                    counter++;
                }

                return htmlDirections.ToString();
            }

            return string.Empty;
        }

        private TravelMode GetTravelMode()
        {
            switch (Settings.Commute.TravelingBy.ToLower())
            {
                case "car":
                    return TravelMode.Driving;
                case "bike" :
                    return TravelMode.Bicycling;
                case "transit":
                    return TravelMode.Transit;
                case "walk":
                    return TravelMode.Walking;
                default:
                    return TravelMode.Driving;
            }
        }
    }
}