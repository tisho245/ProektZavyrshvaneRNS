using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GastroSoft.Model
{
    public class ProductType
    {
        private int productTypeNumber;
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductTypeNumber
        {
            get
            {
                return productTypeNumber;
            }
            set
            {
                productTypeNumber = value;
            }
        }
        private string productTypeName;
        
        [Required(ErrorMessage = "Името на типа продукт е задължително поле")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Името на типа продукт трябва да е между 2 и 100 символа")]
        [Display(Name = "Тип на продукт")]
        public string ProductTypeName
        {
            get
            {
                return productTypeName;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Не може да бъде празно поле.");

                productTypeName = value;
            }
        }
    }
}
