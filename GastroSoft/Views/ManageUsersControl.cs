using System;
using System.Windows.Forms;
using GastroSoft.Controllers;
using GastroSoft.Models;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;

namespace GastroSoft
{
    public partial class ManageUsersControl : UserControl
    {
        private UserController userController;
        private User selectedUser = null;

        public ManageUsersControl()
        {
            InitializeComponent();
            userController = new UserController();
            LoadUsers();
            
            // Set USERNAME field as read-only since it's auto increment
            txbUsername.ReadOnly = true;
            txbUsername.BackColor = SystemColors.Control;
            
        }

        private void LoadUsers()
        {
            try
            {
                var users = userController.GetAll();
                lbUsers.Items.Clear();
                
                foreach (var user in users)
                {
                    string roleText;
                    switch (user.Role)
                    {
                        case User.RoleTypes.Admin:
                            roleText = "Администратор";
                            break;
                        case User.RoleTypes.Seller:
                            roleText = "Продавач";
                            break;
                        case User.RoleTypes.Buyer:
                            roleText = "Купувач";
                            break;
                        default:
                            roleText = "Неизвестна";
                            break;
                    }
                    
                    lbUsers.Items.Add($"{user.Username} | {user.FirstName} {user.LastName} | {user.Email} | {roleText}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Грешка при зареждане на потребители: {ex.Message}", 
                    "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbUsers.SelectedIndex >= 0)
            {
                try
                {
                    var users = userController.GetAll();
                    selectedUser = users[lbUsers.SelectedIndex];
                    
                    // Populate text boxes with selected user data
                    txbUsername.Text = selectedUser.Username;
                    txbFirstName.Text = selectedUser.FirstName;
                    txbEmail.Text = selectedUser.Email;
                    txbRole.Text = ((int)selectedUser.Role).ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Грешка при избиране на потребител: {ex.Message}", 
                        "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedUser == null)
                {
                    MessageBox.Show("Моля, изберете потребител за редактиране!", "Грешка", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate input
                if (string.IsNullOrWhiteSpace(txbFirstName.Text))
                {
                    MessageBox.Show("Името е задължително!", "Грешка", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txbEmail.Text))
                {
                    MessageBox.Show("Имейлът е задължителен!", "Грешка", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!IsValidEmail(txbEmail.Text))
                {
                    MessageBox.Show("Моля въведете валиден имейл адрес!", "Грешка", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int roleValue;
                if (!int.TryParse(txbRole.Text, out roleValue) || roleValue < 0 || roleValue > 2)
                {
                    MessageBox.Show("Ролята трябва да бъде число между 0 и 2!", "Грешка", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Check for duplicate email (username cannot be changed)
                var existingUsers = userController.GetAll();
                if (existingUsers.Any(u => u.Email == txbEmail.Text && u.Email != selectedUser.Email))
                {
                    MessageBox.Show("Този имейл адрес вече се използва!", "Грешка", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Update existing user (USERNAME cannot be changed as it's auto increment)
                selectedUser.FirstName = txbFirstName.Text.Trim();
                selectedUser.Email = txbEmail.Text.Trim();
                selectedUser.Role = (User.RoleTypes)roleValue;
                
                userController.Update(selectedUser.Username, selectedUser);
                MessageBox.Show("Потребителят е обновен успешно!", "Успех", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                LoadUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Грешка при запазване на потребител: {ex.Message}", 
                    "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedUser != null)
            {
                try
                {
                    var result = MessageBox.Show($"Сигурни ли сте, че искате да изтриете потребител '{selectedUser.Username}'?", 
                        "Потвърждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    
                    if (result == DialogResult.Yes)
                    {
                        userController.Delete(selectedUser.Username);
                        MessageBox.Show("Потребителят е изтрит успешно!", "Успех", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        LoadUsers();
                        ClearTextBoxes();
                        selectedUser = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Грешка при изтриване: {ex.Message}", 
                        "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Моля изберете потребител за изтриване!", "Информация", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            selectedUser = null;
            lbUsers.SelectedIndex = -1;
        }

        private void ClearTextBoxes()
        {
            txbUsername.Text = "Auto";
            txbFirstName.Clear();
            txbEmail.Clear();
            txbRole.Clear();
            selectedUser = null;
            lbUsers.SelectedIndex = -1;
        }

        private void AutoFillAllFields()
        {
            try
            {
                var users = userController.GetAll();
                
                if (users.Any())
                {
                    var firstUser = users.First();
                    txbUsername.Text = firstUser.Username;
                    txbFirstName.Text = firstUser.FirstName;
                    txbEmail.Text = firstUser.Email;
                    txbRole.Text = ((int)firstUser.Role).ToString();
                    
                    // Auto-select first user
                    if (lbUsers.Items.Count > 0)
            {
                        lbUsers.SelectedIndex = 0;
                    }
                }
                else
                {
                    // Set default values
                    txbUsername.Text = "примерпотребител";
                    txbFirstName.Text = "Примерно име";
                    txbEmail.Text = "primer@example.com";
                    txbRole.Text = "1"; // Buyer role
                }
            }
            catch (Exception)
            {
                // Fallback values
                txbUsername.Text = "примерпотребител";
                txbFirstName.Text = "Примерно име";
                txbEmail.Text = "primer@example.com";
                txbRole.Text = "1";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Disabled - users should register themselves with password
            MessageBox.Show("Добавянето на потребители от админ панела е недостъпно.\n" +
                           "Потребителите трябва да се регистрират сами с парола.", 
                           "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedUser != null)
            {
                // User is already selected and details are shown, ready for editing
                txbUsername.Focus();
            }
            else
            {
                MessageBox.Show("Моля изберете потребител за редактиране!", "Информация", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Parent?.Controls.Remove(this);
            }

        private void ManageUsersControl_Load(object sender, EventArgs e)
        {

        }
    }
} 
