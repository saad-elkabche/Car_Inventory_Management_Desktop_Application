using Guna.UI.WinForms;
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
using MisonVoiApp.reporting.DataSet1TableAdapters;
using CrystalDecisions.Windows.Forms;

namespace MisonVoiApp.Forms.AddCarForms
{
    public partial class AddMaintenance : Form
    {
        SqlConnection con = Connection.con;
        SqlCommand cmd;
        SqlDataReader dr;
        BindingSource bs;
        AutoClientDBDataContext db;
        bool startReport = false;
        int idMain;
        bool start = false,substart=false;
        public AddMaintenance()
        {
            InitializeComponent();
            this.Size = new Size(1431, 744);
        }

        private void AddMaintenance_Load(object sender, EventArgs e)
        {
            fill_cmbs();
            start = true;
            cmbVoture_SelectedIndexChanged(null, null);
            CmbSpecialist_SelectedIndexChanged(null, null);
        }

        private void fill_cmbs()
        {
            Connection.close_connection();
            try
            {
                cmd = new SqlCommand(@"select  voiture.idVoiture,voiture.modele from voiture", con);
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    bs = new BindingSource();
                    bs.DataSource = dr;
                    cmbVoture.DataSource = bs;
                    cmbVoture.DisplayMember = "modele";
                    cmbVoture.ValueMember = "idVoiture";
                }
                con.Close();

                cmd = new SqlCommand("select * from specialites", con);
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    bs = new BindingSource();
                    bs.DataSource = dr;
                    CmbSpecialist.DataSource = bs;
                    CmbSpecialist.DisplayMember = "nomSpecialites";
                    CmbSpecialist.ValueMember = "idSpec";
                }
           
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            db = new AutoClientDBDataContext();
            cmbClient.DataSource = db.clients;
            cmbClient.DisplayMember = "CINclient";
        }

        private void cmbVoture_SelectedIndexChanged(object sender, EventArgs e)
        {
            Connection.close_connection();
            if (start)
            {
                if (cmbVoture.SelectedIndex != -1)
                {
                    substart = false;
                    try
                    {
                        cmd = new SqlCommand($"select * from piece where idVoiture={int.Parse(cmbVoture.SelectedValue.ToString())}", con);
                        con.Open();
                        dr = cmd.ExecuteReader();
                        if (dr.HasRows)
                        {
                            BindingSource bs = new BindingSource();
                            bs.DataSource = dr;
                            cmbNomPiece.DataSource = bs;
                            cmbNomPiece.DisplayMember = "nomPiece";
                            cmbNomPiece.ValueMember="idPiece";
                            substart = true;
                            cmbNomPiece_SelectedIndexChanged(null, null);
                        }
                        else
                        {
                            cmbNomPiece.DataSource = null;
                        }
                    }catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally { con.Close(); }
                }
            }
        }

