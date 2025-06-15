using GastroSoft.Model;
using GastroSoft.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GastroSoft.Controllers
{
    public class SellController
    {
        private ProjectDBContext dbContext = new ProjectDBContext();

        public Sell Get(int id)
        {
            Sell findedSell = dbContext.Sells.Find(id);
            if (findedSell != null)
            {
                dbContext.Entry(findedSell).Reference(x => x.Users).Load();
                dbContext.Entry(findedSell).Reference(x => x.Products).Load();
            }
            return findedSell;
        }

        public List<Sell> GetAll() 
        { 
                return dbContext.Sells.Include("Products").Include("Users").ToList();
        }

        public void Create(Sell sell)
        {
            try
            {
                // Ensure Id is not set (auto increment)
                sell.Id = 0;
                
                dbContext.Sells.Add(sell);
                dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception($"Грешка при създаване на продажба: {ex.Message}", ex);
            }
        }

        public void Update(int id, Sell sell)
        {
            Sell findedSell = dbContext.Sells.Find(id);
            if (findedSell != null)
            {
                findedSell.Username = sell.Username;
                findedSell.ProductNumber = sell.ProductNumber;
                findedSell.Quantity = sell.Quantity;
                findedSell.TotalPrice = sell.TotalPrice;
                findedSell.DateOfSale = sell.DateOfSale;
                dbContext.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            Sell findedSell = dbContext.Sells.Find(id);
            if (findedSell != null)
            {
                dbContext.Sells.Remove(findedSell);
                dbContext.SaveChanges();
            }
        }
    }
}
