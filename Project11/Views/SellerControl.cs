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
    public partial class SellerControl : UserControl
    {
        private ProductController productController;
        private ProductTypeController productTypeController;
        private SellController sellController;
        private User currentUser;

        public SellerControl(User user)
        {
            InitializeComponent();
            currentUser = user;
            InitializeControllers();
            InitializeWelcome();
            this.BackColor = Color.LightGreen;
            this.Size = new Size(600, 400);
        }

        private void InitializeControllers()
        {
            productController = new ProductController();
            productTypeController = new ProductTypeController();
            sellController = new SellController();
        }

        private void InitializeWelcome()
        {
            lblWelcome.Text = $"Добре дошли, {currentUser.FirstName}! (Продавач)";
        }

        private void manageProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var products = productController.GetAll();
                ShowDataGrid("Управление на продукти", products);
            }
            catch (Exception ex)
            {
                ShowDetailedError("Грешка при зареждане на продукти", ex);
            }
        }

        private void manageProductTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var productTypes = productTypeController.GetAll();
                ShowDataGrid("Управление на типове продукти", productTypes);
            }
            catch (Exception ex)
            {
                ShowDetailedError("Грешка при зареждане на типове", ex);
            }
        }

        private void viewSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var sales = sellController.GetAll();
                ShowDataGrid("Преглед на продажби", sales);
            }
            catch (Exception ex)
            {
                ShowDetailedError("Грешка при зареждане на продажби", ex);
            }
        }

        private void makeSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Функционалност за нова продажба ще бъде добавена скоро.", "Информация", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Функционалност за инвентар ще бъде добавена скоро.", "Информация", 
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
