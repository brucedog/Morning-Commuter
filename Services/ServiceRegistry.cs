using BaseInterfaceLibrary.Model;
using Ninject.Modules;

namespace Services
{
    public class ServiceRegistry : NinjectModule
    {
        public override void Load()
        {
            Bind<WeatherBugWebService.WeatherBugWebServices>().To<WeatherBugWebService.WeatherBugWebServices>().InSingletonScope();
        }
    }
}