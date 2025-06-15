namespace GastroSoft
{
    partial class ReportsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExportReport = new System.Windows.Forms.Button();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lbReportData = new System.Windows.Forms.ListBox();
            this.richTextBoxReport = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExportReport);
            this.panel1.Controls.Add(this.btnGenerateReport);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 60);
            this.panel1.TabIndex = 0;
            // 
            // btnExportReport
            // 
            this.btnExportReport.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnExportReport.Location = new System.Drawing.Point(199, 17);
            this.btnExportReport.Name = "btnExportReport";
            this.btnExportReport.Size = new System.Drawing.Size(100, 26);
            this.btnExportReport.TabIndex = 3;
            this.btnExportReport.Text = "Експорт";
            this.btnExportReport.UseVisualStyleBackColor = true;
            this.btnExportReport.Click += new System.EventHandler(this.btnExportReport_Click);
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnGenerateReport.Location = new System.Drawing.Point(3, 17);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(190, 26);
            this.btnGenerateReport.TabIndex = 2;
            this.btnGenerateReport.Text = "Генерирай отчет";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 60);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lbReportData);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.richTextBoxReport);
            this.splitContainer1.Size = new System.Drawing.Size(750, 520);
            this.splitContainer1.SplitterDistance = 310;
            this.splitContainer1.TabIndex = 2;
            // 
            // lbReportData
            // 
            this.lbReportData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbReportData.Font = new System.Drawing.Font("Calibri", 10F);
            this.lbReportData.FormattingEnabled = true;
            this.lbReportData.ItemHeight = 21;
            this.lbReportData.Location = new System.Drawing.Point(0, 0);
            this.lbReportData.Name = "lbReportData";
            this.lbReportData.Size = new System.Drawing.Size(750, 310);
            this.lbReportData.TabIndex = 0;
            // 
            // richTextBoxReport
            // 
            this.richTextBoxReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxReport.Font = new System.Drawing.Font("Calibri", 10F);
            this.richTextBoxReport.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxReport.Name = "richTextBoxReport";
            this.richTextBoxReport.ReadOnly = true;
            this.richTextBoxReport.Size = new System.Drawing.Size(750, 206);
            this.richTextBoxReport.TabIndex = 1;
            this.richTextBoxReport.Text = "Изберете тип отчет и кликнете \"Генерирай отчет\" за да видите резултатите.";
            // 
            // ReportsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Name = "ReportsControl";
            this.Size = new System.Drawing.Size(750, 580);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.Button btnExportReport;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox lbReportData;
        private System.Windows.Forms.RichTextBox richTextBoxReport;
    }
} 
