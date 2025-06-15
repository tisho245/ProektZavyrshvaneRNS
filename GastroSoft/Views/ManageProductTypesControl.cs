using System;
using System.Windows.Forms;
using GastroSoft.Controllers;
using GastroSoft.Model;
using System.Drawing;
using System.Linq;

namespace GastroSoft
{
    public partial class ManageProductTypesControl : UserControl
    {
        private ProductTypeController productTypeController;
        private ProductType selectedProductType = null;

        public ManageProductTypesControl()
        {
            InitializeComponent();
            productTypeController = new ProductTypeController();
            LoadProductTypes();
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
                    string selectedItem = lbProductTypes.SelectedItem.ToString();
                    int productTypeNumber = int.Parse(selectedItem.Split('|')[0].Trim());
                    selectedProductType = productTypeController.Get(productTypeNumber);
                    
                    if (selectedProductType != null)
                    {
                        //txbProductTypeNumber.Text = selectedProductType.ProductTypeNumber.ToString();
                        txbProductTypeName.Text = selectedProductType.ProductTypeName;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Грешка при избиране на тип продукт: {ex.Message}", 
                        "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input
                if (string.IsNullOrWhiteSpace(txbProductTypeName.Text))
                {
                    MessageBox.Show("Името на типа е задължително!", "Грешка", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (selectedProductType != null)
                {
                    // Update existing product type
                    selectedProductType.ProductTypeName = txbProductTypeName.Text.Trim();
                    
                    productTypeController.Update(selectedProductType.ProductTypeNumber, selectedProductType);
                    MessageBox.Show("Типът продукт е обновен успешно!", "Успех", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Create new product type (ProductTypeNumber is auto increment)
                    var newProductType = new ProductType
                    {
                        ProductTypeName = txbProductTypeName.Text.Trim()
                    };
                    
                    productTypeController.Create(newProductType);
                    MessageBox.Show("Новият тип продукт е създаден успешно!", "Успех", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
                LoadProductTypes();
                ClearTextBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Грешка при запазване: {ex.Message}", 
                    "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedProductType != null)
            {
                try
                {
                    var result = MessageBox.Show($"Сигурни ли сте, че искате да изтриете тип продукт '{selectedProductType.ProductTypeName}'?", 
                        "Потвърждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    
                    if (result == DialogResult.Yes)
                    {
                        productTypeController.Delete(selectedProductType.ProductTypeNumber);
                        MessageBox.Show("Типът продукт е изтрит успешно!", "Успех", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        LoadProductTypes();
                        ClearTextBoxes();
                        selectedProductType = null;
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
                MessageBox.Show("Моля изберете тип продукт за изтриване!", "Информация", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            selectedProductType = null;
            lbProductTypes.SelectedIndex = -1;
        }

        private void ClearTextBoxes()
        {
            txbProductTypeName.Clear();
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            selectedProductType = null;
            lbProductTypes.SelectedIndex = -1;
            txbProductTypeName.Focus();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ManageProductTypesControl_Load(object sender, EventArgs e)
        {
            LoadProductTypes();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Validate input
                if (string.IsNullOrWhiteSpace(txbProductTypeName.Text))
                {
                    MessageBox.Show("Името на типа е задължително!", "Грешка", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Create new product type (ProductTypeNumber is auto increment)
                ProductType productType = new ProductType
                {
                    ProductTypeName = txbProductTypeName.Text.Trim()
                };

                productTypeController.Create(productType);
                MessageBox.Show("Новият тип продукт е създаден успешно!", "Успех", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                LoadProductTypes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Грешка при създаване на тип продукт: {ex.Message}", 
                    "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
} 
