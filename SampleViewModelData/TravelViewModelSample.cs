using System;
using System.Collections.Generic;
using BaseInterfaceLibrary.Model;
using BaseInterfaceLibrary.ViewModel;
using Model.Models;

namespace SampleViewModelData
{
    public class TravelViewModelSample : ITravelViewModel
    {
        public TravelViewModelSample()
        {
            Commute = new Commute
                      {
                          From = "From: 810 River road",
                          To = "To: 810 test street",
                          TravelingBy = "Car"
                      };           
        }
        public bool UseEnglishUnits { get; set; }

        public ICommute Commute { get; set; }

        public string From { get { return "From: " + Commute.From; } }

        public string To { get { return "To: " + Commute.To; } }

        public string TravelingBy { get { return "Traveling by: " + Commute.TravelingBy; } }

        public string ExceptedArrivalTime { get { return "Excepted arrival time" + Commute.ArrivalTime; } }

        public string CurrentTime { get { return DateTime.Now.ToShortTimeString(); } }

        public bool HasWarnings { get; set; }

        public List<string> Warnings { get; set; }
    }
}