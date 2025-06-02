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
    public partial class AdminControl : UserControl
    {
        private UserController userController;
        private ProductController productController;
        private ProductTypeController productTypeController;
        private SellController sellController;
        private User currentUser;

        public AdminControl(User user)
        {
            InitializeComponent();
            currentUser = user;
            InitializeControllers();
            InitializeWelcome();
            this.BackColor = Color.LightBlue;
            this.Size = new Size(600, 400);
        }

        private void InitializeControllers()
        {
            userController = new UserController();
            productController = new ProductController();
            productTypeController = new ProductTypeController();
            sellController = new SellController();
        }

        private void InitializeWelcome()
        {
            lblWelcome.Text = $"Добре дошли, {currentUser.FirstName}! (Администратор)";
        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var users = userController.GetAll();
                ShowDataGrid("Управление на потребители", users);
            }
            catch (Exception ex)
            {
                ShowDetailedError("Грешка при зареждане на потребители", ex);
            }
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

        private void manageSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var sales = sellController.GetAll();
                ShowDataGrid("Управление на продажби", sales);
            }
            catch (Exception ex)
            {
                ShowDetailedError("Грешка при зареждане на продажби", ex);
            }
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Функционалност за отчети ще бъде добавена скоро.", "Информация", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Системни настройки ще бъдат добавени скоро.", "Информация", 
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
