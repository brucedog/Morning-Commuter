using System.Collections.Generic;
using BaseInterfaceLibrary.Model;

namespace BaseInterfaceLibrary.ViewModel
{
    public interface ITravelViewModel
    {
        ICommute Commute { get; set; }
        
        string CurrentTime { get; }

        string From { get; }
        
        string To { get; }

        string TravelingBy { get; }

        string ExceptedArrivalTime { get; }

        bool UseEnglishUnits { get; set; }
        
        bool HasWarnings { get; }

        List<string> Warnings { get; }
    }
}