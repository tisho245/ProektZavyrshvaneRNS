using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project11.Model;
using Project11.Models;
using Project11.Controllers;
using Project11.Views;

namespace Project11
{
    public partial class Index : Form
    {
        public ProjectDBContext ProjectDBContext = new ProjectDBContext();
        private UserController userController;
        private ProductController productController;
        private ProductTypeController productTypeController;
        private SellController sellController;
        private User currentUser;

        public Index()
        {
            InitializeComponent();
            InitializeControllers();
        }

        private void InitializeControllers()
        {
            userController = new UserController();
            productController = new ProductController();
            productTypeController = new ProductTypeController();
            sellController = new SellController();
        }

        private void Index_Load(object sender, EventArgs e)
        {
           
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void txbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gbRegistration_Enter(object sender, EventArgs e)
        {

        }

        private void txtUsernameOrEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbUsernameReg_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text.Trim();
                string password = txbPassword.Text;

                if (string.IsNullOrEmpty(username) || string.IsNullOrWhiteSpace(username))
                {
                    MessageBox.Show("Моля, въведете потребителско име!", "Грешка", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(password) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Моля, въведете парола!", "Грешка", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Try to find user by username
                User user = userController.Get(username);
                
                if (user == null)
                {
                    MessageBox.Show("Потребителят не съществува!", "Грешка", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (user.Password != password)
                {
                    MessageBox.Show("Грешна парола!", "Грешка", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Successful login
                currentUser = user;
                MessageBox.Show($"Добре дошли, {user.FirstName} {user.LastName}!", "Успешен вход", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Hide login/registration panels and show main menu
                ShowMainMenu();
            }
            catch (Exception ex)
            {
                string errorMessage = $"Грешка при влизане:\n\n";
                errorMessage += $"Тип грешка: {ex.GetType().Name}\n";
                errorMessage += $"Съобщение: {ex.Message}\n";
                
                if (ex.InnerException != null)
                {
                    errorMessage += $"\nВътрешна грешка: {ex.InnerException.Message}\n";
                }
                
                errorMessage += $"\nПълни детайли:\n{ex.ToString()}";
                
                MessageBox.Show(errorMessage, "Детайлна грешка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPasswordRegRepeat_Click(object sender, EventArgs e)
        {

        }

        private void lblPasswordRegistration_Click(object sender, EventArgs e)
        {

        }

        private void lblRole_Click(object sender, EventArgs e)
        {

        }

        private void lblEmailRegistration_Click(object sender, EventArgs e)
        {

        }

        private void lblUsernameRegistration_Click(object sender, EventArgs e)
        {

        }

        private void lblFullName_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            try
            {
                string fullName = txbName.Text.Trim();
                string username = txbUsernameReg.Text.Trim();
                string email = txbEmailReg.Text.Trim();
                string password = txbPasswordReg.Text;
                string confirmPassword = txbRepeatPasswordReg.Text;
                
                // Validate inputs
                if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(username) || 
                    string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Моля попълнете всички полета!", "Грешка", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (password != confirmPassword)
                {
                    MessageBox.Show("Паролите не съвпадат!", "Грешка", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string[] nameParts = fullName.Split(' ');
                if (nameParts.Length < 2)
                {
                    MessageBox.Show("Моля въведете пълно име (име и фамилия)!", "Грешка", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string firstName = nameParts[0];
                string lastName = string.Join(" ", nameParts.Skip(1));

                // Create new user
                User newUser = new User();
                newUser.Username = username;
                newUser.Email = email;
                newUser.Password = password;
                newUser.FirstName = firstName;
                newUser.LastName = lastName;
                
                // Set role based on combobox selection (0=Продавач, 1=Купувач)
                if (comboBox1.SelectedIndex == 0)
                    newUser.Role = User.RoleTypes.Seller;
                else
                    newUser.Role = User.RoleTypes.Buyer;

                // Try to create user
                userController.Create(newUser);
                
                MessageBox.Show("Регистрацията е успешна! Можете да влезете в системата.", "Успех", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear registration form
                ClearRegistrationForm();
            }
            catch (Exception ex)
            {
                string errorMessage = $"Грешка при регистрация:\n\n";
                errorMessage += $"Тип грешка: {ex.GetType().Name}\n";
                errorMessage += $"Съобщение: {ex.Message}\n";
                
                if (ex.InnerException != null)
                {
                    errorMessage += $"\nВътрешна грешка: {ex.InnerException.Message}\n";
                }
                
                errorMessage += $"\nПълни детайли:\n{ex.ToString()}";
                
                MessageBox.Show(errorMessage, "Детайлна грешка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void gbLogin_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void lblDescription_Click(object sender, EventArgs e)
        {

        }

        // Additional methods for functionality
        private void ShowMainMenu()
        {
            // Hide login/registration groups
            gbLogin.Visible = false;
            gbRegistration.Visible = false;
            pictureBox1.Visible = false;
            lblDescription.Visible = false;

            // Create appropriate UserControl based on role
            UserControl roleControl = null;
            
            switch (currentUser.Role)
            {
                case User.RoleTypes.Admin:
                    roleControl = new AdminControl(currentUser);
                    break;
                case User.RoleTypes.Seller:
                    roleControl = new SellerControl(currentUser);
                    break;
                case User.RoleTypes.Buyer:
                    roleControl = new BuyerControl(currentUser);
                    break;
            }

            if (roleControl != null)
            {
                roleControl.Location = new Point(50, 50);
                roleControl.Size = new Size(600, 400);
                this.Controls.Add(roleControl);
                
                // Add logout button
                Button btnLogout = new Button();
                btnLogout.Text = "Изход";
                btnLogout.Size = new Size(100, 40);
                btnLogout.Location = new Point(this.Width - 120, 20);
                btnLogout.Click += BtnLogout_Click;
                this.Controls.Add(btnLogout);
            }
        }

     

        private void BtnProducts_Click(object sender, EventArgs e)
        {
            try
            {
                var products = productController.GetAll();
                ShowDataGrid("Продукти", products);
            }
            catch (Exception ex)
            {
                string errorMessage = $"Грешка при зареждане на продукти:\n\n";
                errorMessage += $"Тип грешка: {ex.GetType().Name}\n";
                errorMessage += $"Съобщение: {ex.Message}\n";
                
                if (ex.InnerException != null)
                {
                    errorMessage += $"\nВътрешна грешка: {ex.InnerException.Message}\n";
                }
                
                errorMessage += $"\nПълни детайли:\n{ex.ToString()}";
                
                MessageBox.Show(errorMessage, "Детайлна грешка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnProductTypes_Click(object sender, EventArgs e)
        {
            try
            {
                var productTypes = productTypeController.GetAll();
                ShowDataGrid("Типове продукти", productTypes);
            }
            catch (Exception ex)
            {
                string errorMessage = $"Грешка при зареждане на типове:\n\n";
                errorMessage += $"Тип грешка: {ex.GetType().Name}\n";
                errorMessage += $"Съобщение: {ex.Message}\n";
                
                if (ex.InnerException != null)
                {
                    errorMessage += $"\nВътрешна грешка: {ex.InnerException.Message}\n";
                }
                
                errorMessage += $"\nПълни детайли:\n{ex.ToString()}";
                
                MessageBox.Show(errorMessage, "Детайлна грешка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnUsers_Click(object sender, EventArgs e)
        {
            try
            {
                var users = userController.GetAll();
                ShowDataGrid("Потребители", users);
            }
            catch (Exception ex)
            {
                string errorMessage = $"Грешка при зареждане на потребители:\n\n";
                errorMessage += $"Тип грешка: {ex.GetType().Name}\n";
                errorMessage += $"Съобщение: {ex.Message}\n";
                
                if (ex.InnerException != null)
                {
                    errorMessage += $"\nВътрешна грешка: {ex.InnerException.Message}\n";
                }
                
                errorMessage += $"\nПълни детайли:\n{ex.ToString()}";
                
                MessageBox.Show(errorMessage, "Детайлна грешка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSales_Click(object sender, EventArgs e)
        {
            try
            {
                var sales = sellController.GetAll();
                ShowDataGrid("Продажби", sales);
            }
            catch (Exception ex)
            {
                string errorMessage = $"Грешка при зареждане на продажби:\n\n";
                errorMessage += $"Тип грешка: {ex.GetType().Name}\n";
                errorMessage += $"Съобщение: {ex.Message}\n";
                
                if (ex.InnerException != null)
                {
                    errorMessage += $"\nВътрешна грешка: {ex.InnerException.Message}\n";
                }
                
                errorMessage += $"\nПълни детайли:\n{ex.ToString()}";
                
                MessageBox.Show(errorMessage, "Детайлна грешка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowDataGrid(string title, object data)
        {
            Form dataForm = new Form();
            dataForm.Text = title;
            dataForm.Size = new Size(800, 600);
            dataForm.StartPosition = FormStartPosition.CenterScreen;

            DataGridView dgv = new DataGridView();
            dgv.Dock = DockStyle.Fill;
            dgv.DataSource = data;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.ReadOnly = true;

            dataForm.Controls.Add(dgv);
            dataForm.ShowDialog();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            currentUser = null;
            
            // Remove UserControl and logout button
            var controlsToRemove = this.Controls.OfType<Control>()
                .Where(c => c is UserControl || (c is Button && ((Button)c).Text == "Изход"))
                .ToList();
            foreach (Control control in controlsToRemove)
            {
                this.Controls.Remove(control);
            }
            
            // Show login/registration again
            gbLogin.Visible = true;
            gbRegistration.Visible = true;
            pictureBox1.Visible = true;
            lblDescription.Visible = true;
            
            // Clear login form
            txtUsername.Clear();
            txbPassword.Clear();
        }

        private void ClearRegistrationForm()
        {
            txbName.Clear();
            txbUsernameReg.Clear();
            txbEmailReg.Clear();
            txbPasswordReg.Clear();
            txbRepeatPasswordReg.Clear();
            comboBox1.SelectedIndex = 1; // Default to Купувач
        }
    }
}
