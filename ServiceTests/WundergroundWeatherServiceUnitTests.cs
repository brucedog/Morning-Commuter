using BaseInterfaceLibrary.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ninject;
using Services;

namespace ServiceTests
{
    [TestClass]
    public class WundergroundWeatherServiceUnitTests
    {
        [TestMethod]
        public void WundergroundWeatherServiceReturnsWeatherObject()
        {
            IKernel kernel = new StandardKernel();
            kernel.Load(new Registry.Registry());
            ISettings settings = kernel.Get<ISettings>();
            settings.ZipCode = "15217";

            WundergroundWeatherService sut = new WundergroundWeatherService(kernel);
            Assert.IsNotNull(sut.GetWeather());
        }
    }
}
