using System;
using System.IO;
using System.Net;
using System.Text;
using BaseInterfaceLibrary.Services;

namespace Services
{
    public abstract class WeatherServiceBase : IWeatherService
    {
        protected string MakeWebRequest(string url)
        {
            string result = string.Empty;   
            try
            {
                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;

                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);

                        return reader.ReadToEnd();
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

            return result;
        }

        public abstract string GetCurrentWeather(string zipCode);

        public abstract string GetForecastByUsZipCode(string zipCode);

        public abstract string GetWeatherAlerts(string zipCode);
    }
}