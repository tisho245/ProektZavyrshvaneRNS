namespace GastroSoft
{
    partial class BuyerPurchasesControl
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
            this.lbPurchases = new System.Windows.Forms.ListBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.txbProduct = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txbQuantity = new System.Windows.Forms.TextBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.txbTotalPrice = new System.Windows.Forms.TextBox();
            this.lblPurchaseDate = new System.Windows.Forms.Label();
            this.txbPurchaseDate = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txbStatus = new System.Windows.Forms.TextBox();
            this.btnViewDetails = new System.Windows.Forms.Button();
            this.btnUpdateQuantity = new System.Windows.Forms.Button();
            this.foodShopDataSet = new GastroSoft.FoodShopDataSet();
            this.sellsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sellsTableAdapter = new GastroSoft.FoodShopDataSetTableAdapters.SellsTableAdapter();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblTotalPurchases = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTotalAmount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnExport = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.foodShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellsBindingSource)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbPurchases
            // 
            this.lbPurchases.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbPurchases.Font = new System.Drawing.Font("Calibri", 10F);
            this.lbPurchases.FormattingEnabled = true;
            this.lbPurchases.ItemHeight = 21;
            this.lbPurchases.Location = new System.Drawing.Point(13, 49);
            this.lbPurchases.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbPurchases.Name = "lbPurchases";
            this.lbPurchases.Size = new System.Drawing.Size(399, 592);
            this.lbPurchases.TabIndex = 0;
            this.lbPurchases.SelectedIndexChanged += new System.EventHandler(this.lbPurchases_SelectedIndexChanged);
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblProduct.Location = new System.Drawing.Point(440, 49);
            this.lblProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(76, 21);
            this.lblProduct.TabIndex = 1;
            this.lblProduct.Text = "Продукт:";
            // 
            // txbProduct
            // 
            this.txbProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbProduct.Font = new System.Drawing.Font("Calibri", 10F);
            this.txbProduct.Location = new System.Drawing.Point(600, 46);
            this.txbProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbProduct.Name = "txbProduct";
            this.txbProduct.ReadOnly = true;
            this.txbProduct.Size = new System.Drawing.Size(345, 28);
            this.txbProduct.TabIndex = 2;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblQuantity.Location = new System.Drawing.Point(440, 92);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(98, 21);
            this.lblQuantity.TabIndex = 3;
            this.lblQuantity.Text = "Количество:";
            // 
            // txbQuantity
            // 
            this.txbQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbQuantity.Font = new System.Drawing.Font("Calibri", 10F);
            this.txbQuantity.Location = new System.Drawing.Point(600, 89);
            this.txbQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbQuantity.Name = "txbQuantity";
            this.txbQuantity.Size = new System.Drawing.Size(345, 28);
            this.txbQuantity.TabIndex = 4;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblTotalPrice.Location = new System.Drawing.Point(440, 135);
            this.lblTotalPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(94, 21);
            this.lblTotalPrice.TabIndex = 5;
            this.lblTotalPrice.Text = "Обща цена:";
            // 
            // txbTotalPrice
            // 
            this.txbTotalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbTotalPrice.Font = new System.Drawing.Font("Calibri", 10F);
            this.txbTotalPrice.Location = new System.Drawing.Point(600, 132);
            this.txbTotalPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbTotalPrice.Name = "txbTotalPrice";
            this.txbTotalPrice.ReadOnly = true;
            this.txbTotalPrice.Size = new System.Drawing.Size(345, 28);
            this.txbTotalPrice.TabIndex = 6;
            // 
            // lblPurchaseDate
            // 
            this.lblPurchaseDate.AutoSize = true;
            this.lblPurchaseDate.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblPurchaseDate.Location = new System.Drawing.Point(440, 178);
            this.lblPurchaseDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPurchaseDate.Name = "lblPurchaseDate";
            this.lblPurchaseDate.Size = new System.Drawing.Size(49, 21);
            this.lblPurchaseDate.TabIndex = 7;
            this.lblPurchaseDate.Text = "Дата:";
            // 
            // txbPurchaseDate
            // 
            this.txbPurchaseDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbPurchaseDate.Font = new System.Drawing.Font("Calibri", 10F);
            this.txbPurchaseDate.Location = new System.Drawing.Point(600, 175);
            this.txbPurchaseDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbPurchaseDate.Name = "txbPurchaseDate";
            this.txbPurchaseDate.ReadOnly = true;
            this.txbPurchaseDate.Size = new System.Drawing.Size(345, 28);
            this.txbPurchaseDate.TabIndex = 8;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblStatus.Location = new System.Drawing.Point(440, 222);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(61, 21);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "Статус:";
            // 
            // txbStatus
            // 
            this.txbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbStatus.Font = new System.Drawing.Font("Calibri", 10F);
            this.txbStatus.Location = new System.Drawing.Point(600, 218);
            this.txbStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbStatus.Name = "txbStatus";
            this.txbStatus.ReadOnly = true;
            this.txbStatus.Size = new System.Drawing.Size(345, 28);
            this.txbStatus.TabIndex = 10;
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnViewDetails.Location = new System.Drawing.Point(600, 271);
            this.btnViewDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Size = new System.Drawing.Size(160, 37);
            this.btnViewDetails.TabIndex = 11;
            this.btnViewDetails.Text = "Детайли";
            this.btnViewDetails.UseVisualStyleBackColor = true;
            this.btnViewDetails.Click += new System.EventHandler(this.btnViewDetails_Click);
            // 
            // btnUpdateQuantity
            // 
            this.btnUpdateQuantity.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnUpdateQuantity.Location = new System.Drawing.Point(600, 331);
            this.btnUpdateQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdateQuantity.Name = "btnUpdateQuantity";
            this.btnUpdateQuantity.Size = new System.Drawing.Size(160, 37);
            this.btnUpdateQuantity.TabIndex = 12;
            this.btnUpdateQuantity.Text = "Обнови количество";
            this.btnUpdateQuantity.UseVisualStyleBackColor = true;
            this.btnUpdateQuantity.Click += new System.EventHandler(this.btnUpdateQuantity_Click);
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
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Calibri", 10F);
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTotalPurchases,
            this.lblTotalAmount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 687);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1000, 27);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblTotalPurchases
            // 
            this.lblTotalPurchases.Name = "lblTotalPurchases";
            this.lblTotalPurchases.Size = new System.Drawing.Size(134, 21);
            this.lblTotalPurchases.Text = "Общо покупки: 0";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(151, 21);
            this.lblTotalAmount.Text = "Обща сума: 0.00 лв";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Calibri", 10F);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExport,
            this.btnRefresh});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1000, 28);
            this.toolStrip1.TabIndex = 14;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnExport
            // 
            this.btnExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(71, 25);
            this.btnExport.Text = "Експорт";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(69, 25);
            this.btnRefresh.Text = "Обнови";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // BuyerPurchasesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnUpdateQuantity);
            this.Controls.Add(this.btnViewDetails);
            this.Controls.Add(this.txbStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txbPurchaseDate);
            this.Controls.Add(this.lblPurchaseDate);
            this.Controls.Add(this.txbTotalPrice);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.txbQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txbProduct);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.lbPurchases);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BuyerPurchasesControl";
            this.Size = new System.Drawing.Size(1000, 714);
            ((System.ComponentModel.ISupportInitialize)(this.foodShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellsBindingSource)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbPurchases;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.TextBox txbProduct;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txbQuantity;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.TextBox txbTotalPrice;
        private System.Windows.Forms.Label lblPurchaseDate;
        private System.Windows.Forms.TextBox txbPurchaseDate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txbStatus;
        private System.Windows.Forms.Button btnViewDetails;
        private System.Windows.Forms.Button btnUpdateQuantity;

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblTotalPurchases;
        private System.Windows.Forms.ToolStripStatusLabel lblTotalAmount;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnExport;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.BindingSource sellsBindingSource;
        private FoodShopDataSet foodShopDataSet;
        private FoodShopDataSetTableAdapters.SellsTableAdapter sellsTableAdapter;
    }
}
