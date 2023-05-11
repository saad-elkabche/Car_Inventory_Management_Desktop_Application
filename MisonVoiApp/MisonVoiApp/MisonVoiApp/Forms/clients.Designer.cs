
namespace MisonVoiApp.Forms
{
    partial class clients
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(clients));
            this.btnAddClient = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridClients = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteClient = new FontAwesome.Sharp.IconButton();
            this.btnEditClient = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.achatCache = new FontAwesome.Sharp.IconButton();
            this.cmbType = new Guna.UI.WinForms.GunaComboBox();
            this.txtSearch = new Guna.UI.WinForms.GunaTextBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.achatDebt = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddClient
            // 
            this.btnAddClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(111)))));
            this.btnAddClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClient.ForeColor = System.Drawing.Color.White;
            this.btnAddClient.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnAddClient.IconColor = System.Drawing.Color.White;
            this.btnAddClient.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddClient.IconSize = 35;
            this.btnAddClient.Location = new System.Drawing.Point(1174, 6);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(221, 60);
            this.btnAddClient.TabIndex = 10;
            this.btnAddClient.Text = "Ajouter Client";
            this.btnAddClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddClient.UseVisualStyleBackColor = false;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            this.btnAddClient.MouseLeave += new System.EventHandler(this.btnAddClient_MouseLeave);
            this.btnAddClient.MouseHover += new System.EventHandler(this.btnAddClient_MouseHover);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dataGridClients);
            this.panel1.Location = new System.Drawing.Point(166, 317);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1003, 428);
            this.panel1.TabIndex = 9;
            // 
            // dataGridClients
            // 
            this.dataGridClients.AllowUserToAddRows = false;
            this.dataGridClients.AllowUserToDeleteRows = false;
            this.dataGridClients.AllowUserToResizeColumns = false;
            this.dataGridClients.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dataGridClients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridClients.BackgroundColor = System.Drawing.Color.White;
            this.dataGridClients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridClients.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dataGridClients.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridClients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridClients.ColumnHeadersHeight = 60;
            this.dataGridClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridClients.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridClients.DoubleBuffered = true;
            this.dataGridClients.EnableHeadersVisualStyles = false;
            this.dataGridClients.GridColor = System.Drawing.Color.White;
            this.dataGridClients.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(167)))));
            this.dataGridClients.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridClients.Location = new System.Drawing.Point(0, 0);
            this.dataGridClients.MultiSelect = false;
            this.dataGridClients.Name = "dataGridClients";
            this.dataGridClients.ReadOnly = true;
            this.dataGridClients.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridClients.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridClients.RowHeadersVisible = false;
            this.dataGridClients.RowHeadersWidth = 51;
            this.dataGridClients.RowTemplate.Height = 60;
            this.dataGridClients.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridClients.Size = new System.Drawing.Size(1003, 428);
            this.dataGridClients.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "CIN";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nom-prenom";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "adresse";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "numberPhone";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(210)))), ((int)(((byte)(216)))));
            this.btnDeleteClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteClient.ForeColor = System.Drawing.Color.White;
            this.btnDeleteClient.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDeleteClient.IconColor = System.Drawing.Color.White;
            this.btnDeleteClient.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeleteClient.IconSize = 28;
            this.btnDeleteClient.Location = new System.Drawing.Point(1174, 144);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(221, 61);
            this.btnDeleteClient.TabIndex = 7;
            this.btnDeleteClient.Text = "Suprimer";
            this.btnDeleteClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteClient.UseVisualStyleBackColor = false;
            this.btnDeleteClient.Click += new System.EventHandler(this.btnDeleteClient_Click);
            this.btnDeleteClient.MouseLeave += new System.EventHandler(this.btnAddClient_MouseLeave);
            this.btnDeleteClient.MouseHover += new System.EventHandler(this.btnAddClient_MouseHover);
            // 
            // btnEditClient
            // 
            this.btnEditClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(167)))));
            this.btnEditClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditClient.ForeColor = System.Drawing.Color.White;
            this.btnEditClient.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.btnEditClient.IconColor = System.Drawing.Color.White;
            this.btnEditClient.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditClient.IconSize = 30;
            this.btnEditClient.Location = new System.Drawing.Point(1174, 75);
            this.btnEditClient.Name = "btnEditClient";
            this.btnEditClient.Size = new System.Drawing.Size(221, 60);
            this.btnEditClient.TabIndex = 6;
            this.btnEditClient.Text = "Modifier";
            this.btnEditClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditClient.UseVisualStyleBackColor = false;
            this.btnEditClient.Click += new System.EventHandler(this.btnEditClient_Click);
            this.btnEditClient.MouseLeave += new System.EventHandler(this.btnAddClient_MouseLeave);
            this.btnEditClient.MouseHover += new System.EventHandler(this.btnAddClient_MouseHover);
            // 
            // iconButton2
            // 
            this.iconButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(223)))), ((int)(((byte)(228)))));
            this.iconButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 30;
            this.iconButton2.Location = new System.Drawing.Point(1174, 214);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(221, 60);
            this.iconButton2.TabIndex = 14;
            this.iconButton2.Text = "Detailles";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            this.iconButton2.MouseLeave += new System.EventHandler(this.btnAddClient_MouseLeave);
            this.iconButton2.MouseHover += new System.EventHandler(this.btnAddClient_MouseHover);
            // 
            // achatCache
            // 
            this.achatCache.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.achatCache.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.achatCache.ForeColor = System.Drawing.Color.White;
            this.achatCache.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.achatCache.IconColor = System.Drawing.Color.White;
            this.achatCache.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.achatCache.IconSize = 39;
            this.achatCache.Location = new System.Drawing.Point(12, 65);
            this.achatCache.Name = "achatCache";
            this.achatCache.Size = new System.Drawing.Size(221, 60);
            this.achatCache.TabIndex = 16;
            this.achatCache.Text = "Les ventes";
            this.achatCache.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.achatCache.UseVisualStyleBackColor = false;
            this.achatCache.Click += new System.EventHandler(this.achatCache_Click);
            this.achatCache.MouseLeave += new System.EventHandler(this.achatCache_MouseLeave);
            this.achatCache.MouseHover += new System.EventHandler(this.achatCache_MouseHover);
            // 
            // cmbType
            // 
            this.cmbType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbType.BackColor = System.Drawing.Color.Transparent;
            this.cmbType.BaseColor = System.Drawing.Color.White;
            this.cmbType.BorderColor = System.Drawing.Color.Silver;
            this.cmbType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FocusedColor = System.Drawing.Color.Empty;
            this.cmbType.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbType.ForeColor = System.Drawing.Color.Black;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "CIN",
            "Nom"});
            this.cmbType.Location = new System.Drawing.Point(780, 261);
            this.cmbType.Name = "cmbType";
            this.cmbType.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(167)))));
            this.cmbType.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbType.Radius = 10;
            this.cmbType.Size = new System.Drawing.Size(107, 35);
            this.cmbType.TabIndex = 17;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.BaseColor = System.Drawing.Color.White;
            this.txtSearch.BorderColor = System.Drawing.Color.Silver;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSearch.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(167)))));
            this.txtSearch.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(446, 256);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.Radius = 10;
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(304, 47);
            this.txtSearch.TabIndex = 18;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 40;
            this.iconPictureBox1.Location = new System.Drawing.Point(385, 261);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(44, 40);
            this.iconPictureBox1.TabIndex = 19;
            this.iconPictureBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(385, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(584, 251);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // achatDebt
            // 
            this.achatDebt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(80)))), ((int)(((byte)(102)))));
            this.achatDebt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.achatDebt.ForeColor = System.Drawing.Color.White;
            this.achatDebt.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.achatDebt.IconColor = System.Drawing.Color.White;
            this.achatDebt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.achatDebt.IconSize = 35;
            this.achatDebt.Location = new System.Drawing.Point(12, 131);
            this.achatDebt.Name = "achatDebt";
            this.achatDebt.Size = new System.Drawing.Size(221, 60);
            this.achatDebt.TabIndex = 15;
            this.achatDebt.Text = "Maintenance";
            this.achatDebt.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.achatDebt.UseVisualStyleBackColor = false;
            this.achatDebt.MouseLeave += new System.EventHandler(this.achatCache_MouseLeave);
            this.achatDebt.MouseHover += new System.EventHandler(this.achatCache_MouseHover);
            // 
            // clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1431, 744);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.achatCache);
            this.Controls.Add(this.achatDebt);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDeleteClient);
            this.Controls.Add(this.btnEditClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "clients";
            this.Text = "clients";
            this.Load += new System.EventHandler(this.clients_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnAddClient;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGridClients;
        private FontAwesome.Sharp.IconButton btnDeleteClient;
        private FontAwesome.Sharp.IconButton btnEditClient;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton achatCache;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private Guna.UI.WinForms.GunaComboBox cmbType;
        private Guna.UI.WinForms.GunaTextBox txtSearch;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton achatDebt;
    }
}