namespace GastroSoft
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.продуктиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.продуктиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.типовеПродуктиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.продажбиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.профилToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWelcome.Location = new System.Drawing.Point(13, 43);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(245, 25);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Добре дошли, Клиент!";
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPanel.Controls.Add(this.lblInfo);
            this.mainPanel.Location = new System.Drawing.Point(13, 80);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(973, 621);
            this.mainPanel.TabIndex = 2;
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInfo.ForeColor = System.Drawing.Color.Gray;
            this.lblInfo.Location = new System.Drawing.Point(392, 326);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(239, 20);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Изберете опция от менюто";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.продуктиToolStripMenuItem,
            this.продажбиToolStripMenuItem,
            this.профилToolStripMenuItem,
            this.настройкиToolStripMenuItem,
            this.помощToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1000, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // продуктиToolStripMenuItem
            // 
            this.продуктиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.продуктиToolStripMenuItem1,
            this.типовеПродуктиToolStripMenuItem});
            this.продуктиToolStripMenuItem.Name = "продуктиToolStripMenuItem";
            this.продуктиToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.продуктиToolStripMenuItem.Text = "Продукти";
            // 
            // продуктиToolStripMenuItem1
            // 
            this.продуктиToolStripMenuItem1.Name = "продуктиToolStripMenuItem1";
            this.продуктиToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.продуктиToolStripMenuItem1.Text = "Продукти";
            this.продуктиToolStripMenuItem1.Click += new System.EventHandler(this.productCatalogToolStripMenuItem_Click);
            // 
            // типовеПродуктиToolStripMenuItem
            // 
            this.типовеПродуктиToolStripMenuItem.Name = "типовеПродуктиToolStripMenuItem";
            this.типовеПродуктиToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.типовеПродуктиToolStripMenuItem.Text = "Типове продукти";
            this.типовеПродуктиToolStripMenuItem.Click += new System.EventHandler(this.productTypesToolStripMenuItem_Click);
            // 
            // продажбиToolStripMenuItem
            // 
            this.продажбиToolStripMenuItem.Name = "продажбиToolStripMenuItem";
            this.продажбиToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.продажбиToolStripMenuItem.Text = "Покупки";
            this.продажбиToolStripMenuItem.Click += new System.EventHandler(this.myPurchasesToolStripMenuItem_Click);
            // 
            // профилToolStripMenuItem
            // 
            this.профилToolStripMenuItem.Name = "профилToolStripMenuItem";
            this.профилToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.профилToolStripMenuItem.Text = "Профил";
            this.профилToolStripMenuItem.Click += new System.EventHandler(this.profileToolStripMenuItem_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            this.настройкиToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // помощToolStripMenuItem
            // 
            this.помощToolStripMenuItem.Name = "помощToolStripMenuItem";
            this.помощToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.помощToolStripMenuItem.Text = "Помощ";
            this.помощToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // BuyerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BuyerControl";
            this.Size = new System.Drawing.Size(1000, 714);
            this.Load += new System.EventHandler(this.BuyerControl_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem продуктиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem продуктиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem типовеПродуктиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem продажбиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem профилToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощToolStripMenuItem;
    }
} 
