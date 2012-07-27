using System;

namespace BaseInterfaceLibrary.Model
{
    public interface ICommute : IBaseModel
    {
        string From { get; set; }

        string To { get; set; }

        string TravelingBy { get; set; }
        
        TimeSpan ArrivalTime { get; set; }
        
        string[] Warnings { get; set; }
    }
}