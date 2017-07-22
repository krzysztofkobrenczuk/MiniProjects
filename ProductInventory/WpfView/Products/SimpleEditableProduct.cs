using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfView.Products
{
    public class SimpleEditableProduct : ValidatableBindableBase 
    {
        private int _id;
        public int Id
        {
            get { return _id; }
            set { SetProperty(ref _id, value); }
        }

        private string _name;
        [Required]
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }
        private string _description;
        [Required]
        public string Description
        {
           get { return _description; }
           set { SetProperty(ref _description, value); }
        }
        private decimal _price;
        [Required]
        public decimal Price
        {
            get { return _price; }
            set { SetProperty(ref _price, value); }
        }

        private int _categoryId;
        public int CategoryId
        {
            get { return _categoryId; }
            set { SetProperty(ref _categoryId, value); }
        }
    }
}
