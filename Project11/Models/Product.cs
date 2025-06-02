using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace Project11.Model
{
    public class Product
    {
        private int projectNumber;
        [Key]
        public int ProjectNumber
        {
            get 
            {
                return projectNumber; 
            }
            set 
            {
                projectNumber = value; 
            }
        }
        private string brand;
        public string Brand
        {
            get 
            {
                return brand; 
            }
            set 
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)) 
                    throw new ArgumentNullException("Не сте въвели име на бранда.");
                
                else if (value.Length < 3)
                    throw new ArgumentException("Името на бранда трябва да е поне 3 символа.");

                else if (value.Length > 50)
                    throw new ArgumentException("Името на бранда не може да надвишава 50 символа.");

                else if (value.Any(char.IsDigit))
                    throw new ArgumentException("Името на бранда не трябва да съдържа цифри.");

                brand = value; 
            }
        }
        private string description;
        public string Description
        {
            get 
            {

                return description; 
            }
            set 
            {
                if (value != null)
                {
                    if (value.Length < 10)
                        throw new ArgumentException("Описанието трябва да съдържа поне 10 символа.");

                    if (value.Length > 1000)
                        throw new ArgumentException("Описанието не може да надвишава 1000 символа.");

                    if (!value.Any(char.IsLetter))
                        throw new ArgumentException("Описанието трябва да съдържа поне една буква.");
                }

                description = value; 
            }
        }
        private decimal price;
        public decimal Price
        {
            get 
            {
                return price; 
            }
            set 
            {
                if (value <= 0) 
                    throw new ArgumentException("Цената трябва да е по-голяма от 0.");
                else if (value < 1 && value > 0)
                    throw new ArgumentException("Минималната стойност за цена е 1.");

                price = value; 
            }
        }
        private DateTime expirationDate;
        public DateTime ExpirationDate
        {
            get
            {
                return expirationDate;
            }
            set
            {
                if (value < DateTime.Now)
                    throw new ArgumentException("Датата не може да е в миналото.");

                expirationDate = value;  
            }
        }

        [ForeignKey("ProductTypes")]
        public int ProductTypeNumber
        {
            get;
            set;
        }
        public ProductType ProductTypes 
        {
            get; 
            set; 
        }
    }
}
