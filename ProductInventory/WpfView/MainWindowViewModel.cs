using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfView.Products;
using Microsoft.Practices.Unity;

namespace WpfView
{
    public class MainWindowViewModel : BindableBase
    {

        private ProductListViewModel _productListViewModel;

        private BindableBase _CurrentViewModel;

        public MainWindowViewModel()
        {
            _productListViewModel = ContainerHelper.Container.Resolve<ProductListViewModel>();
            NavCommand = new RelayCommand<string>(OnNav);
         
        }

        public BindableBase CurrentViewModel
        {
            get { return _CurrentViewModel; }
            set { SetProperty(ref _CurrentViewModel, value); }

        }
        public RelayCommand<string> NavCommand { get; private set; }
        private void OnNav(string destination)
        {
            switch (destination)
            {
                case "products":
                    CurrentViewModel = _productListViewModel;
                    break;
            }
        }

        private void NavToProductList()
        {
            CurrentViewModel = _productListViewModel;
        }
        
    }
}
