namespace GastroSoft
{
    partial class ManageSalesControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbSales = new System.Windows.Forms.ListBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.txbProduct = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txbQuantity = new System.Windows.Forms.TextBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.txbTotalPrice = new System.Windows.Forms.TextBox();
            this.lblDateOfSale = new System.Windows.Forms.Label();
            this.dtpDateOfSale = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.foodShopDataSet = new GastroSoft.FoodShopDataSet();
            this.sellsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sellsTableAdapter = new GastroSoft.FoodShopDataSetTableAdapters.SellsTableAdapter();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.foodShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbSales
            // 
            this.lbSales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbSales.Font = new System.Drawing.Font("Calibri", 10F);
            this.lbSales.FormattingEnabled = true;
            this.lbSales.ItemHeight = 21;
            this.lbSales.Location = new System.Drawing.Point(13, 44);
            this.lbSales.Margin = new System.Windows.Forms.Padding(4);
            this.lbSales.Name = "lbSales";
            this.lbSales.Size = new System.Drawing.Size(399, 634);
            this.lbSales.TabIndex = 0;
            this.lbSales.SelectedIndexChanged += new System.EventHandler(this.lbSales_SelectedIndexChanged);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblUsername.Location = new System.Drawing.Point(440, 86);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(101, 21);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Потребител:";
            // 
            // txbUsername
            // 
            this.txbUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbUsername.Font = new System.Drawing.Font("Calibri", 10F);
            this.txbUsername.Location = new System.Drawing.Point(600, 82);
            this.txbUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Size = new System.Drawing.Size(345, 28);
            this.txbUsername.TabIndex = 2;
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblProduct.Location = new System.Drawing.Point(440, 129);
            this.lblProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(76, 21);
            this.lblProduct.TabIndex = 3;
            this.lblProduct.Text = "Продукт:";
            // 
            // txbProduct
            // 
            this.txbProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbProduct.Font = new System.Drawing.Font("Calibri", 10F);
            this.txbProduct.Location = new System.Drawing.Point(600, 126);
            this.txbProduct.Margin = new System.Windows.Forms.Padding(4);
            this.txbProduct.Name = "txbProduct";
            this.txbProduct.ReadOnly = true;
            this.txbProduct.Size = new System.Drawing.Size(345, 28);
            this.txbProduct.TabIndex = 4;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblQuantity.Location = new System.Drawing.Point(440, 172);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(98, 21);
            this.lblQuantity.TabIndex = 5;
            this.lblQuantity.Text = "Количество:";
            // 
            // txbQuantity
            // 
            this.txbQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbQuantity.Font = new System.Drawing.Font("Calibri", 10F);
            this.txbQuantity.Location = new System.Drawing.Point(600, 169);
            this.txbQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.txbQuantity.Name = "txbQuantity";
            this.txbQuantity.Size = new System.Drawing.Size(345, 28);
            this.txbQuantity.TabIndex = 6;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblTotalPrice.Location = new System.Drawing.Point(440, 215);
            this.lblTotalPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(94, 21);
            this.lblTotalPrice.TabIndex = 7;
            this.lblTotalPrice.Text = "Обща цена:";
            // 
            // txbTotalPrice
            // 
            this.txbTotalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbTotalPrice.Font = new System.Drawing.Font("Calibri", 10F);
            this.txbTotalPrice.Location = new System.Drawing.Point(600, 212);
            this.txbTotalPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txbTotalPrice.Name = "txbTotalPrice";
            this.txbTotalPrice.Size = new System.Drawing.Size(345, 28);
            this.txbTotalPrice.TabIndex = 8;
            // 
            // lblDateOfSale
            // 
            this.lblDateOfSale.AutoSize = true;
            this.lblDateOfSale.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblDateOfSale.Location = new System.Drawing.Point(440, 258);
            this.lblDateOfSale.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateOfSale.Name = "lblDateOfSale";
            this.lblDateOfSale.Size = new System.Drawing.Size(147, 21);
            this.lblDateOfSale.TabIndex = 9;
            this.lblDateOfSale.Text = "Дата на продажба:";
            // 
            // dtpDateOfSale
            // 
            this.dtpDateOfSale.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDateOfSale.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpDateOfSale.Font = new System.Drawing.Font("Calibri", 10F);
            this.dtpDateOfSale.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateOfSale.Location = new System.Drawing.Point(600, 255);
            this.dtpDateOfSale.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDateOfSale.Name = "dtpDateOfSale";
            this.dtpDateOfSale.Size = new System.Drawing.Size(345, 28);
            this.dtpDateOfSale.TabIndex = 10;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnSave.Location = new System.Drawing.Point(528, 359);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 37);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Запиши";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnDelete.Location = new System.Drawing.Point(636, 359);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 37);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Изтрий";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnClear.Location = new System.Drawing.Point(528, 404);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(208, 37);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Изчисти";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // foodShopDataSet
            // 
            this.foodShopDataSet.DataSetName = "FoodShopDataSet";
            this.foodShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sellsBindingSource
            // 
            this.sellsBindingSource.DataMember = "Sells";
            this.sellsBindingSource.DataSource = this.foodShopDataSet;
            // 
            // sellsTableAdapter
            // 
            this.sellsTableAdapter.ClearBeforeFill = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnAdd.Location = new System.Drawing.Point(528, 314);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(208, 37);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Добави";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // ManageSalesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpDateOfSale);
            this.Controls.Add(this.lblDateOfSale);
            this.Controls.Add(this.txbTotalPrice);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.txbQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txbProduct);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.txbUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lbSales);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManageSalesControl";
            this.Size = new System.Drawing.Size(1000, 714);
            this.Load += new System.EventHandler(this.ManageSalesControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.foodShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbSales;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txbUsername;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.TextBox txbProduct;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txbQuantity;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.TextBox txbTotalPrice;
        private System.Windows.Forms.Label lblDateOfSale;
        private System.Windows.Forms.DateTimePicker dtpDateOfSale;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.BindingSource sellsBindingSource;
        private FoodShopDataSet foodShopDataSet;
        private FoodShopDataSetTableAdapters.SellsTableAdapter sellsTableAdapter;
        private System.Windows.Forms.Button btnAdd;
    }
} 
