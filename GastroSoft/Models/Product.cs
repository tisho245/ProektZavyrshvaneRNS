using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace GastroSoft.Model
{
    public class Product
    {
        private int productNumber;
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductNumber
        {
            get 
            {
                return productNumber; 
            }
            set 
            {
                productNumber = value; 
            }
        }
        private string brand;
        
        [Required(ErrorMessage = "Марка е задължително поле")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Марка трябва да е между 3 и 50 символа")]
        [Display(Name = "Марка")]
        public string Brand
        {
            get 
            {
                return brand; 
            }
            set 
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)) 
                    throw new ArgumentNullException("Марката не може да е празна или празно.");
                
                else if (value.Length < 3)
                    throw new ArgumentException("Марката трябва да е между 3 и 50 символа.");

                else if (value.Length > 50)
                    throw new ArgumentException("Марката не може да е повече от 50 символа.");

                else if (value.Any(char.IsDigit))
                    throw new ArgumentException("Марката не може да съдържа цифри.");

                brand = value; 
            }
        }
        
        private string productName;
        
        [Required(ErrorMessage = "Името на продукта е задължително поле")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Името на продукта трябва да е между 2 и 100 символа")]
        [Display(Name = "Име на продукт")]
        public string ProductName
        {
            get 
            {
                return productName; 
            }
            set 
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)) 
                    throw new ArgumentNullException("Името на продукта не може да е празно или празно.");
                
                else if (value.Length < 2)
                    throw new ArgumentException("Името на продукта трябва да е между 2 и 100 символа.");

                else if (value.Length > 100)
                    throw new ArgumentException("Името на продукта не може да е повече от 100 символа.");

                productName = value; 
            }
        }
        
        private string description;
        
        [StringLength(1000, MinimumLength = 10, ErrorMessage = "Описанието трябва да е между 10 и 1000 символа")]
        [Display(Name = "Описание")]
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
                        throw new ArgumentException("Описанието трябва да е между 10 и 1000 символа.");

                    if (value.Length > 1000)
                        throw new ArgumentException("Описанието не може да е повече от 1000 символа.");

                    if (!value.Any(char.IsLetter))
                        throw new ArgumentException("Описанието трябва да съдържа само букви.");
                }

                description = value; 
            }
        }
        private decimal price;
        
        [Required(ErrorMessage = "Цената е задължително поле")]
        [Range(1, double.MaxValue, ErrorMessage = "Цената трябва да е най-малко 1")]
        [DataType(DataType.Currency)]
        [Display(Name = "Цена")]
        public decimal Price
        {
            get 
            {
                return price; 
            }
            set 
            {
                if (value <= 0) 
                    throw new ArgumentException("Цената не може да е по-малка или равна на 0.");
                else if (value < 1 && value > 0)
                    throw new ArgumentException("Цената трябва да е най-малко 1.");

                price = value; 
            }
        }
        private DateTime expirationDate;
        
        [Required(ErrorMessage = "Датата на годност е задължително поле")]
        [DataType(DataType.Date)]
        [Display(Name = "Дата на годност")]
        public DateTime ExpirationDate
        {
            get
            {
                return expirationDate;
            }
            set
            {
                // Allow setting past dates for existing products or when loading from database
                // Only validate for new products in the UI layer
                if (value == DateTime.MinValue)
                {
                    // Set a default value if MinValue is provided
                    expirationDate = DateTime.Now.AddDays(30);
                }
                else
                {
                    expirationDate = value;
                }
            }
        }

        [Required(ErrorMessage = "Тип продукт е задължително поле")]
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
