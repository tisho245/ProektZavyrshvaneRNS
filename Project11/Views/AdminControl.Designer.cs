namespace Project11.Views
{
    partial class AdminControl
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
            this.управлениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageProductTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageSalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.управлениеToolStripMenuItem,
            this.отчетиToolStripMenuItem,
            this.настройкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(600, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // управлениеToolStripMenuItem
            // 
            this.управлениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageUsersToolStripMenuItem,
            this.manageProductsToolStripMenuItem,
            this.manageProductTypesToolStripMenuItem,
            this.manageSalesToolStripMenuItem});
            this.управлениеToolStripMenuItem.Name = "управлениеToolStripMenuItem";
            this.управлениеToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.управлениеToolStripMenuItem.Text = "Управление";
            // 
            // manageUsersToolStripMenuItem
            // 
            this.manageUsersToolStripMenuItem.Name = "manageUsersToolStripMenuItem";
            this.manageUsersToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.manageUsersToolStripMenuItem.Text = "Потребители";
            this.manageUsersToolStripMenuItem.Click += new System.EventHandler(this.manageUsersToolStripMenuItem_Click);
            // 
            // manageProductsToolStripMenuItem
            // 
            this.manageProductsToolStripMenuItem.Name = "manageProductsToolStripMenuItem";
            this.manageProductsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.manageProductsToolStripMenuItem.Text = "Продукти";
            this.manageProductsToolStripMenuItem.Click += new System.EventHandler(this.manageProductsToolStripMenuItem_Click);
            // 
            // manageProductTypesToolStripMenuItem
            // 
            this.manageProductTypesToolStripMenuItem.Name = "manageProductTypesToolStripMenuItem";
            this.manageProductTypesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.manageProductTypesToolStripMenuItem.Text = "Типове продукти";
            this.manageProductTypesToolStripMenuItem.Click += new System.EventHandler(this.manageProductTypesToolStripMenuItem_Click);
            // 
            // manageSalesToolStripMenuItem
            // 
            this.manageSalesToolStripMenuItem.Name = "manageSalesToolStripMenuItem";
            this.manageSalesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.manageSalesToolStripMenuItem.Text = "Продажби";
            this.manageSalesToolStripMenuItem.Click += new System.EventHandler(this.manageSalesToolStripMenuItem_Click);
            // 
            // отчетиToolStripMenuItem
            // 
            this.отчетиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportsToolStripMenuItem});
            this.отчетиToolStripMenuItem.Name = "отчетиToolStripMenuItem";
            this.отчетиToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.отчетиToolStripMenuItem.Text = "Отчети";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.reportsToolStripMenuItem.Text = "Генериране на отчети";
            this.reportsToolStripMenuItem.Click += new System.EventHandler(this.reportsToolStripMenuItem_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.settingsToolStripMenuItem.Text = "Системни настройки";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe Script", 16F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.DarkBlue;
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
            this.lblInfo.Size = new System.Drawing.Size(489, 140);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "Като администратор имате пълен достъп до системата:\r\n\r\n• Управление на потребители\r\n• Управление на продукти и типове\r\n• Преглед на продажби\r\n• Генериране на отчети\r\n• Системни настройки";
            // 
            // AdminControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.menuStrip1);
            this.Name = "AdminControl";
            this.Size = new System.Drawing.Size(600, 400);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem управлениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageProductTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageSalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblInfo;
    }
}
