namespace GastroSoft
{
    partial class ManageUsersControl
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
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new GastroSoft.FoodShopDataSetTableAdapters.UsersTableAdapter();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txbFirstName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.txbRole = new System.Windows.Forms.TextBox();
            this.lblUsers = new System.Windows.Forms.Label();
            this.lbUsers = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.foodShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // foodShopDataSet
            // 
            this.foodShopDataSet.DataSetName = "FoodShopDataSet";
            this.foodShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.foodShopDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblUsername.Location = new System.Drawing.Point(20, 50);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(158, 21);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Потребителско име:";
            // 
            // txbUsername
            // 
            this.txbUsername.Font = new System.Drawing.Font("Calibri", 10F);
            this.txbUsername.Location = new System.Drawing.Point(20, 70);
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Size = new System.Drawing.Size(200, 28);
            this.txbUsername.TabIndex = 3;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblFirstName.Location = new System.Drawing.Point(20, 110);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(46, 21);
            this.lblFirstName.TabIndex = 4;
            this.lblFirstName.Text = "Име:";
            // 
            // txbFirstName
            // 
            this.txbFirstName.Font = new System.Drawing.Font("Calibri", 10F);
            this.txbFirstName.Location = new System.Drawing.Point(20, 130);
            this.txbFirstName.Name = "txbFirstName";
            this.txbFirstName.Size = new System.Drawing.Size(200, 28);
            this.txbFirstName.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblEmail.Location = new System.Drawing.Point(20, 170);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(64, 21);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Имейл:";
            // 
            // txbEmail
            // 
            this.txbEmail.Font = new System.Drawing.Font("Calibri", 10F);
            this.txbEmail.Location = new System.Drawing.Point(20, 190);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(200, 28);
            this.txbEmail.TabIndex = 7;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblRole.Location = new System.Drawing.Point(20, 230);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(254, 21);
            this.lblRole.TabIndex = 8;
            this.lblRole.Text = "Роля (0=Admin, 1=Seller, 2=Buyer):";
            // 
            // txbRole
            // 
            this.txbRole.Font = new System.Drawing.Font("Calibri", 10F);
            this.txbRole.Location = new System.Drawing.Point(20, 250);
            this.txbRole.Name = "txbRole";
            this.txbRole.Size = new System.Drawing.Size(200, 28);
            this.txbRole.TabIndex = 9;
            // 
            // lblUsers
            // 
            this.lblUsers.AutoSize = true;
            this.lblUsers.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblUsers.Location = new System.Drawing.Point(280, 50);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(128, 24);
            this.lblUsers.TabIndex = 10;
            this.lblUsers.Text = "Потребители:";
            // 
            // lbUsers
            // 
            this.lbUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbUsers.Font = new System.Drawing.Font("Calibri", 10F);
            this.lbUsers.FormattingEnabled = true;
            this.lbUsers.ItemHeight = 21;
            this.lbUsers.Location = new System.Drawing.Point(280, 75);
            this.lbUsers.Name = "lbUsers";
            this.lbUsers.Size = new System.Drawing.Size(430, 403);
            this.lbUsers.TabIndex = 11;
            this.lbUsers.SelectedIndexChanged += new System.EventHandler(this.lbUsers_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnSave.Location = new System.Drawing.Point(20, 299);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(196, 30);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Запази";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnClear.Location = new System.Drawing.Point(20, 335);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(196, 30);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Изчисти";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnDelete.Location = new System.Drawing.Point(20, 371);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(196, 30);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Изтрий";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ManageUsersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbUsers);
            this.Controls.Add(this.lblUsers);
            this.Controls.Add(this.txbRole);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txbFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txbUsername);
            this.Controls.Add(this.lblUsername);
            this.Name = "ManageUsersControl";
            this.Size = new System.Drawing.Size(750, 580);
            this.Load += new System.EventHandler(this.ManageUsersControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.foodShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txbUsername;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txbFirstName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.TextBox txbRole;
        private System.Windows.Forms.Label lblUsers;
        private System.Windows.Forms.ListBox lbUsers;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private FoodShopDataSet foodShopDataSet;
        private FoodShopDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.BindingSource usersBindingSource;
    }
} 
