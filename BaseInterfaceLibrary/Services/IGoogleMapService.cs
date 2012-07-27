using BaseInterfaceLibrary.Model;

namespace BaseInterfaceLibrary.Services
{
    public interface IGoogleMapService
    {
        ICommute GetCommute();
        
        string GetDirections();
    }
}