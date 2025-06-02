using Project11.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project11.Model
{
    public class ProjectDBContext:DbContext
    {
        public ProjectDBContext() :base("FoodShop")
        {

        }
        public DbSet<Product> Products 
        {
            get;
            set;
        }
        public DbSet<ProductType> ProductTypes 
        {
            get;
            set;
        }
        public DbSet<User> Users
        {
            get;
            set;
        }
        public DbSet<Sell> Sells
        {
            get;
            set;
        }
    }
}
