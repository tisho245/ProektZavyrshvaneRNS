using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project11.Controllers;
using Project11.Models;
using Project11.Model;

namespace Project11.Views
{
    public partial class BuyerControl : UserControl
    {
        private ProductController productController;
        private SellController sellController;
        private User currentUser;

        public BuyerControl(User user)
        {
            InitializeComponent();
            currentUser = user;
            InitializeControllers();
            InitializeWelcome();
            this.BackColor = Color.LightCoral;
            this.Size = new Size(600, 400);
        }

        private void InitializeControllers()
        {
            productController = new ProductController();
            sellController = new SellController();
        }

        private void InitializeWelcome()
        {
            lblWelcome.Text = $"Добре дошли, {currentUser.FirstName}! (Купувач)";
        }

        private void viewProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var products = productController.GetAll();
                ShowDataGrid("Каталог на продукти", products);
            }
            catch (Exception ex)
            {
                ShowDetailedError("Грешка при зареждане на продукти", ex);
            }
        }

        private void myPurchasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var allSales = sellController.GetAll();
                // Filter sales for current user
                var mySales = allSales.Where(s => s.Username == currentUser.Username).ToList();
                ShowDataGrid("Моите покупки", mySales);
            }
            catch (Exception ex)
            {
                ShowDetailedError("Грешка при зареждане на покупки", ex);
            }
        }

        private void makePurchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Функционалност за нова покупка ще бъде добавена скоро.", "Информация", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Функционалност за количка ще бъде добавена скоро.", "Информация", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Профил:\n\nИме: {currentUser.FirstName} {currentUser.LastName}\n" +
                          $"Потребителско име: {currentUser.Username}\n" +
                          $"Email: {currentUser.Email}\n" +
                          $"Роля: {currentUser.Role}", "Моят профил", 
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ShowDataGrid(string title, object data)
        {
            Form dataForm = new Form();
            dataForm.Text = title;
            dataForm.Size = new Size(800, 600);
            dataForm.StartPosition = FormStartPosition.CenterScreen;

            DataGridView dgv = new DataGridView();
            dgv.Dock = DockStyle.Fill;
            dgv.DataSource = data;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.ReadOnly = true;

            dataForm.Controls.Add(dgv);
            dataForm.ShowDialog();
        }

        private void ShowDetailedError(string context, Exception ex)
        {
            string errorMessage = $"{context}:\n\n";
            errorMessage += $"Тип грешка: {ex.GetType().Name}\n";
            errorMessage += $"Съобщение: {ex.Message}\n";
            
            if (ex.InnerException != null)
            {
                errorMessage += $"\nВътрешна грешка: {ex.InnerException.Message}\n";
            }
            
            errorMessage += $"\nПълни детайли:\n{ex.ToString()}";
            
            MessageBox.Show(errorMessage, "Детайлна грешка", 
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
