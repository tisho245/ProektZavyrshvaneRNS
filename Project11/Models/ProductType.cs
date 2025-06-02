using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Project11.Model
{
    public class ProductType
    {
        private int productTypeNumber;
        [Key]
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
        public string ProductTypeName
        {
            get
            {
                return productTypeName;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Не сте въвели тип продукт.");

                productTypeName = value;
            }
        }
    }
}
