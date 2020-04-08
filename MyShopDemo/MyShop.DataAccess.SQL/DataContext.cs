using MyShop.Core.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.DataAccess.SQL
{
    public class DataContext : DbContext
    {
        public DataContext ()
        
            //will look for the default cnnection in the connection string configuration 
            // file in the webconfig file
            : base("DefaultConnection")
        {

        }
        // this sets the db framework based on the classes/objects
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }

            
        
    }
}
