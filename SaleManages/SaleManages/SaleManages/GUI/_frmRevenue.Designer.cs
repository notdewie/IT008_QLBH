namespace SaleManages.GUI
{
    partial class _frmRevenue
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.ChartBDC = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.ChartBDC)).BeginInit();
            this.SuspendLayout();
            // 
            // ChartBDC
            // 
            chartArea1.Name = "ChartArea1";
            this.ChartBDC.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChartBDC.Legends.Add(legend1);
            this.ChartBDC.Location = new System.Drawing.Point(0, 2);
            this.ChartBDC.Name = "ChartBDC";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.LegendText = "Doanh Số Tháng (trVNĐ)";
            series1.Name = "ChartBDC";
            this.ChartBDC.Series.Add(series1);
            this.ChartBDC.Size = new System.Drawing.Size(800, 507);
            this.ChartBDC.TabIndex = 0;
            this.ChartBDC.Text = "chart1";
            title1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.DarkRed;
            title1.Name = "Title1";
            title1.Text = "Biểu đồ doanh thu";
            this.ChartBDC.Titles.Add(title1);
            // 
            // _frmRevenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 508);
            this.Controls.Add(this.ChartBDC);
            this.Name = "_frmRevenue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doanh Thu";
            this.Load += new System.EventHandler(this._frmRevenue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChartBDC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ChartBDC;
    }
}