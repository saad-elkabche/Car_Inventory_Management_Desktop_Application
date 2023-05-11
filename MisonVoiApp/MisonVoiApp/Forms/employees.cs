using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MisonVoiApp;

namespace MisonVoiApp.Forms
{
    public partial class employees : Form
    {
        MisonVoiApp.MaisonAutoEntities1 db;
        public employees()
        {
            InitializeComponent();
        }

        private void btnAddEmp_MouseHover(object sender, EventArgs e)
        {
            (sender as FontAwesome.Sharp.IconButton).IconColor = Color.Black;
            (sender as FontAwesome.Sharp.IconButton).ForeColor = Color.Black;
        }

        private void btnAddEmp_MouseLeave(object sender, EventArgs e)
        {
            (sender as FontAwesome.Sharp.IconButton).IconColor = Color.White;
            (sender as FontAwesome.Sharp.IconButton).ForeColor = Color.White;
        }

        private void achatDebt_MouseHover(object sender, EventArgs e)
        {
            (sender as FontAwesome.Sharp.IconButton).IconColor = Color.FromArgb(0, 151, 167);
            (sender as FontAwesome.Sharp.IconButton).ForeColor = Color.FromArgb(0, 151, 167);

        }

        private void achatDebt_MouseLeave(object sender, EventArgs e)
        {

            (sender as FontAwesome.Sharp.IconButton).IconColor = Color.White;
            (sender as FontAwesome.Sharp.IconButton).ForeColor = Color.White;
        }

        private void employees_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1300, 650);
            fill_data();
        }

        private void fill_data()
        {
            db = new MaisonAutoEntities1();
            var tab = from E in db.Employees select E;
            dataGridEmployees.Rows.Clear();
            foreach (Employee item in tab.ToList())
            {
                dataGridEmployees.Rows.Add(item.idEmployee, item.nomCompletEmp, item.adresse,DateTime.Parse(item.dateNaissance.ToString()).ToString("yyyy-MM-dd"));
            }
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            AddEmp frm = new AddEmp();
            frm.db = this.db;
            frm.ShowDialog();
            fill_data();
        }

        private void btnEditEmp_Click(object sender, EventArgs e)
        {

            if (dataGridEmployees.CurrentRow != null)
            {
                AddEmp frm = new AddEmp();
                frm.btnAjouterCar.Text = "Medifier";
                frm.db = this.db;
                frm.idEmp = int.Parse(dataGridEmployees.CurrentRow.Cells[0].Value.ToString());
                Employee emp = db.Employees.SingleOrDefault(E => E.idEmployee == frm.idEmp);
                frm.txtNom.Text = emp.nomCompletEmp;
                frm.txtAdresse.Text = emp.adresse;
                frm.txtPhone.Text = emp.numberPhone;
                frm.naissancePic.Text = emp.dateNaissance.ToString();
                frm.cmbSpecia.Text = emp.specialite.nomSpecialites;
                frm.ShowDialog();
                fill_data();
            }
        }

        private void btnDeleteEmp_Click(object sender, EventArgs e)
        {
            if (dataGridEmployees.CurrentRow != null)
            {
                if(MessageBox.Show("est ce que tu veux supprimer ce employée", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id =int.Parse(dataGridEmployees.CurrentRow.Cells[0].Value.ToString());
                    db.Employees.Remove(db.Employees.SingleOrDefault(E => E.idEmployee == id));
                    db.SaveChanges();
                    fill_data();
                }
            }
        }

        private void btnDetailEmp_Click(object sender, EventArgs e)
        {
            if (dataGridEmployees.CurrentRow != null)
            {
                AddEmp frm = new AddEmp();
                frm.btnAjouterCar.Visible = false;
                frm.db = this.db;
                frm.idEmp = int.Parse(dataGridEmployees.CurrentRow.Cells[0].Value.ToString());
                Employee emp = db.Employees.SingleOrDefault(E => E.idEmployee == frm.idEmp);
                frm.txtNom.Text = emp.nomCompletEmp;
                frm.txtNom.ReadOnly = true;
                frm.txtAdresse.Text = emp.adresse;
                frm.txtAdresse.ReadOnly = true;
              frm.txtPhone.Text = emp.numberPhone;
                frm.txtPhone.ReadOnly = true;
                frm.naissancePic.Text = emp.dateNaissance.ToString();
                frm.naissancePic.Enabled = false;
                frm.cmbSpecia.Text = emp.specialite.nomSpecialites;
                frm.cmbSpecia.Enabled = false;
                frm.ShowDialog();
                fill_data();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            var tab=(from E in db.Employees where E.nomCompletEmp.Contains(txtSearch.Text) select E).ToList();
            dataGridEmployees.Rows.Clear();
            foreach (Employee item in tab)
            {
                dataGridEmployees.Rows.Add(item.idEmployee, item.nomCompletEmp, item.adresse, DateTime.Parse(item.dateNaissance.ToString()).ToString("yyyy-MM-dd"));
            }
        }

        private void achatDebt_Click(object sender, EventArgs e)
        {
            if (dataGridEmployees.CurrentRow != null)
            {
                MainEmp frm = new MainEmp();
                frm.idEmp = int.Parse(dataGridEmployees.CurrentRow.Cells[0].Value.ToString());
                frm.ShowDialog();
            }
         
        }

        private void Achat_Click(object sender, EventArgs e)
        {
            
        }
    }
}
