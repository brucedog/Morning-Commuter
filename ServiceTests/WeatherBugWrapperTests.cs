using Services.WeatherBugWebService;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ServiceTests
{
    [TestClass]
    public class WeatherBugWrapperTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            WeatherBugWebServices sut = new WeatherBugWebServices();
            var results = sut.GetLiveCompactWeatherByUSZipCode("15217", UnitType.English, "A6338994343");

            Assert.IsNotNull(results.City);
        }
    }
}
