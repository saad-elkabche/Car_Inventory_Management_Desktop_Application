using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MisonVoiApp
{
    public partial class MainForm : Form
    {
        Form CurrntForm;
        IconButton currentBtn;
        public MainForm()
        {
            InitializeComponent();
        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.employees emp = new Forms.employees();
            open_form(emp,btnEmployees);
        }

        private void btnVoiture_Click(object sender, EventArgs e)
        {
            Forms.Cars car = new Forms.Cars();
            open_form(car,sender);
        }
        void open_form(Form frm,object sender)
        {
            if (frm != CurrntForm)
            {
                if (CurrntForm != null)
                    CurrntForm.Close();
                frmPanel.Controls.Clear();
                lblTitle.Text = (sender as FontAwesome.Sharp.IconButton).Text;
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frmPanel.Controls.Add(frm);
                clickedButton(sender);
                frm.Show();
            }
          
            
        }

        private void clickedButton(object sender)
        {
            foreach (IconButton item in MenuPanel.Controls.OfType< IconButton>())
            {
                item.TextImageRelation = TextImageRelation.ImageBeforeText;
                item.IconSize = 60;
                item.IconColor = Color.Black;
                item.ForeColor = Color.Black;
            }
            FontAwesome.Sharp.IconButton btn = (sender as FontAwesome.Sharp.IconButton);
            btn.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn.IconSize = 65;
            btn.ForeColor = Color.White;
            btn.IconColor = Color.White;
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            Forms.clients cl = new Forms.clients();
            open_form(cl,sender);
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            EmployeeContext.Show(btnEmployees, btnEmployees.Width, 0);
           
        }

        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            MaintenanceContext.Show(btnMaintenance, btnMaintenance.Width, 0);
        }

        private void maintenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Maintenance frmMain = new Forms.Maintenance();
            open_form(frmMain,btnMaintenance);
        }

        private void ajouterReparationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.AddCarForms.AddMaintenance frm = new Forms.AddCarForms.AddMaintenance();
            open_form(frm, btnMaintenance) ;
        }

        private void piècesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.AddCarForms.Piece p = new Forms.AddCarForms.Piece();
            open_form(p, btnMaintenance);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1876, 871);
        }

        private void menuMouseHouver(object sender, EventArgs e)
        {

            IconButton btn = sender as IconButton;
            if (btn.TextImageRelation != TextImageRelation.TextBeforeImage)
            {
                btn.Font = new System.Drawing.Font("Impact", 19.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btn.ForeColor = Color.White;
                btn.IconColor = Color.White;
                btn.IconSize = 68;
            }
           
        }

        private void btnAdmin_MouseLeave(object sender, EventArgs e)
        {
            IconButton btn = sender as IconButton;
            if (btn.TextImageRelation != TextImageRelation.TextBeforeImage)
            {
                
                btn.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btn.ForeColor = Color.Black;
                btn.IconColor = Color.Black;
                btn.IconSize = 60;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaxMin_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.Size = new Size(1676, 871);
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
         
        }

        private void spécialitéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (IconButton item in MenuPanel.Controls.OfType<IconButton>())
            {
                if (item.TextImageRelation == TextImageRelation.TextBeforeImage)
                {
                    currentBtn = item;
                    break;
                }
            }
            clickedButton(btnEmployees);
            Forms.specialite frm = new Forms.specialite();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            if(currentBtn!=null)
                clickedButton(currentBtn);
            else
            {
                btnEmployees.TextImageRelation = TextImageRelation.ImageBeforeText;
                btnEmployees.IconSize = 60;
                btnEmployees.IconColor = Color.Black;
                btnEmployees.ForeColor = Color.Black;
            }

        }
    }
}
