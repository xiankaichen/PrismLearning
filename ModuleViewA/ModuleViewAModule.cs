using ModuleViewA.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace ModuleViewA
{
    public class ModuleViewAModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion("ContentRegionA", typeof(ViewA));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {   

        }
    }
}