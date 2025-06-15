namespace GastroSoft
{
    partial class SellerProductsControl
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
            this.lbProducts = new System.Windows.Forms.ListBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.txbBrand = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txbProductName = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txbDescription = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txbPrice = new System.Windows.Forms.TextBox();
            this.lblExpirationDate = new System.Windows.Forms.Label();
            this.txbExpirationDate = new System.Windows.Forms.TextBox();
            this.lblProductType = new System.Windows.Forms.Label();
            this.txbProductType = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbProducts
            // 
            this.lbProducts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbProducts.Font = new System.Drawing.Font("Calibri", 10F);
            this.lbProducts.FormattingEnabled = true;
            this.lbProducts.ItemHeight = 21;
            this.lbProducts.Location = new System.Drawing.Point(13, 80);
            this.lbProducts.Margin = new System.Windows.Forms.Padding(4);
            this.lbProducts.Name = "lbProducts";
            this.lbProducts.Size = new System.Drawing.Size(399, 613);
            this.lbProducts.TabIndex = 0;
            this.lbProducts.SelectedIndexChanged += new System.EventHandler(this.lbProducts_SelectedIndexChanged);
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblBrand.Location = new System.Drawing.Point(440, 80);
            this.lblBrand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(63, 21);
            this.lblBrand.TabIndex = 1;
            this.lblBrand.Text = "Марка:";
            // 
            // txbBrand
            // 
            this.txbBrand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbBrand.Font = new System.Drawing.Font("Calibri", 10F);
            this.txbBrand.Location = new System.Drawing.Point(600, 76);
            this.txbBrand.Margin = new System.Windows.Forms.Padding(4);
            this.txbBrand.Name = "txbBrand";
            this.txbBrand.Size = new System.Drawing.Size(345, 28);
            this.txbBrand.TabIndex = 2;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblProductName.Location = new System.Drawing.Point(440, 121);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(103, 21);
            this.lblProductName.TabIndex = 3;
            this.lblProductName.Text = "Име на продукт:";
            // 
            // txbProductName
            // 
            this.txbProductName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbProductName.Font = new System.Drawing.Font("Calibri", 10F);
            this.txbProductName.Location = new System.Drawing.Point(600, 118);
            this.txbProductName.Margin = new System.Windows.Forms.Padding(4);
            this.txbProductName.Name = "txbProductName";
            this.txbProductName.Size = new System.Drawing.Size(345, 28);
            this.txbProductName.TabIndex = 4;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblDescription.Location = new System.Drawing.Point(440, 162);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(85, 21);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Описание:";
            // 
            // txbDescription
            // 
            this.txbDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbDescription.Font = new System.Drawing.Font("Calibri", 10F);
            this.txbDescription.Location = new System.Drawing.Point(600, 159);
            this.txbDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txbDescription.Multiline = true;
            this.txbDescription.Name = "txbDescription";
            this.txbDescription.Size = new System.Drawing.Size(345, 73);
            this.txbDescription.TabIndex = 6;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblPrice.Location = new System.Drawing.Point(440, 255);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(51, 21);
            this.lblPrice.TabIndex = 7;
            this.lblPrice.Text = "Цена:";
            // 
            // txbPrice
            // 
            this.txbPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbPrice.Font = new System.Drawing.Font("Calibri", 10F);
            this.txbPrice.Location = new System.Drawing.Point(600, 251);
            this.txbPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.Size = new System.Drawing.Size(345, 28);
            this.txbPrice.TabIndex = 8;
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.AutoSize = true;
            this.lblExpirationDate.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblExpirationDate.Location = new System.Drawing.Point(440, 298);
            this.lblExpirationDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Size = new System.Drawing.Size(131, 21);
            this.lblExpirationDate.TabIndex = 9;
            this.lblExpirationDate.Text = "Срок на годност:";
            // 
            // txbExpirationDate
            // 
            this.txbExpirationDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbExpirationDate.Font = new System.Drawing.Font("Calibri", 10F);
            this.txbExpirationDate.Location = new System.Drawing.Point(600, 294);
            this.txbExpirationDate.Margin = new System.Windows.Forms.Padding(4);
            this.txbExpirationDate.Name = "txbExpirationDate";
            this.txbExpirationDate.ReadOnly = true;
            this.txbExpirationDate.Size = new System.Drawing.Size(345, 28);
            this.txbExpirationDate.TabIndex = 10;
            // 
            // lblProductType
            // 
            this.lblProductType.AutoSize = true;
            this.lblProductType.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblProductType.Location = new System.Drawing.Point(440, 341);
            this.lblProductType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(103, 21);
            this.lblProductType.TabIndex = 11;
            this.lblProductType.Text = "Тип продукт:";
            // 
            // txbProductType
            // 
            this.txbProductType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbProductType.Font = new System.Drawing.Font("Calibri", 10F);
            this.txbProductType.Location = new System.Drawing.Point(600, 337);
            this.txbProductType.Margin = new System.Windows.Forms.Padding(4);
            this.txbProductType.Name = "txbProductType";
            this.txbProductType.ReadOnly = true;
            this.txbProductType.Size = new System.Drawing.Size(345, 28);
            this.txbProductType.TabIndex = 12;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnEdit.Location = new System.Drawing.Point(633, 391);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 30);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Редактирай";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnClear.Location = new System.Drawing.Point(739, 391);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 30);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Изчисти";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // SellerProductsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txbProductType);
            this.Controls.Add(this.lblProductType);
            this.Controls.Add(this.txbExpirationDate);
            this.Controls.Add(this.lblExpirationDate);
            this.Controls.Add(this.txbPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txbDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txbProductName);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.txbBrand);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.lbProducts);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SellerProductsControl";
            this.Size = new System.Drawing.Size(1000, 714);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbProducts;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.TextBox txbBrand;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txbProductName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txbDescription;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txbPrice;
        private System.Windows.Forms.Label lblExpirationDate;
        private System.Windows.Forms.TextBox txbExpirationDate;
        private System.Windows.Forms.Label lblProductType;
        private System.Windows.Forms.TextBox txbProductType;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnClear;
    }
} 
