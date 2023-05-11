
namespace MisonVoiApp.Forms
{
    partial class employees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(employees));
            this.dataGridEmployees = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddEmp = new FontAwesome.Sharp.IconButton();
            this.btnDetailEmp = new FontAwesome.Sharp.IconButton();
            this.btnDeleteEmp = new FontAwesome.Sharp.IconButton();
            this.btnEditEmp = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.txtSearch = new Guna.UI.WinForms.GunaTextBox();
            this.Maintenance = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridEmployees
            // 
            this.dataGridEmployees.AllowUserToAddRows = false;
            this.dataGridEmployees.AllowUserToDeleteRows = false;
            this.dataGridEmployees.AllowUserToResizeColumns = false;
            this.dataGridEmployees.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridEmployees.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridEmployees.BackgroundColor = System.Drawing.Color.White;
            this.dataGridEmployees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridEmployees.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dataGridEmployees.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridEmployees.ColumnHeadersHeight = 60;
            this.dataGridEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridEmployees.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridEmployees.DoubleBuffered = true;
            this.dataGridEmployees.EnableHeadersVisualStyles = false;
            this.dataGridEmployees.GridColor = System.Drawing.Color.White;
            this.dataGridEmployees.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(167)))));
            this.dataGridEmployees.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridEmployees.Location = new System.Drawing.Point(0, 0);
            this.dataGridEmployees.MultiSelect = false;
            this.dataGridEmployees.Name = "dataGridEmployees";
            this.dataGridEmployees.ReadOnly = true;
            this.dataGridEmployees.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridEmployees.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridEmployees.RowHeadersVisible = false;
            this.dataGridEmployees.RowHeadersWidth = 51;
            this.dataGridEmployees.RowTemplate.Height = 60;
            this.dataGridEmployees.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridEmployees.Size = new System.Drawing.Size(805, 411);
            this.dataGridEmployees.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "idEmp";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nom-Prenom";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Adresse";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "date Naissance";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // btnAddEmp
            // 
            this.btnAddEmp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(111)))));
            this.btnAddEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmp.ForeColor = System.Drawing.Color.White;
            this.btnAddEmp.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnAddEmp.IconColor = System.Drawing.Color.White;
            this.btnAddEmp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddEmp.IconSize = 35;
            this.btnAddEmp.Location = new System.Drawing.Point(1175, 12);
            this.btnAddEmp.Name = "btnAddEmp";
            this.btnAddEmp.Size = new System.Drawing.Size(221, 60);
            this.btnAddEmp.TabIndex = 9;
            this.btnAddEmp.Text = "Ajouter Employee";
            this.btnAddEmp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddEmp.UseVisualStyleBackColor = false;
            this.btnAddEmp.Click += new System.EventHandler(this.btnAddEmp_Click);
            this.btnAddEmp.MouseLeave += new System.EventHandler(this.btnAddEmp_MouseLeave);
            this.btnAddEmp.MouseHover += new System.EventHandler(this.btnAddEmp_MouseHover);
            // 
            // btnDetailEmp
            // 
            this.btnDetailEmp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetailEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnDetailEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetailEmp.ForeColor = System.Drawing.Color.White;
            this.btnDetailEmp.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            this.btnDetailEmp.IconColor = System.Drawing.Color.White;
            this.btnDetailEmp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDetailEmp.IconSize = 30;
            this.btnDetailEmp.Location = new System.Drawing.Point(1175, 211);
            this.btnDetailEmp.Name = "btnDetailEmp";
            this.btnDetailEmp.Size = new System.Drawing.Size(221, 60);
            this.btnDetailEmp.TabIndex = 8;
            this.btnDetailEmp.Text = "Detailles";
            this.btnDetailEmp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDetailEmp.UseVisualStyleBackColor = false;
            this.btnDetailEmp.Click += new System.EventHandler(this.btnDetailEmp_Click);
            this.btnDetailEmp.MouseLeave += new System.EventHandler(this.btnAddEmp_MouseLeave);
            this.btnDetailEmp.MouseHover += new System.EventHandler(this.btnAddEmp_MouseHover);
            // 
            // btnDeleteEmp
            // 
            this.btnDeleteEmp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(210)))), ((int)(((byte)(216)))));
            this.btnDeleteEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteEmp.ForeColor = System.Drawing.Color.White;
            this.btnDeleteEmp.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDeleteEmp.IconColor = System.Drawing.Color.White;
            this.btnDeleteEmp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeleteEmp.IconSize = 28;
            this.btnDeleteEmp.Location = new System.Drawing.Point(1175, 144);
            this.btnDeleteEmp.Name = "btnDeleteEmp";
            this.btnDeleteEmp.Size = new System.Drawing.Size(221, 61);
            this.btnDeleteEmp.TabIndex = 7;
            this.btnDeleteEmp.Text = "Suprimer";
            this.btnDeleteEmp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteEmp.UseVisualStyleBackColor = false;
            this.btnDeleteEmp.Click += new System.EventHandler(this.btnDeleteEmp_Click);
            this.btnDeleteEmp.MouseLeave += new System.EventHandler(this.btnAddEmp_MouseLeave);
            this.btnDeleteEmp.MouseHover += new System.EventHandler(this.btnAddEmp_MouseHover);
            // 
            // btnEditEmp
            // 
            this.btnEditEmp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(167)))));
            this.btnEditEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditEmp.ForeColor = System.Drawing.Color.White;
            this.btnEditEmp.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.btnEditEmp.IconColor = System.Drawing.Color.White;
            this.btnEditEmp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditEmp.IconSize = 30;
            this.btnEditEmp.Location = new System.Drawing.Point(1175, 78);
            this.btnEditEmp.Name = "btnEditEmp";
            this.btnEditEmp.Size = new System.Drawing.Size(221, 60);
            this.btnEditEmp.TabIndex = 6;
            this.btnEditEmp.Text = "Modifier";
            this.btnEditEmp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditEmp.UseVisualStyleBackColor = false;
            this.btnEditEmp.Click += new System.EventHandler(this.btnEditEmp_Click);
            this.btnEditEmp.MouseLeave += new System.EventHandler(this.btnAddEmp_MouseLeave);
            this.btnEditEmp.MouseHover += new System.EventHandler(this.btnAddEmp_MouseHover);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 40;
            this.iconPictureBox1.Location = new System.Drawing.Point(477, 271);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(44, 40);
            this.iconPictureBox1.TabIndex = 22;
            this.iconPictureBox1.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.BaseColor = System.Drawing.Color.White;
            this.txtSearch.BorderColor = System.Drawing.Color.Silver;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSearch.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(167)))));
            this.txtSearch.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(538, 266);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.Radius = 10;
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(304, 47);
            this.txtSearch.TabIndex = 21;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // Maintenance
            // 
            this.Maintenance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(80)))), ((int)(((byte)(102)))));
            this.Maintenance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Maintenance.ForeColor = System.Drawing.Color.White;
            this.Maintenance.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.Maintenance.IconColor = System.Drawing.Color.White;
            this.Maintenance.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Maintenance.IconSize = 35;
            this.Maintenance.Location = new System.Drawing.Point(12, 78);
            this.Maintenance.Name = "Maintenance";
            this.Maintenance.Size = new System.Drawing.Size(221, 60);
            this.Maintenance.TabIndex = 23;
            this.Maintenance.Text = "Maintenance";
            this.Maintenance.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Maintenance.UseVisualStyleBackColor = false;
            this.Maintenance.Click += new System.EventHandler(this.achatDebt_Click);
            this.Maintenance.MouseLeave += new System.EventHandler(this.achatDebt_MouseLeave);
            this.Maintenance.MouseHover += new System.EventHandler(this.achatDebt_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(513, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(553, 227);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dataGridEmployees);
            this.panel1.Location = new System.Drawing.Point(339, 332);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 411);
            this.panel1.TabIndex = 25;
            // 
            // employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1431, 744);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Maintenance);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnAddEmp);
            this.Controls.Add(this.btnDetailEmp);
            this.Controls.Add(this.btnDeleteEmp);
            this.Controls.Add(this.btnEditEmp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "employees";
            this.Text = "employees";
            this.Load += new System.EventHandler(this.employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public Bunifu.Framework.UI.BunifuCustomDataGrid dataGridEmployees;
        private FontAwesome.Sharp.IconButton btnAddEmp;
        private FontAwesome.Sharp.IconButton btnDetailEmp;
        private FontAwesome.Sharp.IconButton btnDeleteEmp;
        private FontAwesome.Sharp.IconButton btnEditEmp;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Guna.UI.WinForms.GunaTextBox txtSearch;
        private FontAwesome.Sharp.IconButton Maintenance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}