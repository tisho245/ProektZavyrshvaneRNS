using Project11.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project11.Controllers
{
    public class ProductTypeController
    {
        private ProjectDBContext dbContext = new ProjectDBContext();
        
        public ProductType Get(int productTypeId)
        {
            ProductType findedProductType = dbContext.ProductTypes.Find(productTypeId);
            return findedProductType;
        }
        
        public List<ProductType> GetAll()
        {
            return dbContext.ProductTypes.ToList();
        }

        public void Create(ProductType productType)
        {
            dbContext.ProductTypes.Add(productType);
            dbContext.SaveChanges();
        }
        
        public void Update(int productTypeId, ProductType productType)
        {
            ProductType findedProductType = dbContext.ProductTypes.Find(productTypeId);
            if (findedProductType != null)
            {
                findedProductType.ProductTypeName = productType.ProductTypeName;
                dbContext.SaveChanges();
            }
        }

        public void Delete(int productTypeId)
        {
            ProductType findedProductType = dbContext.ProductTypes.Find(productTypeId);
            if (findedProductType != null)
            {
                dbContext.ProductTypes.Remove(findedProductType);
                dbContext.SaveChanges();
            }
        }
    }
}
