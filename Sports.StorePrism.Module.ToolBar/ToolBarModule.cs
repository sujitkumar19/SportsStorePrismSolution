using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Regions;
using Sports.StorePrism.Module.ToolBar.Views;
using SportsstorePrism.Infrastucture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports.StorePrism.Module.ToolBar
{
    public class ToolBarModule:IModule

    {
        
        private IUnityContainer _container;
        private IRegionManager _regionManager;

        public ToolBarModule(IUnityContainer container,IRegionManager regionManager)
        {
            _container = container;
            _regionManager = regionManager;
        }
        public void Initialize()
        {
            var toolBarView = _container.Resolve<ToolBarView>();
            _regionManager.Regions[RegionNames.ToolbarRegion].Add(toolBarView);
        }
    }
}
