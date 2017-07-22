using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductInventory.Classes;
using System.Data.Entity;

namespace ProductInventory.DataModel
{
    public class CategoryRepository : ICategoryRepository
    {
        AppDbContext _context = new AppDbContext();

        public async Task<Category> AddCategoryAsync(Category category)
        {
            _context.Categories.Add(category);
            await _context.SaveChangesAsync();
            return category;
        }

        public async Task<List<Category>> GetAllCategoriesAsync()
        {
            return await _context.Categories.ToListAsync();
        }

        public async Task<List<Product>> GetProductsAsync()
        {
            return await _context.Products.ToListAsync();
            
        }

        public async Task<Category> UpdateCategoryAsync(Category category)
        {
            if(!_context.Categories.Local.Any(c => c.CategoryId == category.CategoryId))
            {
                _context.Categories.Attach(category);
            }
            _context.Entry(category).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return category;
        }
    }
}
