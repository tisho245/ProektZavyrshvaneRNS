namespace GastroSoft
{
    partial class ManageProductTypesControl
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
            this.foodShopDataSet = new GastroSoft.FoodShopDataSet();
            this.productTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTypesTableAdapter = new GastroSoft.FoodShopDataSetTableAdapters.ProductTypesTableAdapter();
            this.lblProductTypeName = new System.Windows.Forms.Label();
            this.txbProductTypeName = new System.Windows.Forms.TextBox();
            this.lblProductTypes = new System.Windows.Forms.Label();
            this.lbProductTypes = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.foodShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // foodShopDataSet
            // 
            this.foodShopDataSet.DataSetName = "FoodShopDataSet";
            this.foodShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productTypesBindingSource
            // 
            this.productTypesBindingSource.DataMember = "ProductTypes";
            this.productTypesBindingSource.DataSource = this.foodShopDataSet;
            // 
            // productTypesTableAdapter
            // 
            this.productTypesTableAdapter.ClearBeforeFill = true;
            // 
            // lblProductTypeName
            // 
            this.lblProductTypeName.AutoSize = true;
            this.lblProductTypeName.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblProductTypeName.Location = new System.Drawing.Point(20, 50);
            this.lblProductTypeName.Name = "lblProductTypeName";
            this.lblProductTypeName.Size = new System.Drawing.Size(96, 21);
            this.lblProductTypeName.TabIndex = 4;
            this.lblProductTypeName.Text = "Име на тип:";
            // 
            // txbProductTypeName
            // 
            this.txbProductTypeName.Font = new System.Drawing.Font("Calibri", 10F);
            this.txbProductTypeName.Location = new System.Drawing.Point(24, 75);
            this.txbProductTypeName.Name = "txbProductTypeName";
            this.txbProductTypeName.Size = new System.Drawing.Size(200, 28);
            this.txbProductTypeName.TabIndex = 5;
            // 
            // lblProductTypes
            // 
            this.lblProductTypes.AutoSize = true;
            this.lblProductTypes.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblProductTypes.Location = new System.Drawing.Point(280, 50);
            this.lblProductTypes.Name = "lblProductTypes";
            this.lblProductTypes.Size = new System.Drawing.Size(160, 24);
            this.lblProductTypes.TabIndex = 6;
            this.lblProductTypes.Text = "Типове продукти:";
            // 
            // lbProductTypes
            // 
            this.lbProductTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbProductTypes.Font = new System.Drawing.Font("Calibri", 10F);
            this.lbProductTypes.FormattingEnabled = true;
            this.lbProductTypes.ItemHeight = 21;
            this.lbProductTypes.Location = new System.Drawing.Point(280, 75);
            this.lbProductTypes.Name = "lbProductTypes";
            this.lbProductTypes.Size = new System.Drawing.Size(420, 403);
            this.lbProductTypes.TabIndex = 7;
            this.lbProductTypes.SelectedIndexChanged += new System.EventHandler(this.lbProductTypes_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnSave.Location = new System.Drawing.Point(33, 156);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 30);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Запази";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnDelete.Location = new System.Drawing.Point(122, 156);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 30);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Изтрий";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnClear.Location = new System.Drawing.Point(33, 188);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(170, 30);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Изчисти";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnAdd.Location = new System.Drawing.Point(33, 122);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(170, 30);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Добави";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // ManageProductTypesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbProductTypes);
            this.Controls.Add(this.lblProductTypes);
            this.Controls.Add(this.txbProductTypeName);
            this.Controls.Add(this.lblProductTypeName);
            this.Name = "ManageProductTypesControl";
            this.Size = new System.Drawing.Size(750, 580);
            this.Load += new System.EventHandler(this.ManageProductTypesControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.foodShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblProductTypeName;
        private System.Windows.Forms.TextBox txbProductTypeName;
        private System.Windows.Forms.Label lblProductTypes;
        private System.Windows.Forms.ListBox lbProductTypes;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.BindingSource productTypesBindingSource;
        private FoodShopDataSet foodShopDataSet;
        private FoodShopDataSetTableAdapters.ProductTypesTableAdapter productTypesTableAdapter;
        private System.Windows.Forms.Button btnAdd;
    }
} 
