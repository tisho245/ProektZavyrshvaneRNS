using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using GastroSoft.Controllers;
using GastroSoft.Models;
using GastroSoft.Model;
using System.Drawing;
using System.IO;

namespace GastroSoft
{
    public partial class ReportsControl : UserControl
    {
        private readonly SellController sellController;
        private readonly ProductController productController;
        private readonly ProductTypeController productTypeController;
        private readonly UserController userController;

        // Additional controls that might not be in Designer
        private DateTimePicker dtpFrom;
        private DateTimePicker dtpTo;
        private Label lblTotalSales;
        private Label lblTotalQuantity;
        private Label lblAverageSale;
        private ListBox lbTopProducts;
        private ListBox lbSalesByType;
        private Label lblPeriod;
        private Label lblTotalSalesCount;

        public ReportsControl()
        {
            InitializeComponent();
            sellController = new SellController();
            productController = new ProductController();
            productTypeController = new ProductTypeController();
            userController = new UserController();
            InitializeAdditionalControls();
            SetupControls();
            this.Load += ReportsControl_Load;
        }

        private void InitializeAdditionalControls()
        {
            // Initialize controls that might not be in Designer
            if (dtpFrom == null)
            {
                dtpFrom = new DateTimePicker();
                dtpTo = new DateTimePicker();
                lblTotalSales = new Label();
                lblTotalQuantity = new Label();
                lblAverageSale = new Label();
                lbTopProducts = new ListBox();
                lbSalesByType = new ListBox();
                lblPeriod = new Label();
                lblTotalSalesCount = new Label();
                
                // Add to controls if needed
                // This is a fallback in case the Designer doesn't have these controls
            }
        }

        private void ReportsControl_Load(object sender, EventArgs e)
        {
            InitializeControls();
            LoadReports();
        }

