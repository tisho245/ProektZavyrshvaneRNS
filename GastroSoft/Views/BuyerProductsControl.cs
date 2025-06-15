using System;
using System.Windows.Forms;
using GastroSoft.Controllers;
using GastroSoft.Models;
using GastroSoft.Model;
using System.Drawing;
using System.Linq;
using GastroSoft.Views;

namespace GastroSoft
{
    public partial class BuyerProductsControl : UserControl
    {
        private ProductController productController;
        private ProductTypeController productTypeController;
        private SellController sellController;
        private User currentUser;
        private Product selectedProduct = null;

        public BuyerProductsControl()
        {
            InitializeComponent();
            productController = new ProductController();
            productTypeController = new ProductTypeController();
            sellController = new SellController();
            LoadProducts();
        }

        public BuyerProductsControl(User user) : this()
        {
            currentUser = user;
        }

        private void LoadProducts()
        {
            try
            {
                var products = productController.GetAll()
                    .Where(p => p.Price > 0)
                    .ToList();
                    
                lbProducts.Items.Clear();
                foreach (var product in products)
                {
                    lbProducts.Items.Add($"{product.ProductTypeNumber} | {product.Brand} | {product.ProductName} | {product.Description} | {product.Price:F2} лв. | {product.ExpirationDate:dd/MM/yyyy}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Грешка при зареждане на продукти: {ex.Message}", 
                    "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbProducts.SelectedIndex >= 0)
            {
                try
                {
                    var products = productController.GetAll()
                        .Where(p => p.Price > 0)
                        .ToList();
                    selectedProduct = products[lbProducts.SelectedIndex];
                    
                    // Populate read-only text boxes with selected product data
                    txbBrand.Text = selectedProduct.Brand;
                    txbProductName.Text = selectedProduct.ProductName;
                    txbDescription.Text = selectedProduct.Description;
                    txbPrice.Text = selectedProduct.Price.ToString("F2") + " лв.";
                    txbExpirationDate.Text = selectedProduct.ExpirationDate.ToString("dd/MM/yyyy");
                    
                    txbProductType.Text = selectedProduct.ProductTypeNumber.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Грешка при избиране на продукт: {ex.Message}", 
                        "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadProducts();
            ClearProductDetails();
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            if (selectedProduct == null)
            {
                MessageBox.Show("Моля изберете продукт за покупка.", 
                    "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Same as btnBuySelected_Click
            btnBuySelected_Click(sender, e);
        }

        private void btnBuySelected_Click(object sender, EventArgs e)
        {
            if (selectedProduct == null)
            {
                MessageBox.Show("Моля изберете продукт за покупка.", 
                    "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                using (var purchaseForm = new PurchaseForm(selectedProduct, currentUser))
                {
                    if (purchaseForm.ShowDialog(this.ParentForm) == DialogResult.OK)
                    {
                        MessageBox.Show("Покупката е извършена успешно!", "Успех", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadProducts(); // Refresh the products list after successful purchase
                        ClearProductDetails();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Грешка при покупка: {ex.Message}", 
                    "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                // Filter products by expiration date (only non-expired products)
                var filteredProducts = productController.GetAll()
                    .Where(p => p.Price > 0 && p.ExpirationDate > DateTime.Now)
                    .ToList();
                    
                lbProducts.Items.Clear();
                foreach (var product in filteredProducts)
                {
                    lbProducts.Items.Add($"{product.ProductTypeNumber} | {product.Brand} | {product.ProductName} | {product.Description} | {product.Price:F2} лв. | {product.ExpirationDate:dd/MM/yyyy}");
                }
                
                MessageBox.Show($"Показани са {filteredProducts.Count} продукта с валиден срок на годност.", 
                    "Филтър", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Грешка при филтриране: {ex.Message}",
                    "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearProductDetails()
        {
            txbBrand.Clear();
            txbProductName.Clear();
            txbDescription.Clear();
            txbPrice.Clear();
            txbExpirationDate.Clear();
            txbProductType.Clear();
            selectedProduct = null;
            numQuantity.Value = 1;
            lbProducts.SelectedIndex = -1;
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
    }
} 
