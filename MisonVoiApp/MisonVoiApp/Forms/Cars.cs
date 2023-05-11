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

namespace MisonVoiApp.Forms
{
    public partial class Cars : Form
    {
        SqlConnection con = Connection.con;
        SqlCommand cmd;
        SqlDataReader dr;
        List<MemoryStream> listImg;
        int ind = 0;
        public int idVoi = 0;
        public Cars()
        {
            InitializeComponent();
        }

        private void Cars_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1350, 780);
            load_data();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            Form frm = new AddCarForms.AddCar();
            (frm as AddCarForms.AddCar).btnAjouterCar.Text = "Ajouter";
            frm.ShowDialog();
            load_data();
        }
        void load_data()
        {
            try
            {
                cmd = new SqlCommand("select idVoiture,modele,annne,carburant,puissanceFiscale,puissanceReelle,status from voiture", con);
                if (con.State == ConnectionState.Open)
                    con.Close();
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dataGridCars.Rows.Clear();
                    while (dr.Read())
                    {
                        dataGridCars.Rows.Add(dr["idVoiture"], dr["modele"],dr["annne"], dr["carburant"], dr["puissanceFiscale"], dr["puissanceReelle"], dr["status"]);
                    }
                }
                else
                {
                    dataGridCars.Rows.Clear();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            { con.Close(); dr.Close(); }
            flippingImages();
        }

        private void btnEditVoiture_Click(object sender, EventArgs e)
        {
            if (dataGridCars.CurrentRow != null && dataGridCars.CurrentRow.Cells[6].Value.ToString() == "Disponible")
            {
                int id = int.Parse(dataGridCars.CurrentRow.Cells[0].Value.ToString());
                AddCarForms.AddCar editFrm = new AddCarForms.AddCar();
                editFrm.idVoi = id;
                ((AddCarForms.AddCar)editFrm).tech = new AddCarForms.Technique();
                ((AddCarForms.AddCar)editFrm).sec = new AddCarForms.securite();
                ((AddCarForms.AddCar)editFrm).confo = new AddCarForms.Confort();
                ((AddCarForms.AddCar)editFrm).photo = new AddCarForms.photo();
                Form frmTech = ((AddCarForms.AddCar)editFrm).tech;
                Form frmSecuri = ((AddCarForms.AddCar)editFrm).sec;
                Form frmConfort = ((AddCarForms.AddCar)editFrm).confo;
                Form fromPhoto = ((AddCarForms.AddCar)editFrm).photo;
                try
                {
                    cmd = new SqlCommand($"select * from voiture where idVoiture={id}", con);
                    if (con.State == ConnectionState.Open)
                        con.Close();
                    con.Open();
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        string str;
                        byte[] imgBy;
                        while (dr.Read())
                        {
                            //technique
                            (frmTech as AddCarForms.Technique).txtModel.Text = dr["modele"].ToString();
                            (frmTech as AddCarForms.Technique).txtAnne.Text = dr["annne"].ToString();
                            (frmTech as AddCarForms.Technique).cmbCarburan.Text = dr["carburant"].ToString();
                            (frmTech as AddCarForms.Technique).txtFiscal.Text = dr["puissanceFiscale"].ToString();
                            (frmTech as AddCarForms.Technique).txtReel.Text = dr["puissanceReelle"].ToString();
                            (frmTech as AddCarForms.Technique).cmbvitesse.Text = dr["boiteVitesses"].ToString();
                            (frmTech as AddCarForms.Technique).txtRapport.Text = dr["nbRapports"].ToString();
                            (frmTech as AddCarForms.Technique).txtConsomation.Text = dr["consomation"].ToString();
                            (frmTech as AddCarForms.Technique).txtEmission.Text = dr["emissionCO2"].ToString();
                            (frmTech as AddCarForms.Technique).txtcat.Text = dr["categorie"].ToString();
                            (frmTech as AddCarForms.Technique).txtPort.Text = dr["nombre_portes"].ToString();
                            (frmTech as AddCarForms.Technique).txtCofrre.Text = dr["coffre"].ToString();
                            //securite
                            (frmSecuri as AddCarForms.securite).chAir.Checked = dr["airbag"].ToString() == "1" ? true : false;
                            (frmSecuri as AddCarForms.securite).chAbs.Checked = dr["ABS"].ToString() == "1" ? true : false;
                            (frmSecuri as AddCarForms.securite).chEps.Checked = dr["EPS"].ToString() == "1" ? true : false;
                            (frmSecuri as AddCarForms.securite).chAlarm.Checked = dr["alarme"].ToString() == "1" ? true : false;
                            (frmSecuri as AddCarForms.securite).chDemmarage.Checked = dr["Antidemmarrage"].ToString() == "1" ? true : false;
                            (frmSecuri as AddCarForms.securite).chPatinage.Checked = dr["Antipatinage"].ToString() == "1" ? true : false;
                            (frmSecuri as AddCarForms.securite).chVitesse.Checked = dr["regulateurVitesse"].ToString() == "1" ? true : false;
                            (frmSecuri as AddCarForms.securite).chFermeture.Checked = dr["fermetureOuvrant"].ToString() == "1" ? true : false;
                            (frmSecuri as AddCarForms.securite).chStationnement.Checked = dr["AideStationement"].ToString() == "1" ? true : false;
                            (frmSecuri as AddCarForms.securite).chControl.Checked = dr["ControlElectriquePressionPneus"].ToString() == "1" ? true : false;
                            (frmSecuri as AddCarForms.securite).chFreinage.Checked = dr["AideFreinageUrgence"].ToString() == "1" ? true : false;
                            //confort
                            (frmConfort as AddCarForms.Confort).chClima.Checked = dr["climatisation"].ToString() == "1" ? true : false;
                            (frmConfort as AddCarForms.Confort).chRetroviseur.Checked = dr["retroviseursElectriques"].ToString() == "1" ? true : false;
                            (frmConfort as AddCarForms.Confort).chVolant.Checked = dr["volantMultiFonctions"].ToString() == "1" ? true : false;
                            (frmConfort as AddCarForms.Confort).chDetecteur.Checked = dr["detecteurPluis"].ToString() == "1" ? true : false;
                            (frmConfort as AddCarForms.Confort).chOrdianteur.Checked = dr["ordinateurBord"].ToString() == "1" ? true : false;
                            (frmConfort as AddCarForms.Confort).chGps.Checked = dr["GPS"].ToString() == "1" ? true : false;
                            (frmConfort as AddCarForms.Confort).chEcran.Checked = dr["ecranTactile"].ToString() == "1" ? true : false;
                            (frmConfort as AddCarForms.Confort).chStartStop.Checked = dr["startStop"].ToString() == "1" ? true : false;
                            (frmConfort as AddCarForms.Confort).chDemrrage.Checked = dr["demarrageSansCle"].ToString() == "1" ? true : false;
                            (frmConfort as AddCarForms.Confort).chCamera.Checked = dr["cameraRecul"].ToString() == "1" ? true : false;
                            (frmConfort as AddCarForms.Confort).chRadar.Checked = dr["radarSattionnement"].ToString() == "1" ? true : false;
                            (frmConfort as AddCarForms.Confort).ChClimAutoma.Checked = dr["climAutomatique"].ToString() == "1" ? true : false;
                            (frmConfort as AddCarForms.Confort).chFreinAmain.Checked = dr["freinMainElectrique"].ToString() == "1" ? true : false;
                            //photo
                            if (!(dr["image1"] is System.DBNull))
                            {
                                imgBy = (byte[])dr["image1"];
                                (fromPhoto as AddCarForms.photo).pic1.Image = Image.FromStream(new MemoryStream(imgBy));
                            }
                            if (!(dr["image2"] is System.DBNull))
                            {
                                imgBy = (byte[])dr["image2"];
                                (fromPhoto as AddCarForms.photo).pic2.Image = Image.FromStream(new MemoryStream(imgBy));
                            }
                            if (!(dr["image3"] is System.DBNull))
                            {
                                imgBy = (byte[])dr["image3"];
                                (fromPhoto as AddCarForms.photo).pic3.Image = Image.FromStream(new MemoryStream(imgBy));
                            }
                        }
                        editFrm.btnAjouterCar.Text = "Modifier";
                        editFrm.ShowDialog();
                        load_data();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { con.Close(); }
            }
            else
                MessageBox.Show("vous ne pouvez pas modifier une voiture indisponible");
        }

        public void btnDetailVoiture_Click(object sender, EventArgs e)
        {
            if (dataGridCars.CurrentRow != null || idVoi!=0)
            {
                int id;
                if (idVoi != 0)
                    id = idVoi;
                else
                    id= int.Parse(dataGridCars.CurrentRow.Cells[0].Value.ToString());
            
                AddCarForms.AddCar editFrm = new AddCarForms.AddCar();
                editFrm.idVoi = id;
                ((AddCarForms.AddCar)editFrm).tech = new AddCarForms.Technique();
                ((AddCarForms.AddCar)editFrm).sec = new AddCarForms.securite();
                ((AddCarForms.AddCar)editFrm).confo = new AddCarForms.Confort();
                ((AddCarForms.AddCar)editFrm).photo = new AddCarForms.ShowPhotos();
                Form frmTech = ((AddCarForms.AddCar)editFrm).tech;
                Form frmSecuri = ((AddCarForms.AddCar)editFrm).sec;
                Form frmConfort = ((AddCarForms.AddCar)editFrm).confo;
                Form frmPhoto = ((AddCarForms.AddCar)editFrm).photo;
                try
                {
                    cmd = new SqlCommand($"select * from voiture where idVoiture={id}", con);
                    if (con.State == ConnectionState.Open)
                        con.Close();
                    con.Open();
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        string str;
                        byte[] imgBy;
                        while (dr.Read())
                        {

                            //technique
                            (frmTech as AddCarForms.Technique).txtModel.Text = dr["modele"].ToString();
                            (frmTech as AddCarForms.Technique).txtAnne.Text = dr["annne"].ToString();
                            (frmTech as AddCarForms.Technique).cmbCarburan.Text = dr["carburant"].ToString();
                            (frmTech as AddCarForms.Technique).txtFiscal.Text = dr["puissanceFiscale"].ToString();
                            (frmTech as AddCarForms.Technique).txtReel.Text = dr["puissanceReelle"].ToString();
                            (frmTech as AddCarForms.Technique).cmbvitesse.Text = dr["boiteVitesses"].ToString();
                            (frmTech as AddCarForms.Technique).txtRapport.Text = dr["nbRapports"].ToString();
                            (frmTech as AddCarForms.Technique).txtConsomation.Text = dr["consomation"].ToString();
                            (frmTech as AddCarForms.Technique).txtEmission.Text = dr["emissionCO2"].ToString();
                            (frmTech as AddCarForms.Technique).txtcat.Text = dr["categorie"].ToString();
                            (frmTech as AddCarForms.Technique).txtPort.Text = dr["nombre_portes"].ToString();
                            (frmTech as AddCarForms.Technique).txtCofrre.Text = dr["coffre"].ToString();
                            //securite
                            (frmSecuri as AddCarForms.securite).chAir.Checked = dr["airbag"].ToString() == "1" ? true : false;
                            (frmSecuri as AddCarForms.securite).chAbs.Checked = dr["ABS"].ToString() == "1" ? true : false;
                            (frmSecuri as AddCarForms.securite).chEps.Checked = dr["EPS"].ToString() == "1" ? true : false;
                            (frmSecuri as AddCarForms.securite).chAlarm.Checked = dr["alarme"].ToString() == "1" ? true : false;
                            (frmSecuri as AddCarForms.securite).chDemmarage.Checked = dr["Antidemmarrage"].ToString() == "1" ? true : false;
                            (frmSecuri as AddCarForms.securite).chPatinage.Checked = dr["Antipatinage"].ToString() == "1" ? true : false;
                            (frmSecuri as AddCarForms.securite).chVitesse.Checked = dr["regulateurVitesse"].ToString() == "1" ? true : false;
                            (frmSecuri as AddCarForms.securite).chFermeture.Checked = dr["fermetureOuvrant"].ToString() == "1" ? true : false;
                            (frmSecuri as AddCarForms.securite).chStationnement.Checked = dr["AideStationement"].ToString() == "1" ? true : false;
                            (frmSecuri as AddCarForms.securite).chControl.Checked = dr["ControlElectriquePressionPneus"].ToString() == "1" ? true : false;
                            (frmSecuri as AddCarForms.securite).chFreinage.Checked = dr["AideFreinageUrgence"].ToString() == "1" ? true : false;
                            //confort
                            (frmConfort as AddCarForms.Confort).chClima.Checked = dr["climatisation"].ToString() == "1" ? true : false;
                            (frmConfort as AddCarForms.Confort).chRetroviseur.Checked = dr["retroviseursElectriques"].ToString() == "1" ? true : false;
                            (frmConfort as AddCarForms.Confort).chVolant.Checked = dr["volantMultiFonctions"].ToString() == "1" ? true : false;
                            (frmConfort as AddCarForms.Confort).chDetecteur.Checked = dr["detecteurPluis"].ToString() == "1" ? true : false;
                            (frmConfort as AddCarForms.Confort).chOrdianteur.Checked = dr["ordinateurBord"].ToString() == "1" ? true : false;
                            (frmConfort as AddCarForms.Confort).chGps.Checked = dr["GPS"].ToString() == "1" ? true : false;
                            (frmConfort as AddCarForms.Confort).chEcran.Checked = dr["ecranTactile"].ToString() == "1" ? true : false;
                            (frmConfort as AddCarForms.Confort).chStartStop.Checked = dr["startStop"].ToString() == "1" ? true : false;
                            (frmConfort as AddCarForms.Confort).chDemrrage.Checked = dr["demarrageSansCle"].ToString() == "1" ? true : false;
                            (frmConfort as AddCarForms.Confort).chCamera.Checked = dr["cameraRecul"].ToString() == "1" ? true : false;
                            (frmConfort as AddCarForms.Confort).chRadar.Checked = dr["radarSattionnement"].ToString() == "1" ? true : false;
                            (frmConfort as AddCarForms.Confort).ChClimAutoma.Checked = dr["climAutomatique"].ToString() == "1" ? true : false;
                            (frmConfort as AddCarForms.Confort).chFreinAmain.Checked = dr["freinMainElectrique"].ToString() == "1" ? true : false;
                            //photo
                            if (!(dr["image1"] is System.DBNull))
                            {
                                imgBy = (byte[])dr["image1"];
                               (frmPhoto as AddCarForms.ShowPhotos).ms1=new MemoryStream(imgBy);
                            }
                            if (!(dr["image2"] is System.DBNull))
                            {
                                imgBy = (byte[])dr["image2"];
                                (frmPhoto as AddCarForms.ShowPhotos).ms2 = new MemoryStream(imgBy);
                            }
                            if (!(dr["image3"] is System.DBNull))
                            {
                                imgBy = (byte[])dr["image3"];
                                (frmPhoto as AddCarForms.ShowPhotos).ms3 = new MemoryStream(imgBy);
                            }
                        }
                        
                        foreach ( BunifuMaterialTextbox item in frmTech.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            item.Enabled = false;
                        }
                        foreach (BunifuCheckbox item in frmSecuri.Controls.OfType<BunifuCheckbox>())
                        {
                            item.Enabled = false;
                        }
                        foreach (BunifuCheckbox item in frmConfort.Controls.OfType<BunifuCheckbox>())
                        {
                            item.Enabled = false;
                        }
                        (frmTech as AddCarForms.Technique).cmbCarburan.DropDownStyle = ComboBoxStyle.Simple;
                        (frmTech as AddCarForms.Technique).cmbvitesse.DropDownStyle = ComboBoxStyle.Simple;
                        editFrm.JustDetail = true;
                        editFrm.btnAjouterCar.Enabled = false;
                        editFrm.btnAjouterCar.Visible = false;
                        editFrm.ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { con.Close(); }
            }
        }

        private void dataGridCars_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            flippingImages();
        }

        private void flippingImages()
        {
            try
            {
                if (dataGridCars.CurrentRow != null)
                {
                    listImg = new List<MemoryStream>();
                    int id = int.Parse(dataGridCars.CurrentRow.Cells[0].Value.ToString());
                    cmd = new SqlCommand($"select image1,image2,image3 from voiture where idVoiture={id}", con);
                    con.Open();
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        if (!(dr["image1"] is System.DBNull))
                        {
                            listImg.Add(new MemoryStream(((byte[])dr["image1"])));
                        }
                        if (!(dr["image2"] is System.DBNull))
                        {
                            listImg.Add(new MemoryStream(((byte[])dr["image2"])));
                        }
                        if (!(dr["image3"] is System.DBNull))
                        {
                            listImg.Add(new MemoryStream(((byte[])dr["image3"])));
                        }
                    }
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dr.Close();
                con.Close();
            }
            ind = 0;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (listImg.Count > 0)
                {
                    if (ind == 0 && listImg.Count > ind)
                    {
                        pictureBox1.Image = Image.FromStream(listImg[ind]);
                    }
                    else if (ind == 1 && listImg.Count > ind)
                    {
                        pictureBox1.Image = Image.FromStream(listImg[ind]);
                    }
                    else if (ind == 2 && listImg.Count > ind)
                    {
                        pictureBox1.Image = Image.FromStream(listImg[ind]);
                    }
                    if (ind + 1 >= listImg.Count)
                    {
                        ind = 0;
                        return;
                    }
                    timer1.Interval = 2100;
                    ind++;
                }
                else
                {
                    pictureBox1.Image = null;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteVoiture_Click(object sender, EventArgs e)
        {
            if (dataGridCars.CurrentRow != null)
            {
                int id=int.Parse(dataGridCars.CurrentRow.Cells[0].Value.ToString());
                string model = dataGridCars.CurrentRow.Cells[1].Value.ToString();
                if(MessageBox.Show($"voulez-vous supprimer {model}", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        cmd = new SqlCommand($"delete from voiture where idVoiture={id}", con);
                        if (con.State == ConnectionState.Open)
                            con.Close();
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally { con.Close(); }
                    load_data();
                }
            }
           
        }

        private void achatCache_Click(object sender, EventArgs e)
        {
            if (dataGridCars.Rows.Count >= 1 && dataGridCars.CurrentRow != null)
            {
                string status = dataGridCars.CurrentRow.Cells[6].Value.ToString();
                if (status == "Disponible")
                {
                    cache frm = new cache();
                    frm.cars = this;
                    frm.idVoi = int.Parse(dataGridCars.CurrentRow.Cells[0].Value.ToString());
                    frm.ShowDialog();
                    load_data();
                }
                else
                    MessageBox.Show("cette voiture est pas disponible");
            }
            else
                MessageBox.Show("nous n'avons pas de voitures");
            
        }
        private void btnAddClient_MouseHover(object sender, EventArgs e)
        {
            (sender as FontAwesome.Sharp.IconButton).ForeColor = Color.Black;
            (sender as FontAwesome.Sharp.IconButton).IconColor = Color.Black;
        }

        private void btnAddClient_MouseLeave(object sender, EventArgs e)
        {
            (sender as FontAwesome.Sharp.IconButton).ForeColor = Color.White;
            (sender as FontAwesome.Sharp.IconButton).IconColor = Color.White;
        }

        private void achatDebt_Click(object sender, EventArgs e)
        {
            if (dataGridCars.Rows.Count >= 1 && dataGridCars.CurrentRow != null)
            {
                string status = dataGridCars.CurrentRow.Cells[6].Value.ToString();
                if (status == "Disponible")
                {
                    Adette frm = new Adette();
                    frm.frmCars = this;
                    frm.idVoi = int.Parse(dataGridCars.CurrentRow.Cells[0].Value.ToString());
                    frm.ShowDialog();
                    load_data();
                }
                else
                    MessageBox.Show("cette voiture est pas disponible");
            }
            else
                MessageBox.Show("nous n'avons pas de voitures");
        }
              
    }
}

