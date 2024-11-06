using ModuleCatalog.Views;
using Prism.Ioc;
using Prism.Modularity;
using System;
using System.Windows;

namespace ModuleCatalog
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

        }

        // 模块的设置是相同的，不同是不同视图注入方式有不同的调用代码
        // 模块的注入方式有四种方式：代码方式、目录方式、配置文件方式、XAML方式


        //  1.配置文件方式注入模块ModuleA，需要一个配置文件App.config，推荐，注意：不需要将App.xaml.cs文件的生成操作设置为Resource
        //protected override IModuleCatalog CreateModuleCatalog()
        //{
        //    return new ConfigurationModuleCatalog(); //目录创建于配置文件
        //}


        // 2.XAML方式导入，需要一个配置文件ModuleCatalog.xaml，不推荐，需要将ModuleCatalog.xaml文件的生成操作设置为Resource，否则报错
        //protected override IModuleCatalog CreateModuleCatalog()
        //{
        //    return new XamlModuleCatalog(new Uri("/ModuleCatalog;component/ModuleCatalog.xaml", UriKind.Relative));
        //}


        // 3.目录方式导入，不需要配置文件，推荐
        protected override IModuleCatalog CreateModuleCatalog()
        {
            return new DirectoryModuleCatalog() { ModulePath = @"./" };
        }

        // 4.代码方式注入模块ModuleA，不需要配置文件，可推荐，但注意引入项目以来
        //protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        //{
        //    moduleCatalog.AddModule<ModuleA.ModuleAModule>();
        //    moduleCatalog.AddModule<ModuleB.ModuleBModule>();
        //}

        // 5. 手动加载，可实现动态加载

    }

}
