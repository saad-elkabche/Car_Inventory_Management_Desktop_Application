using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MisonVoiApp.Forms
{
    public partial class AddEmp : Form
    {
        public MisonVoiApp.MaisonAutoEntities1 db;
        public int idEmp;
        public AddEmp()
        {
            InitializeComponent();
            new Core.DropShaddow().ApplyShadows(this);
        }
        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar!=(char)Keys.Back)
            {
                e.Handled = true;
            }
            if ( txtPhone.Text.Length >=10 && (char)Keys.Back!=e.KeyChar)
            {
                e.Handled = true;
            }
        }

        private void AddEmp_Load(object sender, EventArgs e)
        {
            cmbSpecia.DataSource = db.specialites.ToList();
            cmbSpecia.DisplayMember = "nomSpecialites";
            cmbSpecia.ValueMember = "idSpec";
        }

        private void btnAjouterCar_Click(object sender, EventArgs e)
        {
            if (btnAjouterCar.Text == "Ajouter")
            {
                Employee emp = new Employee();
                emp.nomCompletEmp = txtNom.Text;
                emp.dateNaissance = DateTime.Parse(naissancePic.Value.ToShortDateString());
                emp.adresse = txtAdresse.Text;
                emp.numberPhone = txtPhone.Text;
                emp.idspecialites = int.Parse(cmbSpecia.SelectedValue.ToString());
                db.Employees.Add(emp);
                db.SaveChanges();
            }
            else
            {
                Employee emp = db.Employees.SingleOrDefault(E => E.idEmployee == idEmp);
                emp.nomCompletEmp = txtNom.Text;
                emp.dateNaissance = DateTime.Parse(naissancePic.Value.ToShortDateString());
                emp.adresse = txtAdresse.Text;
                emp.numberPhone = txtPhone.Text;
                emp.idspecialites = int.Parse(cmbSpecia.SelectedValue.ToString());
                db.SaveChanges();
            }
            this.Close();
        }

        private void labelClose_MouseHover(object sender, EventArgs e)
        {
            this.labelClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.2F, System.Drawing.FontStyle.Bold);

        }

        private void labelClose_MouseLeave(object sender, EventArgs e)
        {
            this.labelClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F, System.Drawing.FontStyle.Bold);

        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
