namespace BaseInterfaceLibrary.Services
{
    public interface IWeatherService
    {
        /// <summary>
        /// Gets the current weather.
        /// </summary>
        /// <param name="zipCode">The zip code.</param>
        /// <returns>json result from web service or empty string for no results</returns>
        string GetCurrentWeather(string zipCode);

        /// <summary>
        /// Gets the forecast by us zip code.
        /// </summary>
        /// <param name="zipCode">The zip code.</param>
        /// <returns>json result from web service or empty string for no results</returns>
        string GetForecastByUsZipCode(string zipCode);

        /// <summary>
        /// Gets the weather alerts.
        /// </summary>
        /// <param name="zipCode">The zipCode.</param>
        /// <returns>json result from web service or empty string for no results</returns>
        string GetWeatherAlerts(string zipCode);
    }
}