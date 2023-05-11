
namespace MisonVoiApp.Forms
{
    partial class specialite
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
            this.listSpe = new System.Windows.Forms.ListBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.txtNomSpecialite = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.labaleClose = new System.Windows.Forms.Label();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.SuspendLayout();
            // 
            // listSpe
            // 
            this.listSpe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listSpe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listSpe.FormattingEnabled = true;
            this.listSpe.ItemHeight = 31;
            this.listSpe.Location = new System.Drawing.Point(193, 212);
            this.listSpe.Name = "listSpe";
            this.listSpe.Size = new System.Drawing.Size(245, 283);
            this.listSpe.TabIndex = 0;
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton1.BackColor = System.Drawing.Color.Black;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 35;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton1.Location = new System.Drawing.Point(497, 322);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(153, 50);
            this.iconButton1.TabIndex = 1;
            this.iconButton1.Text = "Supprimer";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // txtNomSpecialite
            // 
            this.txtNomSpecialite.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNomSpecialite.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNomSpecialite.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomSpecialite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNomSpecialite.HintForeColor = System.Drawing.Color.Empty;
            this.txtNomSpecialite.HintText = "";
            this.txtNomSpecialite.isPassword = false;
            this.txtNomSpecialite.LineFocusedColor = System.Drawing.Color.Teal;
            this.txtNomSpecialite.LineIdleColor = System.Drawing.Color.Black;
            this.txtNomSpecialite.LineMouseHoverColor = System.Drawing.Color.Teal;
            this.txtNomSpecialite.LineThickness = 3;
            this.txtNomSpecialite.Location = new System.Drawing.Point(120, 113);
            this.txtNomSpecialite.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomSpecialite.Name = "txtNomSpecialite";
            this.txtNomSpecialite.Size = new System.Drawing.Size(407, 46);
            this.txtNomSpecialite.TabIndex = 2;
            this.txtNomSpecialite.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // iconButton2
            // 
            this.iconButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton2.BackColor = System.Drawing.Color.Black;
            this.iconButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 35;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton2.Location = new System.Drawing.Point(497, 254);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(153, 50);
            this.iconButton2.TabIndex = 3;
            this.iconButton2.Text = "Ajouter";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // labaleClose
            // 
            this.labaleClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labaleClose.AutoSize = true;
            this.labaleClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F, System.Drawing.FontStyle.Bold);
            this.labaleClose.ForeColor = System.Drawing.Color.Gray;
            this.labaleClose.Location = new System.Drawing.Point(662, 9);
            this.labaleClose.Name = "labaleClose";
            this.labaleClose.Size = new System.Drawing.Size(40, 38);
            this.labaleClose.TabIndex = 32;
            this.labaleClose.Text = "X";
            this.labaleClose.Click += new System.EventHandler(this.labaleClose_Click);
            this.labaleClose.MouseLeave += new System.EventHandler(this.labaleClose_MouseLeave);
            this.labaleClose.MouseHover += new System.EventHandler(this.labaleClose_MouseHover);
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this;
            // 
            // specialite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(714, 720);
            this.Controls.Add(this.labaleClose);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.txtNomSpecialite);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.listSpe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "specialite";
            this.Text = "specialite";
            this.Load += new System.EventHandler(this.specialite_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton iconButton1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNomSpecialite;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Label labaleClose;
        private System.Windows.Forms.ListBox listSpe;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
    }
}