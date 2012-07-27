using BaseInterfaceLibrary.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ninject;
using Services;

namespace ServiceTests
{
    [TestClass]
    public class GoogleWeatherServiceUnitTests
    {
        [TestMethod]
        public void GoogleWeatherServiceGetsCurrentWeatherConditions()
        {
            IKernel kernel = new StandardKernel();
            kernel.Load(new Registry.Registry());
            ISettings settings = kernel.Get<ISettings>();
            settings.ZipCode = "15217";

            GoogleWeatherService sut = new GoogleWeatherService(kernel);
            Assert.IsNotNull(sut.GetWeather());
        }
    }
}
