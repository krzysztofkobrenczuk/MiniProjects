using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfView.Products;
using Microsoft.Practices.Unity;
using ProductInventory.Classes;

namespace WpfView
{
    public class MainWindowViewModel : BindableBase
    {

        private ProductListViewModel _productListViewModel;
        private AddEditProductViewModel _addEditViewModel;

        private BindableBase _CurrentViewModel;

        public MainWindowViewModel()
        {
            _productListViewModel = ContainerHelper.Container.Resolve<ProductListViewModel>();
            _addEditViewModel = ContainerHelper.Container.Resolve<AddEditProductViewModel>();

            NavCommand = new RelayCommand<string>(OnNav);

            _productListViewModel.AddProductRequested += NavToAddProduct;
            _productListViewModel.EditProductRequested += NavToEditProduct;
            _addEditViewModel.Done += NavToProductList;
         
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

        private void NavToAddProduct(Product prod)
        {
            _addEditViewModel.EditMode = false;
            _addEditViewModel.SetProduct(prod);
            CurrentViewModel = _addEditViewModel;
        }
        private void NavToEditProduct(Product prod)
        {
            _addEditViewModel.EditMode = true;
            _addEditViewModel.SetProduct(prod);
            CurrentViewModel = _addEditViewModel;
        }


        private void NavToProductList()
        {
            CurrentViewModel = _productListViewModel;
        }
        
    }
}
