
namespace MisonVoiApp.Forms
{
    partial class admin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridUsers = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.txtPass = new Guna.UI.WinForms.GunaTextBox();
            this.txtLogin = new Guna.UI.WinForms.GunaTextBox();
            this.btnAddClient = new FontAwesome.Sharp.IconButton();
            this.btnDeleteClient = new FontAwesome.Sharp.IconButton();
            this.btnEditClient = new FontAwesome.Sharp.IconButton();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labaleClose = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridUsers
            // 
            this.dataGridUsers.AllowUserToAddRows = false;
            this.dataGridUsers.AllowUserToDeleteRows = false;
            this.dataGridUsers.AllowUserToResizeColumns = false;
            this.dataGridUsers.AllowUserToResizeRows = false;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.White;
            this.dataGridUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            this.dataGridUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridUsers.BackgroundColor = System.Drawing.Color.White;
            this.dataGridUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dataGridUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.dataGridUsers.ColumnHeadersHeight = 60;
            this.dataGridUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridUsers.DefaultCellStyle = dataGridViewCellStyle27;
            this.dataGridUsers.DoubleBuffered = true;
            this.dataGridUsers.EnableHeadersVisualStyles = false;
            this.dataGridUsers.GridColor = System.Drawing.Color.White;
            this.dataGridUsers.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(167)))));
            this.dataGridUsers.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridUsers.Location = new System.Drawing.Point(42, 356);
            this.dataGridUsers.MultiSelect = false;
            this.dataGridUsers.Name = "dataGridUsers";
            this.dataGridUsers.ReadOnly = true;
            this.dataGridUsers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle28;
            this.dataGridUsers.RowHeadersVisible = false;
            this.dataGridUsers.RowHeadersWidth = 51;
            this.dataGridUsers.RowTemplate.Height = 60;
            this.dataGridUsers.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridUsers.Size = new System.Drawing.Size(734, 389);
            this.dataGridUsers.TabIndex = 2;
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.Transparent;
            this.txtPass.BaseColor = System.Drawing.Color.White;
            this.txtPass.BorderColor = System.Drawing.Color.Silver;
            this.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPass.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPass.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtPass.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(254, 175);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '\0';
            this.txtPass.Radius = 10;
            this.txtPass.SelectedText = "";
            this.txtPass.Size = new System.Drawing.Size(208, 33);
            this.txtPass.TabIndex = 56;
            // 
            // txtLogin
            // 
            this.txtLogin.BackColor = System.Drawing.Color.Transparent;
            this.txtLogin.BaseColor = System.Drawing.Color.White;
            this.txtLogin.BorderColor = System.Drawing.Color.Silver;
            this.txtLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLogin.FocusedBaseColor = System.Drawing.Color.White;
            this.txtLogin.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtLogin.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtLogin.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Location = new System.Drawing.Point(254, 112);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.PasswordChar = '\0';
            this.txtLogin.Radius = 10;
            this.txtLogin.SelectedText = "";
            this.txtLogin.Size = new System.Drawing.Size(208, 33);
            this.txtLogin.TabIndex = 55;
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
            this.btnAddClient.Location = new System.Drawing.Point(585, 64);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(221, 60);
            this.btnAddClient.TabIndex = 59;
            this.btnAddClient.Text = "Ajouter User";
            this.btnAddClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddClient.UseVisualStyleBackColor = false;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
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
            this.btnDeleteClient.Location = new System.Drawing.Point(585, 202);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(221, 61);
            this.btnDeleteClient.TabIndex = 58;
            this.btnDeleteClient.Text = "Suprimer";
            this.btnDeleteClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteClient.UseVisualStyleBackColor = false;
            this.btnDeleteClient.Click += new System.EventHandler(this.btnDeleteClient_Click);
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
            this.btnEditClient.Location = new System.Drawing.Point(585, 133);
            this.btnEditClient.Name = "btnEditClient";
            this.btnEditClient.Size = new System.Drawing.Size(221, 60);
            this.btnEditClient.TabIndex = 57;
            this.btnEditClient.Text = "Modifier";
            this.btnEditClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditClient.UseVisualStyleBackColor = false;
            this.btnEditClient.Click += new System.EventHandler(this.btnEditClient_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "user";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "passsWord";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(101, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 61;
            this.label5.Text = "Mot de pass";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(117, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 60;
            this.label4.Text = "utilisateur";
            // 
            // labaleClose
            // 
            this.labaleClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labaleClose.AutoSize = true;
            this.labaleClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F, System.Drawing.FontStyle.Bold);
            this.labaleClose.ForeColor = System.Drawing.Color.Gray;
            this.labaleClose.Location = new System.Drawing.Point(766, 9);
            this.labaleClose.Name = "labaleClose";
            this.labaleClose.Size = new System.Drawing.Size(40, 38);
            this.labaleClose.TabIndex = 62;
            this.labaleClose.Text = "X";
            this.labaleClose.Click += new System.EventHandler(this.labaleClose_Click);
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(818, 746);
            this.Controls.Add(this.labaleClose);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.btnDeleteClient);
            this.Controls.Add(this.btnEditClient);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.dataGridUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "admin";
            this.Text = "admin";
            this.Load += new System.EventHandler(this.admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGridUsers;
        private Guna.UI.WinForms.GunaTextBox txtPass;
        private Guna.UI.WinForms.GunaTextBox txtLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private FontAwesome.Sharp.IconButton btnAddClient;
        private FontAwesome.Sharp.IconButton btnDeleteClient;
        private FontAwesome.Sharp.IconButton btnEditClient;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labaleClose;
    }
}