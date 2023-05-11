using Bunifu.Framework.UI;
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
using MisonVoiApp.reporting.DataSet1TableAdapters;
using CrystalDecisions.Windows.Forms;

namespace MisonVoiApp.Forms
{
    public partial class Adette : Form
    {
        SqlConnection con = Connection.con;
        DataSet ds;
        SqlDataAdapter dac, daF, daVoi, daAch;
        bool start = false;
        double totalTTC = 0;
        public int idVoi;
        public Cars frmCars;
        public Adette()
        {
            InitializeComponent();
            new Core.DropShaddow().ApplyShadows(this);
        }

        private void txtPrix_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar!=(char)Keys.Back && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if(e.KeyChar=='.' && (sender as BunifuMaterialTextbox).Text.Length == 0)
            {
                e.Handled = true;
            }
            if(e.KeyChar=='.' && (sender as BunifuMaterialTextbox).Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void txtNbLoyers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
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

        private void cmbClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbClient.SelectedIndex != -1)
            {
                if (start)
                {
                    DataRow[] row = ds.Tables["client"].Select($"CINclient='{cmbClient.SelectedValue}'");
                    lblCin.Text = row[0]["CINclient"].ToString();
                    lblNom.Text = row[0]["nomCompletClient"].ToString();
                    lblAdresse.Text = row[0]["adresse"].ToString();
                    lbldateN.Text = row[0]["dateNaissance"].ToString();
                    lblMetier.Text = row[0]["occupation"].ToString();
                    if (!(row[0]["photo"] is System.DBNull))
                    {
                        byte[] img = (byte[])row[0]["photo"];
                        clientPicture.Image = Image.FromStream(new MemoryStream(img));
                    }
                    else
                        clientPicture.Image = null;
                }
            }
        }

