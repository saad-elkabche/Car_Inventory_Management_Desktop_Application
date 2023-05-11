
namespace MisonVoiApp.Forms
{
    partial class Achat
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Achat));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridVentes = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClient = new FontAwesome.Sharp.IconButton();
            this.btnContrat = new FontAwesome.Sharp.IconButton();
            this.btnDetail = new FontAwesome.Sharp.IconButton();
            this.btnTotalRap = new FontAwesome.Sharp.IconButton();
            this.btnQuantRap = new FontAwesome.Sharp.IconButton();
            this.searchPic = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dataGridVentes);
            this.panel1.Location = new System.Drawing.Point(136, 376);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1164, 368);
            this.panel1.TabIndex = 10;
            // 
            // dataGridVentes
            // 
            this.dataGridVentes.AllowUserToAddRows = false;
            this.dataGridVentes.AllowUserToDeleteRows = false;
            this.dataGridVentes.AllowUserToResizeColumns = false;
            this.dataGridVentes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridVentes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridVentes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridVentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridVentes.BackgroundColor = System.Drawing.Color.White;
            this.dataGridVentes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridVentes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dataGridVentes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridVentes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridVentes.ColumnHeadersHeight = 60;
            this.dataGridVentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridVentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridVentes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridVentes.DoubleBuffered = true;
            this.dataGridVentes.EnableHeadersVisualStyles = false;
            this.dataGridVentes.GridColor = System.Drawing.Color.White;
            this.dataGridVentes.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(167)))));
            this.dataGridVentes.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridVentes.Location = new System.Drawing.Point(0, 0);
            this.dataGridVentes.MultiSelect = false;
            this.dataGridVentes.Name = "dataGridVentes";
            this.dataGridVentes.ReadOnly = true;
            this.dataGridVentes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridVentes.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridVentes.RowHeadersVisible = false;
            this.dataGridVentes.RowHeadersWidth = 51;
            this.dataGridVentes.RowTemplate.Height = 60;
            this.dataGridVentes.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridVentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridVentes.Size = new System.Drawing.Size(1164, 368);
            this.dataGridVentes.TabIndex = 0;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "idCar";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "CIN client";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "date de vente";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Prix de vente";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Nbre jour Garantis";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "type de vente";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // btnClient
            // 
            this.btnClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClient.BackColor = System.Drawing.Color.Black;
            this.btnClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClient.ForeColor = System.Drawing.Color.White;
            this.btnClient.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.btnClient.IconColor = System.Drawing.Color.White;
            this.btnClient.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClient.IconSize = 38;
            this.btnClient.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClient.Location = new System.Drawing.Point(1194, 175);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(221, 60);
            this.btnClient.TabIndex = 60;
            this.btnClient.Text = "Client";
            this.btnClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClient.UseVisualStyleBackColor = false;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // btnContrat
            // 
            this.btnContrat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnContrat.BackColor = System.Drawing.Color.Black;
            this.btnContrat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContrat.ForeColor = System.Drawing.Color.White;
            this.btnContrat.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.btnContrat.IconColor = System.Drawing.Color.White;
            this.btnContrat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnContrat.IconSize = 35;
            this.btnContrat.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnContrat.Location = new System.Drawing.Point(1194, 31);
            this.btnContrat.Name = "btnContrat";
            this.btnContrat.Size = new System.Drawing.Size(221, 60);
            this.btnContrat.TabIndex = 59;
            this.btnContrat.Text = "Contrat";
            this.btnContrat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnContrat.UseVisualStyleBackColor = false;
            this.btnContrat.Click += new System.EventHandler(this.btnContrat_Click);
            // 
            // btnDetail
            // 
            this.btnDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetail.BackColor = System.Drawing.Color.Black;
            this.btnDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetail.ForeColor = System.Drawing.Color.White;
            this.btnDetail.IconChar = FontAwesome.Sharp.IconChar.Car;
            this.btnDetail.IconColor = System.Drawing.Color.White;
            this.btnDetail.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDetail.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDetail.Location = new System.Drawing.Point(1194, 103);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(221, 60);
            this.btnDetail.TabIndex = 58;
            this.btnDetail.Text = "détaillés";
            this.btnDetail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDetail.UseVisualStyleBackColor = false;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // btnTotalRap
            // 
            this.btnTotalRap.BackColor = System.Drawing.Color.Black;
            this.btnTotalRap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalRap.ForeColor = System.Drawing.Color.White;
            this.btnTotalRap.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.btnTotalRap.IconColor = System.Drawing.Color.White;
            this.btnTotalRap.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTotalRap.IconSize = 30;
            this.btnTotalRap.Location = new System.Drawing.Point(12, 48);
            this.btnTotalRap.Name = "btnTotalRap";
            this.btnTotalRap.Size = new System.Drawing.Size(297, 64);
            this.btnTotalRap.TabIndex = 60;
            this.btnTotalRap.Text = "Rapport des vents (Cash)";
            this.btnTotalRap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTotalRap.UseVisualStyleBackColor = false;
            this.btnTotalRap.Click += new System.EventHandler(this.btnTotalRap_Click);
            // 
            // btnQuantRap
            // 
            this.btnQuantRap.BackColor = System.Drawing.Color.Black;
            this.btnQuantRap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuantRap.ForeColor = System.Drawing.Color.White;
            this.btnQuantRap.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.btnQuantRap.IconColor = System.Drawing.Color.White;
            this.btnQuantRap.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQuantRap.IconSize = 30;
            this.btnQuantRap.Location = new System.Drawing.Point(12, 125);
            this.btnQuantRap.Name = "btnQuantRap";
            this.btnQuantRap.Size = new System.Drawing.Size(297, 67);
            this.btnQuantRap.TabIndex = 61;
            this.btnQuantRap.Text = "Rapport des vents (Dettes)";
            this.btnQuantRap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuantRap.UseVisualStyleBackColor = false;
            this.btnQuantRap.Click += new System.EventHandler(this.btnQuantRap_Click);
            // 
            // searchPic
            // 
            this.searchPic.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchPic.BackColor = System.Drawing.Color.Transparent;
            this.searchPic.BaseColor = System.Drawing.Color.White;
            this.searchPic.BorderColor = System.Drawing.Color.Silver;
            this.searchPic.CustomFormat = null;
            this.searchPic.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.searchPic.FocusedColor = System.Drawing.Color.Teal;
            this.searchPic.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchPic.ForeColor = System.Drawing.Color.Black;
            this.searchPic.Location = new System.Drawing.Point(559, 316);
            this.searchPic.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.searchPic.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.searchPic.Name = "searchPic";
            this.searchPic.OnHoverBaseColor = System.Drawing.Color.White;
            this.searchPic.OnHoverBorderColor = System.Drawing.Color.Teal;
            this.searchPic.OnHoverForeColor = System.Drawing.Color.Teal;
            this.searchPic.OnPressedColor = System.Drawing.Color.Black;
            this.searchPic.Radius = 10;
            this.searchPic.Size = new System.Drawing.Size(289, 44);
            this.searchPic.TabIndex = 61;
            this.searchPic.Text = "January 31, 2022";
            this.searchPic.Value = new System.DateTime(2022, 1, 31, 15, 33, 59, 769);
            this.searchPic.ValueChanged += new System.EventHandler(this.gunaDateTimePicker5_ValueChanged);
            // 
            // gunaButton1
            // 
            this.gunaButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(167)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(1140, 318);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.Teal;
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 10;
            this.gunaButton1.Size = new System.Drawing.Size(160, 42);
            this.gunaButton1.TabIndex = 63;
            this.gunaButton1.Text = "Tous";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 40;
            this.iconPictureBox1.Location = new System.Drawing.Point(491, 320);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(44, 40);
            this.iconPictureBox1.TabIndex = 65;
            this.iconPictureBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(464, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(674, 288);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            // 
            // Achat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1431, 744);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnTotalRap);
            this.Controls.Add(this.btnQuantRap);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.searchPic);
            this.Controls.Add(this.btnClient);
            this.Controls.Add(this.btnContrat);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Achat";
            this.Text = "Achat";
            this.Load += new System.EventHandler(this.Achat_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public Bunifu.Framework.UI.BunifuCustomDataGrid dataGridVentes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private FontAwesome.Sharp.IconButton btnClient;
        private FontAwesome.Sharp.IconButton btnContrat;
        private FontAwesome.Sharp.IconButton btnDetail;
        private FontAwesome.Sharp.IconButton btnTotalRap;
        private FontAwesome.Sharp.IconButton btnQuantRap;
        private Guna.UI.WinForms.GunaDateTimePicker searchPic;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}