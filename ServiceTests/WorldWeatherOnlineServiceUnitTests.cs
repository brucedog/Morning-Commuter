using BaseInterfaceLibrary.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ninject;
using Services;

namespace ServiceTests
{
    [TestClass]
    public class WorldWeatherOnlineServiceUnitTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            IKernel kernel = new StandardKernel();
            kernel.Load(new Registry.Registry());
            ISettings settings = kernel.Get<ISettings>();
            settings.ZipCode = "15217";

            WorldWeatherOnlineService sut = new WorldWeatherOnlineService();

            var result = sut.GetCurrentWeather(settings.ZipCode);

            Assert.IsNotNull(result);
        }
    }
}
