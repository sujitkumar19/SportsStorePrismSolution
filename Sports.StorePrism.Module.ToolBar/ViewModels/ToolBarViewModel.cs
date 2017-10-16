using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports.StorePrism.Module.ToolBar.ViewModels
{
    public class ToolBarViewModel:BindableBase
    {
        public ToolBarViewModel()
        {
            NavigateToAddEditProductViewCommand = new DelegateCommand(OnNavigateToAddEditProduct);

        }

        private void OnNavigateToAddEditProduct()
        {
            throw new NotImplementedException();
        }

        //NavigateToAddEditProductViewCommand
        public DelegateCommand NavigateToAddEditProductViewCommand { get; set; }
    }
}
