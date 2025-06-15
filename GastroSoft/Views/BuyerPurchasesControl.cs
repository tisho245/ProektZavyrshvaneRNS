using System;
using System.Windows.Forms;
using GastroSoft.Controllers;
using GastroSoft.Models;
using System.Drawing;
using System.Linq;
using System.Collections.Generic;

namespace GastroSoft
{
    public partial class BuyerPurchasesControl : UserControl
    {
        private SellController sellController;
        private User currentUser;
        private List<Sell> purchases;

        public BuyerPurchasesControl(User user)
        {
            InitializeComponent();
            currentUser = user;
            sellController = new SellController();
            LoadPurchases();
        }

        public BuyerPurchasesControl()
        {
            InitializeComponent();
            sellController = new SellController();
            LoadPurchases();
        }

        private void LoadPurchases()
        {
            try
            {
                var allSales = sellController.GetAll();
                
                if (currentUser != null)
                {
                    purchases = allSales.Where(s => s.Username == currentUser.Username)
                        .OrderByDescending(s => s.DateOfSale)
                        .ToList();
                }
                else
                {
                    // Show sample data if no user
                    purchases = allSales.OrderByDescending(s => s.DateOfSale)
                        .Take(10)
                        .ToList();
                }
                
                RefreshPurchasesList();
                UpdateStatusBar();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Грешка при зареждане на покупки: {ex.Message}", 
                    "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshPurchasesList()
        {
            lbPurchases.Items.Clear();
            
            if (purchases != null)
            {
                foreach (var purchase in purchases)
                {
                    var productName = purchase.Products?.Brand ?? "Неизвестен продукт";
                                var displayText = $"{productName} - {purchase.TotalPrice:F2} лв. - {purchase.DateOfSale:dd/MM/yyyy}";
            lbPurchases.Items.Add(displayText);
                }
            }
            
            ClearDetails();
        }

        private void UpdateStatusBar()
        {
            if (purchases != null)
            {
                lblTotalPurchases.Text = $"Общо покупки: {purchases.Count}";
                var totalAmount = purchases.Sum(p => p.TotalPrice);
                            lblTotalAmount.Text = $"Обща сума: {totalAmount:F2} лв.";
        }
        }

        private void ClearDetails()
        {
            txbProduct.Clear();
            txbQuantity.Clear();
            txbTotalPrice.Clear();
            txbPurchaseDate.Clear();
            txbStatus.Clear();
        }

        private void lbPurchases_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbPurchases.SelectedIndex >= 0 && purchases != null)
            {
                var selectedPurchase = purchases[lbPurchases.SelectedIndex];
                DisplayPurchaseDetails(selectedPurchase);
            }
        }

        private void DisplayPurchaseDetails(Sell purchase)
        {
            txbProduct.Text = purchase.Products?.Brand ?? "Неизвестен продукт";
            txbQuantity.Text = purchase.Quantity.ToString();
            txbTotalPrice.Text = purchase.TotalPrice.ToString("F2") + " лв.";
            txbPurchaseDate.Text = purchase.DateOfSale.ToString("dd/MM/yyyy HH:mm");
            
            // Use the Status property
            string statusText;
            switch (purchase.Status)
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
            
            // Enable quantity editing only for processing orders
            txbQuantity.ReadOnly = purchase.Status != SaleStatus.Processing;
            btnUpdateQuantity.Enabled = purchase.Status == SaleStatus.Processing;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadPurchases();
            MessageBox.Show("Данните са обновени успешно!", "Информация", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void ApplyFilter(string filter)
        {
            try
            {
                var allSales = sellController.GetAll();
                
                if (currentUser != null)
                {
                    purchases = allSales.Where(s => s.Username == currentUser.Username &&
                        (s.Products?.Brand?.ToLower().Contains(filter.ToLower()) == true))
                        .OrderByDescending(s => s.DateOfSale)
                        .ToList();
                }
                else
                {
                    purchases = allSales.Where(s => s.Products?.Brand?.ToLower().Contains(filter.ToLower()) == true)
                        .OrderByDescending(s => s.DateOfSale)
                        .Take(10)
                        .ToList();
                }
                
                RefreshPurchasesList();
                UpdateStatusBar();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Грешка при филтриране: {ex.Message}", 
                    "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                var saveDialog = new SaveFileDialog
                {
                    Filter = "CSV файлове (*.csv)|*.csv",
                    FileName = "purchases.csv"
                };
                
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    var lines = new List<string>
                    {
                        "Продукт,Количество,Обща цена,Дата,Статус"
                    };
                    
                    if (purchases != null)
                    {
                        foreach (var purchase in purchases)
                        {
                            var productName = purchase.Products?.Brand ?? "Неизвестен продукт";
                            lines.Add($"{productName},{purchase.Quantity},{purchase.TotalPrice},{purchase.DateOfSale:dd/MM/yyyy},Завършена");
                        }
                    }
                    
                    System.IO.File.WriteAllLines(saveDialog.FileName, lines);
                    MessageBox.Show("Данните са експортирани успешно!", "Успех", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Грешка при експортиране: {ex.Message}", 
                    "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            if (lbPurchases.SelectedIndex >= 0)
            {
                var selectedPurchase = purchases[lbPurchases.SelectedIndex];
                var productName = selectedPurchase.Products?.Brand ?? "Неизвестен продукт";
                
                string statusText;
                switch (selectedPurchase.Status)
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
                
                var details = $"Детайли за покупка:\n\n" +
                             $"Продукт: {productName}\n" +
                             $"Количество: {selectedPurchase.Quantity}\n" +
                             $"Обща цена: {selectedPurchase.TotalPrice:F2} лв.\n" +
                             $"Дата: {selectedPurchase.DateOfSale:dd/MM/yyyy HH:mm}\n" +
                             $"Статус: {statusText}";
                             
                MessageBox.Show(details, "Детайли на покупка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Моля, изберете покупка за преглед на детайли.", 
                    "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUpdateQuantity_Click(object sender, EventArgs e)
        {
            if (lbPurchases.SelectedIndex >= 0)
            {
                try
                {
                    var selectedPurchase = purchases[lbPurchases.SelectedIndex];
                    int newQuantity;
                    
                    if (int.TryParse(txbQuantity.Text, out newQuantity) && newQuantity > 0)
                    {
                        // Update quantity and recalculate total price
                        var unitPrice = selectedPurchase.TotalPrice / selectedPurchase.Quantity;
                        selectedPurchase.Quantity = newQuantity;
                        selectedPurchase.TotalPrice = unitPrice * newQuantity;
                        
                        // Update in database
                        sellController.Update(selectedPurchase.Id, selectedPurchase);
                        
                        // Refresh display
                        DisplayPurchaseDetails(selectedPurchase);
                        RefreshPurchasesList();
                        UpdateStatusBar();
                        
                        MessageBox.Show("Количеството е обновено успешно!", "Успех", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Моля въведете валидно количество (число по-голямо от 0).", 
                            "Невалидно количество", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Грешка при обновяване на количеството: {ex.Message}", 
                        "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AutoSelectFirstPurchase()
        {
            try
            {
                // Auto-select first purchase if any exist
                if (lbPurchases.Items.Count > 0)
                {
                    lbPurchases.SelectedIndex = 0;
                }
            }
            catch (Exception)
            {
                // Do nothing if auto-select fails
            }
        }

    }
} 
