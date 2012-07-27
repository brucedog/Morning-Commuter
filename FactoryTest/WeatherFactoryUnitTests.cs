using System.Collections.Generic;
using BaseInterfaceLibrary.Factory;
using BaseInterfaceLibrary.Model;
using Factory;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FactoryTest
{
    [TestClass]
    public class WeatherFactoryUnitTests
    {
        [TestMethod]
        public void CreateDetailedWeatherBugModel()
        {
            IWeatherFactory weatherFactory = new WeatherFactory();
            IWeatherBug test =  weatherFactory.CreateWeatherBugDetailModel("15217", true);

            Assert.IsNotNull(test);
        }

        [TestMethod]
        public void CreateWeatherAlerts()
        {
            IWeatherFactory weatherFactory = new WeatherFactory();
            List<IWeatherAlert> alerts = weatherFactory.CreateWeatherAlerts("15217");

            Assert.IsNotNull(alerts);
        }

        [TestMethod]
        public  void CreateWeatherForecastList()
        {
            IWeatherFactory weatherFactory = new WeatherFactory();
            List<IWeatherForecast> results = weatherFactory.CreateWeatherForecastList("15217", true);

            Assert.IsTrue(results.Count > 0);
        }
    }
}
