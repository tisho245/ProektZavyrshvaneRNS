using System;
using System.Windows.Forms;
using GastroSoft.Controllers;
using GastroSoft.Models;
using System.Linq;
using System.Collections.Generic;

namespace GastroSoft
{
    public partial class ManageSalesControl : UserControl
    {
        private readonly SellController sellController;
        private Sell selectedSale = null;

        public ManageSalesControl()
        {
            InitializeComponent();
            sellController = new SellController();
            LoadSales();
        }

        private void LoadSales()
        {
            try
            {
                List<Sell> sells = sellController.GetAll();
                lbSales.Items.Clear();

                foreach (var sell in sells)
                {
                    lbSales.Items.Add($"{sell.Id} | {sell.Username} | {sell.Status} | {sell.Quantity} | {sell.TotalPrice:F2} лв. | {sell.DateOfSale:dd/MM/yyyy}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Грешка при зареждане на продажби: {ex.Message}", 
                    "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lbSales_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbSales.SelectedIndex >= 0)
            {
                try
                {
                    List<Sell> sells = sellController.GetAll();
                    if (sells != null && lbSales.SelectedIndex < sells.Count)
                    {
                        selectedSale = sells[lbSales.SelectedIndex];
                        
                        // Populate text boxes with selected sale data
                        txbUsername.Text = selectedSale.Username;
                        txbProduct.Text = selectedSale.ProductNumber.ToString();
                        txbQuantity.Text = selectedSale.Quantity.ToString();
                        txbTotalPrice.Text = selectedSale.TotalPrice.ToString("F2");
                        dtpDateOfSale.Value = selectedSale.DateOfSale;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Грешка при избиране на продажба: {ex.Message}", 
                        "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input
                if (string.IsNullOrWhiteSpace(txbUsername.Text))
                {
                    MessageBox.Show("Потребителското име е задължително!", "Грешка", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txbProduct.Text, out int productNumber) || productNumber <= 0)
                {
                    MessageBox.Show("Номерът на продукта трябва да бъде положително число!", "Грешка", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txbQuantity.Text, out int quantity) || quantity <= 0)
                {
                    MessageBox.Show("Количеството трябва да бъде положително число!", "Грешка", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(txbTotalPrice.Text, out decimal totalPrice) || totalPrice <= 0)
                {
                    MessageBox.Show("Общата цена трябва да бъде положително число!", "Грешка", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Create new sale
                var newSale = new Sell
                {
                    Username = txbUsername.Text.Trim(),
                    ProductNumber = productNumber,
                    Quantity = quantity,
                    TotalPrice = totalPrice,
                    DateOfSale = dtpDateOfSale.Value,
                    Status = SaleStatus.Completed
                };
                
                sellController.Create(newSale);
                MessageBox.Show("Новата продажба е създадена успешно!", "Успех", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                LoadSales();
                ClearTextBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Грешка при добавяне на продажба: {ex.Message}", 
                    "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedSale == null)
                {
                    MessageBox.Show("Моля, изберете продажба за редактиране!", "Грешка", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate input
                if (string.IsNullOrWhiteSpace(txbUsername.Text))
                {
                    MessageBox.Show("Потребителското име е задължително!", "Грешка", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txbProduct.Text, out int productNumber) || productNumber <= 0)
                {
                    MessageBox.Show("Номерът на продукта трябва да бъде положително число!", "Грешка", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txbQuantity.Text, out int quantity) || quantity <= 0)
                {
                    MessageBox.Show("Количеството трябва да бъде положително число!", "Грешка", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(txbTotalPrice.Text, out decimal totalPrice) || totalPrice <= 0)
                {
                    MessageBox.Show("Общата цена трябва да бъде положително число!", "Грешка", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Update existing sale
                selectedSale.Username = txbUsername.Text.Trim();
                selectedSale.ProductNumber = productNumber;
                selectedSale.Quantity = quantity;
                selectedSale.TotalPrice = totalPrice;
                selectedSale.DateOfSale = dtpDateOfSale.Value;
                
                sellController.Update(selectedSale.Id, selectedSale);
                MessageBox.Show("Продажбата е обновена успешно!", "Успех", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                LoadSales();
                ClearTextBoxes();
                selectedSale = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Грешка при запазване на продажба: {ex.Message}", 
                    "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedSale != null)
            {
                try
                {
                    var result = MessageBox.Show($"Сигурни ли сте, че искате да изтриете продажба ID: {selectedSale.Id}?", 
                        "Потвърждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    
                    if (result == DialogResult.Yes)
                    {
                        sellController.Delete(selectedSale.Id);
                        MessageBox.Show("Продажбата е изтрита успешно!", "Успех", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        LoadSales();
                        ClearTextBoxes();
                        selectedSale = null;
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
                MessageBox.Show("Моля изберете продажба за изтриване!", "Информация", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            selectedSale = null;
            lbSales.SelectedIndex = -1;
        }

        private void ClearTextBoxes()
        {
            txbUsername.Clear();
            txbProduct.Clear();
            txbQuantity.Clear();
            txbTotalPrice.Clear();
            dtpDateOfSale.Value = DateTime.Now;
        }

        private void ManageSalesControl_Load(object sender, EventArgs e)
        {
            if (dtpDateOfSale != null)
                dtpDateOfSale.Value = DateTime.Now;
        }
    }
}
 
