using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Project11.Model;

namespace Project11.Models
{
    public class Sell
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Users")]
        public string Username
        {
            get;
            set;
        }
        public User Users { get; set; }

        [ForeignKey("Products")]
        public int ProductNumber
        {
            get;
            set;
        }
        public Product Products { get; set; }
    }
}
