namespace BaseInterfaceLibrary.Model
{
    public interface IWeather : IWeatherBase
    {
        string Humidity { get; set; }

        string FeelsLikeF { get; set; }

        string FeelsLikeC { get; set; }
        
        string Condition { get; set; }

        string CurrentTempC { get; set; }

        string HeatIndexF { get; set; }

        string HeatIndexC { get; set; }

        string WindChillF { get; set; }

        string WindChillC { get; set; }

        string PrecipToday { get; set; }
    }
}