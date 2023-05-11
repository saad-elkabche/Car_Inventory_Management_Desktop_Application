
namespace MisonVoiApp.Forms
{
    partial class AddEmp
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
            this.naissancePic = new Guna.UI.WinForms.GunaDateTimePicker();
            this.btnAjouterCar = new FontAwesome.Sharp.IconButton();
            this.labelClose = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbSpecia = new Guna.UI.WinForms.GunaComboBox();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.txtAdresse = new Guna.UI.WinForms.GunaTextBox();
            this.txtPhone = new Guna.UI.WinForms.GunaTextBox();
            this.txtNom = new Guna.UI.WinForms.GunaTextBox();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaElipsePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // naissancePic
            // 
            this.naissancePic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.naissancePic.BackColor = System.Drawing.Color.Transparent;
            this.naissancePic.BaseColor = System.Drawing.Color.DarkGray;
            this.naissancePic.BorderColor = System.Drawing.Color.Silver;
            this.naissancePic.BorderSize = 0;
            this.naissancePic.CustomFormat = null;
            this.naissancePic.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.naissancePic.FocusedColor = System.Drawing.Color.Teal;
            this.naissancePic.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.naissancePic.ForeColor = System.Drawing.Color.Black;
            this.naissancePic.Location = new System.Drawing.Point(315, 97);
            this.naissancePic.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.naissancePic.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.naissancePic.Name = "naissancePic";
            this.naissancePic.OnHoverBaseColor = System.Drawing.Color.White;
            this.naissancePic.OnHoverBorderColor = System.Drawing.Color.Teal;
            this.naissancePic.OnHoverForeColor = System.Drawing.Color.Teal;
            this.naissancePic.OnPressedColor = System.Drawing.Color.Black;
            this.naissancePic.Radius = 10;
            this.naissancePic.Size = new System.Drawing.Size(329, 40);
            this.naissancePic.TabIndex = 70;
            this.naissancePic.Text = "January 19, 2022";
            this.naissancePic.Value = new System.DateTime(2022, 1, 19, 23, 59, 59, 674);
            // 
            // btnAjouterCar
            // 
            this.btnAjouterCar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAjouterCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(47)))));
            this.btnAjouterCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnAjouterCar.ForeColor = System.Drawing.Color.White;
            this.btnAjouterCar.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnAjouterCar.IconColor = System.Drawing.Color.White;
            this.btnAjouterCar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAjouterCar.Location = new System.Drawing.Point(658, 576);
            this.btnAjouterCar.Name = "btnAjouterCar";
            this.btnAjouterCar.Size = new System.Drawing.Size(217, 55);
            this.btnAjouterCar.TabIndex = 66;
            this.btnAjouterCar.Text = "Ajouter";
            this.btnAjouterCar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAjouterCar.UseVisualStyleBackColor = false;
            this.btnAjouterCar.Click += new System.EventHandler(this.btnAjouterCar_Click);
            // 
            // labelClose
            // 
            this.labelClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelClose.AutoSize = true;
            this.labelClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F, System.Drawing.FontStyle.Bold);
            this.labelClose.ForeColor = System.Drawing.Color.Gray;
            this.labelClose.Location = new System.Drawing.Point(826, 13);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(40, 38);
            this.labelClose.TabIndex = 65;
            this.labelClose.Text = "X";
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            this.labelClose.MouseLeave += new System.EventHandler(this.labelClose_MouseLeave);
            this.labelClose.MouseHover += new System.EventHandler(this.labelClose_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(112, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 24);
            this.label1.TabIndex = 63;
            this.label1.Text = "specialite";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label21.ForeColor = System.Drawing.Color.DimGray;
            this.label21.Location = new System.Drawing.Point(126, 252);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(84, 24);
            this.label21.TabIndex = 58;
            this.label21.Text = "adresse";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label16.ForeColor = System.Drawing.Color.DimGray;
            this.label16.Location = new System.Drawing.Point(58, 180);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(152, 24);
            this.label16.TabIndex = 57;
            this.label16.Text = "Number Phone";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label15.ForeColor = System.Drawing.Color.DimGray;
            this.label15.Location = new System.Drawing.Point(30, 103);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(180, 24);
            this.label15.TabIndex = 56;
            this.label15.Text = "date de naissance";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label14.ForeColor = System.Drawing.Color.DimGray;
            this.label14.Location = new System.Drawing.Point(58, 38);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(154, 24);
            this.label14.TabIndex = 55;
            this.label14.Text = "Nom Employee";
            // 
            // cmbSpecia
            // 
            this.cmbSpecia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSpecia.BackColor = System.Drawing.Color.Transparent;
            this.cmbSpecia.BaseColor = System.Drawing.Color.White;
            this.cmbSpecia.BorderColor = System.Drawing.Color.Silver;
            this.cmbSpecia.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSpecia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSpecia.FocusedColor = System.Drawing.Color.Empty;
            this.cmbSpecia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSpecia.ForeColor = System.Drawing.Color.Black;
            this.cmbSpecia.FormattingEnabled = true;
            this.cmbSpecia.Location = new System.Drawing.Point(315, 318);
            this.cmbSpecia.Name = "cmbSpecia";
            this.cmbSpecia.OnHoverItemBaseColor = System.Drawing.Color.Teal;
            this.cmbSpecia.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbSpecia.Radius = 10;
            this.cmbSpecia.Size = new System.Drawing.Size(266, 35);
            this.cmbSpecia.TabIndex = 71;
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.Gainsboro;
            this.gunaElipsePanel1.Controls.Add(this.txtAdresse);
            this.gunaElipsePanel1.Controls.Add(this.txtPhone);
            this.gunaElipsePanel1.Controls.Add(this.txtNom);
            this.gunaElipsePanel1.Controls.Add(this.cmbSpecia);
            this.gunaElipsePanel1.Controls.Add(this.label14);
            this.gunaElipsePanel1.Controls.Add(this.naissancePic);
            this.gunaElipsePanel1.Controls.Add(this.label15);
            this.gunaElipsePanel1.Controls.Add(this.label1);
            this.gunaElipsePanel1.Controls.Add(this.label16);
            this.gunaElipsePanel1.Controls.Add(this.label21);
            this.gunaElipsePanel1.Location = new System.Drawing.Point(52, 100);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Radius = 25;
            this.gunaElipsePanel1.Size = new System.Drawing.Size(750, 428);
            this.gunaElipsePanel1.TabIndex = 72;
            // 
            // txtAdresse
            // 
            this.txtAdresse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAdresse.BackColor = System.Drawing.Color.Transparent;
            this.txtAdresse.BaseColor = System.Drawing.Color.White;
            this.txtAdresse.BorderColor = System.Drawing.Color.Silver;
            this.txtAdresse.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdresse.FocusedBaseColor = System.Drawing.Color.White;
            this.txtAdresse.FocusedBorderColor = System.Drawing.Color.Teal;
            this.txtAdresse.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAdresse.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdresse.Location = new System.Drawing.Point(315, 240);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.PasswordChar = '\0';
            this.txtAdresse.Radius = 10;
            this.txtAdresse.SelectedText = "";
            this.txtAdresse.Size = new System.Drawing.Size(266, 42);
            this.txtAdresse.TabIndex = 73;
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhone.BackColor = System.Drawing.Color.Transparent;
            this.txtPhone.BaseColor = System.Drawing.Color.White;
            this.txtPhone.BorderColor = System.Drawing.Color.Silver;
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPhone.FocusedBorderColor = System.Drawing.Color.Teal;
            this.txtPhone.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(315, 167);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.Radius = 10;
            this.txtPhone.SelectedText = "";
            this.txtPhone.Size = new System.Drawing.Size(266, 43);
            this.txtPhone.TabIndex = 72;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            // 
            // txtNom
            // 
            this.txtNom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNom.BackColor = System.Drawing.Color.Transparent;
            this.txtNom.BaseColor = System.Drawing.Color.White;
            this.txtNom.BorderColor = System.Drawing.Color.Silver;
            this.txtNom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNom.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNom.FocusedBorderColor = System.Drawing.Color.Teal;
            this.txtNom.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNom.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(315, 28);
            this.txtNom.Name = "txtNom";
            this.txtNom.PasswordChar = '\0';
            this.txtNom.Radius = 10;
            this.txtNom.SelectedText = "";
            this.txtNom.Size = new System.Drawing.Size(266, 42);
            this.txtNom.TabIndex = 56;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this;
            // 
            // AddEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(887, 652);
            this.Controls.Add(this.gunaElipsePanel1);
            this.Controls.Add(this.btnAjouterCar);
            this.Controls.Add(this.labelClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddEmp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEmp";
            this.Load += new System.EventHandler(this.AddEmp_Load);
            this.gunaElipsePanel1.ResumeLayout(false);
            this.gunaElipsePanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Guna.UI.WinForms.GunaDateTimePicker naissancePic;
        public FontAwesome.Sharp.IconButton btnAjouterCar;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        public Guna.UI.WinForms.GunaComboBox cmbSpecia;
        public Guna.UI.WinForms.GunaTextBox txtAdresse;
        public Guna.UI.WinForms.GunaTextBox txtPhone;
        public Guna.UI.WinForms.GunaTextBox txtNom;
    }
}