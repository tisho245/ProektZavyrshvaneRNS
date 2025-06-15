namespace GastroSoft.Views
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblProductTypeNumber = new System.Windows.Forms.Label();
            this.lblProductTypeName = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(150, 23);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Типове продукти";
            // 
            // lblProductTypeNumber
            // 
            this.lblProductTypeNumber.AutoSize = true;
            this.lblProductTypeNumber.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblProductTypeNumber.Location = new System.Drawing.Point(20, 60);
            this.lblProductTypeNumber.Name = "lblProductTypeNumber";
            this.lblProductTypeNumber.Size = new System.Drawing.Size(50, 17);
            this.lblProductTypeNumber.TabIndex = 1;
            this.lblProductTypeNumber.Text = "Номер:";
            // 
            // lblProductTypeName
            // 
            this.lblProductTypeName.AutoSize = true;
            this.lblProductTypeName.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblProductTypeName.Location = new System.Drawing.Point(20, 90);
            this.lblProductTypeName.Name = "lblProductTypeName";
            this.lblProductTypeName.Size = new System.Drawing.Size(35, 17);
            this.lblProductTypeName.TabIndex = 2;
            this.lblProductTypeName.Text = "Тип:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnRefresh.Location = new System.Drawing.Point(20, 130);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 30);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Обнови";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // BuyerProductTypesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblProductTypeName);
            this.Controls.Add(this.lblProductTypeNumber);
            this.Controls.Add(this.lblTitle);
            this.Name = "BuyerProductTypesControl";
            this.Text = "Типове продукти";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblProductTypeNumber;
        private System.Windows.Forms.Label lblProductTypeName;
        private System.Windows.Forms.Button btnRefresh;
    }
} 