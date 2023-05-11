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

namespace MisonVoiApp.Forms
{
    public partial class MainEmp : Form
    {
        SqlConnection con = Connection.con;
        SqlCommand cmd;
        public int idEmp;
        public MainEmp()
        {
            InitializeComponent();
            new Core.DropShaddow().ApplyShadows(this);
        }

        private void MainEmp_Load(object sender, EventArgs e)
        {
            cmd = new SqlCommand($"select maintenance.dateMintenance as [date de maintenance],maintenance.totalMain from maintenance join detailMaintenanceEmp on detailMaintenanceEmp.idMaintenance=maintenance.idMaintenance where detailMaintenanceEmp.idEmplyee={idEmp}", con);
            try
            {
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    BindingSource bs = new BindingSource();
                    bs.DataSource = dr;
                    dataGridVentes.DataSource = bs;
                }
                else
                {
                    MessageBox.Show("Ce Employees il n'a pas de Maintenance");
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void labaleClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
