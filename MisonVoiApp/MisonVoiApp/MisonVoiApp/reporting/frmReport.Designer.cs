
namespace MisonVoiApp.reporting
{
    partial class frmReport
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
            this.gunaResize1 = new Guna.UI.WinForms.GunaResize(this.components);
            this.gunaResizeControl1 = new Guna.UI.WinForms.GunaResizeControl();
            this.ReportV = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // gunaResize1
            // 
            this.gunaResize1.TargetForm = this;
            // 
            // gunaResizeControl1
            // 
            this.gunaResizeControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaResizeControl1.ForeColor = System.Drawing.Color.Black;
            this.gunaResizeControl1.ForeColorDepth = 255;
            this.gunaResizeControl1.Location = new System.Drawing.Point(0, 0);
            this.gunaResizeControl1.Name = "gunaResizeControl1";
            this.gunaResizeControl1.Size = new System.Drawing.Size(1187, 747);
            this.gunaResizeControl1.TabIndex = 2;
            this.gunaResizeControl1.TargetControl = null;
            // 
            // ReportV
            // 
            this.ReportV.ActiveViewIndex = -1;
            this.ReportV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReportV.Cursor = System.Windows.Forms.Cursors.Default;
            this.ReportV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReportV.Location = new System.Drawing.Point(0, 0);
            this.ReportV.Name = "ReportV";
            this.ReportV.Size = new System.Drawing.Size(1187, 747);
            this.ReportV.TabIndex = 3;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 747);
            this.Controls.Add(this.ReportV);
            this.Controls.Add(this.gunaResizeControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmReport";
            this.Text = "frmReport";
            this.Load += new System.EventHandler(this.frmReport_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaResize gunaResize1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer ReportV;
        private Guna.UI.WinForms.GunaResizeControl gunaResizeControl1;
    }
}