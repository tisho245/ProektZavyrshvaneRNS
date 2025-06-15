using System;
using System.Windows.Forms;
using GastroSoft.Controllers;
using GastroSoft.Models;
using GastroSoft.Model;
using System.Drawing;
using System.Linq;

namespace GastroSoft
{
    public partial class ManageProductsControl : UserControl
    {
        private ProductController productController;
        private ProductTypeController productTypeController;
        private Product selectedProduct = null;

        public ManageProductsControl()
        {
            InitializeComponent();
            productController = new ProductController();
            productTypeController = new ProductTypeController();
            
            // Initialize DateTimePicker with a safe default value
            dtpExpirationDate.Value = DateTime.Now.AddDays(30);
            dtpExpirationDate.MinDate = DateTime.Now;
            
            LoadProducts();
        }

        private void LoadProducts()
        {
            try
            {
                var products = productController.GetAll();
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
                    var products = productController.GetAll();
                    selectedProduct = products[lbProducts.SelectedIndex];
                    
                    // Populate controls with selected product data
                    txbBrand.Text = selectedProduct.Brand;
                    txbProductName.Text = selectedProduct.ProductName;
                    txbDescription.Text = selectedProduct.Description;
                    txbPrice.Text = selectedProduct.Price.ToString("F2") + " лв.";
                    dtpExpirationDate.Value = selectedProduct.ExpirationDate;
                    txbProductType.Text = selectedProduct.ProductTypeNumber.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Грешка при избиране на продукт: {ex.Message}", 
                        "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedProduct != null)
            {
                try
                {
                    var result = MessageBox.Show($"Сигурни ли сте, че искате да изтриете продукт '{selectedProduct.ProductName}'?", 
                        "Потвърждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        
                    if (result == DialogResult.Yes)
                    {
                        productController.Delete(selectedProduct.ProductNumber);
                        MessageBox.Show("Продуктът е изтрит успешно!", "Успех", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        LoadProducts();
                        ClearTextBoxes();
                        selectedProduct = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Грешка при изтриване: {ex.Message}", 
                        "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Моля изберете продукт за изтриване!", "Информация", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            selectedProduct = null;
            lbProducts.SelectedIndex = -1;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // This method is now used as Save button
            if (selectedProduct != null)
            {
                try
                {
                    // Validate input
                    if (string.IsNullOrWhiteSpace(txbProductName.Text))
                    {
                        MessageBox.Show("Името на продукта е задължително!", "Грешка", 
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (string.IsNullOrWhiteSpace(txbBrand.Text))
                    {
                        MessageBox.Show("Марката е задължителна!", "Грешка", 
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (string.IsNullOrWhiteSpace(txbProductType.Text))
                    {
                        MessageBox.Show("Типът на продукта е задължителен!", "Грешка", 
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (string.IsNullOrWhiteSpace(txbPrice.Text))
                    {
                        MessageBox.Show("Цената е задължителна!", "Грешка", 
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    int productTypeNumber;
                    if (!int.TryParse(txbProductType.Text, out productTypeNumber) || productTypeNumber <= 0)
                    {
                        MessageBox.Show("Номерът на типа трябва да бъде положително число!", "Грешка", 
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    decimal price;
                    if (!decimal.TryParse(txbPrice.Text.Replace(" лв.", ""), out price) || price <= 0)
                    {
                        MessageBox.Show("Цената трябва да бъде положително число!", "Грешка", 
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Validate expiration date
                    if (dtpExpirationDate.Value.Date < DateTime.Now.Date)
                    {
                        MessageBox.Show("Датата на годност не може да е преди днешната дата!", "Грешка", 
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Update existing product
                    selectedProduct.Brand = txbBrand.Text.Trim();
                    selectedProduct.ProductName = txbProductName.Text.Trim();
                    selectedProduct.Description = txbDescription.Text.Trim();
                    selectedProduct.Price = price;
                    selectedProduct.ExpirationDate = dtpExpirationDate.Value;
                    selectedProduct.ProductTypeNumber = productTypeNumber;
                    
                    productController.Update(selectedProduct.ProductNumber, selectedProduct);
                    MessageBox.Show("Продуктът е запазен успешно!", "Успех", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    LoadProducts();
                    ClearTextBoxes();
                    selectedProduct = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Грешка при запазване: {ex.Message}", 
                        "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Моля изберете продукт за редактиране!", "Информация", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ClearTextBoxes()
        {
            txbBrand.Clear();
            txbProductName.Clear();
            txbDescription.Clear();
            txbPrice.Clear();
            txbProductType.Clear();
            
            // Set a safe default date (30 days from now)
            dtpExpirationDate.Value = DateTime.Now.AddDays(30);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input
                if (string.IsNullOrWhiteSpace(txbProductName.Text))
                {
                    MessageBox.Show("Името на продукта е задължително!", "Грешка", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txbBrand.Text))
                {
                    MessageBox.Show("Марката е задължителна!", "Грешка", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txbProductType.Text))
                {
                    MessageBox.Show("Типът на продукта е задължителен!", "Грешка", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txbPrice.Text))
                {
                    MessageBox.Show("Цената е задължителна!", "Грешка", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int productTypeNumber;
                if (!int.TryParse(txbProductType.Text, out productTypeNumber) || productTypeNumber <= 0)
                {
                    MessageBox.Show("Номерът на типа трябва да бъде положително число!", "Грешка", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal price;
                if (!decimal.TryParse(txbPrice.Text.Replace(" лв.", ""), out price) || price <= 0)
                {
                    MessageBox.Show("Цената трябва да бъде положително число!", "Грешка", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate expiration date for new products
                if (dtpExpirationDate.Value.Date < DateTime.Now.Date)
                {
                    MessageBox.Show("Датата на годност не може да е преди днешната дата!", "Грешка", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Product product = new Product();
                product.ProductName = txbProductName.Text.Trim();
                product.ProductTypeNumber = productTypeNumber;
                product.Brand = txbBrand.Text.Trim();
                product.Description = txbDescription.Text.Trim();
                product.Price = price;
                product.ExpirationDate = dtpExpirationDate.Value; // Use the DateTimePicker value
                
                productController.Create(product);
                MessageBox.Show("Продуктът е добавен успешно!", "Успех", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                LoadProducts();
                ClearTextBoxes();
                selectedProduct = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Грешка при добавяне на продукт: {ex.Message}", 
                    "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Parent?.Controls.Remove(this);
        }
    }
} 
