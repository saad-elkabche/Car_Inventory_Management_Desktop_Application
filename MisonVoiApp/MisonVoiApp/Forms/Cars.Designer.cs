
namespace MisonVoiApp.Forms
{
    partial class Cars
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridCars = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditVoiture = new FontAwesome.Sharp.IconButton();
            this.btnDeleteVoiture = new FontAwesome.Sharp.IconButton();
            this.btnDetailVoiture = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddVoiture = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.achatCache = new FontAwesome.Sharp.IconButton();
            this.achatDebt = new FontAwesome.Sharp.IconButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCars)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridCars
            // 
            this.dataGridCars.AllowUserToAddRows = false;
            this.dataGridCars.AllowUserToDeleteRows = false;
            this.dataGridCars.AllowUserToResizeColumns = false;
            this.dataGridCars.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridCars.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridCars.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridCars.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridCars.BackgroundColor = System.Drawing.Color.White;
            this.dataGridCars.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridCars.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dataGridCars.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCars.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridCars.ColumnHeadersHeight = 60;
            this.dataGridCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridCars.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column7});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridCars.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridCars.DoubleBuffered = true;
            this.dataGridCars.EnableHeadersVisualStyles = false;
            this.dataGridCars.GridColor = System.Drawing.Color.White;
            this.dataGridCars.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(167)))));
            this.dataGridCars.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridCars.Location = new System.Drawing.Point(0, 0);
            this.dataGridCars.MultiSelect = false;
            this.dataGridCars.Name = "dataGridCars";
            this.dataGridCars.ReadOnly = true;
            this.dataGridCars.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCars.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridCars.RowHeadersVisible = false;
            this.dataGridCars.RowHeadersWidth = 51;
            this.dataGridCars.RowTemplate.Height = 60;
            this.dataGridCars.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridCars.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridCars.Size = new System.Drawing.Size(1164, 422);
            this.dataGridCars.TabIndex = 0;
            this.dataGridCars.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCars_CellDoubleClick);
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
            this.Column1.HeaderText = "Model voiture";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Annee";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Carburant";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "puiss-Fiscale";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "puiss-reelle";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "status";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // btnEditVoiture
            // 
            this.btnEditVoiture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditVoiture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(167)))));
            this.btnEditVoiture.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditVoiture.ForeColor = System.Drawing.Color.White;
            this.btnEditVoiture.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.btnEditVoiture.IconColor = System.Drawing.Color.White;
            this.btnEditVoiture.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditVoiture.IconSize = 30;
            this.btnEditVoiture.Location = new System.Drawing.Point(1172, 69);
            this.btnEditVoiture.Name = "btnEditVoiture";
            this.btnEditVoiture.Size = new System.Drawing.Size(221, 60);
            this.btnEditVoiture.TabIndex = 1;
            this.btnEditVoiture.Text = "Modifier";
            this.btnEditVoiture.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditVoiture.UseVisualStyleBackColor = false;
            this.btnEditVoiture.Click += new System.EventHandler(this.btnEditVoiture_Click);
            this.btnEditVoiture.MouseLeave += new System.EventHandler(this.btnAddClient_MouseLeave);
            this.btnEditVoiture.MouseHover += new System.EventHandler(this.btnAddClient_MouseHover);
            // 
            // btnDeleteVoiture
            // 
            this.btnDeleteVoiture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteVoiture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(210)))), ((int)(((byte)(216)))));
            this.btnDeleteVoiture.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteVoiture.ForeColor = System.Drawing.Color.White;
            this.btnDeleteVoiture.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDeleteVoiture.IconColor = System.Drawing.Color.White;
            this.btnDeleteVoiture.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeleteVoiture.IconSize = 28;
            this.btnDeleteVoiture.Location = new System.Drawing.Point(1172, 135);
            this.btnDeleteVoiture.Name = "btnDeleteVoiture";
            this.btnDeleteVoiture.Size = new System.Drawing.Size(221, 61);
            this.btnDeleteVoiture.TabIndex = 2;
            this.btnDeleteVoiture.Text = "Suprimer";
            this.btnDeleteVoiture.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteVoiture.UseVisualStyleBackColor = false;
            this.btnDeleteVoiture.Click += new System.EventHandler(this.btnDeleteVoiture_Click);
            this.btnDeleteVoiture.MouseLeave += new System.EventHandler(this.btnAddClient_MouseLeave);
            this.btnDeleteVoiture.MouseHover += new System.EventHandler(this.btnAddClient_MouseHover);
            // 
            // btnDetailVoiture
            // 
            this.btnDetailVoiture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetailVoiture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnDetailVoiture.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetailVoiture.ForeColor = System.Drawing.Color.White;
            this.btnDetailVoiture.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            this.btnDetailVoiture.IconColor = System.Drawing.Color.White;
            this.btnDetailVoiture.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDetailVoiture.IconSize = 30;
            this.btnDetailVoiture.Location = new System.Drawing.Point(1172, 202);
            this.btnDetailVoiture.Name = "btnDetailVoiture";
            this.btnDetailVoiture.Size = new System.Drawing.Size(221, 60);
            this.btnDetailVoiture.TabIndex = 3;
            this.btnDetailVoiture.Text = "Detailles";
            this.btnDetailVoiture.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDetailVoiture.UseVisualStyleBackColor = false;
            this.btnDetailVoiture.Click += new System.EventHandler(this.btnDetailVoiture_Click);
            this.btnDetailVoiture.MouseLeave += new System.EventHandler(this.btnAddClient_MouseLeave);
            this.btnDetailVoiture.MouseHover += new System.EventHandler(this.btnAddClient_MouseHover);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dataGridCars);
            this.panel1.Location = new System.Drawing.Point(116, 317);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1164, 422);
            this.panel1.TabIndex = 4;
            // 
            // btnAddVoiture
            // 
            this.btnAddVoiture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddVoiture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(111)))));
            this.btnAddVoiture.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddVoiture.ForeColor = System.Drawing.Color.White;
            this.btnAddVoiture.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnAddVoiture.IconColor = System.Drawing.Color.White;
            this.btnAddVoiture.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddVoiture.IconSize = 35;
            this.btnAddVoiture.Location = new System.Drawing.Point(1172, 3);
            this.btnAddVoiture.Name = "btnAddVoiture";
            this.btnAddVoiture.Size = new System.Drawing.Size(221, 60);
            this.btnAddVoiture.TabIndex = 5;
            this.btnAddVoiture.Text = "Ajouter Voiture";
            this.btnAddVoiture.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddVoiture.UseVisualStyleBackColor = false;
            this.btnAddVoiture.Click += new System.EventHandler(this.iconButton4_Click);
            this.btnAddVoiture.MouseLeave += new System.EventHandler(this.btnAddClient_MouseLeave);
            this.btnAddVoiture.MouseHover += new System.EventHandler(this.btnAddClient_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(282, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(836, 294);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // achatCache
            // 
            this.achatCache.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(160)))), ((int)(((byte)(94)))));
            this.achatCache.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.achatCache.ForeColor = System.Drawing.Color.White;
            this.achatCache.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckAlt;
            this.achatCache.IconColor = System.Drawing.Color.White;
            this.achatCache.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.achatCache.IconSize = 39;
            this.achatCache.Location = new System.Drawing.Point(26, 54);
            this.achatCache.Name = "achatCache";
            this.achatCache.Size = new System.Drawing.Size(221, 60);
            this.achatCache.TabIndex = 8;
            this.achatCache.Text = "vente voiture cache";
            this.achatCache.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.achatCache.UseVisualStyleBackColor = false;
            this.achatCache.Click += new System.EventHandler(this.achatCache_Click);
            this.achatCache.MouseLeave += new System.EventHandler(this.btnAddClient_MouseLeave);
            this.achatCache.MouseHover += new System.EventHandler(this.btnAddClient_MouseHover);
            // 
            // achatDebt
            // 
            this.achatDebt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(191)))), ((int)(((byte)(147)))));
            this.achatDebt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.achatDebt.ForeColor = System.Drawing.Color.White;
            this.achatDebt.IconChar = FontAwesome.Sharp.IconChar.CreditCard;
            this.achatDebt.IconColor = System.Drawing.Color.White;
            this.achatDebt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.achatDebt.IconSize = 35;
            this.achatDebt.Location = new System.Drawing.Point(26, 120);
            this.achatDebt.Name = "achatDebt";
            this.achatDebt.Size = new System.Drawing.Size(221, 60);
            this.achatDebt.TabIndex = 7;
            this.achatDebt.Text = "vente voiture (dette)";
            this.achatDebt.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.achatDebt.UseVisualStyleBackColor = false;
            this.achatDebt.Click += new System.EventHandler(this.achatDebt_Click);
            this.achatDebt.MouseLeave += new System.EventHandler(this.btnAddClient_MouseLeave);
            this.achatDebt.MouseHover += new System.EventHandler(this.btnAddClient_MouseHover);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Cars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1431, 744);
            this.Controls.Add(this.achatCache);
            this.Controls.Add(this.achatDebt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAddVoiture);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDetailVoiture);
            this.Controls.Add(this.btnDeleteVoiture);
            this.Controls.Add(this.btnEditVoiture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cars";
            this.Text = "Cars";
            this.Load += new System.EventHandler(this.Cars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCars)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnEditVoiture;
        private FontAwesome.Sharp.IconButton btnDeleteVoiture;
        private FontAwesome.Sharp.IconButton btnDetailVoiture;
        private System.Windows.Forms.Panel panel1;
        private UI.circleButton circleButton1;
        private FontAwesome.Sharp.IconButton btnAddVoiture;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private FontAwesome.Sharp.IconButton achatCache;
        private FontAwesome.Sharp.IconButton achatDebt;
        private System.Windows.Forms.Timer timer1;
        public Bunifu.Framework.UI.BunifuCustomDataGrid dataGridCars;
    }
}