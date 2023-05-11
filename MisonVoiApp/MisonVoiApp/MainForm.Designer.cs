
namespace MisonVoiApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.btnAdmin = new FontAwesome.Sharp.IconButton();
            this.btnAchat = new FontAwesome.Sharp.IconButton();
            this.btnMaintenance = new FontAwesome.Sharp.IconButton();
            this.btnEmployees = new FontAwesome.Sharp.IconButton();
            this.btnClients = new FontAwesome.Sharp.IconButton();
            this.btnVoiture = new FontAwesome.Sharp.IconButton();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.btnMaxMin = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.frmPanel = new System.Windows.Forms.Panel();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.MaintenanceContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.maintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterReparationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.piècesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EmployeeContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.employeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spécialitéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MenuPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.titlePanel.SuspendLayout();
            this.MaintenanceContext.SuspendLayout();
            this.EmployeeContext.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(111)))));
            this.MenuPanel.Controls.Add(this.label3);
            this.MenuPanel.Controls.Add(this.iconPictureBox2);
            this.MenuPanel.Controls.Add(this.iconPictureBox1);
            this.MenuPanel.Controls.Add(this.label2);
            this.MenuPanel.Controls.Add(this.btnAdmin);
            this.MenuPanel.Controls.Add(this.btnAchat);
            this.MenuPanel.Controls.Add(this.btnMaintenance);
            this.MenuPanel.Controls.Add(this.btnEmployees);
            this.MenuPanel.Controls.Add(this.btnClients);
            this.MenuPanel.Controls.Add(this.btnVoiture);
            this.MenuPanel.Controls.Add(this.btnHome);
            this.MenuPanel.Controls.Add(this.panel2);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(328, 871);
            this.MenuPanel.TabIndex = 0;
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(198)))), ((int)(((byte)(203)))));
            this.btnAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            this.btnAdmin.IconColor = System.Drawing.Color.Black;
            this.btnAdmin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdmin.IconSize = 60;
            this.btnAdmin.Location = new System.Drawing.Point(0, 691);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(328, 100);
            this.btnAdmin.TabIndex = 7;
            this.btnAdmin.Text = " Administrateur";
            this.btnAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            this.btnAdmin.MouseLeave += new System.EventHandler(this.btnAdmin_MouseLeave);
            this.btnAdmin.MouseHover += new System.EventHandler(this.menuMouseHouver);
            // 
            // btnAchat
            // 
            this.btnAchat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(198)))), ((int)(((byte)(203)))));
            this.btnAchat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAchat.FlatAppearance.BorderSize = 0;
            this.btnAchat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAchat.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAchat.IconChar = FontAwesome.Sharp.IconChar.Donate;
            this.btnAchat.IconColor = System.Drawing.Color.Black;
            this.btnAchat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAchat.IconSize = 60;
            this.btnAchat.Location = new System.Drawing.Point(0, 591);
            this.btnAchat.Name = "btnAchat";
            this.btnAchat.Size = new System.Drawing.Size(328, 100);
            this.btnAchat.TabIndex = 8;
            this.btnAchat.Text = "         Ventes ";
            this.btnAchat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAchat.UseVisualStyleBackColor = false;
            this.btnAchat.Click += new System.EventHandler(this.btnAchat_Click);
            this.btnAchat.MouseLeave += new System.EventHandler(this.btnAdmin_MouseLeave);
            this.btnAchat.MouseHover += new System.EventHandler(this.menuMouseHouver);
            // 
            // btnMaintenance
            // 
            this.btnMaintenance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(198)))), ((int)(((byte)(203)))));
            this.btnMaintenance.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMaintenance.FlatAppearance.BorderSize = 0;
            this.btnMaintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaintenance.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaintenance.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.btnMaintenance.IconColor = System.Drawing.Color.Black;
            this.btnMaintenance.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaintenance.IconSize = 60;
            this.btnMaintenance.Location = new System.Drawing.Point(0, 491);
            this.btnMaintenance.Name = "btnMaintenance";
            this.btnMaintenance.Size = new System.Drawing.Size(328, 100);
            this.btnMaintenance.TabIndex = 6;
            this.btnMaintenance.Text = "    Maintenance";
            this.btnMaintenance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMaintenance.UseVisualStyleBackColor = false;
            this.btnMaintenance.Click += new System.EventHandler(this.btnMaintenance_Click);
            this.btnMaintenance.MouseLeave += new System.EventHandler(this.btnAdmin_MouseLeave);
            this.btnMaintenance.MouseHover += new System.EventHandler(this.menuMouseHouver);
            // 
            // btnEmployees
            // 
            this.btnEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(198)))), ((int)(((byte)(203)))));
            this.btnEmployees.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmployees.FlatAppearance.BorderSize = 0;
            this.btnEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployees.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployees.IconChar = FontAwesome.Sharp.IconChar.UserAstronaut;
            this.btnEmployees.IconColor = System.Drawing.Color.Black;
            this.btnEmployees.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEmployees.IconSize = 60;
            this.btnEmployees.Location = new System.Drawing.Point(0, 391);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(328, 100);
            this.btnEmployees.TabIndex = 5;
            this.btnEmployees.Text = "     Employées";
            this.btnEmployees.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmployees.UseVisualStyleBackColor = false;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            this.btnEmployees.MouseLeave += new System.EventHandler(this.btnAdmin_MouseLeave);
            this.btnEmployees.MouseHover += new System.EventHandler(this.menuMouseHouver);
            // 
            // btnClients
            // 
            this.btnClients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(198)))), ((int)(((byte)(203)))));
            this.btnClients.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClients.FlatAppearance.BorderSize = 0;
            this.btnClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClients.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClients.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.btnClients.IconColor = System.Drawing.Color.Black;
            this.btnClients.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClients.IconSize = 60;
            this.btnClients.Location = new System.Drawing.Point(0, 291);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(328, 100);
            this.btnClients.TabIndex = 4;
            this.btnClients.Text = "       Clients";
            this.btnClients.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClients.UseVisualStyleBackColor = false;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            this.btnClients.MouseLeave += new System.EventHandler(this.btnAdmin_MouseLeave);
            this.btnClients.MouseHover += new System.EventHandler(this.menuMouseHouver);
            // 
            // btnVoiture
            // 
            this.btnVoiture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(198)))), ((int)(((byte)(203)))));
            this.btnVoiture.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVoiture.FlatAppearance.BorderSize = 0;
            this.btnVoiture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoiture.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoiture.IconChar = FontAwesome.Sharp.IconChar.Car;
            this.btnVoiture.IconColor = System.Drawing.Color.Black;
            this.btnVoiture.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVoiture.IconSize = 60;
            this.btnVoiture.Location = new System.Drawing.Point(0, 191);
            this.btnVoiture.Name = "btnVoiture";
            this.btnVoiture.Size = new System.Drawing.Size(328, 100);
            this.btnVoiture.TabIndex = 3;
            this.btnVoiture.Text = "     Voitures";
            this.btnVoiture.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoiture.UseVisualStyleBackColor = false;
            this.btnVoiture.Click += new System.EventHandler(this.btnVoiture_Click);
            this.btnVoiture.MouseLeave += new System.EventHandler(this.btnAdmin_MouseLeave);
            this.btnVoiture.MouseHover += new System.EventHandler(this.menuMouseHouver);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(198)))), ((int)(((byte)(203)))));
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnHome.IconColor = System.Drawing.Color.Black;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.IconSize = 60;
            this.btnHome.Location = new System.Drawing.Point(0, 91);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(328, 100);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "     Home";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            this.btnHome.MouseLeave += new System.EventHandler(this.btnAdmin_MouseLeave);
            this.btnHome.MouseHover += new System.EventHandler(this.menuMouseHouver);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(328, 91);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "YourCar company";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(72, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(111)))));
            this.titlePanel.Controls.Add(this.iconButton3);
            this.titlePanel.Controls.Add(this.iconButton2);
            this.titlePanel.Controls.Add(this.iconButton1);
            this.titlePanel.Controls.Add(this.btnMaxMin);
            this.titlePanel.Controls.Add(this.btnClose);
            this.titlePanel.Controls.Add(this.lblTitle);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(328, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(1348, 91);
            this.titlePanel.TabIndex = 1;
            // 
            // btnMaxMin
            // 
            this.btnMaxMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaxMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMaxMin.FlatAppearance.BorderSize = 0;
            this.btnMaxMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaxMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaxMin.ForeColor = System.Drawing.Color.White;
            this.btnMaxMin.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.btnMaxMin.IconColor = System.Drawing.Color.White;
            this.btnMaxMin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaxMin.IconSize = 25;
            this.btnMaxMin.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMaxMin.Location = new System.Drawing.Point(1266, 1);
            this.btnMaxMin.Name = "btnMaxMin";
            this.btnMaxMin.Size = new System.Drawing.Size(40, 30);
            this.btnMaxMin.TabIndex = 2;
            this.btnMaxMin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMaxMin.UseVisualStyleBackColor = false;
            this.btnMaxMin.Click += new System.EventHandler(this.btnMaxMin_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnClose.IconColor = System.Drawing.Color.Bisque;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.Location = new System.Drawing.Point(1307, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 30);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(605, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(130, 51);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Home";
            // 
            // frmPanel
            // 
            this.frmPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frmPanel.Location = new System.Drawing.Point(328, 91);
            this.frmPanel.Name = "frmPanel";
            this.frmPanel.Size = new System.Drawing.Size(1348, 780);
            this.frmPanel.TabIndex = 2;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.titlePanel;
            // 
            // MaintenanceContext
            // 
            this.MaintenanceContext.AutoSize = false;
            this.MaintenanceContext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(198)))), ((int)(((byte)(203)))));
            this.MaintenanceContext.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaintenanceContext.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MaintenanceContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maintenanceToolStripMenuItem,
            this.ajouterReparationToolStripMenuItem,
            this.piècesToolStripMenuItem});
            this.MaintenanceContext.Name = "MaintenanceContext";
            this.MaintenanceContext.ShowImageMargin = false;
            this.MaintenanceContext.Size = new System.Drawing.Size(250, 160);
            // 
            // maintenanceToolStripMenuItem
            // 
            this.maintenanceToolStripMenuItem.Name = "maintenanceToolStripMenuItem";
            this.maintenanceToolStripMenuItem.Size = new System.Drawing.Size(221, 30);
            this.maintenanceToolStripMenuItem.Text = "Maintenance";
            this.maintenanceToolStripMenuItem.Click += new System.EventHandler(this.maintenanceToolStripMenuItem_Click);
            // 
            // ajouterReparationToolStripMenuItem
            // 
            this.ajouterReparationToolStripMenuItem.Name = "ajouterReparationToolStripMenuItem";
            this.ajouterReparationToolStripMenuItem.Size = new System.Drawing.Size(221, 30);
            this.ajouterReparationToolStripMenuItem.Text = "Ajouter Reparation";
            this.ajouterReparationToolStripMenuItem.Click += new System.EventHandler(this.ajouterReparationToolStripMenuItem_Click);
            // 
            // piècesToolStripMenuItem
            // 
            this.piècesToolStripMenuItem.Name = "piècesToolStripMenuItem";
            this.piècesToolStripMenuItem.Size = new System.Drawing.Size(221, 30);
            this.piècesToolStripMenuItem.Text = "Pièces";
            this.piècesToolStripMenuItem.Click += new System.EventHandler(this.piècesToolStripMenuItem_Click);
            // 
            // EmployeeContext
            // 
            this.EmployeeContext.AutoSize = false;
            this.EmployeeContext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(198)))), ((int)(((byte)(203)))));
            this.EmployeeContext.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeContext.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.EmployeeContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeesToolStripMenuItem,
            this.spécialitéToolStripMenuItem});
            this.EmployeeContext.Name = "EmployeeContext";
            this.EmployeeContext.ShowImageMargin = false;
            this.EmployeeContext.Size = new System.Drawing.Size(200, 100);
            // 
            // employeesToolStripMenuItem
            // 
            this.employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            this.employeesToolStripMenuItem.Size = new System.Drawing.Size(151, 30);
            this.employeesToolStripMenuItem.Text = "Employées";
            this.employeesToolStripMenuItem.Click += new System.EventHandler(this.employeesToolStripMenuItem_Click);
            // 
            // spécialitéToolStripMenuItem
            // 
            this.spécialitéToolStripMenuItem.Name = "spécialitéToolStripMenuItem";
            this.spécialitéToolStripMenuItem.Size = new System.Drawing.Size(151, 30);
            this.spécialitéToolStripMenuItem.Text = "spécialité";
            this.spécialitéToolStripMenuItem.Click += new System.EventHandler(this.spécialitéToolStripMenuItem_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton1.BackColor = System.Drawing.Color.Transparent;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Facebook;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 35;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton1.Location = new System.Drawing.Point(1262, 49);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(40, 39);
            this.iconButton1.TabIndex = 3;
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // iconButton2
            // 
            this.iconButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton2.BackColor = System.Drawing.Color.Transparent;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Instagram;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 35;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton2.Location = new System.Drawing.Point(1308, 49);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(40, 39);
            this.iconButton2.TabIndex = 4;
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // iconButton3
            // 
            this.iconButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton3.BackColor = System.Drawing.Color.Transparent;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.ForeColor = System.Drawing.Color.White;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Youtube;
            this.iconButton3.IconColor = System.Drawing.Color.White;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 35;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton3.Location = new System.Drawing.Point(1216, 49);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(40, 39);
            this.iconButton3.TabIndex = 5;
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconButton3.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(97, 806);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "developed by saad Dev";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Desktop;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.Location = new System.Drawing.Point(59, 803);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox1.TabIndex = 9;
            this.iconPictureBox1.TabStop = false;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.iconPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Copyright;
            this.iconPictureBox2.IconColor = System.Drawing.Color.White;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 29;
            this.iconPictureBox2.Location = new System.Drawing.Point(3, 839);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(32, 29);
            this.iconPictureBox2.TabIndex = 10;
            this.iconPictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(35, 844);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "copyright";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1676, 871);
            this.Controls.Add(this.frmPanel);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.MenuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1676, 871);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.MaintenanceContext.ResumeLayout(false);
            this.EmployeeContext.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Panel frmPanel;
        private FontAwesome.Sharp.IconButton btnHome;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private FontAwesome.Sharp.IconButton btnAdmin;
        private FontAwesome.Sharp.IconButton btnMaintenance;
        private FontAwesome.Sharp.IconButton btnEmployees;
        private FontAwesome.Sharp.IconButton btnClients;
        private FontAwesome.Sharp.IconButton btnVoiture;
        private System.Windows.Forms.ContextMenuStrip MaintenanceContext;
        private System.Windows.Forms.ToolStripMenuItem maintenanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterReparationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem piècesToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip EmployeeContext;
        private System.Windows.Forms.ToolStripMenuItem employeesToolStripMenuItem;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ToolStripMenuItem spécialitéToolStripMenuItem;
        private FontAwesome.Sharp.IconButton btnMaxMin;
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton btnAchat;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}