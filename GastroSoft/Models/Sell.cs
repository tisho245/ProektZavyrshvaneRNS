using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GastroSoft.Model;

namespace GastroSoft.Models
{
    public class Sell
    {
        private int id;
        [Key]
        public int Id 
        {
            get 
            {
                return id; 
            }
            set 
            {
                id = value; 
            } 
        }

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

        private DateTime dateOfSale;
        [Required(ErrorMessage = "Датата е задължителна")]
        [DataType(DataType.DateTime)]
        [Display(Name = "Дата на продажба")]
        public DateTime DateOfSale 
        {
            get
            {
                return dateOfSale; 
            }
            set 
            {
                dateOfSale = value; 
            } 
        }

        private int quantity;
        [Required(ErrorMessage = "Количеството е задължително")]
        [Range(1, int.MaxValue, ErrorMessage = "Количеството трябва да бъде положително число")]
        [Display(Name = "Количество")]
        public int Quantity 
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value; 
            } 
        }

        private decimal totalPrice;
        [Required(ErrorMessage = "Цената е задължителна")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Цената трябва да бъде положително число")]
        [Display(Name = "Цена")]
        public decimal TotalPrice 
        {
            get 
            {
                return totalPrice; 
            }
            set
            {
                totalPrice = value;
            }
        }
        private SaleStatus status=SaleStatus.Processing;
        [Required]
        [Display(Name = "Статус")]
        public SaleStatus Status 
        {
            get { return status; }
            set { status = value; } 
        }
    }

    public enum SaleStatus
    {
        Processing = 0,
        Completed = 1,
        Cancelled = 2
    }
}
