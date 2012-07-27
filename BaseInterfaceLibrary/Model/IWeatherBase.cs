namespace BaseInterfaceLibrary.Model
{
    public interface IWeatherBase : IBaseModel
    {
        string CurrentTemperature { get; set; }

        string HighTemperatureForToday { get; set; }

        string LowTemperatureForToday { get; set; }

        string CurrentWeatherSummary { get; set; }
    }
}