using System;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;

namespace GastroSoft
{
    public partial class HelpControl : UserControl
    {
        public HelpControl()
        {
            InitializeComponent();
            InitializeHelpContent();
        }

        private void InitializeHelpContent()
        {
            // Add help topics to tree view
            TreeNode rootNode = new TreeNode("Ръководство за потребителя");
            
            TreeNode gettingStarted = new TreeNode("Първи стъпки");
            gettingStarted.Nodes.Add("Вход в системата");
            gettingStarted.Nodes.Add("Регистрация");
            gettingStarted.Nodes.Add("Навигация");
            
            TreeNode adminHelp = new TreeNode("Администратор");
            adminHelp.Nodes.Add("Управление на потребители");
            adminHelp.Nodes.Add("Управление на продукти");
            adminHelp.Nodes.Add("Отчети");
            adminHelp.Nodes.Add("Настройки");
            
            TreeNode sellerHelp = new TreeNode("Продавач");
            sellerHelp.Nodes.Add("Продажби");
            sellerHelp.Nodes.Add("Наличности");
            sellerHelp.Nodes.Add("Отчети");
            
            TreeNode buyerHelp = new TreeNode("Купувач");
            buyerHelp.Nodes.Add("Разглеждане на продукти");
            buyerHelp.Nodes.Add("Правене на поръчки");
            buyerHelp.Nodes.Add("Проследяване");
            
            TreeNode troubleshooting = new TreeNode("Отстраняване на проблеми");
            troubleshooting.Nodes.Add("Често срещани проблеми");
            troubleshooting.Nodes.Add("Връзка с поддръжката");
            
            rootNode.Nodes.Add(gettingStarted);
            rootNode.Nodes.Add(adminHelp);
            rootNode.Nodes.Add(sellerHelp);
            rootNode.Nodes.Add(buyerHelp);
            rootNode.Nodes.Add(troubleshooting);
            
            treeViewTopics.Nodes.Add(rootNode);
            treeViewTopics.ExpandAll();
            
            ShowWelcomeContent();
        }

        private void ShowWelcomeContent()
        {
            richTextBoxContent.Clear();
            richTextBoxContent.AppendText("Добре дошли в помощната система на GastroSoft!\n\n");
            richTextBoxContent.AppendText("Изберете тема от лявата страна за да получите подробна информация.\n\n");
            richTextBoxContent.AppendText("Системата предоставя функционалности за:\n");
            richTextBoxContent.AppendText("- Администратори - пълно управление на системата\n");
            richTextBoxContent.AppendText("- Продавачи - управление на продажби и наличности\n");
            richTextBoxContent.AppendText("- Купувачи - разглеждане и поръчване на продукти\n\n");
            richTextBoxContent.AppendText("За допълнителна помощ използвайте връзките в долната част.");
        }

        private void treeViewTopics_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string selectedTopic = e.Node.Text;
            ShowHelpContent(selectedTopic);
        }

