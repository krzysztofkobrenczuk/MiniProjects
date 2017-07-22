using ProductInventory.Classes;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInventory.DataModel
{
    public class DataHelper
    {
        public static void NewDoWithSeed()
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<AppDbContext>());
            using (var context = new AppDbContext())
            {
                if (context.Products.Any())
                {
                    return;
                }
                var Meble = context.Categories.Add(new Category { CategoryName = "Meble" });
                var Zabawki = context.Categories.Add(new Category { CategoryName = "Zabawki" });
            }
        }
    }
}
