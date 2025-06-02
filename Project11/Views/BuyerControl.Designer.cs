namespace Project11.Views
{
    partial class BuyerControl
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
            this.каталогToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.покупкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makePurchaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myPurchasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.профилToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.каталогToolStripMenuItem,
            this.покупкиToolStripMenuItem,
            this.профилToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(600, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // каталогToolStripMenuItem
            // 
            this.каталогToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewProductsToolStripMenuItem});
            this.каталогToolStripMenuItem.Name = "каталогToolStripMenuItem";
            this.каталогToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.каталогToolStripMenuItem.Text = "Каталог";
            // 
            // viewProductsToolStripMenuItem
            // 
            this.viewProductsToolStripMenuItem.Name = "viewProductsToolStripMenuItem";
            this.viewProductsToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.viewProductsToolStripMenuItem.Text = "Преглед продукти";
            this.viewProductsToolStripMenuItem.Click += new System.EventHandler(this.viewProductsToolStripMenuItem_Click);
            // 
            // покупкиToolStripMenuItem
            // 
            this.покупкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makePurchaseToolStripMenuItem,
            this.myPurchasesToolStripMenuItem,
            this.cartToolStripMenuItem});
            this.покупкиToolStripMenuItem.Name = "покупкиToolStripMenuItem";
            this.покупкиToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.покупкиToolStripMenuItem.Text = "Покупки";
            // 
            // makePurchaseToolStripMenuItem
            // 
            this.makePurchaseToolStripMenuItem.Name = "makePurchaseToolStripMenuItem";
            this.makePurchaseToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.makePurchaseToolStripMenuItem.Text = "Нова покупка";
            this.makePurchaseToolStripMenuItem.Click += new System.EventHandler(this.makePurchaseToolStripMenuItem_Click);
            // 
            // myPurchasesToolStripMenuItem
            // 
            this.myPurchasesToolStripMenuItem.Name = "myPurchasesToolStripMenuItem";
            this.myPurchasesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.myPurchasesToolStripMenuItem.Text = "Моите покупки";
            this.myPurchasesToolStripMenuItem.Click += new System.EventHandler(this.myPurchasesToolStripMenuItem_Click);
            // 
            // cartToolStripMenuItem
            // 
            this.cartToolStripMenuItem.Name = "cartToolStripMenuItem";
            this.cartToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cartToolStripMenuItem.Text = "Количка";
            this.cartToolStripMenuItem.Click += new System.EventHandler(this.cartToolStripMenuItem_Click);
            // 
            // профилToolStripMenuItem
            // 
            this.профилToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem});
            this.профилToolStripMenuItem.Name = "профилToolStripMenuItem";
            this.профилToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.профилToolStripMenuItem.Text = "Профил";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.profileToolStripMenuItem.Text = "Моят профил";
            this.profileToolStripMenuItem.Click += new System.EventHandler(this.profileToolStripMenuItem_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe Script", 16F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.DarkRed;
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
            this.lblInfo.Size = new System.Drawing.Size(421, 112);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "Като купувач имате достъп до:\r\n\r\n• Преглед на каталог с продукти\r\n• Правене на покупки\r\n• Преглед на моите покупки";
            // 
            // BuyerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.menuStrip1);
            this.Name = "BuyerControl";
            this.Size = new System.Drawing.Size(600, 400);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem каталогToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem покупкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makePurchaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myPurchasesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem профилToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblInfo;
    }
}