        private void ShowHelpContent(string topic)
        {
            richTextBoxContent.Clear();
            richTextBoxContent.AppendText($"{topic}\n");
            richTextBoxContent.AppendText(new string('=', topic.Length) + "\n\n");

            switch (topic)
            {
                case "Вход в системата":
                    richTextBoxContent.AppendText("За да влезете в системата:\n\n");
                    richTextBoxContent.AppendText("1. Въведете потребителското си име\n");
                    richTextBoxContent.AppendText("2. Въведете паролата си\n");
                    richTextBoxContent.AppendText("3. Натиснете бутона 'Вход'\n\n");
                    richTextBoxContent.AppendText("Ако нямате акаунт, използвайте формата за регистрация.");
                    break;

                case "Регистрация":
                    richTextBoxContent.AppendText("За да се регистрирате:\n\n");
                    richTextBoxContent.AppendText("1. Попълнете всички задължителни полета\n");
                    richTextBoxContent.AppendText("2. Изберете роля (Купувач/Продавач)\n");
                    richTextBoxContent.AppendText("3. Въведете валиден имейл адрес\n");
                    richTextBoxContent.AppendText("4. Създайте сигурна парола\n");
                    richTextBoxContent.AppendText("5. Потвърдете паролата\n");
                    richTextBoxContent.AppendText("6. Натиснете 'Регистрирай ме'");
                    break;

                case "Управление на потребители":
                    richTextBoxContent.AppendText("Като администратор можете:\n\n");
                    richTextBoxContent.AppendText("- Преглед на всички потребители\n");
                    richTextBoxContent.AppendText("- Добавяне на нови потребители\n");
                    richTextBoxContent.AppendText("- Редактиране на потребителски данни\n");
                    richTextBoxContent.AppendText("- Изтриване на потребители\n");
                    richTextBoxContent.AppendText("- Промяна на роли и права");
                    break;

                case "Управление на продукти":
                    richTextBoxContent.AppendText("Управление на продуктите включва:\n\n");
                    richTextBoxContent.AppendText("- Добавяне на нови продукти\n");
                    richTextBoxContent.AppendText("- Редактиране на съществуващи продукти\n");
                    richTextBoxContent.AppendText("- Управление на наличности\n");
                    richTextBoxContent.AppendText("- Категоризиране по типове\n");
                    richTextBoxContent.AppendText("- Проследяване на срокове на годност");
                    break;

                case "Продажби":
                    richTextBoxContent.AppendText("Функции за продажби:\n\n");
                    richTextBoxContent.AppendText("- Създаване на нови продажби\n");
                    richTextBoxContent.AppendText("- Преглед на история на продажби\n");
                    richTextBoxContent.AppendText("- Филтриране по дата\n");
                    richTextBoxContent.AppendText("- Проследяване на дневни продажби");
                    break;

                case "Разглеждане на продукти":
                    richTextBoxContent.AppendText("Като купувач можете:\n\n");
                    richTextBoxContent.AppendText("- Разглеждане на каталога с продукти\n");
                    richTextBoxContent.AppendText("- Търсене на конкретни продукти\n");
                    richTextBoxContent.AppendText("- Филтриране по категории\n");
                    richTextBoxContent.AppendText("- Добавяне в любими\n");
                    richTextBoxContent.AppendText("- Добавяне в количката");
                    break;

                case "Често срещани проблеми":
                    richTextBoxContent.AppendText("Решения на често срещани проблеми:\n\n");
                    richTextBoxContent.AppendText("Проблем: Забравена парола\n");
                    richTextBoxContent.AppendText("Решение: Свържете се с администратор\n\n");
                    richTextBoxContent.AppendText("Проблем: Грешка при вход\n");
                    richTextBoxContent.AppendText("Решение: Проверете потребителското име и парола\n\n");
                    richTextBoxContent.AppendText("Проблем: Бавна работа на системата\n");
                    richTextBoxContent.AppendText("Решение: Рестартирайте приложението");
                    break;

                default:
                    richTextBoxContent.AppendText("Изберете конкретна тема за подробна информация.");
                    break;
            }
        }

        private void linkLabelDocumentation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                MessageBox.Show("Документацията ще бъде достъпна скоро на уебсайта на компанията.", 
                    "Документация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Грешка при отваряне на документацията: {ex.Message}", 
                    "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabelSupport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                string supportInfo = "Връзка с поддръжката:\n\n" +
                                   "Телефон: +359 888 123 456\n" +
                                   "Email: support@gastrosoft.com\n" +
                                   "Работно време: 9:00 - 18:00 (Пон-Пет)\n\n" +
                                   "При спешни проблеми използвайте телефонния номер.";

                MessageBox.Show(supportInfo, "Връзка с поддръжката", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Грешка при зареждане на контактна информация: {ex.Message}", 
                    "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void richTextBoxContent_TextChanged(object sender, EventArgs e)
        {

        }
    }
} 
