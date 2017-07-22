﻿using ProductInventory.Classes;
using ProductInventory.DataModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfView.Products
{
    class ProductListViewModel : BindableBase
    {
        private IProductRepository _repo;
        private List<Product> _allProducts;

        public ProductListViewModel(IProductRepository repo)
        {
            _repo = repo;

        }

        private ObservableCollection<Product> _products;

        public ObservableCollection<Product> Products
        {
            get { return _products; }
            set { SetProperty(ref _products, value); }
        }
        private string _SearchInput;
        public string SearchInput
        {
            get { return _SearchInput; }
            set
            {
                SetProperty(ref _SearchInput, value);
                FilterCustomers(_SearchInput);
            }
        }

        private void FilterCustomers(string searchInput)
        {
            if (string.IsNullOrWhiteSpace(searchInput))
            {
                Products = new ObservableCollection<Product>(_allProducts);
                return;
            }
            else
            {
                Products = new ObservableCollection<Product>(_allProducts.Where(c => c.Name.ToLower().Contains(searchInput.ToLower())));
            }
        }

        public async void LoadProducts()
        {
            _allProducts = await _repo.GetProductsAsync();
            Products = new ObservableCollection<Product>(_allProducts);
        }

        private void OnClearSearch()
        {
            SearchInput = null;
        }
        
    }
}
