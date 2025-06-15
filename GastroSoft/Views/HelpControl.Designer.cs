namespace GastroSoft
{
    partial class HelpControl
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Начало");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Вход в системата");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Роли на потребителите");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Първи стъпки", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Управление на потребители");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Управление на продукти");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Управление на продажби");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Генериране на отчети");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Настройки");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Администратор", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Преглед на продукти");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Управление на продажби");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Наличности на склад");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Продавач", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12,
            treeNode13});
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Каталог на продукти");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Моите покупки");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Профил");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Купувач", new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode16,
            treeNode17});
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Често срещани проблеми");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Контакти за поддръжка");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Съобщаване на грешки");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Поддръжка", new System.Windows.Forms.TreeNode[] {
            treeNode19,
            treeNode20,
            treeNode21});
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeViewTopics = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBoxContent = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.linkLabelDocumentation = new System.Windows.Forms.LinkLabel();
            this.linkLabelSupport = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeViewTopics);
            this.splitContainer1.Panel1MinSize = 200;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(726, 562);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // treeViewTopics
            // 
            this.treeViewTopics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewTopics.Font = new System.Drawing.Font("Calibri", 10F);
            this.treeViewTopics.FullRowSelect = true;
            this.treeViewTopics.HideSelection = false;
            this.treeViewTopics.Location = new System.Drawing.Point(0, 0);
            this.treeViewTopics.Name = "treeViewTopics";
            treeNode1.Name = "nodeWelcome";
            treeNode1.Text = "Начало";
            treeNode2.Name = "nodeLogin";
            treeNode2.Text = "Вход в системата";
            treeNode3.Name = "nodeRoles";
            treeNode3.Text = "Роли на потребителите";
            treeNode4.Name = "nodeGettingStarted";
            treeNode4.Text = "Първи стъпки";
            treeNode5.Name = "nodeManageUsers";
            treeNode5.Text = "Управление на потребители";
            treeNode6.Name = "nodeManageProducts";
            treeNode6.Text = "Управление на продукти";
            treeNode7.Name = "nodeManageSales";
            treeNode7.Text = "Управление на продажби";
            treeNode8.Name = "nodeReports";
            treeNode8.Text = "Генериране на отчети";
            treeNode9.Name = "nodeSettings";
            treeNode9.Text = "Настройки";
            treeNode10.Name = "nodeAdmin";
            treeNode10.Text = "Администратор";
            treeNode11.Name = "nodeSellerProducts";
            treeNode11.Text = "Преглед на продукти";
            treeNode12.Name = "nodeSellerSales";
            treeNode12.Text = "Управление на продажби";
            treeNode13.Name = "nodeInventory";
            treeNode13.Text = "Наличности на склад";
            treeNode14.Name = "nodeSeller";
            treeNode14.Text = "Продавач";
            treeNode15.Name = "nodeBuyerProducts";
            treeNode15.Text = "Каталог на продукти";
            treeNode16.Name = "nodeBuyerPurchases";
            treeNode16.Text = "Моите покупки";
            treeNode17.Name = "nodeProfile";
            treeNode17.Text = "Профил";
            treeNode18.Name = "nodeBuyer";
            treeNode18.Text = "Купувач";
            treeNode19.Name = "nodeTroubleshooting";
            treeNode19.Text = "Често срещани проблеми";
            treeNode20.Name = "nodeSupport";
            treeNode20.Text = "Контакти за поддръжка";
            treeNode21.Name = "nodeBugReport";
            treeNode21.Text = "Съобщаване на грешки";
            treeNode22.Name = "nodeHelp";
            treeNode22.Text = "Поддръжка";
            this.treeViewTopics.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode10,
            treeNode14,
            treeNode18,
            treeNode22});
            this.treeViewTopics.Size = new System.Drawing.Size(266, 562);
            this.treeViewTopics.TabIndex = 0;
            this.treeViewTopics.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewTopics_AfterSelect);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.richTextBoxContent);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(456, 562);
            this.panel1.TabIndex = 0;
            // 
            // richTextBoxContent
            // 
            this.richTextBoxContent.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBoxContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxContent.Font = new System.Drawing.Font("Calibri", 10F);
            this.richTextBoxContent.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxContent.Name = "richTextBoxContent";
            this.richTextBoxContent.ReadOnly = true;
            this.richTextBoxContent.Size = new System.Drawing.Size(456, 522);
            this.richTextBoxContent.TabIndex = 1;
            this.richTextBoxContent.Text = "Добре дошли в помощния център на Система за управление на хранителен магазин!\n\nИзберете тема от лявото меню за да получите подробна информация и инструкции.";
            this.richTextBoxContent.TextChanged += new System.EventHandler(this.richTextBoxContent_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.linkLabelDocumentation);
            this.panel2.Controls.Add(this.linkLabelSupport);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 522);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(456, 40);
            this.panel2.TabIndex = 0;
            // 
            // linkLabelDocumentation
            // 
            this.linkLabelDocumentation.AutoSize = true;
            this.linkLabelDocumentation.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.linkLabelDocumentation.Location = new System.Drawing.Point(15, 12);
            this.linkLabelDocumentation.Name = "linkLabelDocumentation";
            this.linkLabelDocumentation.Size = new System.Drawing.Size(118, 21);
            this.linkLabelDocumentation.TabIndex = 1;
            this.linkLabelDocumentation.TabStop = true;
            this.linkLabelDocumentation.Text = "Документация";
            this.linkLabelDocumentation.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelDocumentation_LinkClicked);
            // 
            // linkLabelSupport
            // 
            this.linkLabelSupport.AutoSize = true;
            this.linkLabelSupport.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.linkLabelSupport.Location = new System.Drawing.Point(155, 12);
            this.linkLabelSupport.Name = "linkLabelSupport";
            this.linkLabelSupport.Size = new System.Drawing.Size(161, 21);
            this.linkLabelSupport.TabIndex = 0;
            this.linkLabelSupport.TabStop = true;
            this.linkLabelSupport.Text = "Връзка с поддръжка";
            this.linkLabelSupport.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSupport_LinkClicked);
            // 
            // HelpControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "HelpControl";
            this.Size = new System.Drawing.Size(750, 580);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeViewTopics;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBoxContent;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel linkLabelDocumentation;
        private System.Windows.Forms.LinkLabel linkLabelSupport;
    }
} 
