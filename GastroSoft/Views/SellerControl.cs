using System;
using System.Drawing;
using System.Windows.Forms;
using GastroSoft.Controllers;
using GastroSoft.Models;
using GastroSoft.Views;

namespace GastroSoft
{
    public partial class SellerControl : UserControl
    {
        private ProductController productController;
        private ProductTypeController productTypeController;
        private SellController sellController;
        private User currentUser;

        public SellerControl()
        {
            InitializeComponent();
        }

        public SellerControl(User user) : this()
        {
            currentUser = user;
            InitializeControllers();
            InitializeWelcome();
            this.BackColor = Color.LightGreen;
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
                mainPanel.Controls.Clear();
                var productsControl = new SellerProductsControl();
                productsControl.Dock = DockStyle.Fill;
                mainPanel.Controls.Add(productsControl);
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
                mainPanel.Controls.Clear();
                var productTypesControl = new SellerProductTypesControl();
                productTypesControl.Dock = DockStyle.Fill;
                mainPanel.Controls.Add(productTypesControl);
            }
            catch (Exception ex)
            {
                ShowDetailedError("Грешка при зареждане на типове продукти", ex);
            }
        }

        private void manageSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                mainPanel.Controls.Clear();
                var salesControl = new SellerSalesControl(currentUser);
                salesControl.Dock = DockStyle.Fill;
                mainPanel.Controls.Add(salesControl);
            }
            catch (Exception ex)
            {
                ShowDetailedError("Грешка при зареждане на продажби", ex);
            }
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                mainPanel.Controls.Clear();
                var reportsControl = new ReportsControl();
                reportsControl.Dock = DockStyle.Fill;
                mainPanel.Controls.Add(reportsControl);
            }
            catch (Exception ex)
            {
                ShowDetailedError("Грешка при зареждане на отчети", ex);
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                mainPanel.Controls.Clear();
                var settingsControl = new SettingsControl();
                settingsControl.Dock = DockStyle.Fill;
                mainPanel.Controls.Add(settingsControl);
            }
            catch (Exception ex)
            {
                ShowDetailedError("Грешка при зареждане на настройки", ex);
            }
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                mainPanel.Controls.Clear();
                var profileControl = new ProfileControl(currentUser);
                profileControl.Dock = DockStyle.Fill;
                mainPanel.Controls.Add(profileControl);
            }
            catch (Exception ex)
            {
                ShowDetailedError("Грешка при зареждане на профил", ex);
            }
        }

        private void ShowDetailedError(string context, Exception ex)
        {
            string details = $"Контекст: {context}\n\n" +
                           $"Тип на грешка: {ex.GetType().Name}\n" +
                           $"Съобщение: {ex.Message}\n\n";

            if (ex.InnerException != null)
            {
                details += $"Вътрешна грешка: {ex.InnerException.Message}\n\n";
            }

            details += $"Stack Trace:\n{ex.StackTrace}";

            MessageBox.Show(details, "Детайлна информация за грешка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
} 
