using Project11.Model;
using Project11.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project11.Controllers
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
            return dbContext.Sells.Include("Users").Include("Products").ToList();
        }

        public void Create(Sell sell)
        {
            dbContext.Sells.Add(sell);
            dbContext.SaveChanges();
        }

        public void Update(int id, Sell sell)
        {
            Sell findedSell = dbContext.Sells.Find(id);
            if (findedSell != null)
            {
                findedSell.Username = sell.Username;
                findedSell.ProductNumber = sell.ProductNumber;
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
