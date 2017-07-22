using ProductInventory.Classes;
using ProductInventory.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfView.Products
{
    public class AddEditProductViewModel : BindableBase
    {
        private IProductRepository _repo;

        public AddEditProductViewModel(IProductRepository repo)
        {
            _repo = repo;
            CancelCommand = new RelayCommand(OnCancel);
            SaveCommand = new RelayCommand(OnSave, CanSave);
        }

        private bool _EditMode;
        public bool EditMode
        {
            get { return _EditMode; }
            set { SetProperty(ref _EditMode, value); }
        }
        private SimpleEditableProduct _Product;
        public SimpleEditableProduct Product
        {
          get { return _Product; }
            set { SetProperty(ref _Product, value); }
        }
        public Product _editingProduct = null;

        public void SetProduct(Product prod)
        {
            _editingProduct = prod;
            if (Product != null) Product.ErrorsChanged -= RaiseCanExecuteChanged;
            Product = new SimpleEditableProduct();
            Product.ErrorsChanged += RaiseCanExecuteChanged;
            CopyProduct(prod, Product);
        }

        private void RaiseCanExecuteChanged(object sender, EventArgs e)
        {
            SaveCommand.RaiseCanExecuteChanged();
        }

        public RelayCommand CancelCommand { get; private set; }
        public RelayCommand SaveCommand { get; private set; }

        public event Action Done = delegate { };

        private void OnCancel()
        {
            Done();
        }
        private async void OnSave()
        {
            UpdateProduct(Product, _editingProduct);
            if (EditMode)
                await _repo.UpdateProductAsync(_editingProduct);
            else
                await _repo.AddProductAsync(_editingProduct);
            Done();
        }

        private void UpdateProduct(SimpleEditableProduct source, Product target)
        {
            target.Name = source.Name;
            target.Description = source.Description;
            target.Price = source.Price;
            target.CategoryId = source.CategoryId;
        }

        private bool CanSave()
        {
            return !Product.HasErrors;
        }

        private void CopyProduct(Product source, SimpleEditableProduct target)
        {
            target.Id = source.Id;
            if (EditMode)
            {
                target.Name = source.Name;
                target.Description = source.Description;
                target.Price = source.Price;
                target.CategoryId = source.CategoryId;
            }
        }


    }
}
