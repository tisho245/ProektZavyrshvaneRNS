namespace GastroSoft
{
    partial class SellerSalesControl
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
            this.lbSales = new System.Windows.Forms.ListBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txbProductName = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txbQuantity = new System.Windows.Forms.TextBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.txbTotalPrice = new System.Windows.Forms.TextBox();
            this.lblSaleDate = new System.Windows.Forms.Label();
            this.txbSaleDate = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txbStatus = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbSales
            // 
            this.lbSales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbSales.Font = new System.Drawing.Font("Calibri", 10F);
            this.lbSales.FormattingEnabled = true;
            this.lbSales.ItemHeight = 21;
            this.lbSales.Location = new System.Drawing.Point(13, 35);
            this.lbSales.Margin = new System.Windows.Forms.Padding(4);
            this.lbSales.Name = "lbSales";
            this.lbSales.Size = new System.Drawing.Size(465, 613);
            this.lbSales.TabIndex = 0;
            this.lbSales.SelectedIndexChanged += new System.EventHandler(this.lbSales_SelectedIndexChanged);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblUsername.Location = new System.Drawing.Point(507, 49);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(158, 21);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Потребителско име:";
            // 
            // txbUsername
            // 
            this.txbUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbUsername.Font = new System.Drawing.Font("Calibri", 10F);
            this.txbUsername.Location = new System.Drawing.Point(720, 46);
            this.txbUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.ReadOnly = true;
            this.txbUsername.Size = new System.Drawing.Size(225, 28);
            this.txbUsername.TabIndex = 2;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblProductName.Location = new System.Drawing.Point(507, 92);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(76, 21);
            this.lblProductName.TabIndex = 3;
            this.lblProductName.Text = "Продукт:";
            // 
            // txbProductName
            // 
            this.txbProductName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbProductName.Font = new System.Drawing.Font("Calibri", 10F);
            this.txbProductName.Location = new System.Drawing.Point(720, 89);
            this.txbProductName.Margin = new System.Windows.Forms.Padding(4);
            this.txbProductName.Name = "txbProductName";
            this.txbProductName.ReadOnly = true;
            this.txbProductName.Size = new System.Drawing.Size(225, 28);
            this.txbProductName.TabIndex = 4;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblQuantity.Location = new System.Drawing.Point(507, 135);
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
            this.txbQuantity.Location = new System.Drawing.Point(720, 132);
            this.txbQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.txbQuantity.Name = "txbQuantity";
            this.txbQuantity.Size = new System.Drawing.Size(225, 28);
            this.txbQuantity.TabIndex = 6;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblTotalPrice.Location = new System.Drawing.Point(507, 178);
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
            this.txbTotalPrice.Location = new System.Drawing.Point(720, 175);
            this.txbTotalPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txbTotalPrice.Name = "txbTotalPrice";
            this.txbTotalPrice.Size = new System.Drawing.Size(225, 28);
            this.txbTotalPrice.TabIndex = 8;
            // 
            // lblSaleDate
            // 
            this.lblSaleDate.AutoSize = true;
            this.lblSaleDate.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblSaleDate.Location = new System.Drawing.Point(511, 261);
            this.lblSaleDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaleDate.Name = "lblSaleDate";
            this.lblSaleDate.Size = new System.Drawing.Size(49, 21);
            this.lblSaleDate.TabIndex = 9;
            this.lblSaleDate.Text = "Дата:";
            this.lblSaleDate.Click += new System.EventHandler(this.lblSaleDate_Click);
            // 
            // txbSaleDate
            // 
            this.txbSaleDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbSaleDate.Font = new System.Drawing.Font("Calibri", 10F);
            this.txbSaleDate.Location = new System.Drawing.Point(724, 257);
            this.txbSaleDate.Margin = new System.Windows.Forms.Padding(4);
            this.txbSaleDate.Name = "txbSaleDate";
            this.txbSaleDate.ReadOnly = true;
            this.txbSaleDate.Size = new System.Drawing.Size(225, 28);
            this.txbSaleDate.TabIndex = 10;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnEdit.Location = new System.Drawing.Point(600, 298);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(108, 30);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Редактирай";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnClear.Location = new System.Drawing.Point(720, 298);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(108, 30);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Изчисти";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txbStatus
            // 
            this.txbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbStatus.Font = new System.Drawing.Font("Calibri", 10F);
            this.txbStatus.Location = new System.Drawing.Point(724, 213);
            this.txbStatus.Margin = new System.Windows.Forms.Padding(4);
            this.txbStatus.Name = "txbStatus";
            this.txbStatus.Size = new System.Drawing.Size(225, 28);
            this.txbStatus.TabIndex = 14;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblStatus.Location = new System.Drawing.Point(511, 216);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(61, 21);
            this.lblStatus.TabIndex = 13;
            this.lblStatus.Text = "Статус:";
            // 
            // SellerSalesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txbStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txbSaleDate);
            this.Controls.Add(this.lblSaleDate);
            this.Controls.Add(this.txbTotalPrice);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.txbQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txbProductName);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.txbUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lbSales);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SellerSalesControl";
            this.Size = new System.Drawing.Size(1000, 714);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbSales;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txbUsername;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txbProductName;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txbQuantity;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.TextBox txbTotalPrice;
        private System.Windows.Forms.Label lblSaleDate;
        private System.Windows.Forms.TextBox txbSaleDate;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txbStatus;
        private System.Windows.Forms.Label lblStatus;
    }
} 