        private void calculeButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtPrix.Text) && !string.IsNullOrEmpty(txtAppo.Text) && !string.IsNullOrEmpty(txtAssurance.Text) && !string.IsNullOrEmpty(txtNbLoyers.Text))
                {
                    totalTTC = ((Convert.ToDouble(txtPrix.Text) - Convert.ToDouble(txtAppo.Text)) / Convert.ToDouble(txtNbLoyers.Text)) + Convert.ToDouble(txtAssurance.Text);
                    txtresTTC.Text = totalTTC.ToString();
                    int nb = Convert.ToInt32(txtNbLoyers.Text);
                    if (nb <= 30)
                    {
                        txtxCoutGlobal.Text = "4000";
                    }
                    else if (nb <= 50)
                    {
                        txtxCoutGlobal.Text = "6000";
                    }
                    else if (nb <= 60)
                        txtxCoutGlobal.Text = "8000";
                    else if (nb <= 80)
                        txtxCoutGlobal.Text = "1100";
                    else
                    {
                        MessageBox.Show("le nombre du mois est superieur que 80");
                    }
                }
                else
                {
                    MessageBox.Show("entrer les frais en haut");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            frmCars.btnDetailVoiture_Click(null, null);
        }

        private void btnCfr_Click(object sender, EventArgs e)
        {
            calculeButton_Click(null, null);
            try
            {
                if (totalTTC != 0 && cmbClient.Text != "")
                {
                    if (MessageBox.Show("est ce que tu veux confirmer le vente", "queqtion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //insert to achat
                        DataRow row = ds.Tables["dette"].NewRow();
                        row["idClient"] = cmbClient.SelectedValue.ToString();
                        row["idVoiture"] = idVoi;
                        row["dateAchat"] = DateTime.Now;
                        row["prixVoiture"] = Convert.ToDouble(txtPrix.Text);
                        row["ApportClientTTC"] = Convert.ToDouble(txtAppo.Text);
                        row["nbLoyers"] = Convert.ToInt32(txtNbLoyers.Text);
                        row["LoyerTTC"] = Convert.ToDouble(txtresTTC.Text);
                        row["AssurenceMensuelle"] = Convert.ToDouble(txtAssurance.Text);
                        row["coutGlobalTTC"] = Convert.ToDouble(txtxCoutGlobal.Text);
                        row["jrsGarantis"] = Convert.ToInt32(txtNbJour.Text);
                        ds.Tables["dette"].Rows.Add(row);
                        //update status car
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
                        // mise a jour la base de donnee
                        if (con.State == ConnectionState.Open)
                            con.Close();
                        con.Open();
                        //achat table
                        SqlTransaction tran = con.BeginTransaction();
                        try
                        {
                            daAch = new SqlDataAdapter("select * from AchatLoyers", con);
                            daAch.InsertCommand = new SqlCommand("insert into AchatLoyers values(@idcl,@idvoi,@date,@prixvoi,@appoort,@nbLoy,@loyer,@Assur,@coutG,@jrGarantis)", con);
                            daAch.InsertCommand.Parameters.Add("@idcl", SqlDbType.VarChar, 50, "idClient");
                            daAch.InsertCommand.Parameters.Add("@idvoi", SqlDbType.Int, 50, "idVoiture");
                            daAch.InsertCommand.Parameters.Add("@date", SqlDbType.Date, 50, "dateAchat");
                            daAch.InsertCommand.Parameters.Add("@prixvoi", SqlDbType.Float, 50, "prixVoiture");
                            daAch.InsertCommand.Parameters.Add("@appoort", SqlDbType.Float, 50, "ApportClientTTC");
                            daAch.InsertCommand.Parameters.Add("@nbLoy", SqlDbType.Int, 50, "nbLoyers");
                            daAch.InsertCommand.Parameters.Add("@loyer", SqlDbType.Float, 50, "LoyerTTC");
                            daAch.InsertCommand.Parameters.Add("@Assur", SqlDbType.Float, 50, "AssurenceMensuelle");
                            daAch.InsertCommand.Parameters.Add("@coutG", SqlDbType.Float, 50, "coutGlobalTTC");
                            daAch.InsertCommand.Parameters.Add("@jrGarantis", SqlDbType.Int, 50, "jrsGarantis");
                            daAch.InsertCommand.Transaction = tran;
                            daAch.Update(ds, "dette");
                            //voiture table
                            daVoi = new SqlDataAdapter("select * from voiture", con);
                            daVoi.UpdateCommand = new SqlCommand("update voiture set status=@sta where idVoiture=@id", con);
                            daVoi.UpdateCommand.Parameters.Add("sta", SqlDbType.VarChar, 60, "status");
                            daVoi.UpdateCommand.Parameters.Add("@id", SqlDbType.Int, 0, "idVoiture");
                            daVoi.UpdateCommand.Transaction = tran;
                            daVoi.Update(ds, "voiture");
                            tran.Commit();
                        }catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            tran.Rollback();
                        }
                    }
                    else
                        MessageBox.Show("1)-remplir le champ de prix après cliquer sur le bouton de transfert.\n2)-choisir un client.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            showReport();
        }

        public void showReport()
        {
            reporting.DataSet1 ds = new reporting.DataSet1();
            achatLoyersAdapter dalo = new achatLoyersAdapter();
            dalo.Fill(ds.achatLoyers);
            reporting.achatDette report = new reporting.achatDette();
            report.SetDataSource(ds);
            report.SetParameterValue("idVoi", idVoi);
            reporting.frmReport frm = new reporting.frmReport();
            (frm.Controls["ReportV"] as CrystalReportViewer).ReportSource = report;
            frm.ShowDialog();
            this.Close();
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            addClient frm = new addClient();
            frm.db = new AutoClientDBDataContext();
            frm.ShowDialog();
            fill_data();
            cmbClient_SelectedIndexChanged(null, null);
        }

        private void Adette_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1065, 839);
            fill_data();
            cmbClient_SelectedIndexChanged(null, null);
        }

        private void fill_data()
        {
            ds = new DataSet();
            dac= new SqlDataAdapter("select * from client", con);
            dac.Fill(ds, "client");
            daVoi= new SqlDataAdapter("select * from  voiture", con);
            daVoi.Fill(ds, "voiture");
            daAch = new SqlDataAdapter("select * from AchatLoyers", con);
            daAch.Fill(ds, "dette");
            daF=new SqlDataAdapter("select * from frais", con);
            daF.Fill(ds, "frais");
            //cmb
            cmbClient.DataSource = ds.Tables["client"];
            cmbClient.DisplayMember = "nomCompletClient";
            cmbClient.ValueMember = "CINclient";
            start = true;
            //txtBox
            DataRow[] rows = ds.Tables["frais"].Select($"idFrais='{1}'");
            txtAssurance.Text = rows[0]["assurence"].ToString();
            txtNbJour.Text = rows[0]["JrsGarantie"].ToString();
        }
    }
}
