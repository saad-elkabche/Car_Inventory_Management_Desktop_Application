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
    public partial class homaPage : Form
    {
        SqlConnection con = Connection.con;
        SqlDataAdapter da;
        public homaPage()
        {
            InitializeComponent();
        }

        private void homaPage_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            da = new SqlDataAdapter("select client.nomCompletClient,SUM (AchatCache.totalAchat ) as [total] from client join AchatCache on AchatCache.idClient=client.CINclient group by client.nomCompletClient", con);
            da.Fill(ds, "cash");
            foreach (DataRow item in ds.Tables["cash"].Rows)
            {
                chCash.Series["cash"].Points.AddXY(item[0], item[1]);
            }

            da = new SqlDataAdapter("select client.nomCompletClient,SUM (AchatLoyers.prixVoiture ) from client join AchatLoyers on AchatLoyers.idClient=client.CINclient group by client.nomCompletClient", con);                da.Fill(ds, "dette");
            foreach (DataRow item in ds.Tables["dette"].Rows)
            {
                chDette.Series["dette"].Points.AddXY(item[0], item[1]);
            }

            SqlCommand cmd = new SqlCommand("select sum(AchatCache.totalAchat) from AchatCache ", con);
            con.Open();
            double toCash= (double)(cmd.ExecuteScalar());
            con.Close();

            cmd = new SqlCommand("select SUM(AchatLoyers.prixVoiture) from AchatLoyers", con);
            con.Open();
            double toDette = (double)(cmd.ExecuteScalar());
            con.Close();


            chartComparison.Series["compar"].Points.AddXY("Cash", toCash);
            chartComparison.Series["compar"].Points.AddXY("Loyers", toDette);
            txtchiff.Text = (toCash + toCash).ToString();
        }

        private void bunifuMetroTextbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
