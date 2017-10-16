using Prism.Modularity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using Prism.Regions;
using SportsStorePrism.Module.Products.Views;
using SportsstorePrism.Infrastucture;

namespace SportsStorePrism.Module.Products
{
    public class ProductsModule : IModule
    {
        IUnityContainer _container;
        IRegionManager _regionManager;
        public void Initialize()
        {
            var productView = _container.Resolve<ProductView>();
            _regionManager.Regions[RegionNames.ProductRegion].Add(productView);
        }
        public ProductsModule(IUnityContainer container, IRegionManager regionManager)
        {
            _container = container;
            _regionManager = regionManager;
        }
    }
}
