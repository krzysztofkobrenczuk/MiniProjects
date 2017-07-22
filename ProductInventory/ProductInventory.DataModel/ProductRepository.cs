using ProductInventory.Classes;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace ProductInventory.DataModel
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _context = new AppDbContext();

        public async Task<Product> AddProductAsync(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return product;
        }

        public async Task DeleteProductAsync(int id)
        {
            var product = _context.Products.FirstOrDefault(p => p.Id == id);
            if(product != null)
            {
                _context.Products.Remove(product);
            }
            await _context.SaveChangesAsync();
        }

        public Task<Product> GetProductAsync(int id)
        {
            return _context.Products.FirstOrDefaultAsync(p => p.Id == id); 
        }

        public Task<List<Product>> GetProductsAsync()
        {
            return _context.Products.ToListAsync();
        }

        public async Task<List<Product>> GetProductsByCategory(int categoryId)
        {
            return await _context.Products.Where(p => p.CategoryId == categoryId).ToListAsync();
        }
        public async Task<Product> UpdateProductAsync(Product product)
        {
             if(!_context.Products.Local.Any(p => p.Id == product.Id))
            {
                _context.Products.Attach(product);
            }
            _context.Entry(product).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return product;
        }

        
    }
}
