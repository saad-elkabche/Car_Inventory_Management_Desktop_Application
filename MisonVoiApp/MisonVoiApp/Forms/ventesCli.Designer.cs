
namespace MisonVoiApp.Forms
{
    partial class ventesCli
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridVentes = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDetail = new FontAwesome.Sharp.IconButton();
            this.labaleClose = new System.Windows.Forms.Label();
            this.btnContrat = new FontAwesome.Sharp.IconButton();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVentes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridVentes
            // 
            this.dataGridVentes.AllowUserToAddRows = false;
            this.dataGridVentes.AllowUserToDeleteRows = false;
            this.dataGridVentes.AllowUserToResizeColumns = false;
            this.dataGridVentes.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            this.dataGridVentes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridVentes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridVentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridVentes.BackgroundColor = System.Drawing.Color.White;
            this.dataGridVentes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridVentes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dataGridVentes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridVentes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridVentes.ColumnHeadersHeight = 60;
            this.dataGridVentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridVentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridVentes.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridVentes.DoubleBuffered = true;
            this.dataGridVentes.EnableHeadersVisualStyles = false;
            this.dataGridVentes.GridColor = System.Drawing.Color.White;
            this.dataGridVentes.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(167)))));
            this.dataGridVentes.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridVentes.Location = new System.Drawing.Point(88, 280);
            this.dataGridVentes.MultiSelect = false;
            this.dataGridVentes.Name = "dataGridVentes";
            this.dataGridVentes.ReadOnly = true;
            this.dataGridVentes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridVentes.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridVentes.RowHeadersVisible = false;
            this.dataGridVentes.RowHeadersWidth = 51;
            this.dataGridVentes.RowTemplate.Height = 60;
            this.dataGridVentes.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridVentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridVentes.Size = new System.Drawing.Size(734, 389);
            this.dataGridVentes.TabIndex = 1;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "idVoi";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "date de vente";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "prix de vente";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "nb Jour garantis";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "type de vente";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // btnDetail
            // 
            this.btnDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetail.BackColor = System.Drawing.Color.Black;
            this.btnDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetail.ForeColor = System.Drawing.Color.White;
            this.btnDetail.IconChar = FontAwesome.Sharp.IconChar.Car;
            this.btnDetail.IconColor = System.Drawing.Color.White;
            this.btnDetail.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDetail.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDetail.Location = new System.Drawing.Point(353, 168);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(191, 54);
            this.btnDetail.TabIndex = 53;
            this.btnDetail.Text = "détaillés";
            this.btnDetail.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDetail.UseVisualStyleBackColor = false;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // labaleClose
            // 
            this.labaleClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labaleClose.AutoSize = true;
            this.labaleClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F, System.Drawing.FontStyle.Bold);
            this.labaleClose.ForeColor = System.Drawing.Color.Gray;
            this.labaleClose.Location = new System.Drawing.Point(880, 20);
            this.labaleClose.Name = "labaleClose";
            this.labaleClose.Size = new System.Drawing.Size(40, 38);
            this.labaleClose.TabIndex = 52;
            this.labaleClose.Text = "X";
            this.labaleClose.Click += new System.EventHandler(this.labaleClose_Click);
            this.labaleClose.MouseLeave += new System.EventHandler(this.labaleClose_MouseLeave);
            this.labaleClose.MouseHover += new System.EventHandler(this.labaleClose_MouseHover);
            // 
            // btnContrat
            // 
            this.btnContrat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnContrat.BackColor = System.Drawing.Color.Black;
            this.btnContrat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContrat.ForeColor = System.Drawing.Color.White;
            this.btnContrat.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.btnContrat.IconColor = System.Drawing.Color.White;
            this.btnContrat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnContrat.IconSize = 35;
            this.btnContrat.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnContrat.Location = new System.Drawing.Point(353, 104);
            this.btnContrat.Name = "btnContrat";
            this.btnContrat.Size = new System.Drawing.Size(191, 54);
            this.btnContrat.TabIndex = 54;
            this.btnContrat.Text = "Contrat";
            this.btnContrat.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnContrat.UseVisualStyleBackColor = false;
            this.btnContrat.Click += new System.EventHandler(this.btnContrat_Click);
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this;
            // 
            // ventesCli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(945, 670);
            this.Controls.Add(this.btnContrat);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.labaleClose);
            this.Controls.Add(this.dataGridVentes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ventesCli";
            this.Text = "ventesCli";
            this.Load += new System.EventHandler(this.ventesCli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVentes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGridVentes;
        private FontAwesome.Sharp.IconButton btnDetail;
        private System.Windows.Forms.Label labaleClose;
        private FontAwesome.Sharp.IconButton btnContrat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
    }
}