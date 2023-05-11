
namespace MisonVoiApp.Forms.AddCarForms
{
    partial class Piece
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridPiece = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddPiece = new FontAwesome.Sharp.IconButton();
            this.btnDeletePiece = new FontAwesome.Sharp.IconButton();
            this.btnEditPiece = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomPierce = new Guna.UI.WinForms.GunaTextBox();
            this.txtPrixPierc = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbVoture = new Guna.UI.WinForms.GunaComboBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.txtQuantiti = new Guna.UI.WinForms.GunaTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPiece)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dataGridPiece);
            this.panel1.Location = new System.Drawing.Point(336, 355);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 389);
            this.panel1.TabIndex = 6;
            // 
            // dataGridPiece
            // 
            this.dataGridPiece.AllowUserToAddRows = false;
            this.dataGridPiece.AllowUserToDeleteRows = false;
            this.dataGridPiece.AllowUserToResizeColumns = false;
            this.dataGridPiece.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            this.dataGridPiece.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridPiece.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridPiece.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridPiece.BackgroundColor = System.Drawing.Color.White;
            this.dataGridPiece.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridPiece.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dataGridPiece.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridPiece.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridPiece.ColumnHeadersHeight = 60;
            this.dataGridPiece.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridPiece.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column1,
            this.Column5,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridPiece.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridPiece.DoubleBuffered = true;
            this.dataGridPiece.EnableHeadersVisualStyles = false;
            this.dataGridPiece.GridColor = System.Drawing.Color.White;
            this.dataGridPiece.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(167)))));
            this.dataGridPiece.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridPiece.Location = new System.Drawing.Point(0, 0);
            this.dataGridPiece.MultiSelect = false;
            this.dataGridPiece.Name = "dataGridPiece";
            this.dataGridPiece.ReadOnly = true;
            this.dataGridPiece.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridPiece.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridPiece.RowHeadersVisible = false;
            this.dataGridPiece.RowHeadersWidth = 51;
            this.dataGridPiece.RowTemplate.Height = 60;
            this.dataGridPiece.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridPiece.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPiece.Size = new System.Drawing.Size(634, 389);
            this.dataGridPiece.TabIndex = 0;
            this.dataGridPiece.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPiece_CellContentDoubleClick);
            // 
            // Column4
            // 
            this.Column4.HeaderText = "idPiece";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nom Piece";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "quantite";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Prix ";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Model";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // btnAddPiece
            // 
            this.btnAddPiece.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPiece.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(111)))));
            this.btnAddPiece.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPiece.ForeColor = System.Drawing.Color.White;
            this.btnAddPiece.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnAddPiece.IconColor = System.Drawing.Color.White;
            this.btnAddPiece.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddPiece.IconSize = 35;
            this.btnAddPiece.Location = new System.Drawing.Point(1198, 71);
            this.btnAddPiece.Name = "btnAddPiece";
            this.btnAddPiece.Size = new System.Drawing.Size(221, 60);
            this.btnAddPiece.TabIndex = 10;
            this.btnAddPiece.Text = "Ajouter";
            this.btnAddPiece.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddPiece.UseVisualStyleBackColor = false;
            this.btnAddPiece.Click += new System.EventHandler(this.CRUD);
            // 
            // btnDeletePiece
            // 
            this.btnDeletePiece.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeletePiece.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(210)))), ((int)(((byte)(216)))));
            this.btnDeletePiece.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePiece.ForeColor = System.Drawing.Color.White;
            this.btnDeletePiece.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDeletePiece.IconColor = System.Drawing.Color.White;
            this.btnDeletePiece.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeletePiece.IconSize = 28;
            this.btnDeletePiece.Location = new System.Drawing.Point(1198, 203);
            this.btnDeletePiece.Name = "btnDeletePiece";
            this.btnDeletePiece.Size = new System.Drawing.Size(221, 61);
            this.btnDeletePiece.TabIndex = 8;
            this.btnDeletePiece.Text = "Suprimer";
            this.btnDeletePiece.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeletePiece.UseVisualStyleBackColor = false;
            this.btnDeletePiece.Click += new System.EventHandler(this.CRUD);
            // 
            // btnEditPiece
            // 
            this.btnEditPiece.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditPiece.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(167)))));
            this.btnEditPiece.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditPiece.ForeColor = System.Drawing.Color.White;
            this.btnEditPiece.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.btnEditPiece.IconColor = System.Drawing.Color.White;
            this.btnEditPiece.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditPiece.IconSize = 30;
            this.btnEditPiece.Location = new System.Drawing.Point(1198, 137);
            this.btnEditPiece.Name = "btnEditPiece";
            this.btnEditPiece.Size = new System.Drawing.Size(221, 60);
            this.btnEditPiece.TabIndex = 7;
            this.btnEditPiece.Text = "Modifier";
            this.btnEditPiece.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditPiece.UseVisualStyleBackColor = false;
            this.btnEditPiece.Click += new System.EventHandler(this.CRUD);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(639, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 68;
            this.label1.Text = "Voiture";
            // 
            // txtNomPierce
            // 
            this.txtNomPierce.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomPierce.BackColor = System.Drawing.Color.Transparent;
            this.txtNomPierce.BaseColor = System.Drawing.Color.White;
            this.txtNomPierce.BorderColor = System.Drawing.Color.Silver;
            this.txtNomPierce.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNomPierce.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNomPierce.FocusedBorderColor = System.Drawing.Color.Teal;
            this.txtNomPierce.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNomPierce.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomPierce.Location = new System.Drawing.Point(796, 189);
            this.txtNomPierce.Name = "txtNomPierce";
            this.txtNomPierce.PasswordChar = '\0';
            this.txtNomPierce.Radius = 10;
            this.txtNomPierce.SelectedText = "";
            this.txtNomPierce.Size = new System.Drawing.Size(347, 43);
            this.txtNomPierce.TabIndex = 77;
            // 
            // txtPrixPierc
            // 
            this.txtPrixPierc.BackColor = System.Drawing.Color.Transparent;
            this.txtPrixPierc.BaseColor = System.Drawing.Color.White;
            this.txtPrixPierc.BorderColor = System.Drawing.Color.Silver;
            this.txtPrixPierc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrixPierc.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPrixPierc.FocusedBorderColor = System.Drawing.Color.Teal;
            this.txtPrixPierc.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPrixPierc.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrixPierc.Location = new System.Drawing.Point(176, 93);
            this.txtPrixPierc.Name = "txtPrixPierc";
            this.txtPrixPierc.PasswordChar = '\0';
            this.txtPrixPierc.Radius = 10;
            this.txtPrixPierc.SelectedText = "";
            this.txtPrixPierc.Size = new System.Drawing.Size(347, 43);
            this.txtPrixPierc.TabIndex = 78;
            this.txtPrixPierc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrixPierc_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(608, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 79;
            this.label2.Text = "Nom Pièce";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(51, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 80;
            this.label3.Text = "Prix Pièce";
            // 
            // cmbVoture
            // 
            this.cmbVoture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbVoture.BackColor = System.Drawing.Color.Transparent;
            this.cmbVoture.BaseColor = System.Drawing.Color.White;
            this.cmbVoture.BorderColor = System.Drawing.Color.Silver;
            this.cmbVoture.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbVoture.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVoture.FocusedColor = System.Drawing.Color.Empty;
            this.cmbVoture.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.cmbVoture.ForeColor = System.Drawing.Color.Black;
            this.cmbVoture.FormattingEnabled = true;
            this.cmbVoture.Location = new System.Drawing.Point(796, 98);
            this.cmbVoture.Name = "cmbVoture";
            this.cmbVoture.OnHoverItemBaseColor = System.Drawing.Color.Teal;
            this.cmbVoture.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbVoture.Radius = 10;
            this.cmbVoture.Size = new System.Drawing.Size(347, 33);
            this.cmbVoture.TabIndex = 98;
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(210)))), ((int)(((byte)(216)))));
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 28;
            this.iconButton1.Location = new System.Drawing.Point(1198, 270);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(221, 62);
            this.iconButton1.TabIndex = 99;
            this.iconButton1.Text = "Clear";
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // txtQuantiti
            // 
            this.txtQuantiti.BackColor = System.Drawing.Color.Transparent;
            this.txtQuantiti.BaseColor = System.Drawing.Color.White;
            this.txtQuantiti.BorderColor = System.Drawing.Color.Silver;
            this.txtQuantiti.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantiti.FocusedBaseColor = System.Drawing.Color.White;
            this.txtQuantiti.FocusedBorderColor = System.Drawing.Color.Teal;
            this.txtQuantiti.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtQuantiti.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantiti.Location = new System.Drawing.Point(176, 189);
            this.txtQuantiti.Name = "txtQuantiti";
            this.txtQuantiti.PasswordChar = '\0';
            this.txtQuantiti.Radius = 10;
            this.txtQuantiti.SelectedText = "";
            this.txtQuantiti.Size = new System.Drawing.Size(347, 43);
            this.txtQuantiti.TabIndex = 100;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(70, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 101;
            this.label4.Text = "quantite";
            // 
            // Piece
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1431, 744);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtQuantiti);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.cmbVoture);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrixPierc);
            this.Controls.Add(this.txtNomPierce);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddPiece);
            this.Controls.Add(this.btnDeletePiece);
            this.Controls.Add(this.btnEditPiece);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Piece";
            this.Text = "Piece";
            this.Load += new System.EventHandler(this.Piece_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPiece)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public Bunifu.Framework.UI.BunifuCustomDataGrid dataGridPiece;
        private FontAwesome.Sharp.IconButton btnAddPiece;
        private FontAwesome.Sharp.IconButton btnDeletePiece;
        private FontAwesome.Sharp.IconButton btnEditPiece;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox txtNomPierce;
        private Guna.UI.WinForms.GunaTextBox txtPrixPierc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaComboBox cmbVoture;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Guna.UI.WinForms.GunaTextBox txtQuantiti;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}