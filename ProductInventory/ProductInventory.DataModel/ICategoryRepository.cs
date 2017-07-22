using ProductInventory.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInventory.DataModel
{
    public interface ICategoryRepository
    {
        Task<Category> AddCategoryAsync(Category category);
        Task<Category> UpdateCategoryAsync(Category category);
        Task<List<Category>> GetAllCategoriesAsync();


        Task<List<Product>> GetProductsAsync();

        
    }
}
