
namespace BijayBharatiCW
{
    partial class ReportForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.reportdataGridView = new System.Windows.Forms.DataGridView();
            this.customerTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adultsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.childrenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.sortHighToLowbutton = new System.Windows.Forms.Button();
            this.sortLowToHighbutton = new System.Windows.Forms.Button();
            this.defaultbutton = new System.Windows.Forms.Button();
            this.reporttabControl = new System.Windows.Forms.TabControl();
            this.byDaytabPage = new System.Windows.Forms.TabPage();
            this.byDaychart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.adultChildrentabPage = new System.Windows.Forms.TabPage();
            this.adultChildrenchart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.weeklyReporttabPage = new System.Windows.Forms.TabPage();
            this.weeklychart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.loadChartbutton = new System.Windows.Forms.Button();
            this.exportReportbutton = new System.Windows.Forms.Button();
            this.statspanel = new System.Windows.Forms.Panel();
            this.earningValuelabel = new System.Windows.Forms.Label();
            this.countValuelabel = new System.Windows.Forms.Label();
            this.earninglabel = new System.Windows.Forms.Label();
            this.lcountabel = new System.Windows.Forms.Label();
            this.refreshReportbutton = new System.Windows.Forms.Button();
            this.importFiletextBox = new System.Windows.Forms.TextBox();
            this.importFilebutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.reportdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportBindingSource)).BeginInit();
            this.reporttabControl.SuspendLayout();
            this.byDaytabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.byDaychart)).BeginInit();
            this.adultChildrentabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adultChildrenchart)).BeginInit();
            this.weeklyReporttabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weeklychart)).BeginInit();
            this.statspanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportdataGridView
            // 
            this.reportdataGridView.AllowUserToResizeColumns = false;
            this.reportdataGridView.AllowUserToResizeRows = false;
            this.reportdataGridView.AutoGenerateColumns = false;
            this.reportdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerTypeDataGridViewTextBoxColumn,
            this.ticketCategoryDataGridViewTextBoxColumn,
            this.ticketPriceDataGridViewTextBoxColumn,
            this.groupSizeDataGridViewTextBoxColumn,
            this.adultsDataGridViewTextBoxColumn,
            this.childrenDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.dayDataGridViewTextBoxColumn,
            this.entryDataGridViewTextBoxColumn,
            this.exitDataGridViewTextBoxColumn});
            this.reportdataGridView.DataSource = this.reportBindingSource;
            this.reportdataGridView.Location = new System.Drawing.Point(0, -1);
            this.reportdataGridView.Name = "reportdataGridView";
            this.reportdataGridView.Size = new System.Drawing.Size(1036, 174);
            this.reportdataGridView.TabIndex = 0;
            // 
            // customerTypeDataGridViewTextBoxColumn
            // 
            this.customerTypeDataGridViewTextBoxColumn.DataPropertyName = "Customer_Type";
            this.customerTypeDataGridViewTextBoxColumn.HeaderText = "Customer_Type";
            this.customerTypeDataGridViewTextBoxColumn.Name = "customerTypeDataGridViewTextBoxColumn";
            // 
            // ticketCategoryDataGridViewTextBoxColumn
            // 
            this.ticketCategoryDataGridViewTextBoxColumn.DataPropertyName = "Ticket_Category";
            this.ticketCategoryDataGridViewTextBoxColumn.HeaderText = "Ticket_Category";
            this.ticketCategoryDataGridViewTextBoxColumn.Name = "ticketCategoryDataGridViewTextBoxColumn";
            // 
            // ticketPriceDataGridViewTextBoxColumn
            // 
            this.ticketPriceDataGridViewTextBoxColumn.DataPropertyName = "Ticket_Price";
            this.ticketPriceDataGridViewTextBoxColumn.HeaderText = "Ticket_Price";
            this.ticketPriceDataGridViewTextBoxColumn.Name = "ticketPriceDataGridViewTextBoxColumn";
            // 
            // groupSizeDataGridViewTextBoxColumn
            // 
            this.groupSizeDataGridViewTextBoxColumn.DataPropertyName = "Group_Size";
            this.groupSizeDataGridViewTextBoxColumn.HeaderText = "Group_Size";
            this.groupSizeDataGridViewTextBoxColumn.Name = "groupSizeDataGridViewTextBoxColumn";
            // 
            // adultsDataGridViewTextBoxColumn
            // 
            this.adultsDataGridViewTextBoxColumn.DataPropertyName = "Adults";
            this.adultsDataGridViewTextBoxColumn.HeaderText = "Adults";
            this.adultsDataGridViewTextBoxColumn.Name = "adultsDataGridViewTextBoxColumn";
            // 
            // childrenDataGridViewTextBoxColumn
            // 
            this.childrenDataGridViewTextBoxColumn.DataPropertyName = "Children";
            this.childrenDataGridViewTextBoxColumn.HeaderText = "Children";
            this.childrenDataGridViewTextBoxColumn.Name = "childrenDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // dayDataGridViewTextBoxColumn
            // 
            this.dayDataGridViewTextBoxColumn.DataPropertyName = "Day";
            this.dayDataGridViewTextBoxColumn.HeaderText = "Day";
            this.dayDataGridViewTextBoxColumn.Name = "dayDataGridViewTextBoxColumn";
            // 
            // entryDataGridViewTextBoxColumn
            // 
            this.entryDataGridViewTextBoxColumn.DataPropertyName = "Entry";
            this.entryDataGridViewTextBoxColumn.HeaderText = "Entry";
            this.entryDataGridViewTextBoxColumn.Name = "entryDataGridViewTextBoxColumn";
            // 
            // exitDataGridViewTextBoxColumn
            // 
            this.exitDataGridViewTextBoxColumn.DataPropertyName = "Exit";
            this.exitDataGridViewTextBoxColumn.HeaderText = "Exit";
            this.exitDataGridViewTextBoxColumn.Name = "exitDataGridViewTextBoxColumn";
            // 
            // reportBindingSource
            // 
            this.reportBindingSource.DataSource = typeof(BijayBharatiCW.Report);
            // 
            // sortHighToLowbutton
            // 
            this.sortHighToLowbutton.Location = new System.Drawing.Point(258, 179);
            this.sortHighToLowbutton.Name = "sortHighToLowbutton";
            this.sortHighToLowbutton.Size = new System.Drawing.Size(108, 33);
            this.sortHighToLowbutton.TabIndex = 1;
            this.sortHighToLowbutton.Text = "Sort High to Low";
            this.sortHighToLowbutton.UseVisualStyleBackColor = true;
            this.sortHighToLowbutton.Click += new System.EventHandler(this.sortHighToLowbutton_Click);
            // 
            // sortLowToHighbutton
            // 
            this.sortLowToHighbutton.Location = new System.Drawing.Point(137, 179);
            this.sortLowToHighbutton.Name = "sortLowToHighbutton";
            this.sortLowToHighbutton.Size = new System.Drawing.Size(115, 33);
            this.sortLowToHighbutton.TabIndex = 2;
            this.sortLowToHighbutton.Text = "Sort Low to High";
            this.sortLowToHighbutton.UseVisualStyleBackColor = true;
            this.sortLowToHighbutton.Click += new System.EventHandler(this.sortLowToHighbutton_Click);
            // 
            // defaultbutton
            // 
            this.defaultbutton.Location = new System.Drawing.Point(16, 179);
            this.defaultbutton.Name = "defaultbutton";
            this.defaultbutton.Size = new System.Drawing.Size(115, 33);
            this.defaultbutton.TabIndex = 3;
            this.defaultbutton.Text = "Default";
            this.defaultbutton.UseVisualStyleBackColor = true;
            this.defaultbutton.Click += new System.EventHandler(this.defaultbutton_Click);
            // 
            // reporttabControl
            // 
            this.reporttabControl.Controls.Add(this.byDaytabPage);
            this.reporttabControl.Controls.Add(this.adultChildrentabPage);
            this.reporttabControl.Controls.Add(this.weeklyReporttabPage);
            this.reporttabControl.Location = new System.Drawing.Point(382, 179);
            this.reporttabControl.Name = "reporttabControl";
            this.reporttabControl.SelectedIndex = 0;
            this.reporttabControl.Size = new System.Drawing.Size(567, 259);
            this.reporttabControl.TabIndex = 4;
            // 
            // byDaytabPage
            // 
            this.byDaytabPage.Controls.Add(this.byDaychart);
            this.byDaytabPage.Location = new System.Drawing.Point(4, 22);
            this.byDaytabPage.Name = "byDaytabPage";
            this.byDaytabPage.Padding = new System.Windows.Forms.Padding(3);
            this.byDaytabPage.Size = new System.Drawing.Size(559, 233);
            this.byDaytabPage.TabIndex = 0;
            this.byDaytabPage.Text = "Earning by day";
            this.byDaytabPage.UseVisualStyleBackColor = true;
            // 
            // byDaychart
            // 
            chartArea1.Name = "ChartArea1";
            this.byDaychart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.byDaychart.Legends.Add(legend1);
            this.byDaychart.Location = new System.Drawing.Point(0, 0);
            this.byDaychart.Name = "byDaychart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Earning";
            this.byDaychart.Series.Add(series1);
            this.byDaychart.Size = new System.Drawing.Size(563, 237);
            this.byDaychart.TabIndex = 0;
            this.byDaychart.Text = "Earning by day";
            // 
            // adultChildrentabPage
            // 
            this.adultChildrentabPage.Controls.Add(this.adultChildrenchart);
            this.adultChildrentabPage.Location = new System.Drawing.Point(4, 22);
            this.adultChildrentabPage.Name = "adultChildrentabPage";
            this.adultChildrentabPage.Padding = new System.Windows.Forms.Padding(3);
            this.adultChildrentabPage.Size = new System.Drawing.Size(559, 233);
            this.adultChildrentabPage.TabIndex = 1;
            this.adultChildrentabPage.Text = "Adult:Children";
            this.adultChildrentabPage.UseVisualStyleBackColor = true;
            // 
            // adultChildrenchart
            // 
            chartArea2.Name = "ChartArea1";
            this.adultChildrenchart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.adultChildrenchart.Legends.Add(legend2);
            this.adultChildrenchart.Location = new System.Drawing.Point(0, 0);
            this.adultChildrenchart.Name = "adultChildrenchart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Visitors";
            this.adultChildrenchart.Series.Add(series2);
            this.adultChildrenchart.Size = new System.Drawing.Size(544, 244);
            this.adultChildrenchart.TabIndex = 0;
            this.adultChildrenchart.Text = "adultChildrenchart";
            // 
            // weeklyReporttabPage
            // 
            this.weeklyReporttabPage.Controls.Add(this.weeklychart);
            this.weeklyReporttabPage.Location = new System.Drawing.Point(4, 22);
            this.weeklyReporttabPage.Name = "weeklyReporttabPage";
            this.weeklyReporttabPage.Padding = new System.Windows.Forms.Padding(3);
            this.weeklyReporttabPage.Size = new System.Drawing.Size(559, 233);
            this.weeklyReporttabPage.TabIndex = 2;
            this.weeklyReporttabPage.Text = "Weekly Report";
            this.weeklyReporttabPage.UseVisualStyleBackColor = true;
            // 
            // weeklychart
            // 
            chartArea3.Name = "ChartArea1";
            this.weeklychart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.weeklychart.Legends.Add(legend3);
            this.weeklychart.Location = new System.Drawing.Point(0, -1);
            this.weeklychart.Name = "weeklychart";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "weeklyEarnings";
            this.weeklychart.Series.Add(series3);
            this.weeklychart.Size = new System.Drawing.Size(543, 234);
            this.weeklychart.TabIndex = 0;
            this.weeklychart.Text = "chart1";
            // 
            // loadChartbutton
            // 
            this.loadChartbutton.Location = new System.Drawing.Point(16, 401);
            this.loadChartbutton.Name = "loadChartbutton";
            this.loadChartbutton.Size = new System.Drawing.Size(115, 33);
            this.loadChartbutton.TabIndex = 5;
            this.loadChartbutton.Text = "Refresh Charts";
            this.loadChartbutton.UseVisualStyleBackColor = true;
            this.loadChartbutton.Click += new System.EventHandler(this.loadChartbutton_Click);
            // 
            // exportReportbutton
            // 
            this.exportReportbutton.Location = new System.Drawing.Point(16, 276);
            this.exportReportbutton.Name = "exportReportbutton";
            this.exportReportbutton.Size = new System.Drawing.Size(115, 33);
            this.exportReportbutton.TabIndex = 6;
            this.exportReportbutton.Text = "Export Report";
            this.exportReportbutton.UseVisualStyleBackColor = true;
            this.exportReportbutton.Click += new System.EventHandler(this.exportReportbutton_Click);
            // 
            // statspanel
            // 
            this.statspanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statspanel.Controls.Add(this.earningValuelabel);
            this.statspanel.Controls.Add(this.countValuelabel);
            this.statspanel.Controls.Add(this.earninglabel);
            this.statspanel.Controls.Add(this.lcountabel);
            this.statspanel.Location = new System.Drawing.Point(166, 294);
            this.statspanel.Name = "statspanel";
            this.statspanel.Size = new System.Drawing.Size(200, 140);
            this.statspanel.TabIndex = 7;
            // 
            // earningValuelabel
            // 
            this.earningValuelabel.AutoSize = true;
            this.earningValuelabel.Location = new System.Drawing.Point(103, 87);
            this.earningValuelabel.Name = "earningValuelabel";
            this.earningValuelabel.Size = new System.Drawing.Size(13, 13);
            this.earningValuelabel.TabIndex = 3;
            this.earningValuelabel.Text = "0";
            // 
            // countValuelabel
            // 
            this.countValuelabel.AutoSize = true;
            this.countValuelabel.Location = new System.Drawing.Point(103, 45);
            this.countValuelabel.Name = "countValuelabel";
            this.countValuelabel.Size = new System.Drawing.Size(13, 13);
            this.countValuelabel.TabIndex = 2;
            this.countValuelabel.Text = "0";
            // 
            // earninglabel
            // 
            this.earninglabel.AutoSize = true;
            this.earninglabel.Location = new System.Drawing.Point(20, 87);
            this.earninglabel.Name = "earninglabel";
            this.earninglabel.Size = new System.Drawing.Size(78, 13);
            this.earninglabel.TabIndex = 1;
            this.earninglabel.Text = "Total Earnings:";
            // 
            // lcountabel
            // 
            this.lcountabel.AutoSize = true;
            this.lcountabel.Location = new System.Drawing.Point(20, 45);
            this.lcountabel.Name = "lcountabel";
            this.lcountabel.Size = new System.Drawing.Size(77, 13);
            this.lcountabel.TabIndex = 0;
            this.lcountabel.Text = "Total Records:";
            // 
            // refreshReportbutton
            // 
            this.refreshReportbutton.Location = new System.Drawing.Point(16, 340);
            this.refreshReportbutton.Name = "refreshReportbutton";
            this.refreshReportbutton.Size = new System.Drawing.Size(115, 41);
            this.refreshReportbutton.TabIndex = 8;
            this.refreshReportbutton.Text = "Refresh Report/ Lateset File";
            this.refreshReportbutton.UseVisualStyleBackColor = true;
            this.refreshReportbutton.Click += new System.EventHandler(this.refreshReportbutton_Click);
            // 
            // importFiletextBox
            // 
            this.importFiletextBox.Location = new System.Drawing.Point(0, 233);
            this.importFiletextBox.Name = "importFiletextBox";
            this.importFiletextBox.Size = new System.Drawing.Size(239, 20);
            this.importFiletextBox.TabIndex = 9;
            // 
            // importFilebutton
            // 
            this.importFilebutton.Location = new System.Drawing.Point(258, 233);
            this.importFilebutton.Name = "importFilebutton";
            this.importFilebutton.Size = new System.Drawing.Size(108, 33);
            this.importFilebutton.TabIndex = 10;
            this.importFilebutton.Text = "Import File";
            this.importFilebutton.UseVisualStyleBackColor = true;
            this.importFilebutton.Click += new System.EventHandler(this.importFilebutton_Click);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1035, 450);
            this.Controls.Add(this.importFilebutton);
            this.Controls.Add(this.importFiletextBox);
            this.Controls.Add(this.refreshReportbutton);
            this.Controls.Add(this.statspanel);
            this.Controls.Add(this.exportReportbutton);
            this.Controls.Add(this.loadChartbutton);
            this.Controls.Add(this.reporttabControl);
            this.Controls.Add(this.defaultbutton);
            this.Controls.Add(this.sortLowToHighbutton);
            this.Controls.Add(this.sortHighToLowbutton);
            this.Controls.Add(this.reportdataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(1051, 489);
            this.MinimumSize = new System.Drawing.Size(1051, 489);
            this.Name = "ReportForm";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportForm";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportBindingSource)).EndInit();
            this.reporttabControl.ResumeLayout(false);
            this.byDaytabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.byDaychart)).EndInit();
            this.adultChildrentabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.adultChildrenchart)).EndInit();
            this.weeklyReporttabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.weeklychart)).EndInit();
            this.statspanel.ResumeLayout(false);
            this.statspanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView reportdataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adultsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn childrenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exitDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource reportBindingSource;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button sortHighToLowbutton;
        private System.Windows.Forms.Button sortLowToHighbutton;
        private System.Windows.Forms.Button defaultbutton;
        private System.Windows.Forms.TabControl reporttabControl;
        private System.Windows.Forms.TabPage byDaytabPage;
        private System.Windows.Forms.TabPage adultChildrentabPage;
        private System.Windows.Forms.DataVisualization.Charting.Chart byDaychart;
        private System.Windows.Forms.Button loadChartbutton;
        private System.Windows.Forms.DataVisualization.Charting.Chart adultChildrenchart;
        private System.Windows.Forms.Button exportReportbutton;
        private System.Windows.Forms.Panel statspanel;
        private System.Windows.Forms.Label earningValuelabel;
        private System.Windows.Forms.Label countValuelabel;
        private System.Windows.Forms.Label earninglabel;
        private System.Windows.Forms.Label lcountabel;
        private System.Windows.Forms.Button refreshReportbutton;
        private System.Windows.Forms.TextBox importFiletextBox;
        private System.Windows.Forms.Button importFilebutton;
        private System.Windows.Forms.TabPage weeklyReporttabPage;
        private System.Windows.Forms.DataVisualization.Charting.Chart weeklychart;
    }
}