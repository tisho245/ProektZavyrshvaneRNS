using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GastroSoft.Controllers;
using GastroSoft.Models;
using GastroSoft.Model;

namespace GastroSoft.Views
{
    public partial class SellerProductTypesControl : UserControl
    {
        private ProductTypeController productTypeController;
        private List<ProductType> allProductTypes;
        private ProductType selectedProductType;

        public SellerProductTypesControl()
        {
            InitializeComponent();
            productTypeController = new ProductTypeController();
            LoadProductTypes();
        }

        private void LoadProductTypes()
        {
            try
            {
                allProductTypes = productTypeController.GetAll();
                RefreshProductTypesList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Грешка при зареждане на типовете продукти: {ex.Message}",
                    "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshProductTypesList()
        {
            lbProductTypes.Items.Clear();
            
            foreach (var productType in allProductTypes)
            {
                lbProductTypes.Items.Add($"{productType.ProductTypeNumber} - {productType.ProductTypeName}");
            }

            ClearTextBoxes();
        }

        private void lbProductTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbProductTypes.SelectedIndex >= 0 && lbProductTypes.SelectedIndex < allProductTypes.Count)
            {
                selectedProductType = allProductTypes[lbProductTypes.SelectedIndex];
                DisplayProductTypeDetails(selectedProductType);
            }
        }

        private void DisplayProductTypeDetails(ProductType productType)
        {
            try
            {
                txbProductTypeName.Text = productType.ProductTypeName ?? "";
                txbProductTypeNumber.Text = productType.ProductTypeNumber.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Грешка при зареждане на типовете: {ex.Message}",
                    "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearTextBoxes()
        {
            txbProductTypeName.Clear();
            txbProductTypeNumber.Clear();
            selectedProductType = null;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedProductType != null)
            {
                try
                {
                    // Open edit dialog
                    using (var editForm = new Form())
                    {
                        editForm.Text = "Редактиране на тип продукт";
                        editForm.Size = new Size(400, 200);
                        editForm.StartPosition = FormStartPosition.CenterParent;
                        
                        var lblName = new Label() { Text = "Име на типа:", Location = new Point(10, 20), Width = 80 };
                        var txtName = new TextBox() { Text = selectedProductType.ProductTypeName, Location = new Point(100, 18), Width = 250 };
                        
                        var btnSave = new Button() { Text = "Запази", DialogResult = DialogResult.OK, Location = new Point(180, 60), Width = 80 };
                        var btnCancel = new Button() { Text = "Отказ", DialogResult = DialogResult.Cancel, Location = new Point(270, 60), Width = 80 };
                        
                        editForm.Controls.AddRange(new Control[] { lblName, txtName, btnSave, btnCancel });
                        editForm.AcceptButton = btnSave;
                        editForm.CancelButton = btnCancel;
                        
                        if (editForm.ShowDialog() == DialogResult.OK)
                        {
                            // Validate and update
                            if (string.IsNullOrWhiteSpace(txtName.Text))
                            {
                                MessageBox.Show("Не сте въвели име на типа!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            
                            selectedProductType.ProductTypeName = txtName.Text;
                            
                            productTypeController.Update(selectedProductType.ProductTypeNumber, selectedProductType);
                            MessageBox.Show("Типът е успешно редактиран!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadProductTypes();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Грешка при редактиране: {ex.Message}", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Типът продукт не може да бъде изтрит!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            lbProductTypes.SelectedIndex = -1;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Parent?.Controls.Remove(this);
        }
    }
}
