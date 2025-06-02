using Project11.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project11.Controllers
{
    public class ProductController
    {
        private ProjectDBContext dbContext = new ProjectDBContext();
        public Product Get(int productId)
        {
            Product findedProduct = dbContext.Products.Find(productId);
            if (findedProduct != null)
                dbContext.Entry(findedProduct).Reference(x => x.ProductTypes).Load();
            
            return findedProduct;
        }
        public List<Product> GetAll() 
        {
            return dbContext.Products.Include("ProductTypes").ToList();
        }

        public void Create(Product product) 
        {
            dbContext.Products.Add(product);
            dbContext.SaveChanges();
        }
        public void Update(int productId, Product product) 
        {
            Product findedProduct = dbContext.Products.Find(productId);
            if (findedProduct != null)
                dbContext.Entry(findedProduct).Reference(x => x.ProductTypes).Load();
       
            findedProduct.ProductTypeNumber = product.ProductTypeNumber;
            findedProduct.ExpirationDate=product.ExpirationDate;
            findedProduct.Price = product.Price;
            findedProduct.Brand = product.Brand;
            findedProduct.Description = product.Description;
            dbContext.SaveChanges();
        }

        public void Delete(int productId) 
        {
            Product findedProduct = dbContext.Products.Find(productId);
            if (findedProduct != null)
                dbContext.Entry(findedProduct).Reference(x => x.ProductTypes).Load();
           
            dbContext.Products.Remove(findedProduct);
            dbContext.SaveChanges();
        }
    }
}
