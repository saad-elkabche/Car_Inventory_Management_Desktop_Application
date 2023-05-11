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
    public partial class Maintenance : Form
    {
        DataSet ds;
        SqlDataAdapter daM;
        SqlConnection con = Connection.con;
        public Maintenance()
        {
            InitializeComponent();
        }

        private void Maintenance_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1431, 744);
            fill_data();
        }

        private void fill_data()
        {
            ds = new DataSet();
            daM = new SqlDataAdapter("select maintenance.*,client.nomCompletClient from maintenance join client on maintenance.idClient=CINclient", con);
            daM.Fill(ds, "maintenance");
            dataGridMain.Rows.Clear();
            foreach (DataRow item in ds.Tables["maintenance"].Rows)
            {
                if(item["idVoiture"] is DBNull)
                {
                    dataGridMain.Rows.Add(item["idMaintenance"], item["idVoiture"], item["idClient"], item["nomCompletClient"], ((DateTime)item["dateMintenance"]).ToString("yyyy-MM-dd"),item["totalMain"],"None");
                }
               else
                {
                    dataGridMain.Rows.Add(item["idMaintenance"], item["idVoiture"], item["idClient"], item["nomCompletClient"], ((DateTime)item["dateMintenance"]).ToString("yyyy-MM-dd"), item["totalMain"], "Garantis");
                }
            }
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
          
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            string cin = dataGridMain.CurrentRow.Cells[2].Value.ToString();
            clients frm = new clients();
            frm.CIN = cin;
            frm.db = new AutoClientDBDataContext();
            frm.iconButton2_Click(null, null);
        }

        private void iconButton2_Click_1(object sender, EventArgs e)
        {
            if (dataGridMain.CurrentRow != null)
            {
                if (dataGridMain.CurrentRow.Cells[6].Value.ToString() == "Garantis")
                {
                    int id = (int)(dataGridMain.CurrentRow.Cells[1].Value);
                    Cars frm = new Cars();
                    frm.idVoi = id;
                    frm.btnDetailVoiture_Click(null, null);
                }
                else
                {
                    MessageBox.Show("vous ne pouvez pas voir une voiture avec un type de 'None'");
                }
            }
           
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (dataGridMain.CurrentRow != null)
            {
                int id =(int)(dataGridMain.CurrentRow.Cells[0].Value);
            AddCarForms.DetailEmployees frm = new AddCarForms.DetailEmployees();
                frm.idMain = id;
                frm.StartPosition=FormStartPosition.CenterScreen;
                frm.Show();
            }
            
        }
    }
}
