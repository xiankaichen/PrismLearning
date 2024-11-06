using NavigationView.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace NavigationView
{
    public class NavigationViewModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            // 注入视和content
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion("ContentRegion", typeof(ViewNavigation));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<ViewA>("PageA");
            containerRegistry.RegisterForNavigation<ViewB>("PageB");
        }

    }
}