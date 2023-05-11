
namespace MisonVoiApp.Forms
{
    partial class addClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addClient));
            this.label21 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNom = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtAdresse = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPhone = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtCin = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtOccupation = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelClose = new System.Windows.Forms.Label();
            this.btnAjouterCar = new FontAwesome.Sharp.IconButton();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.UserPicture = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.picPicture = new FontAwesome.Sharp.IconButton();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.naissancePic = new Guna.UI.WinForms.GunaDateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.UserPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label21.ForeColor = System.Drawing.Color.DarkGray;
            this.label21.Location = new System.Drawing.Point(175, 569);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(84, 24);
            this.label21.TabIndex = 37;
            this.label21.Text = "adresse";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label16.ForeColor = System.Drawing.Color.DarkGray;
            this.label16.Location = new System.Drawing.Point(107, 497);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(152, 24);
            this.label16.TabIndex = 36;
            this.label16.Text = "Number Phone";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label15.ForeColor = System.Drawing.Color.DarkGray;
            this.label15.Location = new System.Drawing.Point(79, 422);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(180, 24);
            this.label15.TabIndex = 35;
            this.label15.Text = "date de naissance";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label14.ForeColor = System.Drawing.Color.DarkGray;
            this.label14.Location = new System.Drawing.Point(146, 353);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(113, 24);
            this.label14.TabIndex = 34;
            this.label14.Text = "Nom Client";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label13.ForeColor = System.Drawing.Color.DarkGray;
            this.label13.Location = new System.Drawing.Point(215, 281);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 24);
            this.label13.TabIndex = 33;
            this.label13.Text = "CIN";
            // 
            // txtNom
            // 
            this.txtNom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNom.HintForeColor = System.Drawing.Color.Empty;
            this.txtNom.HintText = "";
            this.txtNom.isPassword = false;
            this.txtNom.LineFocusedColor = System.Drawing.Color.CadetBlue;
            this.txtNom.LineIdleColor = System.Drawing.Color.Gray;
            this.txtNom.LineMouseHoverColor = System.Drawing.Color.CadetBlue;
            this.txtNom.LineThickness = 3;
            this.txtNom.Location = new System.Drawing.Point(328, 339);
            this.txtNom.Margin = new System.Windows.Forms.Padding(4);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(329, 35);
            this.txtNom.TabIndex = 41;
            this.txtNom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtAdresse
            // 
            this.txtAdresse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAdresse.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdresse.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdresse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAdresse.HintForeColor = System.Drawing.Color.Empty;
            this.txtAdresse.HintText = "";
            this.txtAdresse.isPassword = false;
            this.txtAdresse.LineFocusedColor = System.Drawing.Color.CadetBlue;
            this.txtAdresse.LineIdleColor = System.Drawing.Color.Gray;
            this.txtAdresse.LineMouseHoverColor = System.Drawing.Color.CadetBlue;
            this.txtAdresse.LineThickness = 3;
            this.txtAdresse.Location = new System.Drawing.Point(328, 555);
            this.txtAdresse.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(329, 35);
            this.txtAdresse.TabIndex = 40;
            this.txtAdresse.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPhone.HintForeColor = System.Drawing.Color.Empty;
            this.txtPhone.HintText = "";
            this.txtPhone.isPassword = false;
            this.txtPhone.LineFocusedColor = System.Drawing.Color.CadetBlue;
            this.txtPhone.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPhone.LineMouseHoverColor = System.Drawing.Color.CadetBlue;
            this.txtPhone.LineThickness = 3;
            this.txtPhone.Location = new System.Drawing.Point(328, 483);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(329, 35);
            this.txtPhone.TabIndex = 39;
            this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAge_KeyPress);
            // 
            // txtCin
            // 
            this.txtCin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCin.HintForeColor = System.Drawing.Color.Empty;
            this.txtCin.HintText = "";
            this.txtCin.isPassword = false;
            this.txtCin.LineFocusedColor = System.Drawing.Color.CadetBlue;
            this.txtCin.LineIdleColor = System.Drawing.Color.Gray;
            this.txtCin.LineMouseHoverColor = System.Drawing.Color.CadetBlue;
            this.txtCin.LineThickness = 3;
            this.txtCin.Location = new System.Drawing.Point(328, 267);
            this.txtCin.Margin = new System.Windows.Forms.Padding(4);
            this.txtCin.Name = "txtCin";
            this.txtCin.Size = new System.Drawing.Size(329, 35);
            this.txtCin.TabIndex = 38;
            this.txtCin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtOccupation
            // 
            this.txtOccupation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOccupation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOccupation.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOccupation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtOccupation.HintForeColor = System.Drawing.Color.Empty;
            this.txtOccupation.HintText = "";
            this.txtOccupation.isPassword = false;
            this.txtOccupation.LineFocusedColor = System.Drawing.Color.CadetBlue;
            this.txtOccupation.LineIdleColor = System.Drawing.Color.Gray;
            this.txtOccupation.LineMouseHoverColor = System.Drawing.Color.CadetBlue;
            this.txtOccupation.LineThickness = 3;
            this.txtOccupation.Location = new System.Drawing.Point(328, 627);
            this.txtOccupation.Margin = new System.Windows.Forms.Padding(4);
            this.txtOccupation.Name = "txtOccupation";
            this.txtOccupation.Size = new System.Drawing.Size(329, 35);
            this.txtOccupation.TabIndex = 43;
            this.txtOccupation.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(184, 642);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 42;
            this.label1.Text = "Metier";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelClose
            // 
            this.labelClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelClose.AutoSize = true;
            this.labelClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F, System.Drawing.FontStyle.Bold);
            this.labelClose.ForeColor = System.Drawing.Color.Gray;
            this.labelClose.Location = new System.Drawing.Point(814, 16);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(40, 38);
            this.labelClose.TabIndex = 48;
            this.labelClose.Text = "X";
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            this.labelClose.MouseLeave += new System.EventHandler(this.labelClose_MouseLeave);
            this.labelClose.MouseHover += new System.EventHandler(this.labelClose_MouseHover);
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
            this.btnAjouterCar.Location = new System.Drawing.Point(652, 691);
            this.btnAjouterCar.Name = "btnAjouterCar";
            this.btnAjouterCar.Size = new System.Drawing.Size(217, 55);
            this.btnAjouterCar.TabIndex = 49;
            this.btnAjouterCar.Text = "Ajouter";
            this.btnAjouterCar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAjouterCar.UseVisualStyleBackColor = false;
            this.btnAjouterCar.Click += new System.EventHandler(this.btnAjouterCar_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(47, 225);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(769, 20);
            this.bunifuSeparator1.TabIndex = 50;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // UserPicture
            // 
            this.UserPicture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserPicture.BaseColor = System.Drawing.Color.White;
            this.UserPicture.Image = ((System.Drawing.Image)(resources.GetObject("UserPicture.Image")));
            this.UserPicture.Location = new System.Drawing.Point(395, 32);
            this.UserPicture.Name = "UserPicture";
            this.UserPicture.Size = new System.Drawing.Size(120, 120);
            this.UserPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UserPicture.TabIndex = 51;
            this.UserPicture.TabStop = false;
            this.UserPicture.UseTransfarantBackground = false;
            // 
            // picPicture
            // 
            this.picPicture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(47)))));
            this.picPicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.picPicture.ForeColor = System.Drawing.Color.White;
            this.picPicture.IconChar = FontAwesome.Sharp.IconChar.Camera;
            this.picPicture.IconColor = System.Drawing.Color.White;
            this.picPicture.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.picPicture.IconSize = 30;
            this.picPicture.Location = new System.Drawing.Point(417, 158);
            this.picPicture.Name = "picPicture";
            this.picPicture.Size = new System.Drawing.Size(70, 51);
            this.picPicture.TabIndex = 52;
            this.picPicture.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.picPicture.UseVisualStyleBackColor = false;
            this.picPicture.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // naissancePic
            // 
            this.naissancePic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.naissancePic.BackColor = System.Drawing.Color.DarkGray;
            this.naissancePic.BaseColor = System.Drawing.Color.DarkGray;
            this.naissancePic.BorderColor = System.Drawing.Color.Silver;
            this.naissancePic.BorderSize = 0;
            this.naissancePic.CustomFormat = null;
            this.naissancePic.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.naissancePic.FocusedColor = System.Drawing.Color.Teal;
            this.naissancePic.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.naissancePic.ForeColor = System.Drawing.Color.Black;
            this.naissancePic.Location = new System.Drawing.Point(328, 416);
            this.naissancePic.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.naissancePic.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.naissancePic.Name = "naissancePic";
            this.naissancePic.OnHoverBaseColor = System.Drawing.Color.White;
            this.naissancePic.OnHoverBorderColor = System.Drawing.Color.Teal;
            this.naissancePic.OnHoverForeColor = System.Drawing.Color.Teal;
            this.naissancePic.OnPressedColor = System.Drawing.Color.Black;
            this.naissancePic.Size = new System.Drawing.Size(329, 40);
            this.naissancePic.TabIndex = 53;
            this.naissancePic.Text = "January 19, 2022";
            this.naissancePic.Value = new System.DateTime(2022, 1, 19, 23, 59, 59, 674);
            // 
            // addClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(881, 758);
            this.Controls.Add(this.naissancePic);
            this.Controls.Add(this.picPicture);
            this.Controls.Add(this.UserPicture);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.btnAjouterCar);
            this.Controls.Add(this.labelClose);
            this.Controls.Add(this.txtOccupation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtCin);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "addClient";
            this.Load += new System.EventHandler(this.addClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelClose;
        public FontAwesome.Sharp.IconButton btnAjouterCar;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        public FontAwesome.Sharp.IconButton picPicture;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtNom;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtAdresse;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtPhone;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtCin;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtOccupation;
        public Guna.UI.WinForms.GunaDateTimePicker naissancePic;
        public Guna.UI.WinForms.GunaCirclePictureBox UserPicture;
    }
}