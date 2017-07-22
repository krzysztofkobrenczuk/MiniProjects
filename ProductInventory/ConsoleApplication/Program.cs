using ProductInventory.Classes;
using ProductInventory.DataModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new NullDatabaseInitializer<AppDbContext>());

            InsertProduct();
            Console.ReadKey();
        }

        private static void InsertProduct()
        {
            var product = new Product
            {
                Name = "Krzesło",
                Description = "Malowane krzeslo",
                Price = 22,
                CategoryId = 1,

            };

            using (var context = new AppDbContext())
            {
                context.Database.Log = Console.WriteLine;
                context.Products.Add(product);
                context.SaveChanges();
            }
        }
    }
}
