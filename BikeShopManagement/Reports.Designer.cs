namespace BikeShopManagement
{
    partial class Reports
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataVisualization.Charting.Chart mostSoldChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart mostProfitableChart;

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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.mostSoldChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.mostProfitableChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnExit1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mostSoldChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostProfitableChart)).BeginInit();
            this.SuspendLayout();
            // 
            // mostSoldChart
            // 
            this.mostSoldChart.BackColor = System.Drawing.Color.LightGreen;
            this.mostSoldChart.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;
            this.mostSoldChart.BorderlineColor = System.Drawing.Color.Transparent;
            this.mostSoldChart.BorderSkin.BackColor = System.Drawing.Color.SeaGreen;
            this.mostSoldChart.BorderSkin.BorderColor = System.Drawing.Color.SeaGreen;
            this.mostSoldChart.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            this.mostSoldChart.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Raised;
            chartArea1.Name = "ChartArea1";
            this.mostSoldChart.ChartAreas.Add(chartArea1);
            this.mostSoldChart.Location = new System.Drawing.Point(28, 43);
            this.mostSoldChart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mostSoldChart.Name = "mostSoldChart";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.mostSoldChart.Series.Add(series1);
            this.mostSoldChart.Size = new System.Drawing.Size(735, 189);
            this.mostSoldChart.TabIndex = 0;
            this.mostSoldChart.Text = "Most Sold Products";
            // 
            // mostProfitableChart
            // 
            this.mostProfitableChart.BackColor = System.Drawing.Color.LightGreen;
            this.mostProfitableChart.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            this.mostProfitableChart.BorderlineColor = System.Drawing.Color.Transparent;
            this.mostProfitableChart.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            this.mostProfitableChart.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Raised;
            chartArea2.Name = "ChartArea2";
            this.mostProfitableChart.ChartAreas.Add(chartArea2);
            this.mostProfitableChart.Location = new System.Drawing.Point(28, 236);
            this.mostProfitableChart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mostProfitableChart.Name = "mostProfitableChart";
            series2.ChartArea = "ChartArea2";
            series2.Name = "Series2";
            this.mostProfitableChart.Series.Add(series2);
            this.mostProfitableChart.Size = new System.Drawing.Size(735, 203);
            this.mostProfitableChart.TabIndex = 1;
            this.mostProfitableChart.Text = "Most Profitable Products";
            this.mostProfitableChart.Click += new System.EventHandler(this.mostProfitableChart_Click);
            // 
            // btnExit1
            // 
            this.btnExit1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit1.Location = new System.Drawing.Point(761, 0);
            this.btnExit1.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit1.Name = "btnExit1";
            this.btnExit1.Size = new System.Drawing.Size(39, 28);
            this.btnExit1.TabIndex = 0;
            this.btnExit1.Text = "X";
            this.btnExit1.UseVisualStyleBackColor = true;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnExit1);
            this.Controls.Add(this.mostProfitableChart);
            this.Controls.Add(this.mostSoldChart);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Reports";
            this.Size = new System.Drawing.Size(800, 450);
            ((System.ComponentModel.ISupportInitialize)(this.mostSoldChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostProfitableChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit1;
    }
}
