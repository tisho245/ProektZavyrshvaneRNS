using Project11.Model;
using Project11.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project11.Controllers
{
    public class UserController
    {
        private ProjectDBContext dbContext = new ProjectDBContext();
        
        public User Get(string username)
        {
            User findedUser = dbContext.Users.Find(username);
            return findedUser;
        }
        
        public List<User> GetAll()
        {
            return dbContext.Users.ToList();
        }

        public void Create(User user)
        {
            dbContext.Users.Add(user);
            dbContext.SaveChanges();
        }
        
        public void Update(string username, User user)
        {
            User findedUser = dbContext.Users.Find(username);
            if (findedUser != null)
            {
                findedUser.Email = user.Email;
                findedUser.Password = user.Password;
                findedUser.FirstName = user.FirstName;
                findedUser.LastName = user.LastName;
                findedUser.Role = user.Role;
                dbContext.SaveChanges();
            }
        }

        public void Delete(string username)
        {
            User findedUser = dbContext.Users.Find(username);
            if (findedUser != null)
            {
                dbContext.Users.Remove(findedUser);
                dbContext.SaveChanges();
            }
        }
    }
}
