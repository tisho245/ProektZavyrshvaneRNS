namespace Project11.Views
{
    partial class SellerControl
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.продуктиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageProductTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.продажбиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeSaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инвентарToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.продуктиToolStripMenuItem,
            this.продажбиToolStripMenuItem,
            this.инвентарToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(600, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // продуктиToolStripMenuItem
            // 
            this.продуктиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageProductsToolStripMenuItem,
            this.manageProductTypesToolStripMenuItem});
            this.продуктиToolStripMenuItem.Name = "продуктиToolStripMenuItem";
            this.продуктиToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.продуктиToolStripMenuItem.Text = "Продукти";
            // 
            // manageProductsToolStripMenuItem
            // 
            this.manageProductsToolStripMenuItem.Name = "manageProductsToolStripMenuItem";
            this.manageProductsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.manageProductsToolStripMenuItem.Text = "Управление продукти";
            this.manageProductsToolStripMenuItem.Click += new System.EventHandler(this.manageProductsToolStripMenuItem_Click);
            // 
            // manageProductTypesToolStripMenuItem
            // 
            this.manageProductTypesToolStripMenuItem.Name = "manageProductTypesToolStripMenuItem";
            this.manageProductTypesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.manageProductTypesToolStripMenuItem.Text = "Типове продукти";
            this.manageProductTypesToolStripMenuItem.Click += new System.EventHandler(this.manageProductTypesToolStripMenuItem_Click);
            // 
            // продажбиToolStripMenuItem
            // 
            this.продажбиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makeSaleToolStripMenuItem,
            this.viewSalesToolStripMenuItem});
            this.продажбиToolStripMenuItem.Name = "продажбиToolStripMenuItem";
            this.продажбиToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.продажбиToolStripMenuItem.Text = "Продажби";
            // 
            // makeSaleToolStripMenuItem
            // 
            this.makeSaleToolStripMenuItem.Name = "makeSaleToolStripMenuItem";
            this.makeSaleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.makeSaleToolStripMenuItem.Text = "Нова продажба";
            this.makeSaleToolStripMenuItem.Click += new System.EventHandler(this.makeSaleToolStripMenuItem_Click);
            // 
            // viewSalesToolStripMenuItem
            // 
            this.viewSalesToolStripMenuItem.Name = "viewSalesToolStripMenuItem";
            this.viewSalesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.viewSalesToolStripMenuItem.Text = "Преглед продажби";
            this.viewSalesToolStripMenuItem.Click += new System.EventHandler(this.viewSalesToolStripMenuItem_Click);
            // 
            // инвентарToolStripMenuItem
            // 
            this.инвентарToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventoryToolStripMenuItem});
            this.инвентарToolStripMenuItem.Name = "инвентарToolStripMenuItem";
            this.инвентарToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.инвентарToolStripMenuItem.Text = "Инвентар";
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.inventoryToolStripMenuItem.Text = "Проверка на наличности";
            this.inventoryToolStripMenuItem.Click += new System.EventHandler(this.inventoryToolStripMenuItem_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe Script", 16F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblWelcome.Location = new System.Drawing.Point(50, 80);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(272, 44);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Добре дошли!";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblInfo.Location = new System.Drawing.Point(50, 150);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(478, 112);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "Като продавач имате достъп до:\r\n\r\n• Управление на продукти и типове\r\n• Създаване и преглед на продажби\r\n• Проверка на инвентар";
            // 
            // SellerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.menuStrip1);
            this.Name = "SellerControl";
            this.Size = new System.Drawing.Size(600, 400);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem продуктиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageProductTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem продажбиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeSaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewSalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инвентарToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblInfo;
    }
}
