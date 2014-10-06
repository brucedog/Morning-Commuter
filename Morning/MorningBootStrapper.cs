using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows;
using BaseInterfaceLibrary.ViewModel;
using Caliburn.Micro;
using Ninject;
using View.Views;
using ViewModel.ViewModels;

namespace View
{
    public class MorningBootStrapper : Bootstrapper<IMainWindowViewModel>
    {
        protected override void Configure()
        {
            InitializeNinject();
            AssemblySource.Instance.AddRange(SelectAssemblies());
            Kernel.Get<IEventAggregator>().Subscribe(this);
        }

        protected override IEnumerable<Assembly> SelectAssemblies()
        {
            return new[]
            {
                Assembly.GetExecutingAssembly(),
                typeof(MainWindowViewModel).Assembly,
                typeof(MainWindowView).Assembly
            };
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            var config = new TypeMappingConfiguration
                             {
                                 DefaultSubNamespaceForViewModels = typeof(MainWindowViewModel).Namespace,
                                 DefaultSubNamespaceForViews = typeof(MainWindowView).Namespace
                             };

            ViewLocator.ConfigureTypeMappings(config);
            ViewModelLocator.ConfigureTypeMappings(config);
            
            base.OnStartup(sender, e);
        }
        
        /// <summary>
        /// Overrides default IoC behavior to use Ninject.
        /// </summary>
        /// <param name="service"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        protected override object GetInstance(Type service, string key)
        {
            return string.IsNullOrEmpty(key)
                ? Kernel.Get(service)
                : Kernel.Get(service, key);
        }
        
        /// <summary>
        /// Initializes the IoC container.
        /// </summary>
        private void InitializeNinject()
        {
            Kernel = new StandardKernel();
            Kernel.Load(new Registry.Registry());
            Kernel.Bind<IWindowManager>().To<WindowManager>().InSingletonScope();
            Kernel.Bind<IEventAggregator>().To<EventAggregator>().InSingletonScope();
        }

        /// <summary>
        /// Initializes Caliburn.Micro settings.
        /// </summary>
        //private void InitializeCaliburn()
        //{
        //    //Disable convention-based property bindings.
        //    ViewModelBinder.BindProperties = (e, t) => { return null; };
        //}

        private IKernel Kernel { get; set; }
    }
}