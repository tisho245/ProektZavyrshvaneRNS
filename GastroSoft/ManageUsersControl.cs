using System;
using System.Windows.Forms;
using GastroSoft.Controllers;
using GastroSoft.Models;
using System.Drawing;
using System.Linq;

namespace GastroSoft
{
    public partial class ManageUsersControl : UserControl
    {
        private UserController userController;

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
                dataGridUsers.DataSource = userController.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Грешка при зареждане на потребители: {ex.Message}", 
                    "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Функционалност за добавяне на потребител ще бъде добавена скоро.", 
                "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Функционалност за редактиране на потребител ще бъде добавена скоро.", 
                "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Функционалност за изтриване на потребител ще бъде добавена скоро.", 
                "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadUsers();
        }
    }
} 
