namespace GastroSoft
{
    partial class BuyerProductTypesControl
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
            this.lbProductTypes = new System.Windows.Forms.ListBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblProductTypeNumber = new System.Windows.Forms.Label();
            this.lblProductTypeName = new System.Windows.Forms.Label();
            this.txbProductTypeNumber = new System.Windows.Forms.TextBox();
            this.txbProductTypeName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbProductTypes
            // 
            this.lbProductTypes.FormattingEnabled = true;
            this.lbProductTypes.ItemHeight = 16;
            this.lbProductTypes.Location = new System.Drawing.Point(27, 62);
            this.lbProductTypes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbProductTypes.Name = "lbProductTypes";
            this.lbProductTypes.Size = new System.Drawing.Size(599, 244);
            this.lbProductTypes.TabIndex = 0;
            this.lbProductTypes.SelectedIndexChanged += new System.EventHandler(this.lbProductTypes_SelectedIndexChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.Location = new System.Drawing.Point(27, 18);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(170, 25);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Типове продукти";
            // 
            // lblProductTypeNumber
            // 
            this.lblProductTypeNumber.AutoSize = true;
            this.lblProductTypeNumber.Location = new System.Drawing.Point(27, 345);
            this.lblProductTypeNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductTypeNumber.Name = "lblProductTypeNumber";
            this.lblProductTypeNumber.Size = new System.Drawing.Size(53, 16);
            this.lblProductTypeNumber.TabIndex = 2;
            this.lblProductTypeNumber.Text = "Номер:";
            // 
            // lblProductTypeName
            // 
            this.lblProductTypeName.AutoSize = true;
            this.lblProductTypeName.Location = new System.Drawing.Point(27, 382);
            this.lblProductTypeName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductTypeName.Name = "lblProductTypeName";
            this.lblProductTypeName.Size = new System.Drawing.Size(35, 16);
            this.lblProductTypeName.TabIndex = 3;
            this.lblProductTypeName.Text = "Тип:";
            // 
            // txbProductTypeNumber
            // 
            this.txbProductTypeNumber.Location = new System.Drawing.Point(160, 341);
            this.txbProductTypeNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbProductTypeNumber.Name = "txbProductTypeNumber";
            this.txbProductTypeNumber.ReadOnly = true;
            this.txbProductTypeNumber.Size = new System.Drawing.Size(132, 22);
            this.txbProductTypeNumber.TabIndex = 4;
            // 
            // txbProductTypeName
            // 
            this.txbProductTypeName.Location = new System.Drawing.Point(160, 378);
            this.txbProductTypeName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbProductTypeName.Name = "txbProductTypeName";
            this.txbProductTypeName.ReadOnly = true;
            this.txbProductTypeName.Size = new System.Drawing.Size(265, 22);
            this.txbProductTypeName.TabIndex = 5;
            // 
            // BuyerProductTypesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txbProductTypeName);
            this.Controls.Add(this.txbProductTypeNumber);
            this.Controls.Add(this.lblProductTypeName);
            this.Controls.Add(this.lblProductTypeNumber);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lbProductTypes);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BuyerProductTypesControl";
            this.Size = new System.Drawing.Size(800, 492);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbProductTypes;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblProductTypeNumber;
        private System.Windows.Forms.Label lblProductTypeName;
        private System.Windows.Forms.TextBox txbProductTypeNumber;
        private System.Windows.Forms.TextBox txbProductTypeName;
    }
}
