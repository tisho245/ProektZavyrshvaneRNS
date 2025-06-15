using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using GastroSoft.Controllers;
using GastroSoft.Models;

namespace GastroSoft.Views
{
    public partial class ProfileControl : UserControl
    {
        private UserController userController;
        private User currentUser;

        public ProfileControl()
        {
            InitializeComponent();
            userController = new UserController();
        }

        public ProfileControl(User user) : this()
        {
            currentUser = user;
            LoadUserData();
        }

        public void SetCurrentUser(User user)
        {
            currentUser = user;
            LoadUserData();
        }

        private void LoadUserData()
        {
            if (currentUser != null)
            {
                txbUsername.Text = currentUser.Username;
                txbFirstName.Text = currentUser.FirstName ?? "";
                txbLastName.Text = currentUser.LastName ?? "";
                txbEmail.Text = currentUser.Email ?? "";
                
                // Display user-friendly role names
                string roleDisplayName = GetRoleDisplayName(currentUser.Role);
                txbRole.Text = roleDisplayName;
            }
        }

        private string GetRoleDisplayName(User.RoleTypes role)
        {
            switch (role)
            {
                case User.RoleTypes.Admin:
                    return "Администратор";
                case User.RoleTypes.Seller:
                    return "Продавач";
                case User.RoleTypes.Buyer:
                    return "Купувач";
                default:
                    return "Неизвестна роля";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidatePersonalInfo())
                {
                    SavePersonalInfo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Грешка при запазване: {ex.Message}",
                    "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidatePersonalInfo()
        {
            // Check required fields
            if (string.IsNullOrWhiteSpace(txbFirstName.Text))
            {
                MessageBox.Show("Моля въведете име.", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbFirstName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txbLastName.Text))
            {
                MessageBox.Show("Моля въведете фамилия.", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbLastName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txbEmail.Text))
            {
                MessageBox.Show("Моля въведете имейл.", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbEmail.Focus();
                return false;
            }

            // Validate email format
            if (!IsValidEmail(txbEmail.Text))
            {
                MessageBox.Show("Моля въведете валиден имейл.", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbEmail.Focus();
                return false;
            }

            // Check if email is already used by another user
            if (!IsEmailUnique(txbEmail.Text))
            {
                MessageBox.Show("Имейлът вече е зает.", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbEmail.Focus();
                return false;
            }

            return true;
        }

        private bool IsValidEmail(string email)
        {
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, emailPattern);
        }

        private bool IsEmailUnique(string email)
        {
            if (currentUser != null && currentUser.Email?.ToLower() == email.ToLower())
            {
                return true; // Same email as current user
            }

            var allUsers = userController.GetAll();
            return !allUsers.Any(u => u.Email?.ToLower() == email.ToLower());
        }

        private void SavePersonalInfo()
        {
            if (currentUser != null)
            {
                currentUser.FirstName = txbFirstName.Text.Trim();
                currentUser.LastName = txbLastName.Text.Trim();
                currentUser.Email = txbEmail.Text.Trim();

                userController.Update(currentUser.Username, currentUser);
                
                MessageBox.Show("Профилът е успешно запазен!", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                LoadUserData(); // Reload to ensure data consistency
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidatePasswordChange())
                {
                    ChangePassword();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Грешка при смяна на парола: {ex.Message}",
                    "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidatePasswordChange()
        {
            // Check if old password is provided
            if (string.IsNullOrWhiteSpace(txbPasswordOld.Text))
            {
                MessageBox.Show("Моля въведете стара парола.", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbPasswordOld.Focus();
                return false;
            }

            // Check if new password is provided
            if (string.IsNullOrWhiteSpace(txbPasswordNew.Text))
            {
                MessageBox.Show("Моля въведете нова парола.", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbPasswordNew.Focus();
                return false;
            }

            // Check password length
            if (txbPasswordNew.Text.Length < 6)
            {
                MessageBox.Show("Паролата трябва да бъде с дължина поне 6 символа.", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbPasswordNew.Focus();
                return false;
            }

            // Check if password confirmation matches
            if (txbPasswordNew.Text != txbPasswordConfirm.Text)
            {
                MessageBox.Show("Паролите не съвпадат.", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbPasswordConfirm.Focus();
                return false;
            }

            // Verify old password
            if (currentUser != null && currentUser.Password != txbPasswordOld.Text)
            {
                MessageBox.Show("Старата парола е невалидна.", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbPasswordOld.Focus();
                return false;
            }

            return true;
        }

        private void ChangePassword()
        {
            if (currentUser != null)
            {
                currentUser.Password = txbPasswordNew.Text;
                userController.Update(currentUser.Username, currentUser);
                
                MessageBox.Show("Паролата е успешно сменена!", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                // Clear password fields
                ClearPasswordFields();
            }
        }

        private void ClearPasswordFields()
        {
            txbPasswordOld.Clear();
            txbPasswordNew.Clear();
            txbPasswordConfirm.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Reload original data
            LoadUserData();
            ClearPasswordFields();
            
            MessageBox.Show("Профилът не е запазен.", "Предупреждение",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
 
