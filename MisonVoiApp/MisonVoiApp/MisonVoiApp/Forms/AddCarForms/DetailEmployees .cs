using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MisonVoiApp.Forms.AddCarForms
{
    
    public partial class DetailEmployees : Form
    {
        public  int idMain;
        SqlDataAdapter das;
        SqlConnection con = Connection.con;
        DataSet ds;
        public DetailEmployees()
        {
            InitializeComponent();
            new Core.DropShaddow().ApplyShadows(this);
        }

        private void DetailEmployees_Load(object sender, EventArgs e)
        {
            ds = new DataSet();
            das = new SqlDataAdapter($"select Employees.nomCompletEmp,Employees.dateNaissance,Employees.adresse,Employees.numberPhone,specialites.nomSpecialites from Employees join detailMaintenanceEmp on detailMaintenanceEmp.idEmplyee=Employees.idEmployee join specialites on Employees.idspecialites=specialites.idSpec where detailMaintenanceEmp.idMaintenance={idMain}", con);
            das.Fill(ds, "maint");
            if (ds.Tables["maint"].Rows.Count != 0)
            {
                dataGridMain.DataSource = ds.Tables["maint"];
            }
            else
            {
                MessageBox.Show("no amployees here");
                this.Close();
            }
        }

        private void labaleClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
