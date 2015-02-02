using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows;
using BaseInterfaceLibrary.ViewModel;
using Caliburn.Micro;
using Ninject;
using View.Views;
using ViewModel.ViewModels;

namespace View
{
    public class MorningBootStrapper : BootstrapperBase
    {
        public MorningBootStrapper()
        {
            Initialize();
        }

        protected override void Configure()
        {
            InitializeNinject();
            AssemblySource.Instance.AddRange(SelectAssemblies());
            Kernel.Get<IEventAggregator>().Subscribe(this);
        }

        protected override IEnumerable<Assembly> SelectAssemblies()
        {
            var baseAssemblies = new List<Assembly>(base.SelectAssemblies());
            var thisAssembly = Assembly.GetAssembly(typeof(MorningBootStrapper));
            
            if (!baseAssemblies.Contains(thisAssembly))
            {
                baseAssemblies.Add(thisAssembly);
            }

            foreach (var assembly in baseAssemblies.ToList().Where(newAssembly => AssemblySource.Instance.Contains(newAssembly)))
            {
                baseAssemblies.Remove(assembly);
            }

            return baseAssemblies;
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

            DisplayRootViewFor<IMainWindowViewModel>();
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

        private IKernel Kernel { get; set; }
    }
}