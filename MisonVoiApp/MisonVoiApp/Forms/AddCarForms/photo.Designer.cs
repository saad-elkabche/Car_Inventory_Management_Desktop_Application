
namespace MisonVoiApp.Forms.AddCarForms
{
    partial class photo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(photo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pic3 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.browseForPic = new FontAwesome.Sharp.IconButton();
            this.addPic = new FontAwesome.Sharp.IconButton();
            this.MainPic = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainPic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pic3);
            this.panel1.Controls.Add(this.pic2);
            this.panel1.Controls.Add(this.pic1);
            this.panel1.Controls.Add(this.browseForPic);
            this.panel1.Controls.Add(this.addPic);
            this.panel1.Controls.Add(this.MainPic);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MinimumSize = new System.Drawing.Size(990, 625);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(990, 625);
            this.panel1.TabIndex = 9;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // pic3
            // 
            this.pic3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pic3.Location = new System.Drawing.Point(565, 501);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(119, 82);
            this.pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic3.TabIndex = 14;
            this.pic3.TabStop = false;
            this.pic3.Tag = "3";
            this.pic3.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureEdit);
            // 
            // pic2
            // 
            this.pic2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pic2.Location = new System.Drawing.Point(446, 501);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(119, 82);
            this.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic2.TabIndex = 13;
            this.pic2.TabStop = false;
            this.pic2.Tag = "2";
            this.pic2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureEdit);
            // 
            // pic1
            // 
            this.pic1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pic1.Location = new System.Drawing.Point(330, 501);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(119, 82);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic1.TabIndex = 12;
            this.pic1.TabStop = false;
            this.pic1.Tag = "1";
            this.pic1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureEdit);
            // 
            // browseForPic
            // 
            this.browseForPic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.browseForPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(212)))), ((int)(((byte)(217)))));
            this.browseForPic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseForPic.ForeColor = System.Drawing.Color.White;
            this.browseForPic.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.browseForPic.IconColor = System.Drawing.Color.White;
            this.browseForPic.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.browseForPic.IconSize = 30;
            this.browseForPic.Location = new System.Drawing.Point(400, 332);
            this.browseForPic.Name = "browseForPic";
            this.browseForPic.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.browseForPic.Size = new System.Drawing.Size(229, 41);
            this.browseForPic.TabIndex = 11;
            this.browseForPic.Text = "Browse";
            this.browseForPic.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.browseForPic.UseVisualStyleBackColor = false;
            this.browseForPic.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // addPic
            // 
            this.addPic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(212)))), ((int)(((byte)(217)))));
            this.addPic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPic.ForeColor = System.Drawing.Color.White;
            this.addPic.IconChar = FontAwesome.Sharp.IconChar.Images;
            this.addPic.IconColor = System.Drawing.Color.White;
            this.addPic.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addPic.IconSize = 30;
            this.addPic.Location = new System.Drawing.Point(400, 385);
            this.addPic.Name = "addPic";
            this.addPic.Size = new System.Drawing.Size(229, 41);
            this.addPic.TabIndex = 10;
            this.addPic.Text = "Ajouter photo";
            this.addPic.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addPic.UseVisualStyleBackColor = false;
            this.addPic.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // MainPic
            // 
            this.MainPic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MainPic.Image = ((System.Drawing.Image)(resources.GetObject("MainPic.Image")));
            this.MainPic.Location = new System.Drawing.Point(283, 65);
            this.MainPic.Name = "MainPic";
            this.MainPic.Size = new System.Drawing.Size(456, 233);
            this.MainPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MainPic.TabIndex = 9;
            this.MainPic.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // photo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(990, 625);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(990, 625);
            this.Name = "photo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "photo";
            this.Click += new System.EventHandler(this.photo_Click);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton browseForPic;
        private FontAwesome.Sharp.IconButton addPic;
        private System.Windows.Forms.PictureBox MainPic;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.PictureBox pic3;
        public System.Windows.Forms.PictureBox pic2;
        public System.Windows.Forms.PictureBox pic1;
    }
}