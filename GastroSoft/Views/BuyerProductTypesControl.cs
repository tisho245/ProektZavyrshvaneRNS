using System;
using System.Windows.Forms;
using GastroSoft.Controllers;
using GastroSoft.Models;
using GastroSoft.Model;
using System.Drawing;
using System.Linq;

namespace GastroSoft
{
    public partial class BuyerProductTypesControl : UserControl
    {
        private ProductTypeController productTypeController;
        private User currentUser;
        private ProductType selectedProductType = null;

        public BuyerProductTypesControl()
        {
            InitializeComponent();
            productTypeController = new ProductTypeController();
            LoadProductTypes();
        }

        public BuyerProductTypesControl(User user) : this()
        {
            currentUser = user;
        }

        private void LoadProductTypes()
        {
            try
            {
                var productTypes = productTypeController.GetAll();
                    
                lbProductTypes.Items.Clear();
                foreach (var productType in productTypes)
                {
                    lbProductTypes.Items.Add($"{productType.ProductTypeNumber} | {productType.ProductTypeName}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Грешка при зареждане на типове продукти: {ex.Message}", 
                    "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lbProductTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbProductTypes.SelectedIndex >= 0)
            {
                try
                {
                    var productTypes = productTypeController.GetAll();
                    selectedProductType = productTypes[lbProductTypes.SelectedIndex];
                    
                    // Populate read-only text boxes with selected product type data
                    txbProductTypeNumber.Text = selectedProductType.ProductTypeNumber.ToString();
                    txbProductTypeName.Text = selectedProductType.ProductTypeName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Грешка при филтриране на типове: {ex.Message}", 
                        "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadProductTypes();
            ClearProductTypeDetails();
        }

        private void ClearProductTypeDetails()
        {
            txbProductTypeNumber.Clear();
            txbProductTypeName.Clear();
            selectedProductType = null;
            lbProductTypes.SelectedIndex = -1;
        }
    }
}
