namespace BaseInterfaceLibrary.ViewModel
{
    public interface IWeatherAlertViewModel
    {
        string Title { get; }
        
        string Message { get; }
        
        string Type { get; }
        
        string ExpireTime { get; }
        
        string TimeIssued { get; }
    }
}