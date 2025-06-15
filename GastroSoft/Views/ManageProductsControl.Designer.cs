namespace GastroSoft
{
    partial class ManageProductsControl
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
            this.foodShopDataSet = new GastroSoft.FoodShopDataSet();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new GastroSoft.FoodShopDataSetTableAdapters.ProductsTableAdapter();
            this.lblBrand = new System.Windows.Forms.Label();
            this.txbBrand = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txbProductName = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txbDescription = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txbPrice = new System.Windows.Forms.TextBox();
            this.lblExpirationDate = new System.Windows.Forms.Label();
            this.dtpExpirationDate = new System.Windows.Forms.DateTimePicker();
            this.lblProductType = new System.Windows.Forms.Label();
            this.txbProductType = new System.Windows.Forms.TextBox();
            this.lblProducts = new System.Windows.Forms.Label();
            this.lbProducts = new System.Windows.Forms.ListBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.foodShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // foodShopDataSet
            // 
            this.foodShopDataSet.DataSetName = "FoodShopDataSet";
            this.foodShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.foodShopDataSet;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblBrand.Location = new System.Drawing.Point(20, 50);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(63, 21);
            this.lblBrand.TabIndex = 2;
            this.lblBrand.Text = "Марка:";
            // 
            // txbBrand
            // 
            this.txbBrand.Font = new System.Drawing.Font("Calibri", 10F);
            this.txbBrand.Location = new System.Drawing.Point(20, 70);
            this.txbBrand.Name = "txbBrand";
            this.txbBrand.Size = new System.Drawing.Size(200, 28);
            this.txbBrand.TabIndex = 3;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblProductName.Location = new System.Drawing.Point(20, 110);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(130, 21);
            this.lblProductName.TabIndex = 4;
            this.lblProductName.Text = "Име на продукт:";
            // 
            // txbProductName
            // 
            this.txbProductName.Font = new System.Drawing.Font("Calibri", 10F);
            this.txbProductName.Location = new System.Drawing.Point(20, 130);
            this.txbProductName.Name = "txbProductName";
            this.txbProductName.Size = new System.Drawing.Size(200, 28);
            this.txbProductName.TabIndex = 5;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblDescription.Location = new System.Drawing.Point(20, 170);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(85, 21);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = "Описание:";
            // 
            // txbDescription
            // 
            this.txbDescription.Font = new System.Drawing.Font("Calibri", 10F);
            this.txbDescription.Location = new System.Drawing.Point(20, 190);
            this.txbDescription.Multiline = true;
            this.txbDescription.Name = "txbDescription";
            this.txbDescription.Size = new System.Drawing.Size(200, 60);
            this.txbDescription.TabIndex = 7;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblPrice.Location = new System.Drawing.Point(20, 270);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(51, 21);
            this.lblPrice.TabIndex = 8;
            this.lblPrice.Text = "Цена:";
            // 
            // txbPrice
            // 
            this.txbPrice.Font = new System.Drawing.Font("Calibri", 10F);
            this.txbPrice.Location = new System.Drawing.Point(20, 290);
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.Size = new System.Drawing.Size(200, 28);
            this.txbPrice.TabIndex = 9;
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.AutoSize = true;
            this.lblExpirationDate.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblExpirationDate.Location = new System.Drawing.Point(20, 330);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Size = new System.Drawing.Size(131, 21);
            this.lblExpirationDate.TabIndex = 10;
            this.lblExpirationDate.Text = "Срок на годност:";
            // 
            // dtpExpirationDate
            // 
            this.dtpExpirationDate.Font = new System.Drawing.Font("Calibri", 10F);
            this.dtpExpirationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExpirationDate.Location = new System.Drawing.Point(20, 350);
            this.dtpExpirationDate.Name = "dtpExpirationDate";
            this.dtpExpirationDate.Size = new System.Drawing.Size(200, 28);
            this.dtpExpirationDate.TabIndex = 11;
            // 
            // lblProductType
            // 
            this.lblProductType.AutoSize = true;
            this.lblProductType.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblProductType.Location = new System.Drawing.Point(20, 390);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(103, 21);
            this.lblProductType.TabIndex = 12;
            this.lblProductType.Text = "Тип продукт:";
            // 
            // txbProductType
            // 
            this.txbProductType.Font = new System.Drawing.Font("Calibri", 10F);
            this.txbProductType.Location = new System.Drawing.Point(20, 410);
            this.txbProductType.Name = "txbProductType";
            this.txbProductType.Size = new System.Drawing.Size(200, 28);
            this.txbProductType.TabIndex = 13;
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblProducts.Location = new System.Drawing.Point(226, 48);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(96, 24);
            this.lblProducts.TabIndex = 14;
            this.lblProducts.Text = "Продукти:";
            // 
            // lbProducts
            // 
            this.lbProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbProducts.Font = new System.Drawing.Font("Calibri", 10F);
            this.lbProducts.FormattingEnabled = true;
            this.lbProducts.ItemHeight = 21;
            this.lbProducts.Location = new System.Drawing.Point(226, 75);
            this.lbProducts.Name = "lbProducts";
            this.lbProducts.Size = new System.Drawing.Size(496, 403);
            this.lbProducts.TabIndex = 15;
            this.lbProducts.SelectedIndexChanged += new System.EventHandler(this.lbProducts_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnDelete.Location = new System.Drawing.Point(106, 490);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(114, 30);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Изтрий";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnClear.Location = new System.Drawing.Point(20, 490);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 30);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Изчисти";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnAdd.Location = new System.Drawing.Point(20, 454);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 30);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Добави";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnEdit.Location = new System.Drawing.Point(106, 454);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(114, 30);
            this.btnEdit.TabIndex = 20;
            this.btnEdit.Text = "Запази";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // ManageProductsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lbProducts);
            this.Controls.Add(this.lblProducts);
            this.Controls.Add(this.txbProductType);
            this.Controls.Add(this.lblProductType);
            this.Controls.Add(this.dtpExpirationDate);
            this.Controls.Add(this.lblExpirationDate);
            this.Controls.Add(this.txbPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txbDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txbProductName);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.txbBrand);
            this.Controls.Add(this.lblBrand);
            this.Name = "ManageProductsControl";
            this.Size = new System.Drawing.Size(750, 580);
            ((System.ComponentModel.ISupportInitialize)(this.foodShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.TextBox txbBrand;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txbProductName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txbDescription;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txbPrice;
        private System.Windows.Forms.Label lblExpirationDate;
        private System.Windows.Forms.DateTimePicker dtpExpirationDate;
        private System.Windows.Forms.Label lblProductType;
        private System.Windows.Forms.TextBox txbProductType;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.ListBox lbProducts;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private FoodShopDataSet foodShopDataSet;
        private FoodShopDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
    }
} 
