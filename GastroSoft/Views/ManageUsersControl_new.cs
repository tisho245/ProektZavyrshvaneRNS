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
                // Validate input
                if (string.IsNullOrWhiteSpace(txbUsername.Text))
                {
                    MessageBox.Show("Потребителското име е задължително!", "Грешка", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

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

                // Check for duplicate username/email
                var existingUsers = userController.GetAll();
                if (selectedUser == null) // New user
                {
                    if (existingUsers.Any(u => u.Username == txbUsername.Text))
                    {
                        MessageBox.Show("Това потребителско име вече съществува!", "Грешка", 
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (existingUsers.Any(u => u.Email == txbEmail.Text))
                    {
                        MessageBox.Show("Този имейл адрес вече се използва!", "Грешка", 
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else // Existing user
                {
                    if (existingUsers.Any(u => u.Username == txbUsername.Text && u.Username != selectedUser.Username))
                    {
                        MessageBox.Show("Това потребителско име вече съществува!", "Грешка", 
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (existingUsers.Any(u => u.Email == txbEmail.Text && u.Email != selectedUser.Email))
                    {
                        MessageBox.Show("Този имейл адрес вече се използва!", "Грешка", 
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                if (selectedUser != null)
                {
                    // Update existing user
                    selectedUser.Username = txbUsername.Text;
                    selectedUser.FirstName = txbFirstName.Text;
                    selectedUser.Email = txbEmail.Text;
                    selectedUser.Role = (User.RoleTypes)roleValue;
                    
                    userController.Update(selectedUser.Username, selectedUser);
                    MessageBox.Show("Потребителят е обновен успешно!", "Успех", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Create new user
                    var newUser = new User
                    {
                        Username = txbUsername.Text,
                        FirstName = txbFirstName.Text,
                        Email = txbEmail.Text,
                        Password = "password123", // Default password
                        LastName = "Фамилия", // Default last name
                        Role = (User.RoleTypes)roleValue
                    };
                    
                    userController.Create(newUser);
                    MessageBox.Show("Новият потребител е създаден успешно!", "Успех", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
                LoadUsers();
                ClearTextBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Грешка при запазване: {ex.Message}", 
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
            txbUsername.Clear();
            txbFirstName.Clear();
            txbEmail.Clear();
            txbRole.Clear();
        }
    }
} 