using NavigationApp.Views;
using Prism.Ioc;
using System.Windows;
using NavigationView;
using NavigationView.Views;
using Prism.Modularity;

namespace NavigationApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            //containerRegistry.RegisterForNavigation<ViewA>("PageA");
            //containerRegistry.RegisterForNavigation<ViewB>("PageB");

        }

        // 模块的设置是相同的，不同是不同视图注入方式有不同的调用代码
        // 模块的注入方式有四种方式：代码方式、目录方式、配置文件方式、XAML方式

        protected override IModuleCatalog CreateModuleCatalog()
        {
            return new DirectoryModuleCatalog() { ModulePath = @"./" };
        }
    }
}
