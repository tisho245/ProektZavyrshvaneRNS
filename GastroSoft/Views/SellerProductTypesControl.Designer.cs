namespace GastroSoft.Views
{
    partial class SellerProductTypesControl
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
            this.lblProductTypeName = new System.Windows.Forms.Label();
            this.txbProductTypeName = new System.Windows.Forms.TextBox();
            this.lblProductTypeNumber = new System.Windows.Forms.Label();
            this.txbProductTypeNumber = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbProductTypes
            // 
            this.lbProductTypes.Font = new System.Drawing.Font("Calibri", 10F);
            this.lbProductTypes.FormattingEnabled = true;
            this.lbProductTypes.ItemHeight = 21;
            this.lbProductTypes.Location = new System.Drawing.Point(20, 20);
            this.lbProductTypes.Name = "lbProductTypes";
            this.lbProductTypes.Size = new System.Drawing.Size(350, 382);
            this.lbProductTypes.TabIndex = 0;
            this.lbProductTypes.SelectedIndexChanged += new System.EventHandler(this.lbProductTypes_SelectedIndexChanged);
            // 
            // lblProductTypeName
            // 
            this.lblProductTypeName.AutoSize = true;
            this.lblProductTypeName.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblProductTypeName.Location = new System.Drawing.Point(400, 50);
            this.lblProductTypeName.Name = "lblProductTypeName";
            this.lblProductTypeName.Size = new System.Drawing.Size(104, 21);
            this.lblProductTypeName.TabIndex = 1;
            this.lblProductTypeName.Text = "Тип на продукт:";
            // 
            // txbProductTypeName
            // 
            this.txbProductTypeName.Font = new System.Drawing.Font("Calibri", 10F);
            this.txbProductTypeName.Location = new System.Drawing.Point(520, 47);
            this.txbProductTypeName.Name = "txbProductTypeName";
            this.txbProductTypeName.ReadOnly = true;
            this.txbProductTypeName.Size = new System.Drawing.Size(200, 28);
            this.txbProductTypeName.TabIndex = 2;
            // 
            // lblProductTypeNumber
            // 
            this.lblProductTypeNumber.AutoSize = true;
            this.lblProductTypeNumber.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblProductTypeNumber.Location = new System.Drawing.Point(400, 90);
            this.lblProductTypeNumber.Name = "lblProductTypeNumber";
            this.lblProductTypeNumber.Size = new System.Drawing.Size(64, 21);
            this.lblProductTypeNumber.TabIndex = 3;
            this.lblProductTypeNumber.Text = "Номер:";
            // 
            // txbProductTypeNumber
            // 
            this.txbProductTypeNumber.Font = new System.Drawing.Font("Calibri", 10F);
            this.txbProductTypeNumber.Location = new System.Drawing.Point(520, 87);
            this.txbProductTypeNumber.Name = "txbProductTypeNumber";
            this.txbProductTypeNumber.ReadOnly = true;
            this.txbProductTypeNumber.Size = new System.Drawing.Size(200, 28);
            this.txbProductTypeNumber.TabIndex = 4;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnEdit.Location = new System.Drawing.Point(446, 132);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(114, 30);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Редактирай";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnClear.Location = new System.Drawing.Point(566, 132);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 30);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Изчисти";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // SellerProductTypesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txbProductTypeNumber);
            this.Controls.Add(this.lblProductTypeNumber);
            this.Controls.Add(this.txbProductTypeName);
            this.Controls.Add(this.lblProductTypeName);
            this.Controls.Add(this.lbProductTypes);
            this.Name = "SellerProductTypesControl";
            this.Size = new System.Drawing.Size(800, 500);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox lbProductTypes;
        private System.Windows.Forms.Label lblProductTypeName;
        private System.Windows.Forms.TextBox txbProductTypeName;
        private System.Windows.Forms.Label lblProductTypeNumber;
        private System.Windows.Forms.TextBox txbProductTypeNumber;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnClear;
    }
}
