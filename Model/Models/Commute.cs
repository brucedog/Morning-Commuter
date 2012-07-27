using System;
using BaseInterfaceLibrary.Model;

namespace Model.Models
{
    public class Commute : ICommute
    {
        public string From { get; set; }
       
        public string To { get; set; }

        public string TravelingBy { get; set; }

        public TimeSpan ArrivalTime { get; set; }

        public string[] Warnings { get; set; }
    }
}