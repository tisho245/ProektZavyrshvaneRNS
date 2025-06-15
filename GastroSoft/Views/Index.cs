using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GastroSoft.Model;
using GastroSoft.Models;
using GastroSoft.Controllers;


namespace GastroSoft
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
                    MessageBox.Show("Не, потребителското име е грешно!", "Грешка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(password) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Не, паролата е грешна!", "Грешка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

               
                User user = userController.Get(username);
                
                if (user == null)
                {
                    MessageBox.Show("Невалидни данни за вход!", "Грешка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (user.Password != password)
                {
                    MessageBox.Show("Грешка при вход!", "Грешка",
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
                string errorMessage = $"Грешка при вход:\n\n";
                errorMessage += $"Тип грешка: {ex.GetType().Name}\n";
                errorMessage += $"Описание: {ex.Message}\n";
                
                if (ex.InnerException != null)
                {
                    errorMessage += $"\nВътрешна грешка: {ex.InnerException.Message}\n";
                }
                
                errorMessage += $"\nПодробности:\n{ex.ToString()}";
                
                MessageBox.Show(errorMessage, "Грешка при вход", 
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
                    MessageBox.Show("Не всички полета са попълнени (или са грешни)!", "Грешка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (password != confirmPassword)
                {
                    MessageBox.Show("Паролите не съвпадат!", "Грешка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string[] nameParts = fullName.Split(' ');
                if (nameParts.Length < 2)
                {
                    MessageBox.Show("Не всички полета са попълнени (или са грешни)!", "Грешка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                
                // Set role based on combobox selection (0=????????, 1=???????)
                if (comboBox1.SelectedIndex == 0)
                    newUser.Role = User.RoleTypes.Seller;
                else
                    newUser.Role = User.RoleTypes.Buyer;

                // Try to create user
                userController.Create(newUser);
                
                MessageBox.Show("Регистрацията е успешна! Моля влезте в системата.", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear registration form
                ClearRegistrationForm();
            }
            catch (Exception ex)
            {
                string errorMessage = $"Грешка при регистрация:\n\n";
                errorMessage += $"Тип грешка: {ex.GetType().Name}\n";
                errorMessage += $"Описание: {ex.Message}\n";
                
                if (ex.InnerException != null)
                {
                    errorMessage += $"\nВътрешна грешка: {ex.InnerException.Message}\n";
                }
                
                errorMessage += $"\nПодробности:\n{ex.ToString()}";
                
                MessageBox.Show(errorMessage, "Грешка при регистрация",
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
            //pictureBox1.Visible = false;
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
                // Set exact size and position to cover the entire form area
                roleControl.Location = new Point(0, 0);
                roleControl.Size = new Size(726, 562);
                roleControl.Dock = DockStyle.Fill; // Ensure it fills the entire form
                this.Controls.Add(roleControl);
                roleControl.BringToFront(); // Bring to front to ensure it's visible
                
                // Show logout button (already exists in designer)
                btnLogout.Visible = true;
                btnLogout.BringToFront(); // Make sure logout button is on top
            }
        }

     

        private void BtnProducts_Click(object sender, EventArgs e)
        {
            try
            {
                var products = productController.GetAll();
                ShowDataGrid("????????", products);
            }
            catch (Exception ex)
            {
                string errorMessage = $"Грешка при зареждане на продукти:\n\n";
                errorMessage += $"Тип грешка: {ex.GetType().Name}\n";
                errorMessage += $"Описание: {ex.Message}\n";
                
                if (ex.InnerException != null)
                {
                    errorMessage += $"\nВътрешна грешка: {ex.InnerException.Message}\n";
                }
                
                errorMessage += $"\nПодробности:\n{ex.ToString()}";
                
                MessageBox.Show(errorMessage, "Грешка при зареждане на продукти", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnProductTypes_Click(object sender, EventArgs e)
        {
            try
            {
                var productTypes = productTypeController.GetAll();
                ShowDataGrid("?????? ????????", productTypes);
            }
            catch (Exception ex)
            {
                string errorMessage = $"Грешка при зареждане на типове продукти:\n\n";
                errorMessage += $"Тип грешка: {ex.GetType().Name}\n";
                errorMessage += $"Описание: {ex.Message}\n";
                
                if (ex.InnerException != null)
                {
                    errorMessage += $"\nВътрешна грешка: {ex.InnerException.Message}\n";
                }
                
                errorMessage += $"\nПодробности:\n{ex.ToString()}";
                
                MessageBox.Show(errorMessage, "Грешка при зареждане на типове продукти", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnUsers_Click(object sender, EventArgs e)
        {
            try
            {
                var users = userController.GetAll();
                ShowDataGrid("???????????", users);
            }
            catch (Exception ex)
            {
                string errorMessage = $"Грешка при зареждане на потребители:\n\n";
                errorMessage += $"Тип грешка: {ex.GetType().Name}\n";
                errorMessage += $"Описание: {ex.Message}\n";
                
                if (ex.InnerException != null)
                {
                    errorMessage += $"\nВътрешна грешка: {ex.InnerException.Message}\n";
                }
                
                errorMessage += $"\nПодробности:\n{ex.ToString()}";
                
                MessageBox.Show(errorMessage, "Грешка при зареждане на потребители", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSales_Click(object sender, EventArgs e)
        {
            try
            {
                var sales = sellController.GetAll();
                ShowDataGrid("????????", sales);
            }
            catch (Exception ex)
            {
                string errorMessage = $"Грешка при зареждане на продажби:\n\n";
                errorMessage += $"Тип грешка: {ex.GetType().Name}\n";
                errorMessage += $"Описание: {ex.Message}\n";
                
                if (ex.InnerException != null)
                {
                    errorMessage += $"\nВътрешна грешка: {ex.InnerException.Message}\n";
                }
                
                errorMessage += $"\nПодробности:\n{ex.ToString()}";
                
                MessageBox.Show(errorMessage, "Грешка при зареждане на продажби", 
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
            
            // Remove UserControls only
            var controlsToRemove = this.Controls.OfType<UserControl>().ToList();
            foreach (Control control in controlsToRemove)
            {
                this.Controls.Remove(control);
            }
            
            // Hide logout button
            btnLogout.Visible = false;
            
            // Show login/registration again
            gbLogin.Visible = true;
            gbRegistration.Visible = true;
            //pictureBox1.Visible = true;
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
            comboBox1.SelectedIndex = 1; // Default to ???????
        }
    }
}
