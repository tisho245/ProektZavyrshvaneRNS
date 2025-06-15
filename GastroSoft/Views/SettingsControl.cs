using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace GastroSoft
{
    public partial class SettingsControl : UserControl
    {
        public SettingsControl()
        {
            InitializeComponent();
            InitializeSettings();
        }

        private void InitializeSettings()
        {
            txtBackupPath.Text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "GastroSoft_Backups");
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {
                string backupPath = txtBackupPath.Text;
                if (!Directory.Exists(backupPath))
                {
                    Directory.CreateDirectory(backupPath);
                }

                string backupFileName = $"backup_{DateTime.Now:yyyyMMdd_HHmmss}.bak";
                string fullBackupPath = Path.Combine(backupPath, backupFileName);

                // Simulate backup creation
                File.WriteAllText(fullBackupPath, $"Backup created on {DateTime.Now}");

                MessageBox.Show($"Архивът е създаден успешно:\n{fullBackupPath}", 
                    "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Грешка при създаване на архив: {ex.Message}", 
                    "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Backup files (*.bak)|*.bak|All files (*.*)|*.*";
                    openFileDialog.InitialDirectory = txtBackupPath.Text;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string selectedFile = openFileDialog.FileName;
                        
                        // Simulate restore process
                        MessageBox.Show($"Възстановяването от архив е завършено успешно:\n{selectedFile}", 
                            "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Грешка при възстановяване: {ex.Message}", 
                    "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChangeTheme_Click(object sender, EventArgs e)
        {
            try
            {
                // Simple theme toggle
                if (this.BackColor == SystemColors.Control)
                {
                    this.BackColor = Color.DarkGray;
                    MessageBox.Show("Тъмна тема е активирана.", "Тема", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    this.BackColor = SystemColors.Control;
                    MessageBox.Show("Светла тема е активирана.", "Тема", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Грешка при смяна на тема: {ex.Message}", 
                    "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSystemInfo_Click(object sender, EventArgs e)
        {
            try
            {
                string systemInfo = $"Системна информация:\n\n" +
                                  $"Операционна система: {Environment.OSVersion}\n" +
                                  $"Версия на .NET: {Environment.Version}\n" +
                                  $"Машинно име: {Environment.MachineName}\n" +
                                  $"Потребител: {Environment.UserName}\n" +
                                  $"Работна директория: {Environment.CurrentDirectory}\n" +
                                  $"Процесори: {Environment.ProcessorCount}\n" +
                                  $"Системна директория: {Environment.SystemDirectory}";

                MessageBox.Show(systemInfo, "Системна информация", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Грешка при извличане на системна информация: {ex.Message}", 
                    "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
} 
