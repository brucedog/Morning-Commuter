namespace BaseInterfaceLibrary.Model
{
    public interface IWeatherForecast : IBaseModel
    {
        string Description { get; }

        string HighTemperature { get; }

        string LowTemperature { get; }

        string Predicition { get; }

        string Day { get; }
    }
}