namespace GastroSoft
{
    partial class BuyerProductsControl
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
            this.lblProductType = new System.Windows.Forms.Label();
            this.txbProductType = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txbDescription = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txbPrice = new System.Windows.Forms.TextBox();
            this.lblExpirationDate = new System.Windows.Forms.Label();
            this.txbExpirationDate = new System.Windows.Forms.TextBox();
            this.lblProducts = new System.Windows.Forms.Label();
            this.lbProducts = new System.Windows.Forms.ListBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnBuySelected = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.foodShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
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
            this.txbBrand.ReadOnly = true;
            this.txbBrand.Size = new System.Drawing.Size(200, 28);
            this.txbBrand.TabIndex = 3;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblProductName.Location = new System.Drawing.Point(20, 100);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(130, 21);
            this.lblProductName.TabIndex = 4;
            this.lblProductName.Text = "Име на продукт:";
            // 
            // txbProductName
            // 
            this.txbProductName.Font = new System.Drawing.Font("Calibri", 10F);
            this.txbProductName.Location = new System.Drawing.Point(20, 120);
            this.txbProductName.Name = "txbProductName";
            this.txbProductName.ReadOnly = true;
            this.txbProductName.Size = new System.Drawing.Size(200, 28);
            this.txbProductName.TabIndex = 5;
            // 
            // lblProductType
            // 
            this.lblProductType.AutoSize = true;
            this.lblProductType.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblProductType.Location = new System.Drawing.Point(20, 150);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(103, 21);
            this.lblProductType.TabIndex = 6;
            this.lblProductType.Text = "Тип продукт:";
            // 
            // txbProductType
            // 
            this.txbProductType.Font = new System.Drawing.Font("Calibri", 10F);
            this.txbProductType.Location = new System.Drawing.Point(20, 170);
            this.txbProductType.Name = "txbProductType";
            this.txbProductType.ReadOnly = true;
            this.txbProductType.Size = new System.Drawing.Size(200, 28);
            this.txbProductType.TabIndex = 7;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblDescription.Location = new System.Drawing.Point(20, 210);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(85, 21);
            this.lblDescription.TabIndex = 8;
            this.lblDescription.Text = "Описание:";
            // 
            // txbDescription
            // 
            this.txbDescription.Font = new System.Drawing.Font("Calibri", 10F);
            this.txbDescription.Location = new System.Drawing.Point(20, 230);
            this.txbDescription.Multiline = true;
            this.txbDescription.Name = "txbDescription";
            this.txbDescription.ReadOnly = true;
            this.txbDescription.Size = new System.Drawing.Size(200, 60);
            this.txbDescription.TabIndex = 9;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblPrice.Location = new System.Drawing.Point(20, 310);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(51, 21);
            this.lblPrice.TabIndex = 10;
            this.lblPrice.Text = "Цена:";
            // 
            // txbPrice
            // 
            this.txbPrice.Font = new System.Drawing.Font("Calibri", 10F);
            this.txbPrice.Location = new System.Drawing.Point(20, 330);
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.ReadOnly = true;
            this.txbPrice.Size = new System.Drawing.Size(200, 28);
            this.txbPrice.TabIndex = 11;
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.AutoSize = true;
            this.lblExpirationDate.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblExpirationDate.Location = new System.Drawing.Point(20, 370);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Size = new System.Drawing.Size(131, 21);
            this.lblExpirationDate.TabIndex = 12;
            this.lblExpirationDate.Text = "Срок на годност:";
            // 
            // txbExpirationDate
            // 
            this.txbExpirationDate.Font = new System.Drawing.Font("Calibri", 10F);
            this.txbExpirationDate.Location = new System.Drawing.Point(20, 390);
            this.txbExpirationDate.Name = "txbExpirationDate";
            this.txbExpirationDate.ReadOnly = true;
            this.txbExpirationDate.Size = new System.Drawing.Size(200, 28);
            this.txbExpirationDate.TabIndex = 13;
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblProducts.Location = new System.Drawing.Point(280, 50);
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
            this.lbProducts.Location = new System.Drawing.Point(280, 75);
            this.lbProducts.Name = "lbProducts";
            this.lbProducts.Size = new System.Drawing.Size(420, 361);
            this.lbProducts.TabIndex = 15;
            this.lbProducts.SelectedIndexChanged += new System.EventHandler(this.lbProducts_SelectedIndexChanged);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblQuantity.Location = new System.Drawing.Point(20, 430);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(98, 21);
            this.lblQuantity.TabIndex = 16;
            this.lblQuantity.Text = "Количество:";
            // 
            // numQuantity
            // 
            this.numQuantity.Font = new System.Drawing.Font("Calibri", 10F);
            this.numQuantity.Location = new System.Drawing.Point(20, 450);
            this.numQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(120, 28);
            this.numQuantity.TabIndex = 17;
            this.numQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnBuySelected
            // 
            this.btnBuySelected.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnBuySelected.Location = new System.Drawing.Point(150, 445);
            this.btnBuySelected.Name = "btnBuySelected";
            this.btnBuySelected.Size = new System.Drawing.Size(100, 35);
            this.btnBuySelected.TabIndex = 18;
            this.btnBuySelected.Text = "Купи";
            this.btnBuySelected.UseVisualStyleBackColor = true;
            this.btnBuySelected.Click += new System.EventHandler(this.btnBuySelected_Click);
            // 
            // BuyerProductsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBuySelected);
            this.Controls.Add(this.numQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lbProducts);
            this.Controls.Add(this.lblProducts);
            this.Controls.Add(this.txbExpirationDate);
            this.Controls.Add(this.lblExpirationDate);
            this.Controls.Add(this.txbPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txbDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txbProductType);
            this.Controls.Add(this.lblProductType);
            this.Controls.Add(this.txbProductName);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.txbBrand);
            this.Controls.Add(this.lblBrand);
            this.Name = "BuyerProductsControl";
            this.Size = new System.Drawing.Size(750, 580);
            ((System.ComponentModel.ISupportInitialize)(this.foodShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.TextBox txbBrand;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txbProductName;
        private System.Windows.Forms.Label lblProductType;
        private System.Windows.Forms.TextBox txbProductType;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txbDescription;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txbPrice;
        private System.Windows.Forms.Label lblExpirationDate;
        private System.Windows.Forms.TextBox txbExpirationDate;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.ListBox lbProducts;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Button btnBuySelected;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private FoodShopDataSet foodShopDataSet;
        private FoodShopDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
    }
} 
