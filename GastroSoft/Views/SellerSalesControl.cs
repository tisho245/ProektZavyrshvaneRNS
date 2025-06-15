using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using GastroSoft.Controllers;
using GastroSoft.Models;
using System.Drawing;

namespace GastroSoft
{
    public partial class SellerSalesControl : UserControl
    {
        private SellController sellController;
        private ProductController productController;
        private User currentUser;
        private List<Sell> allSales;
        private List<Sell> filteredSales;

        public SellerSalesControl(User user)
        {
            InitializeComponent();
            currentUser = user;
            sellController = new SellController();
            productController = new ProductController();
            LoadSales();
        }

        public SellerSalesControl()
        {
            InitializeComponent();
            sellController = new SellController();
            productController = new ProductController();
            LoadSales();
        }

        private void LoadSales()
        {
            try
            {
                allSales = sellController.GetAll()
                    .OrderByDescending(s => s.DateOfSale)
                    .ToList();
                filteredSales = new List<Sell>(allSales);
                RefreshSalesList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Грешка при зареждане на продажби: {ex.Message}", 
                    "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshSalesList()
        {
            lbSales.Items.Clear();
            
            foreach (var sale in filteredSales)
            {
                var username = sale.Users?.Username ?? sale.Username ?? "Неизвестен";
                var productName = sale.Products?.ProductName ?? "Неизвестен продукт";
                var productTypeNumber = sale.Products?.ProductTypeNumber.ToString() ?? "0";
                var displayText = $"{sale.Id} | {username} | {productTypeNumber} | {productName} | {sale.Quantity} бр. | {sale.TotalPrice:F2} лв. | {sale.DateOfSale:dd/MM/yyyy}";
                lbSales.Items.Add(displayText);
            }

            // Clear text boxes when list is refreshed
            ClearTextBoxes();
        }

        private void lbSales_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbSales.SelectedIndex >= 0 && lbSales.SelectedIndex < filteredSales.Count)
            {
                var selectedSale = filteredSales[lbSales.SelectedIndex];
                DisplaySaleDetails(selectedSale);
            }
        }

        private void DisplaySaleDetails(Sell sale)
        {
            try
            {
                txbUsername.Text = sale.Users?.Username ?? sale.Username ?? "Неизвестен";
                txbProductName.Text = sale.Products?.ProductName ?? "Неизвестен продукт";
                txbQuantity.Text = sale.Quantity.ToString();
                txbTotalPrice.Text = sale.TotalPrice.ToString("F2") + " лв.";
                txbSaleDate.Text = sale.DateOfSale.ToString("dd/MM/yyyy HH:mm");
                
                // Add status display
                string statusText;
                switch (sale.Status)
                {
                    case SaleStatus.Processing:
                        statusText = "В обработка";
                        break;
                    case SaleStatus.Completed:
                        statusText = "Завършена";
                        break;
                    case SaleStatus.Cancelled:
                        statusText = "Отказана";
                        break;
                    default:
                        statusText = "Неизвестен";
                        break;
                }
                txbStatus.Text = statusText;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Грешка при показването на детайлите: {ex.Message}", 
                    "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearTextBoxes()
        {
            txbUsername.Text = "";
            txbProductName.Text = "";
            txbQuantity.Text = "";
            txbTotalPrice.Text = "";
            txbSaleDate.Text = "";
            txbStatus.Text = "";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lbSales.SelectedIndex >= 0 && lbSales.SelectedIndex < filteredSales.Count)
            {
                try
                {
                    var selectedSale = filteredSales[lbSales.SelectedIndex];
                    
                    // Validate input from textboxes
                    int quantity;
                    if (!int.TryParse(txbQuantity.Text, out quantity) || quantity <= 0)
                    {
                        MessageBox.Show("Количеството трябва да бъде положително число!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txbQuantity.Focus();
                        return;
                    }
                    
                    decimal totalPrice;
                    if (!decimal.TryParse(txbTotalPrice.Text.Replace(" лв.", ""), out totalPrice) || totalPrice <= 0)
                    {
                        MessageBox.Show("Общата цена трябва да бъде положително число!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txbTotalPrice.Focus();
                        return;
                    }
                    
                    // Update sale with new values
                    selectedSale.Quantity = quantity;
                    selectedSale.TotalPrice = totalPrice;
                    
                    sellController.Update(selectedSale.Id, selectedSale);
                    MessageBox.Show("Продажбата е редактирана успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadSales();
                    
                    // Re-select the updated sale
                    lbSales.SelectedIndex = filteredSales.FindIndex(s => s.Id == selectedSale.Id);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Грешка при редактирането: {ex.Message}", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Моля изберете продажба за редактиране!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AutoSelectFirstSale()
        {
            try
            {
                // Auto-select first sale if any exist
                if (lbSales.Items.Count > 0)
                {
                    lbSales.SelectedIndex = 0;
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
            lbSales.SelectedIndex = -1;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Parent?.Controls.Remove(this);
        }

        private void lblSaleDate_Click(object sender, EventArgs e)
        {

        }
    }
} 
