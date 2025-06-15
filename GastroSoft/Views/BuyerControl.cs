using System;
using System.Drawing;
using System.Windows.Forms;
using GastroSoft.Controllers;
using GastroSoft.Models;
using GastroSoft.Views;

namespace GastroSoft
{
    public partial class BuyerControl : UserControl
    {
        private ProductController productController;
        private SellController sellController;
        private User currentUser;

        public BuyerControl()
        {
            InitializeComponent();
        }

        public BuyerControl(User user) : this()
        {
            currentUser = user;
            InitializeControllers();
            InitializeWelcome();
            this.BackColor = Color.LightCoral;
        }

        private void InitializeControllers()
        {
            productController = new ProductController();
            sellController = new SellController();
        }

        private void InitializeWelcome()
        {
            lblWelcome.Text = $"Добре дошли, {currentUser.FirstName}! (Клиент)";
        }

        private void productCatalogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                mainPanel.Controls.Clear();
                var productsControl = new BuyerProductsControl(currentUser);
                productsControl.Dock = DockStyle.Fill;
                mainPanel.Controls.Add(productsControl);
            }
            catch (Exception ex)
            {
                ShowDetailedError("Грешка при зареждане на каталог с продукти", ex);
            }
        }

        private void productTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                mainPanel.Controls.Clear();
                BuyerProductTypesControl productTypesControl = new BuyerProductTypesControl();
                productTypesControl.Dock = DockStyle.Fill;
                mainPanel.Controls.Add(productTypesControl);
            }
            catch (Exception ex)
            {
                ShowDetailedError("Грешка при зареждане на типове продукти", ex);
            }
        }

        private void myPurchasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                mainPanel.Controls.Clear();
                var purchasesControl = new BuyerPurchasesControl(currentUser);
                purchasesControl.Dock = DockStyle.Fill;
                mainPanel.Controls.Add(purchasesControl);
            }
            catch (Exception ex)
            {
                ShowDetailedError("Грешка при зареждане на покупки", ex);
            }
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                mainPanel.Controls.Clear();
                ProfileControl profileControl = new ProfileControl(currentUser);
                profileControl.Dock = DockStyle.Fill;
                mainPanel.Controls.Add(profileControl);
            }
            catch (Exception ex)
            {
                ShowDetailedError("Грешка при зареждане на профил", ex);
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

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                mainPanel.Controls.Clear();
                var helpControl = new HelpControl();
                helpControl.Dock = DockStyle.Fill;
                mainPanel.Controls.Add(helpControl);
            }
            catch (Exception ex)
            {
                ShowDetailedError("Грешка при зареждане на помощ", ex);
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

        private void BuyerControl_Load(object sender, EventArgs e)
        {
            // Load default view - product catalog
            productCatalogToolStripMenuItem_Click(sender, e);
        }
    }
} 
