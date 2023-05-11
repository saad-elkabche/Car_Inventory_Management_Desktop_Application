
namespace MisonVoiApp.Forms
{
    partial class homaPage
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chCash = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chDette = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartComparison = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtchiff = new Bunifu.Framework.UI.BunifuMetroTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.chCash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chDette)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartComparison)).BeginInit();
            this.SuspendLayout();
            // 
            // chCash
            // 
            this.chCash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chCash.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chCash.Legends.Add(legend1);
            this.chCash.Location = new System.Drawing.Point(852, 342);
            this.chCash.Name = "chCash";
            this.chCash.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.Name = "cash";
            this.chCash.Series.Add(series1);
            this.chCash.Size = new System.Drawing.Size(567, 390);
            this.chCash.TabIndex = 0;
            this.chCash.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "le total d\'achat cash du client";
            this.chCash.Titles.Add(title1);
            // 
            // chDette
            // 
            this.chDette.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            chartArea2.Name = "ChartArea1";
            this.chDette.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chDette.Legends.Add(legend2);
            this.chDette.Location = new System.Drawing.Point(1, 354);
            this.chDette.Name = "chDette";
            this.chDette.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.Legend = "Legend1";
            series2.Name = "dette";
            this.chDette.Series.Add(series2);
            this.chDette.Size = new System.Drawing.Size(559, 406);
            this.chDette.TabIndex = 1;
            this.chDette.Text = "chart2";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Title1";
            title2.Text = "le total d\'achat avec Loyers du client";
            this.chDette.Titles.Add(title2);
            // 
            // chartComparison
            // 
            this.chartComparison.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.Name = "ChartArea1";
            this.chartComparison.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartComparison.Legends.Add(legend3);
            this.chartComparison.Location = new System.Drawing.Point(438, -11);
            this.chartComparison.Name = "chartComparison";
            this.chartComparison.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "compar";
            this.chartComparison.Series.Add(series3);
            this.chartComparison.Size = new System.Drawing.Size(534, 347);
            this.chartComparison.TabIndex = 2;
            this.chartComparison.Text = "chart3";
            title3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.Name = "Title1";
            title3.Text = "comparaison entre achat cash et achat avec loyers";
            this.chartComparison.Titles.Add(title3);
            // 
            // txtchiff
            // 
            this.txtchiff.BorderColorFocused = System.Drawing.Color.Teal;
            this.txtchiff.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtchiff.BorderColorMouseHover = System.Drawing.Color.Teal;
            this.txtchiff.BorderThickness = 3;
            this.txtchiff.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtchiff.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtchiff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtchiff.isPassword = false;
            this.txtchiff.Location = new System.Drawing.Point(66, 992);
            this.txtchiff.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtchiff.Name = "txtchiff";
            this.txtchiff.Size = new System.Drawing.Size(518, 169);
            this.txtchiff.TabIndex = 3;
            this.txtchiff.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // homaPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1431, 744);
            this.Controls.Add(this.txtchiff);
            this.Controls.Add(this.chartComparison);
            this.Controls.Add(this.chDette);
            this.Controls.Add(this.chCash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "homaPage";
            this.Text = "homaPage";
            this.Load += new System.EventHandler(this.homaPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chCash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chDette)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartComparison)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chCash;
        private System.Windows.Forms.DataVisualization.Charting.Chart chDette;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartComparison;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtchiff;
    }
}