        private void CmbSpecialist_SelectedIndexChanged(object sender, EventArgs e)
        {
            Connection.close_connection();
            if (start)
            {
                if (CmbSpecialist.SelectedIndex != -1)
                {
                    try
                    {
                        cmd = new SqlCommand($"select * from Employees where Employees.idspecialites={int.Parse(CmbSpecialist.SelectedValue.ToString())}", con);
                        con.Open();
                        DataTable dt = new DataTable();
                        dt.Load(cmd.ExecuteReader());
                        if (dt.Rows.Count != 0)
                        {
                            cmbNomEmp.DataSource = dt;
                            cmbNomEmp.DisplayMember = "nomCompletEmp";
                            cmbNomEmp.ValueMember = "idEmployee";
                        }
                        else
                        {
                            cmbNomEmp.DataSource = null;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally { con.Close(); }
               
                }
            }
        }

        private void chGarantis_CheckedChanged(object sender, EventArgs e)
        {
            if (chGarantis.Checked)
            {
                foreach (Control item in grpGara.Controls)
                {
                    item.Enabled = true;
                }
            }
            else
            {
                foreach (Control item in grpGara.Controls)
                {
                    if(item is GunaGoogleSwitch || item is Label)
                    {
                        continue;
                    }
                    item.Enabled = false;
                }
            }
        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            Connection.close_connection();
            bool findVente = false;
            if (!string.IsNullOrEmpty(txtNVente.Text))
            {
                try
                {
                    cmd = new SqlCommand($"select jrsGarantis,achatDate from AchatCache  where idVoiture={txtNVente.Text}", con);
                    con.Open();
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        if (dr.Read())
                        {
                            findVente = true;
                            DateTime date = ((DateTime)dr["achatDate"]).AddDays(Convert.ToDouble(dr["jrsGarantis"]));
                            txtRestJour.Text = date.ToString("yyyy-MM-dd");

                        }
                        dr.Close();
                    }
                    else
                    {
                        cmd = new SqlCommand($"select jrsGarantis,dateAchat from AchatLoyers where idVoiture={int.Parse(txtNVente.Text)}", con);
                        if (con.State == ConnectionState.Open)
                            con.Close();
                        con.Open();
                        dr = cmd.ExecuteReader();
                        if (dr.HasRows)
                        {
                            if (dr.Read())
                            {
                                findVente = true;
                                DateTime date = ((DateTime)dr["dateAchat"]).AddDays(Convert.ToDouble(dr["jrsGarantis"]));
                                txtRestJour.Text = date.ToString("yyyy-MM-dd");
                               
                            }
                            dr.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                        con.Close();
                }
                if (!findVente)
                {
                    MessageBox.Show("nous n'avons pas de vente avec ce N° : " + txtNVente.Text);
                }
            }

        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            addClient frm = new addClient();
            frm.btnAjouterCar.Text = "Ajouter";
            frm.db = this.db;
            frm.ShowDialog();
            fill_cmbs();
        }

        private void AddPiece_Click(object sender, EventArgs e)
        {
            if (cmbNomPiece.SelectedIndex != -1 && txtQuantiti.Text!="")
            {
                foreach (DataGridViewRow item in datagridPiece.Rows)
                {
                    if (cmbNomPiece.SelectedValue.ToString() == item.Cells[0].Value.ToString())
                    {
                        MessageBox.Show("ce pièce est deja existe");
                        return;
                    }
                }
                int idPiece = int.Parse(cmbNomPiece.SelectedValue.ToString());
                int qPiece = int.Parse(txtQuantiti.Text);
                if (quantiPiece(idPiece, qPiece) > 0)
                {
                    double sum = 0;
                    datagridPiece.Rows.Add(cmbNomPiece.SelectedValue, cmbNomPiece.Text,txtQuantiti.Text, TxtPrixPiece.Text, cmbVoture.Text);
                    foreach (DataGridViewRow item in datagridPiece.Rows)
                    {
                        sum += (Convert.ToDouble(item.Cells[3].Value)*int.Parse(item.Cells[2].Value.ToString()));
                    }
                    txtTotal.Text = sum.ToString();
                    if (quantiPiece(idPiece, qPiece) < 20)
                    {
                        MessageBox.Show($"vous n'en avez que {quantiPiece(idPiece, qPiece)} en stock");
                    }
                }
                else
                {
                    MessageBox.Show("quantité supérieure à ce que vous avez en Stock");
                }
               
            }
            else
            {
                MessageBox.Show("remplir le champ de quantiti");
            }
          
        }
        int quantiPiece(int idPiece,int quantiti)
        {
            
            SqlCommand cmd = new SqlCommand("select piece.quantiti from piece ", con);
            con.Open();
            int quan = (int)cmd.ExecuteScalar();
            con.Close();
            return quan - quantiti;
        }

        private void deletePiece_Click(object sender, EventArgs e)
        {
            if (datagridPiece.CurrentRow != null)
            {
                double sum = 0;
                datagridPiece.Rows.Remove(datagridPiece.CurrentRow);
                foreach (DataGridViewRow item in datagridPiece.Rows)
                {
                    sum += Convert.ToDouble(item.Cells[2].Value);
                }
                txtTotal.Text = sum.ToString();
            }
        }

        private void AddEmp_Click(object sender, EventArgs e)
        {
            if (cmbNomEmp.SelectedIndex != -1)
            {
                foreach (DataGridViewRow item in datagridEmps.Rows)
                {
                    if (cmbNomEmp.SelectedValue.ToString() == item.Cells[0].Value.ToString())
                    {
                        MessageBox.Show("ce Employee est deja existe");
                        return;
                    }
                }
                datagridEmps.Rows.Add(cmbNomEmp.SelectedValue, cmbNomEmp.Text, CmbSpecialist.Text);
            }
        }

        private void DeleteEmp_Click(object sender, EventArgs e)
        {
            if (datagridEmps.CurrentRow != null)
            {
                datagridEmps.Rows.Remove(datagridEmps.CurrentRow);
            }
        }

        private void btnConfirmerMain_Click(object sender, EventArgs e)
        {
           
            Connection.close_connection();
            if(!string.IsNullOrEmpty(cmbClient.Text) && datagridEmps.Rows.Count!=0 && datagridPiece.Rows.Count!=0 && !string.IsNullOrEmpty(txtTarif.Text))
            {
                con.Open();
                SqlTransaction tran = con.BeginTransaction();
                try
                {
                    double total;
                    if (chGarantis.Checked && DateTime.Parse(txtRestJour.Text) > DateTime.Now)
                    {
                        total = 0;
                    }
                    else
                    {
                        total = Convert.ToDouble(txtTarif.Text) + Convert.ToDouble(txtTotal.Text);
                    }
                if (txtNVente.Text != "")
                    cmd = new SqlCommand($"insert into maintenance values('{DateTime.Now}',{int.Parse(txtNVente.Text)},'{cmbClient.Text}',{total})", con, tran);
                else
                {
                    cmd = new SqlCommand($"insert into maintenance values('{DateTime.Now}',@idVoi,'{cmbClient.Text}',{total})", con, tran);
                    cmd.Parameters.AddWithValue("@idVoi", DBNull.Value);
                }
                cmd.ExecuteNonQuery();
                    //detailMaintenacePiece
                    SqlCommand cmd1 = new SqlCommand("select max(maintenance.idMaintenance) from maintenance", con,tran);
                     idMain = int.Parse(cmd1.ExecuteScalar().ToString());
                    foreach (DataGridViewRow item in datagridPiece.Rows)
                    {
                        int idPiece = int.Parse(item.Cells[0].Value.ToString());
                        cmd1 = new SqlCommand($"insert into maintenanceDetailPiece values({idMain},{idPiece})", con, tran);
                        cmd1.ExecuteNonQuery();
                        SqlCommand cmd2 = new SqlCommand($"update piece set quantiti=quantiti-{int.Parse(item.Cells[2].Value.ToString())} where idPiece={idPiece}", con, tran);
                        cmd2.ExecuteNonQuery();
                    }
                    foreach (DataGridViewRow item in datagridEmps.Rows)
                    {
                        cmd1 = new SqlCommand($"insert into detailMaintenanceEmp values({idMain},{int.Parse(item.Cells[0].Value.ToString())})", con, tran);
                        cmd1.ExecuteNonQuery();
                    }
                    tran.Commit();
                con.Close();
                    startReport = true;
                   
            }
                catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                tran.Rollback();
            }
            finally { con.Close(); }
            }
            else
            {
                MessageBox.Show("   1/_sélectionner un client.\n    2/_sélectionner des pièces et des employees.\n  3/_remplir le champ tarif.", "Guide", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (startReport)
            {
                //showReport();
                MessageBox.Show("Reparation est ajouté avec succès");
                clear_data();
            }

        }

        private void clear_data()
        {
            datagridEmps.Rows.Clear();
            datagridPiece.Rows.Clear();
            foreach (GunaTextBox item in this.Controls.OfType< GunaTextBox>())
            {
                item.Clear();
            }
            foreach (GunaComboBox item in this.Controls.OfType< GunaComboBox>())
            {
                item.SelectedIndex = 0;
            }
            txtQuantiti.Text = "";
        }

        public void showReport()
        {
            //reporting.DataSet1 ds = new reporting.DataSet1();
            //maintenanceTableAdapter da = new maintenanceTableAdapter();
            //da.Fill(ds.maintenance);
            //PieceTableAdapter deP = new PieceTableAdapter();
            //deP.Fill(ds.Piece);
            //Emp1TableAdapter depm = new Emp1TableAdapter();
            //depm.Fill(ds.Emp);
            //reporting.facture report = new reporting.facture();
            //report.SetDataSource(ds);
            //report.SetParameterValue("idMain", idMain);
            //reporting.frmReport frm = new reporting.frmReport();
            //(frm.Controls["ReportV"] as CrystalReportViewer).ReportSource = report;
            //frm.Show();
        }

        private void txtNVente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar!=(char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void cmbNomPiece_SelectedIndexChanged(object sender, EventArgs e)
        {
            Connection.close_connection();
            if (substart)
            {
                if (cmbNomPiece.SelectedIndex != -1)
                {
                    cmd = new SqlCommand($"select * from piece where idPiece={int.Parse(cmbNomPiece.SelectedValue.ToString())}", con);
                    try
                    {
                        con.Open();
                        dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            TxtPrixPiece.Text = dr["prix"].ToString();
                        }
                        dr.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally { con.Close(); }
                }
            }
        }
        
    }
}
