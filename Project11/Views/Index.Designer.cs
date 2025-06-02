namespace Project11
{
    partial class Index
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.gbRegistration = new System.Windows.Forms.GroupBox();
            this.btnRegistration = new System.Windows.Forms.Button();
            this.txbRepeatPasswordReg = new System.Windows.Forms.TextBox();
            this.txbPasswordReg = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txbEmailReg = new System.Windows.Forms.TextBox();
            this.txbUsernameReg = new System.Windows.Forms.TextBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.lblPasswordRegRepeat = new System.Windows.Forms.Label();
            this.lblEmailRegistration = new System.Windows.Forms.Label();
            this.lblPasswordRegistration = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblUsernameRegistration = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.gbLogin.SuspendLayout();
            this.gbRegistration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe Script", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblWelcome.Location = new System.Drawing.Point(201, 12);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(325, 70);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Добре дошли";
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe Script", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(8, 35);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(184, 25);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Потребителско име:";
            this.lblUsername.Click += new System.EventHandler(this.lblUsername_Click);
            // 
            // gbLogin
            // 
            this.gbLogin.Controls.Add(this.btnLogin);
            this.gbLogin.Controls.Add(this.txtUsername);
            this.gbLogin.Controls.Add(this.txbPassword);
            this.gbLogin.Controls.Add(this.lblPassword);
            this.gbLogin.Controls.Add(this.lblUsername);
            this.gbLogin.Font = new System.Drawing.Font("Segoe Script", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.gbLogin.Location = new System.Drawing.Point(10, 128);
            this.gbLogin.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.gbLogin.Size = new System.Drawing.Size(347, 202);
            this.gbLogin.TabIndex = 2;
            this.gbLogin.TabStop = false;
            this.gbLogin.Text = "Вход";
            this.gbLogin.Enter += new System.EventHandler(this.gbLogin_Enter);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnLogin.Font = new System.Drawing.Font("Segoe Script", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(127, 122);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(93, 49);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Вход";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(155, 32);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(186, 32);
            this.txtUsername.TabIndex = 4;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsernameOrEmail_TextChanged);
            // 
            // txbPassword
            // 
            this.txbPassword.Location = new System.Drawing.Point(75, 70);
            this.txbPassword.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(266, 32);
            this.txbPassword.TabIndex = 3;
            this.txbPassword.UseSystemPasswordChar = true;
            this.txbPassword.TextChanged += new System.EventHandler(this.txbPassword_TextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe Script", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(17, 73);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(76, 25);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Парола:";
            this.lblPassword.Click += new System.EventHandler(this.lblPassword_Click);
            // 
            // gbRegistration
            // 
            this.gbRegistration.Controls.Add(this.btnRegistration);
            this.gbRegistration.Controls.Add(this.txbRepeatPasswordReg);
            this.gbRegistration.Controls.Add(this.txbPasswordReg);
            this.gbRegistration.Controls.Add(this.comboBox1);
            this.gbRegistration.Controls.Add(this.txbEmailReg);
            this.gbRegistration.Controls.Add(this.txbUsernameReg);
            this.gbRegistration.Controls.Add(this.txbName);
            this.gbRegistration.Controls.Add(this.lblPasswordRegRepeat);
            this.gbRegistration.Controls.Add(this.lblEmailRegistration);
            this.gbRegistration.Controls.Add(this.lblPasswordRegistration);
            this.gbRegistration.Controls.Add(this.lblRole);
            this.gbRegistration.Controls.Add(this.lblUsernameRegistration);
            this.gbRegistration.Controls.Add(this.lblFullName);
            this.gbRegistration.Font = new System.Drawing.Font("Segoe Script", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.gbRegistration.Location = new System.Drawing.Point(363, 128);
            this.gbRegistration.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.gbRegistration.Name = "gbRegistration";
            this.gbRegistration.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.gbRegistration.Size = new System.Drawing.Size(357, 421);
            this.gbRegistration.TabIndex = 3;
            this.gbRegistration.TabStop = false;
            this.gbRegistration.Text = "Регистрация";
            this.gbRegistration.Enter += new System.EventHandler(this.gbRegistration_Enter);
            // 
            // btnRegistration
            // 
            this.btnRegistration.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnRegistration.Font = new System.Drawing.Font("Segoe Script", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnRegistration.Location = new System.Drawing.Point(102, 336);
            this.btnRegistration.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(171, 60);
            this.btnRegistration.TabIndex = 10;
            this.btnRegistration.Text = "Регистрирай ме";
            this.btnRegistration.UseVisualStyleBackColor = false;
            this.btnRegistration.Click += new System.EventHandler(this.btnRegistration_Click);
            // 
            // txbRepeatPasswordReg
            // 
            this.txbRepeatPasswordReg.Location = new System.Drawing.Point(171, 286);
            this.txbRepeatPasswordReg.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txbRepeatPasswordReg.Name = "txbRepeatPasswordReg";
            this.txbRepeatPasswordReg.Size = new System.Drawing.Size(177, 32);
            this.txbRepeatPasswordReg.TabIndex = 9;
            this.txbRepeatPasswordReg.UseSystemPasswordChar = true;
            this.txbRepeatPasswordReg.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txbPasswordReg
            // 
            this.txbPasswordReg.Location = new System.Drawing.Point(73, 236);
            this.txbPasswordReg.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txbPasswordReg.Name = "txbPasswordReg";
            this.txbPasswordReg.Size = new System.Drawing.Size(275, 32);
            this.txbPasswordReg.TabIndex = 8;
            this.txbPasswordReg.UseSystemPasswordChar = true;
            this.txbPasswordReg.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Продавач",
            "Купувач"});
            this.comboBox1.Location = new System.Drawing.Point(59, 186);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(289, 33);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txbEmailReg
            // 
            this.txbEmailReg.Location = new System.Drawing.Point(71, 135);
            this.txbEmailReg.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txbEmailReg.Name = "txbEmailReg";
            this.txbEmailReg.Size = new System.Drawing.Size(277, 32);
            this.txbEmailReg.TabIndex = 6;
            this.txbEmailReg.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // txbUsernameReg
            // 
            this.txbUsernameReg.Location = new System.Drawing.Point(156, 86);
            this.txbUsernameReg.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txbUsernameReg.Name = "txbUsernameReg";
            this.txbUsernameReg.Size = new System.Drawing.Size(192, 32);
            this.txbUsernameReg.TabIndex = 4;
            this.txbUsernameReg.TextChanged += new System.EventHandler(this.txbUsernameReg_TextChanged);
            // 
            // txbName
            // 
            this.txbName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txbName.Location = new System.Drawing.Point(133, 35);
            this.txbName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(215, 32);
            this.txbName.TabIndex = 5;
            this.txbName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblPasswordRegRepeat
            // 
            this.lblPasswordRegRepeat.AutoSize = true;
            this.lblPasswordRegRepeat.Font = new System.Drawing.Font("Segoe Script", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblPasswordRegRepeat.Location = new System.Drawing.Point(13, 291);
            this.lblPasswordRegRepeat.Name = "lblPasswordRegRepeat";
            this.lblPasswordRegRepeat.Size = new System.Drawing.Size(198, 25);
            this.lblPasswordRegRepeat.TabIndex = 5;
            this.lblPasswordRegRepeat.Text = "Повторете паролата:";
            this.lblPasswordRegRepeat.Click += new System.EventHandler(this.lblPasswordRegRepeat_Click);
            // 
            // lblEmailRegistration
            // 
            this.lblEmailRegistration.AutoSize = true;
            this.lblEmailRegistration.Font = new System.Drawing.Font("Segoe Script", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblEmailRegistration.Location = new System.Drawing.Point(16, 140);
            this.lblEmailRegistration.Name = "lblEmailRegistration";
            this.lblEmailRegistration.Size = new System.Drawing.Size(72, 25);
            this.lblEmailRegistration.TabIndex = 2;
            this.lblEmailRegistration.Text = "Имейл:";
            this.lblEmailRegistration.Click += new System.EventHandler(this.lblEmailRegistration_Click);
            // 
            // lblPasswordRegistration
            // 
            this.lblPasswordRegistration.AutoSize = true;
            this.lblPasswordRegistration.Font = new System.Drawing.Font("Segoe Script", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblPasswordRegistration.Location = new System.Drawing.Point(17, 241);
            this.lblPasswordRegistration.Name = "lblPasswordRegistration";
            this.lblPasswordRegistration.Size = new System.Drawing.Size(76, 25);
            this.lblPasswordRegistration.TabIndex = 4;
            this.lblPasswordRegistration.Text = "Парола:";
            this.lblPasswordRegistration.Click += new System.EventHandler(this.lblPasswordRegistration_Click);
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Segoe Script", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblRole.Location = new System.Drawing.Point(18, 191);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(56, 25);
            this.lblRole.TabIndex = 3;
            this.lblRole.Text = "Роля:";
            this.lblRole.Click += new System.EventHandler(this.lblRole_Click);
            // 
            // lblUsernameRegistration
            // 
            this.lblUsernameRegistration.AutoSize = true;
            this.lblUsernameRegistration.Font = new System.Drawing.Font("Segoe Script", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblUsernameRegistration.Location = new System.Drawing.Point(12, 89);
            this.lblUsernameRegistration.Name = "lblUsernameRegistration";
            this.lblUsernameRegistration.Size = new System.Drawing.Size(184, 25);
            this.lblUsernameRegistration.TabIndex = 1;
            this.lblUsernameRegistration.Text = "Потребителско име:";
            this.lblUsernameRegistration.Click += new System.EventHandler(this.lblUsernameRegistration_Click);
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Segoe Script", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblFullName.Location = new System.Drawing.Point(12, 39);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(153, 25);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "Име и фамилия:";
            this.lblFullName.Click += new System.EventHandler(this.lblFullName_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Project11.Properties.Resources.user_login_man_1024;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(46, 338);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 209);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe Script", 17F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblDescription.Location = new System.Drawing.Point(199, 70);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(322, 48);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "в нашия магазин!";
            this.lblDescription.Click += new System.EventHandler(this.lblDescription_Click);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(726, 562);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbRegistration);
            this.Controls.Add(this.gbLogin);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblDescription);
            this.Font = new System.Drawing.Font("Segoe Script", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Index";
            this.Text = "Начало";
            this.Load += new System.EventHandler(this.Index_Load);
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            this.gbRegistration.ResumeLayout(false);
            this.gbRegistration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.GroupBox gbLogin;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.GroupBox gbRegistration;
        private System.Windows.Forms.Label lblUsernameRegistration;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblEmailRegistration;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblPasswordRegRepeat;
        private System.Windows.Forms.Label lblPasswordRegistration;
        private System.Windows.Forms.TextBox txbUsernameReg;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txbEmailReg;
        private System.Windows.Forms.TextBox txbPasswordReg;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegistration;
        private System.Windows.Forms.TextBox txbRepeatPasswordReg;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDescription;
    }
}

