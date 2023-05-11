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
    public partial class ventesCli : Form
    {
        SqlConnection con = Connection.con;
        SqlCommand cmd;
        public string idCl;
        public ventesCli()
        {
            InitializeComponent();
            new Core.DropShaddow().ApplyShadows(this);
        }

        private void ventesCli_Load(object sender, EventArgs e)
        {
            filldata();
            if (dataGridVentes.Rows.Count == 0)
            {
                MessageBox.Show("Ce client il n'a pas de vente");
                this.Close();
            }
        }

        private void filldata()
        {
            try
            {
                cmd = new SqlCommand($"select * from AchatCache where idClient='{idCl}'", con);
                if (con.State == ConnectionState.Open)
                    con.Close();
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dataGridVentes.Rows.Add(dr["idVoiture"], DateTime.Parse(dr["achatDate"].ToString()).ToString("yyyy-MM-dd"), dr["totalAchat"], dr["jrsGarantis"], "Cash");
                }
                dr.Close();
                cmd= new SqlCommand($"select * from AchatLoyers where idClient='{idCl}'", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dataGridVentes.Rows.Add(dr["idVoiture"], DateTime.Parse(dr["dateAchat"].ToString()).ToString("yyyy-MM-dd"), dr["prixVoiture"], dr["jrsGarantis"], "Dette");
                }
                dr.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close();}
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            if (dataGridVentes.CurrentRow != null)
            {
                Cars frm = new Cars();
                frm.idVoi = int.Parse(dataGridVentes.CurrentRow.Cells[0].Value.ToString());
                frm.btnDetailVoiture_Click(null, null);
            }
        }

        private void labaleClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void labaleClose_MouseHover(object sender, EventArgs e)
        {
            this.labaleClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.2F, System.Drawing.FontStyle.Bold);

        }

        private void labaleClose_MouseLeave(object sender, EventArgs e)
        {
            this.labaleClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F, System.Drawing.FontStyle.Bold);

        }

        private void btnContrat_Click(object sender, EventArgs e)
        {
            if (dataGridVentes.CurrentRow != null)
            {
                if(dataGridVentes.CurrentRow.Cells[4].Value.ToString()== "Cash")
                {
                    cache frm = new cache();
                    frm.idVoi = int.Parse(dataGridVentes.CurrentRow.Cells[0].Value.ToString());
                    frm.showReport();
                }
                else
                {
                    Adette frm = new Adette();
                    frm.idVoi = int.Parse(dataGridVentes.CurrentRow.Cells[0].Value.ToString());
                    frm.showReport();
                }
            }
        }
    }
}
