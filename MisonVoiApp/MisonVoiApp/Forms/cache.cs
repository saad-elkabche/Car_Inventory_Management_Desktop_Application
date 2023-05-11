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
using Bunifu.Framework.UI;
using CrystalDecisions.Windows.Forms;
using MisonVoiApp.reporting.DataSet1TableAdapters;

namespace MisonVoiApp.Forms
{
    public partial class cache : Form
    {
        SqlConnection con = Connection.con;
        DataSet ds;
        SqlDataAdapter daC;
        SqlDataAdapter daF;
        SqlDataAdapter daAch;
        SqlDataAdapter daVoi;
        
        public Form cars;
        bool start = false;
        byte[] imgClient;
        public int idVoi;
        double total;
        public cache()
        {
            new Core.DropShaddow().ApplyShadows(this);
            InitializeComponent();
        }

        private void cache_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1065, 839);
            fillData();
            cmbClient_SelectedIndexChanged(null, null);
        }

        private void fillData()
        {
            try
            {
                ds = new DataSet();
                daC = new SqlDataAdapter("select * from client", con);
                daF = new SqlDataAdapter("select * from frais", con);
                daAch = new SqlDataAdapter("select * from AchatCache", con);
                daVoi = new SqlDataAdapter("select * from  voiture", con);
                daVoi.Fill(ds, "voiture");
                daAch.Fill(ds, "cache");
                daF.Fill(ds, "frais");
                daC.Fill(ds, "client");
                DataRow[] dr = ds.Tables["frais"].Select($"idfrais='{1}'");
                txtRemise.Text = dr[0][1].ToString();
                txtFrais.Text = dr[0][2].ToString();
                txtAutre.Text = dr[0][3].ToString();
                txtGarantis.Text = dr[0][4].ToString();
                cmbClient.DataSource = ds.Tables["client"];
                cmbClient.DisplayMember = "nomCompletClient";
                cmbClient.ValueMember = "CINclient";
            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message);
            }
            start = true;
        }

        private void cmbClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbClient.SelectedIndex != -1)
                {
                    if (start)
                    {
                        DataRow[] dr = ds.Tables["client"].Select($"CINclient='{cmbClient.SelectedValue}'");
                        lblCin.Text = dr[0]["CINclient"].ToString();
                        lblNom.Text = dr[0]["nomCompletClient"].ToString();
                        lbldateN.Text = ((DateTime)dr[0]["dateNaissance"]).ToString("MM/dd/yyyy");
                        lblMetier.Text = dr[0]["occupation"].ToString();
                        lblAdresse.Text = dr[0]["adresse"].ToString();
                        if (!(dr[0][6] is System.DBNull))
                        {
                            imgClient = (byte[])dr[0][6];
                            pictureBox1.Image = Image.FromStream(new MemoryStream(imgClient));
                        }
                        else
                        {
                            pictureBox1.Image = null;
                        }
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            try
            {
                addClient frm = new addClient();
                frm.db = new AutoClientDBDataContext();
                frm.ShowDialog();
                fillData();
                cmbClient_SelectedIndexChanged(null, null);
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
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

       

        private void txtPrix_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.' )
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && (sender as BunifuMaterialTextbox).Text.Length == 0)
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && (sender as BunifuMaterialTextbox).Text.Contains("."))
            {
                e.Handled = true;
            }
         
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtPrix.Text) && !string.IsNullOrEmpty(txtFrais.Text) && !string.IsNullOrEmpty(txtAutre.Text) && !string.IsNullOrEmpty(txtRemise.Text))
                {
                    total = (Convert.ToDouble(txtPrix.Text) + Convert.ToDouble(txtFrais.Text) + Convert.ToDouble(txtAutre.Text)) + Convert.ToDouble(txtRemise.Text);
                    lblTotal.Text = total + "(DH)";
                }
                else
                {
                    MessageBox.Show("entrer les frais en haut");
                }
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            (cars as Forms.Cars).btnDetailVoiture_Click(null, null);
        }

        private void btnCfr_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbClient.Text != "" && total != 0)
                {
                    if (MessageBox.Show("est ce que tu veux confirmer le vente", "queqtion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DataRow row = ds.Tables["cache"].NewRow();
                        row["idClient"] = cmbClient.SelectedValue.ToString();
                        row["idVoiture"] = this.idVoi;
                        row["achatDate"] = DateTime.Now;
                        row["remisePromotionelle"] = Convert.ToDouble(txtRemise.Text);
                        row["fraisMatriculation"] = Convert.ToDouble(txtFrais.Text);
                        row["autreFrais"] = Convert.ToDouble(txtAutre.Text);
                        row["totalAchat"] = total;
                        row["jrsGarantis"] = int.Parse(txtGarantis.Text);
                        ds.Tables["cache"].Rows.Add(row);
                        foreach (DataRow item in ds.Tables["voiture"].Rows)
                        {
                            if (item.RowState != DataRowState.Deleted)
                            {
                                if (item["idVoiture"].ToString() == idVoi.ToString())
                                {
                                    item["status"] = "Indisponible";
                                    break;
                                }
                            }
                        }

                        if (!Excute())
                        {
                            return;
                        }
                        showReport();
                        foreach (DataRow item in ds.Tables["frais"].Rows)
                        {
                            item[1] = Convert.ToDouble(txtRemise.Text);
                            item[2] = Convert.ToDouble(txtFrais.Text);
                            item[3] = Convert.ToDouble(txtAutre.Text);
                            item[4] = Convert.ToInt32(txtGarantis.Text);
                        }
                        daF = new SqlDataAdapter("select * from frais", con);
                        SqlCommandBuilder sbf = new SqlCommandBuilder(daF);
                        daF.Update(ds, "frais");
                        this.Close();
                    }
                }
                else
                    MessageBox.Show("1)-remplir le champ de prix après cliquer sur le bouton de transfert.\n2)-choisir un client.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void showReport()
        {
            try
            {
                reporting.DataSet1 dsT = new reporting.DataSet1();
                achatCacheAdapter daCach = new achatCacheAdapter();
                daCach.Fill(dsT.achatCache);
                reporting.achatCache report = new reporting.achatCache();
                report.SetDataSource(dsT);
                report.SetParameterValue("idVoi", idVoi);
                reporting.frmReport frm = new reporting.frmReport();
                (frm.Controls["reportV"] as CrystalReportViewer).ReportSource = report;
                frm.ShowDialog();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        bool Excute()
        {
            bool resul = false;

            con.Open();
            SqlTransaction tran = con.BeginTransaction();
          
            try
            {
                daC = new SqlDataAdapter("select * from AchatCache", con);
                daC.InsertCommand = new SqlCommand("insert into AchatCache values(@idcl,@idvoi,@date,@remise,@matric,@autre,@total,@jrs)", con);
                daC.InsertCommand.Transaction = tran;
                daC.InsertCommand.Parameters.Add("@idcl", SqlDbType.VarChar, 50, "idClient");
                daC.InsertCommand.Parameters.Add("@idvoi", SqlDbType.Int, 0, "idVoiture");
                daC.InsertCommand.Parameters.Add("@date", SqlDbType.Date, 0, "achatDate");
                daC.InsertCommand.Parameters.Add("@remise", SqlDbType.Float, 0, "remisePromotionelle");
                daC.InsertCommand.Parameters.Add("@matric", SqlDbType.Float, 0, "fraisMatriculation");
                daC.InsertCommand.Parameters.Add("@autre", SqlDbType.Float, 0, "autreFrais");
                daC.InsertCommand.Parameters.Add("@total", SqlDbType.Float, 0, "totalAchat");
                daC.InsertCommand.Parameters.Add("@jrs", SqlDbType.Int, 0, "jrsGarantis");
                daC.Update(ds, "cache");
                //voiture
                daVoi = new SqlDataAdapter("select * from  voiture", con);
                daVoi.UpdateCommand = new SqlCommand("update voiture set status='Indisponible' where idVoiture=@idvoi", con);
                daVoi.UpdateCommand.Transaction = tran;
                daVoi.UpdateCommand.Parameters.Add("idvoi", SqlDbType.Int, 0, "idVoiture");
                try
                {
                    daVoi.Update(ds, "voiture");
                    tran.Commit();
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                resul = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("transaction est invalide (" + ex.Message + ")");
                tran.Rollback();
                resul = false;
            }
            finally { con.Close(); }
            return resul;
        }

        private void cmbClient_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void lblAdresse_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void lblMetier_Click(object sender, EventArgs e)
        {

        }

        private void lbldateN_Click(object sender, EventArgs e)
        {

        }

        private void lblNom_Click(object sender, EventArgs e)
        {

        }

        private void lblCin_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void bunifuSeparator1_Load(object sender, EventArgs e)
        {

        }

        private void txtRemise_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.' && e.KeyChar!='-')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && txtRemise.Text.Length == 0)
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && txtRemise.Text.Contains("."))
            {
                e.Handled = true;
            }
            if(e.KeyChar=='-'&& txtRemise.Text.Length != 0)
            {
                e.Handled = true;
            }
        }
    }
}
