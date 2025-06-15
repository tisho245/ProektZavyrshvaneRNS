using System;
using System.Windows.Forms;
using GastroSoft.Controllers;
using GastroSoft.Model;
using GastroSoft.Models;

namespace GastroSoft.Views
{
    public partial class PurchaseForm : Form
    {
        private readonly Product selectedProduct;
        private readonly User currentUser;
        private SellController sellController;

        public PurchaseForm(Product product, User user)
        {
            InitializeComponent();
            this.selectedProduct = product;
            this.currentUser = user;
            sellController = new SellController();

            // Set product details
            lblProductName.Text = $"Име: {selectedProduct.ProductName} | Марка: {selectedProduct.Brand} | Тип: {selectedProduct.ProductTypeNumber}";
            lblDescription.Text = $"Описание: {selectedProduct.Description}";
            lblPrice.Text = $"Цена: {selectedProduct.Price:F2} лв.";
            
            // Auto-fill quantity
            numQuantity.Value = 1;
            
            UpdateTotalPrice();
        }

        private void numQuantity_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

        private void UpdateTotalPrice()
        {
            decimal totalPrice = selectedProduct.Price * numQuantity.Value;
            lblTotalPrice.Text = $"Обща цена: {totalPrice:F2} лв.";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentUser == null)
                {
                    MessageBox.Show("Не сте влезли в системата.", "Грешка", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var sell = new Sell
                {
                    Username = currentUser.Username,
                    ProductNumber = selectedProduct.ProductNumber,
                    DateOfSale = DateTime.Now,
                    Quantity = (int)numQuantity.Value,
                    TotalPrice = selectedProduct.Price * numQuantity.Value
                };

                sellController.Create(sell);
                
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Грешка при покупка: {ex.Message}", "Грешка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
} 