        private void InitializeControls()
        {
            try
            {
                // Set default date range (current month)
                if (dtpFrom != null)
                    dtpFrom.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                if (dtpTo != null)
                    dtpTo.Value = DateTime.Now;

                // Set up event handlers
                if (dtpFrom != null)
                    dtpFrom.ValueChanged += (s, e) => LoadReports();
                if (dtpTo != null)
                    dtpTo.ValueChanged += (s, e) => LoadReports();
                if (btnGenerateReport != null)
                    btnGenerateReport.Click += btnGenerateReport_Click;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Грешка при инициализация: {ex.Message}", "Грешка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetupControls()
        {
            // Initialize labels
            if (lblTotalSales != null)
                lblTotalSales.Text = "Общо продажби: 0.00 лв.";
            if (lblTotalQuantity != null)
                lblTotalQuantity.Text = "Общо количество: 0 бр.";
            if (lblAverageSale != null)
                lblAverageSale.Text = "Средна продажба: 0.00 лв.";
        }

        private void LoadReports()
        {
            try
            {
                var fromDate = dtpFrom?.Value ?? new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                var toDate = dtpTo?.Value ?? DateTime.Now;
                
                // Get sales for the period
                var sales = sellController.GetAll()
                    .Where(s => s.DateOfSale >= fromDate && s.DateOfSale <= toDate.AddDays(1).AddSeconds(-1))
                    .ToList();

                UpdateStatistics(sales);
                UpdateTopProducts(sales);
                UpdateSalesByType(sales);
                UpdatePeriodInfo(fromDate, toDate, sales.Count);
                
                // Auto-generate report in RichTextBox
                GenerateDetailedReport(sales, fromDate, toDate);
            }
            catch (Exception ex)
            {
                if (richTextBoxReport != null)
                {
                    richTextBoxReport.Text = $"ГРЕШКА ПРИ ЗАРЕЖДАНЕ НА ОТЧЕТИ\n\n{ex.Message}";
                }
                SetErrorState();
            }
        }

        private void UpdateStatistics(List<Sell> sales)
        {
            try
            {
                decimal totalSales = sales.Sum(s => s.TotalPrice);
                int totalQuantity = sales.Sum(s => s.Quantity);
                decimal averageSale = sales.Any() ? sales.Average(s => s.TotalPrice) : 0;

                if (lblTotalSales != null)
                    lblTotalSales.Text = $"Общо продажби: {totalSales:F2} лв.";
                if (lblTotalQuantity != null)
                    lblTotalQuantity.Text = $"Общо количество: {totalQuantity} бр.";
                if (lblAverageSale != null)
                    lblAverageSale.Text = $"Средна продажба: {averageSale:F2} лв.";
            }
            catch (Exception)
            {
                if (lblTotalSales != null)
                    lblTotalSales.Text = "Общо продажби: Грешка";
                if (lblTotalQuantity != null)
                    lblTotalQuantity.Text = "Общо количество: Грешка";
                if (lblAverageSale != null)
                    lblAverageSale.Text = "Средна продажба: Грешка";
            }
        }

        private void UpdateTopProducts(List<Sell> sales)
        {
            try
            {
                if (lbTopProducts == null) return;

                lbTopProducts.Items.Clear();

                if (!sales.Any())
                {
                    lbTopProducts.Items.Add("Няма данни за периода");
                    return;
                }

                var topProducts = sales
                    .GroupBy(s => new { 
                        ProductNumber = s.ProductNumber,
                        ProductName = s.Products?.ProductName ?? "Неизвестен продукт"
                    })
                    .Select(g => new { 
                        ProductName = g.Key.ProductName,
                        Total = g.Sum(s => s.TotalPrice),
                        Quantity = g.Sum(s => s.Quantity)
                    })
                    .OrderByDescending(x => x.Total)
                    .Take(10)
                    .ToList();

                foreach (var product in topProducts)
                {
                    lbTopProducts.Items.Add($"{product.ProductName}: {product.Total:F2} лв. ({product.Quantity} бр.)");
                }
            }
            catch (Exception)
            {
                if (lbTopProducts != null)
                {
                    lbTopProducts.Items.Clear();
                    lbTopProducts.Items.Add("Грешка при зареждане");
                }
            }
        }

        private void UpdateSalesByType(List<Sell> sales)
        {
            try
            {
                if (lbSalesByType == null) return;

                lbSalesByType.Items.Clear();

                if (!sales.Any())
                {
                    lbSalesByType.Items.Add("Няма данни за периода");
                    return;
                }

                var salesByType = sales
                    .GroupBy(s => s.Products?.ProductTypeNumber ?? 0)
                    .Select(g => new { 
                        TypeNumber = g.Key,
                        Total = g.Sum(s => s.TotalPrice),
                        Quantity = g.Sum(s => s.Quantity)
                    })
                    .OrderByDescending(x => x.Total)
                    .ToList();

                foreach (var type in salesByType)
                {
                    try
                    {
                        var productType = productTypeController.Get(type.TypeNumber);
                        var typeName = productType?.ProductTypeName ?? $"Тип {type.TypeNumber}";
                        lbSalesByType.Items.Add($"{typeName}: {type.Total:F2} лв. ({type.Quantity} бр.)");
                    }
                    catch
                    {
                        lbSalesByType.Items.Add($"Тип {type.TypeNumber}: {type.Total:F2} лв. ({type.Quantity} бр.)");
                    }
                }
            }
            catch (Exception)
            {
                if (lbSalesByType != null)
                {
                    lbSalesByType.Items.Clear();
                    lbSalesByType.Items.Add("Грешка при зареждане");
                }
            }
        }

        private void UpdatePeriodInfo(DateTime fromDate, DateTime toDate, int salesCount)
        {
            try
            {
                if (lblPeriod != null)
                    lblPeriod.Text = $"Период: {fromDate:dd/MM/yyyy} - {toDate:dd/MM/yyyy}";
                if (lblTotalSalesCount != null)
                    lblTotalSalesCount.Text = $"Брой продажби: {salesCount}";
            }
            catch (Exception)
            {
                if (lblPeriod != null)
                    lblPeriod.Text = "Период: Грешка";
                if (lblTotalSalesCount != null)
                    lblTotalSalesCount.Text = "Брой продажби: Грешка";
            }
        }

        private void SetErrorState()
        {
            if (lblTotalSales != null)
                lblTotalSales.Text = "Общо продажби: Грешка при зареждане";
            if (lblTotalQuantity != null)
                lblTotalQuantity.Text = "Общо количество: Грешка при зареждане";
            if (lblAverageSale != null)
                lblAverageSale.Text = "Средна продажба: Грешка при зареждане";
            
            if (lbTopProducts != null)
            {
                lbTopProducts.Items.Clear();
                lbTopProducts.Items.Add("Грешка при зареждане на данни");
            }
            
            if (lbSalesByType != null)
            {
                lbSalesByType.Items.Clear();
                lbSalesByType.Items.Add("Грешка при зареждане на данни");
            }
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            try
            {
                var fromDate = dtpFrom?.Value ?? new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                var toDate = dtpTo?.Value ?? DateTime.Now;
                
                var sales = sellController.GetAll()
                    .Where(s => s.DateOfSale >= fromDate && s.DateOfSale <= toDate.AddDays(1).AddSeconds(-1))
                    .ToList();

                GenerateDetailedReport(sales, fromDate, toDate);
            }
            catch (Exception ex)
            {
                if (richTextBoxReport != null)
                {
                    richTextBoxReport.Text = $"ГРЕШКА ПРИ ГЕНЕРИРАНЕ НА ОТЧЕТ\n\n{ex.Message}";
                }
            }
        }

        private void GenerateDetailedReport(List<Sell> sales, DateTime fromDate, DateTime toDate)
        {
            try
            {
                var reportText = $"ДЕТАЙЛЕН ОТЧЕТ ЗА ПРОДАЖБИ\n";
                reportText += $"Период: {fromDate:dd/MM/yyyy} - {toDate:dd/MM/yyyy}\n";
                reportText += $"Генериран на: {DateTime.Now:dd/MM/yyyy HH:mm}\n";
                reportText += new string('=', 50) + "\n\n";

                // Summary
                decimal totalSales = sales.Sum(s => s.TotalPrice);
                int totalQuantity = sales.Sum(s => s.Quantity);
                decimal averageSale = sales.Any() ? sales.Average(s => s.TotalPrice) : 0;

                reportText += "ОБОБЩЕНИЕ:\n";
                reportText += new string('-', 20) + "\n";
                reportText += $"Общо продажби: {totalSales:F2} лв.\n";
                reportText += $"Общо количество: {totalQuantity} бр.\n";
                reportText += $"Брой продажби: {sales.Count}\n";
                reportText += $"Средна продажба: {averageSale:F2} лв.\n\n";

                // Top products
                var topProducts = sales
                    .GroupBy(s => s.Products?.ProductName ?? "Неизвестен продукт")
                    .Select(g => new { 
                        ProductName = g.Key,
                        Total = g.Sum(s => s.TotalPrice),
                        Quantity = g.Sum(s => s.Quantity)
                    })
                    .OrderByDescending(x => x.Total)
                    .Take(10)
                    .ToList();

                reportText += "ТОП 10 ПРОДУКТИ:\n";
                reportText += new string('-', 20) + "\n";
                foreach (var product in topProducts)
                {
                    reportText += $"{product.ProductName}: {product.Total:F2} лв. ({product.Quantity} бр.)\n";
                }

                reportText += "\n" + new string('-', 20) + "\n";
                reportText += "ДЕТАЙЛНИ ПРОДАЖБИ:\n";
                reportText += new string('-', 20) + "\n";
                
                foreach (var sale in sales.OrderByDescending(s => s.DateOfSale))
                {
                    reportText += $"{sale.DateOfSale:dd/MM/yyyy HH:mm} | {sale.Username} | Продукт: {sale.ProductNumber} | {sale.Quantity} бр. | {sale.TotalPrice:F2} лв.\n";
                }

                // Display report in RichTextBox
                if (richTextBoxReport != null)
                {
                    richTextBoxReport.Text = reportText;
                    richTextBoxReport.SelectionStart = 0;
                    richTextBoxReport.ScrollToCaret();
                }
            }
            catch (Exception ex)
            {
                if (richTextBoxReport != null)
                {
                    richTextBoxReport.Text = $"ГРЕШКА ПРИ ГЕНЕРИРАНЕ НА ДЕТАЙЛЕН ОТЧЕТ\n\n{ex.Message}";
                }
            }
        }

        private void btnExportReport_Click(object sender, EventArgs e)
            {
            try
            {
                if (string.IsNullOrEmpty(richTextBoxReport.Text))
                {
                    MessageBox.Show("Няма данни за експортиране. Моля първо генерирайте отчет.", 
                        "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Text files (*.txt)|*.txt";
                saveDialog.DefaultExt = "txt";
                saveDialog.FileName = $"Отчет_Продажби_{DateTime.Now:yyyyMMdd_HHmmss}.txt";
                saveDialog.Title = "Запазване на отчет";
                
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    System.IO.File.WriteAllText(saveDialog.FileName, richTextBoxReport.Text, System.Text.Encoding.UTF8);
                    MessageBox.Show($"Отчетът е експортиран успешно в:\n{saveDialog.FileName}", 
                        "Експорт завършен", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Грешка при експортиране: {ex.Message}", 
                    "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AutoGenerateReport()
        {
            try
            {
                // Auto-generate report on load
                LoadReports();
            }
            catch (Exception)
            {
                // Do nothing if auto-generation fails
            }
        }
    }
} 
