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
using CrystalDecisions.Windows.Forms;
using MisonVoiApp.reporting.DataSet1TableAdapters;

namespace MisonVoiApp.Forms
{
    public partial class Achat : Form
    {
        SqlConnection con = Connection.con;
        SqlCommand cmd;
        SqlDataReader dr;
        public Achat()
        {
            InitializeComponent();
        }

        private void Achat_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1300, 804);
            fill_data();
        }

        private void fill_data()
        {
            try
            {
                cmd = new SqlCommand("select * from AchatCache",con);
                if (con.State == ConnectionState.Open)
                    con.Close();
                con.Open();
                dr = cmd.ExecuteReader();
                dataGridVentes.Rows.Clear();
                while (dr.Read())
                {
                    dataGridVentes.Rows.Add(dr["idVoiture"], dr["idClient"],  ((DateTime)dr["achatDate"]).ToString("yyyy-MM-dd"), dr["totalAchat"], dr["jrsGarantis"], "Cash");
                }
                dr.Close();
                cmd = new SqlCommand("select * from AchatLoyers", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dataGridVentes.Rows.Add(dr["idVoiture"], dr["idClient"],((DateTime)dr["dateAchat"]).ToString("yyyy-MM-dd"), dr["prixVoiture"], dr["jrsGarantis"], "Dette");
                }
                dr.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }
        }

        private void gunaDateTimePicker5_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand($"select * from AchatCache  where achatDate='{searchPic.Value.ToString("yyyy-MM-dd")}'", con);
                if (con.State == ConnectionState.Open)
                    con.Close();
                con.Open();
                dr = cmd.ExecuteReader();
                dataGridVentes.Rows.Clear();
                while (dr.Read())
                {
                    dataGridVentes.Rows.Add(dr["idVoiture"], dr["idClient"], ((DateTime)dr["achatDate"]).ToString("yyyy-MM-dd"), dr["totalAchat"], dr["jrsGarantis"], "Cash");
                }
                dr.Close();
                cmd = new SqlCommand($"select * from AchatLoyers where dateAchat='{searchPic.Value.ToString("yyyy - MM - dd")}'", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dataGridVentes.Rows.Add(dr["idVoiture"], dr["idClient"], ((DateTime)dr["dateAchat"]).ToString("yyyy-MM-dd"), dr["prixVoiture"], dr["jrsGarantis"], "Dette");
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            fill_data();
        }

        private void btnContrat_Click(object sender, EventArgs e)
        {
            if (dataGridVentes.CurrentRow != null)
            {
                if (dataGridVentes.CurrentRow.Cells[5].Value.ToString() == "Cash")
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

        private void btnDetail_Click(object sender, EventArgs e)
        {
            if (dataGridVentes.CurrentRow != null)
            {
                Cars frm = new Cars();
                frm.idVoi = int.Parse(dataGridVentes.CurrentRow.Cells[0].Value.ToString());
                frm.btnDetailVoiture_Click(null, null);
            }
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            if (dataGridVentes.CurrentRow != null)
            {
                clients cl = new clients();
                cl.db = new AutoClientDBDataContext();
                cl.CIN = dataGridVentes.CurrentRow.Cells[1].Value.ToString();
                cl.iconButton2_Click(null, null);
            }
           
        }

        private void btnTotalRap_Click(object sender, EventArgs e)
        {
            reporting.DataSet1 ds = new reporting.DataSet1();
            diagrammeBarCacheAdapter daD = new diagrammeBarCacheAdapter();
            daD.Fill(ds.diagrammeBarCache);
            reporting.diagram report = new reporting.diagram();
            report.SetDataSource(ds);
            reporting.frmReport frm = new reporting.frmReport();
            (frm.Controls["ReportV"] as CrystalReportViewer).ReportSource = report;
            frm.Show();
            
        }

        private void btnQuantRap_Click(object sender, EventArgs e)
        {
            reporting.DataSet1 ds = new reporting.DataSet1();
            diagrammeDetteAdapter daD = new diagrammeDetteAdapter();
            daD.Fill(ds.diagrammeBarDette);
            reporting.DiagrammeDette report = new reporting.DiagrammeDette();
            report.SetDataSource(ds);
            reporting.frmReport frm = new reporting.frmReport();
            (frm.Controls["ReportV"] as CrystalReportViewer).ReportSource = report;
            frm.Show();
        }
    }
}
