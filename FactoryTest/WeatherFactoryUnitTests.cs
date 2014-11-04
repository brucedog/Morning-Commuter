using System.Collections.Generic;
using BaseInterfaceLibrary.Factory;
using BaseInterfaceLibrary.Model;
using Factory;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ninject;

namespace FactoryTest
{
    [TestClass]
    public class WeatherFactoryUnitTests
    {
        private StandardKernel _kernel;

        [TestInitialize]
        public void Setup()
        {
            _kernel = new StandardKernel();
            _kernel.Load(new Registry.Registry());
            ISettings settings = _kernel.Get<ISettings>();
            settings.ZipCode = "15217";
        }

        [TestMethod]
        public void CreateWeather()
        {
            IWeatherFactory weatherFactory = new WeatherFactory(_kernel);
            IWeather alerts = weatherFactory.CreateCurrentWeather("15217", true);

            Assert.IsNotNull(alerts);
        }

        [TestMethod]
        public void CreateWeatherAlerts()
        {
            IWeatherFactory weatherFactory = new WeatherFactory(_kernel);
            List<IWeatherAlert> alerts = weatherFactory.CreateWeatherAlerts("15217");

            Assert.IsNotNull(alerts);
        }

        [Ignore]
        [TestMethod]
        public  void CreateWeatherForecastList()
        {
            IWeatherFactory weatherFactory = new WeatherFactory(_kernel);
            List<IWeatherForecast> results = weatherFactory.CreateWeatherForecastList("15217", true);

            Assert.IsTrue(results.Count > 0);
        }
    }
}
