using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GastroSoft.Controllers;
using GastroSoft.Models;
using GastroSoft.Model;

namespace GastroSoft
{
    public partial class SellerProductsControl : UserControl
    {
        private ProductController productController;
        private ProductTypeController productTypeController;
        private List<Product> allProducts;
        private List<Product> filteredProducts;

        public SellerProductsControl()
        {
            InitializeComponent();
            productController = new ProductController();
            productTypeController = new ProductTypeController();
            LoadProducts();
        }

        private void LoadProducts()
        {
            try
            {
                allProducts = productController.GetAll();
                filteredProducts = new List<Product>(allProducts);
                RefreshProductList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Грешка при зареждането на продуктите: {ex.Message}", 
                    "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshProductList()
        {
            lbProducts.Items.Clear();
            
            foreach (var product in filteredProducts)
            {
                lbProducts.Items.Add($"{product.ProductTypeNumber} | {product.Brand} | {product.ProductName} | {product.Description} | {product.Price:F2} лв. | {product.ExpirationDate:dd/MM/yyyy} ");
            }

            // Clear textboxes when list is refreshed
            ClearTextBoxes();
        }

        private void lbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbProducts.SelectedIndex >= 0 && lbProducts.SelectedIndex < filteredProducts.Count)
            {
                var selectedProduct = filteredProducts[lbProducts.SelectedIndex];
                DisplayProductDetails(selectedProduct);
            }
        }

        private void DisplayProductDetails(Product product)
        {
            try
            {
                txbBrand.Text = product.Brand ?? "";
                txbProductName.Text = product.ProductName ?? "";
                txbDescription.Text = product.Description ?? "";
                // Price formatted with Bulgarian leva
                txbPrice.Text = product.Price.ToString("F2") + " лв.";
                txbExpirationDate.Text = product.ExpirationDate.ToString("dd/MM/yyyy");
                
                txbProductType.Text = product.ProductTypeNumber.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Грешка при показването на детайлите: {ex.Message}", 
                    "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearTextBoxes()
        {
            txbBrand.Text = "";
            txbProductName.Text = "";
            txbDescription.Text = "";
            txbPrice.Text = "";
            txbExpirationDate.Text = "";
            txbProductType.Text = "";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lbProducts.SelectedIndex >= 0 && lbProducts.SelectedIndex < filteredProducts.Count)
            {
                try
                {
                    var selectedProduct = filteredProducts[lbProducts.SelectedIndex];
                    
                    // Validate input from textboxes
                    if (string.IsNullOrWhiteSpace(txbBrand.Text))
                    {
                        MessageBox.Show("Марката е задължителна!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txbBrand.Focus();
                        return;
                    }
                    
                    if (string.IsNullOrWhiteSpace(txbProductName.Text))
                    {
                        MessageBox.Show("Името на продукта е задължително!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txbProductName.Focus();
                        return;
                    }
                    
                    if (string.IsNullOrWhiteSpace(txbDescription.Text))
                    {
                        MessageBox.Show("Описанието е задължително!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txbDescription.Focus();
                        return;
                    }
                    
                    decimal price;
                    if (!decimal.TryParse(txbPrice.Text.Replace(" лв.", ""), out price) || price <= 0)
                    {
                        MessageBox.Show("Цената трябва да бъде положително число!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txbPrice.Focus();
                        return;
                    }
                    
                    // Update product with new values
                    selectedProduct.Brand = txbBrand.Text.Trim();
                    selectedProduct.ProductName = txbProductName.Text.Trim();
                    selectedProduct.Description = txbDescription.Text.Trim();
                    selectedProduct.Price = price;
                    
                    productController.Update(selectedProduct.ProductNumber, selectedProduct);
                    MessageBox.Show("Продуктът е редактиран успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadProducts();
                    
                    // Re-select the updated product
                    lbProducts.SelectedIndex = filteredProducts.FindIndex(p => p.ProductNumber == selectedProduct.ProductNumber);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Грешка при редактирането: {ex.Message}", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Моля изберете продукт за редактиране!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AutoSelectFirstProduct()
        {
            try
            {
                // Auto-select first product if any exist
                if (lbProducts.Items.Count > 0)
                {
                    lbProducts.SelectedIndex = 0;
                }
            }
            catch (Exception)
            {
                // Do nothing if auto-select fails
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            lbProducts.SelectedIndex = -1;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Parent?.Controls.Remove(this);
        }
    }
} 
