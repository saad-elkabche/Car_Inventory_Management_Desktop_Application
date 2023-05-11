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

namespace MisonVoiApp.Forms.AddCarForms
{
    public partial class AddCar : Form
    {
        public Form tech, sec, confo, photo;
        SqlConnection con = Connection.con;
        SqlCommand cmd;
        SqlDataReader dr;
        public int idVoi;
        public bool JustDetail = false;
        public AddCar()
        {
            InitializeComponent();
            
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            if (this.panel1.Tag.ToString() == "securite")
            {
                if (tech == null)
                {
                    tech = new securite();
                }
                btnPre.Visible = false;
                btnSui.Location = new Point(btnSui.Location.X-25, btnSui.Location.Y);
                btnPre.Location = new Point(btnPre.Location.X - 25, btnPre.Location.Y);
                openForm(tech);
                chSec.Checked = false;
            }
            else if (this.panel1.Tag.ToString() == "Confort")
            {
                if (sec == null)
                {
                    sec = new Confort();
                }
                openForm(sec);
                chConf.Checked = false;
            }
            else if (this.panel1.Tag.ToString() == "photo" || this.panel1.Tag.ToString()== "ShowPhotos")
            {
                if (confo == null)
                {
                    confo = new Confort();
                }
                openForm(confo);
                chFo.Checked = false;
                btnSui.Visible = true;
                btnSui.Location = new Point(btnSui.Location.X - 50, btnSui.Location.Y);
                btnPre.Location = new Point(btnPre.Location.X - 50, btnPre.Location.Y);
            }
        }

        private void labaleClose_MouseHover(object sender, EventArgs e)
        {
            this.labaleClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold);
        }

        private void labaleClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labaleClose_MouseLeave(object sender, EventArgs e)
        {
            this.labaleClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F, System.Drawing.FontStyle.Bold);

        }

        private void btnAjouterCar_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            if (btnAjouterCar.Text == "Ajouter")
                ajouter_car();
            else if (btnAjouterCar.Text == "Modifier")
                edit_car();
            else
                detail_car();
            this.Close();
        }

        private void AddCar_Load(object sender, EventArgs e)
        {
            this.Size = new Size(990, 574);
            (new Core.DropShaddow()).ApplyShadows(this);
            if(tech == null)
            {
                tech = new Technique();
            }
            openForm(tech);
        }

        private void openForm(Form frm)
        {
            this.panel1.Controls.Clear();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.panel1.Tag = frm.Name;
            this.panel1.Controls.Add(frm);
            frm.Show();
        }

        private void suiTech_Click(object sender, EventArgs e)
        {
            if(this.panel1.Tag.ToString()== "Technique")
            {
                if (sec == null)
                {
                    sec = new securite();
                }
                btnPre.Visible = true;
                btnPre.Location = new Point(btnPre.Location.X+25, btnPre.Location.Y);
                btnSui.Location = new Point(btnSui.Location.X+25, btnSui.Location.Y);
                openForm(sec);
                chSec.Checked = true;
            }
            else if (this.panel1.Tag.ToString() == "securite")
            {
                if (confo == null)
                {
                    confo = new Confort();
                }
                openForm(confo);
                chConf.Checked = true;
            }
            else if (this.panel1.Tag.ToString() == "Confort")
            {
                if (photo == null)
                {
                    photo = new photo();
                }
                openForm(photo);
                chFo.Checked = true;
                btnSui.Location = new Point(btnSui.Location.X + 50, btnSui.Location.Y);
                btnSui.Visible = false;
                btnPre.Location = new Point(btnPre.Location.X + 50, btnPre.Location.Y);
                if (!JustDetail )
                {
                    btnAjouterCar.Enabled = true;
                    btnAjouterCar.Visible = true;
                }
               
            }

        }
        void ajouter_car()
        {
            try
            {
                string query = "insert into voiture values (@model,@annee,@carbu,@fiscal,@reelle,@vetisse,@rapport,@conso,@emission,@categorie,@nbPorte,@coffre,@airbag,@abs,@eps,@alarm,@demarr,@patinage,@Rvitesse,@Fouvrant,@Astationement,@controlElecPress,@freinageUrgence,@clim,@retroviseur,@volan,@detecteurPluis,@OrdinateurBord,@GPS,@EcranTactile,@startSto,@demarrageSansCle,@cameraRecul,@radarSatation,@climAutomatique,@freinAmain,@status,@imge1,@imge2,@imge3)";
                cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.Text;
                SqlParameter para1 = new SqlParameter();
                para1.SqlDbType = SqlDbType.Image;
                para1.ParameterName = "@imge1";
                if (((photo as photo).photo1) != null)
                {
                    para1.Value = (photo as photo).photo1;
                }
                else
                    para1.Value = DBNull.Value;
                cmd.Parameters.Add(para1);
                SqlParameter para2 = new SqlParameter();
                para2.SqlDbType = SqlDbType.Image;
                para2.ParameterName = "@imge2";
                if (((photo as photo).photo2) != null)
                {
                    para2.Value = (photo as photo).photo2;
                }
                else
                    para2.Value = DBNull.Value;

                cmd.Parameters.Add(para2);
                SqlParameter para3 = new SqlParameter();
                para3.SqlDbType = SqlDbType.Image;
                para3.ParameterName = "@imge3";
                if (((photo as photo).photo3) != null)
                {
                    para3.Value = (photo as photo).photo3;
                }
                else
                    para3.Value = DBNull.Value;
                cmd.Parameters.Add(para3);
                cmd.Parameters.AddWithValue("@model", (tech as Technique).txtModel.Text);
                cmd.Parameters.AddWithValue("@annee", (tech as Technique).txtAnne.Text);
                cmd.Parameters.AddWithValue("@carbu", (tech as Technique).cmbCarburan.Text);
                cmd.Parameters.AddWithValue("@fiscal", int.Parse(((tech as Technique).txtFiscal.Text) == "" ? "0" : (tech as Technique).txtFiscal.Text));
                cmd.Parameters.AddWithValue("@reelle", int.Parse(((tech as Technique).txtReel.Text) == "" ? "0" : (tech as Technique).txtReel.Text));
                cmd.Parameters.AddWithValue("@vetisse", (tech as Technique).cmbvitesse.Text);
                cmd.Parameters.AddWithValue("@rapport", int.Parse(((tech as Technique).txtRapport.Text) == "" ? "0" : (tech as Technique).txtRapport.Text));
                cmd.Parameters.AddWithValue("@conso", float.Parse(((tech as Technique).txtConsomation.Text) == "" ? "0" : (tech as Technique).txtConsomation.Text));
                cmd.Parameters.AddWithValue("@emission", int.Parse(((tech as Technique).txtEmission.Text) == "" ? "0" : (tech as Technique).txtEmission.Text));
                cmd.Parameters.AddWithValue("@categorie", (tech as Technique).txtcat.Text);
                cmd.Parameters.AddWithValue("@nbPorte", int.Parse(((tech as Technique).txtPort.Text) == "" ? "0" : (tech as Technique).txtPort.Text));
                cmd.Parameters.AddWithValue("@coffre", int.Parse(((tech as Technique).txtCofrre.Text) == "" ? "0" : (tech as Technique).txtCofrre.Text));
                cmd.Parameters.AddWithValue("@airbag", (sec as securite).chAir.Checked ? 1 : 0);
                cmd.Parameters.AddWithValue("@abs", (sec as securite).chAbs.Checked ? 1 : 0);
                cmd.Parameters.AddWithValue("@eps", (sec as securite).chEps.Checked ? 1 : 0);
                cmd.Parameters.AddWithValue("@alarm", (sec as securite).chAlarm.Checked ? 1 : 0);
                cmd.Parameters.AddWithValue("@demarr", (sec as securite).chDemmarage.Checked ? 1 : 0);
                cmd.Parameters.AddWithValue("@patinage", (sec as securite).chPatinage.Checked ? 1 : 0);
                cmd.Parameters.AddWithValue("@Rvitesse", (sec as securite).chVitesse.Checked ? 1 : 0);
                cmd.Parameters.AddWithValue("@Fouvrant", (sec as securite).chFermeture.Checked ? 1 : 0);
                cmd.Parameters.AddWithValue("@Astationement", (sec as securite).chStationnement.Checked ? 1 : 0);
                cmd.Parameters.AddWithValue("@controlElecPress", (sec as securite).chControl.Checked ? 1 : 0);
                cmd.Parameters.AddWithValue("@freinageUrgence", (sec as securite).chFreinage.Checked ? 1 : 0);
                cmd.Parameters.AddWithValue("@clim", (confo as Confort).chClima.Checked ? 1 : 0);
                cmd.Parameters.AddWithValue("@retroviseur", (confo as Confort).chRetroviseur.Checked ? 1 : 0);
                cmd.Parameters.AddWithValue("@volan", (confo as Confort).chVolant.Checked ? 1 : 0);
                cmd.Parameters.AddWithValue("@detecteurPluis", (confo as Confort).chDetecteur.Checked ? 1 : 0);
                cmd.Parameters.AddWithValue("@OrdinateurBord", (confo as Confort).chOrdianteur.Checked ? 1 : 0);
                cmd.Parameters.AddWithValue("@GPS", (confo as Confort).chGps.Checked ? 1 : 0);
                cmd.Parameters.AddWithValue("@EcranTactile", (confo as Confort).chEcran.Checked ? 1 : 0);
                cmd.Parameters.AddWithValue("@startSto", (confo as Confort).chStartStop.Checked ? 1 : 0);
                cmd.Parameters.AddWithValue("@demarrageSansCle", (confo as Confort).chDemrrage.Checked ? 1 : 0);
                cmd.Parameters.AddWithValue("@cameraRecul", (confo as Confort).chCamera.Checked ? 1 : 0);
                cmd.Parameters.AddWithValue("@radarSatation", (confo as Confort).chRadar.Checked ? 1 : 0);
                cmd.Parameters.AddWithValue("@climAutomatique", (confo as Confort).chClima.Checked ? 1 : 0);
                cmd.Parameters.AddWithValue("@freinAmain", (confo as Confort).chFreinAmain.Checked ? 1 : 0);
                cmd.Parameters.AddWithValue("@status", "Disponible");
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        void edit_car()
        {
            try
            {
                string query = "update voiture set modele=@model,annne=@annee,carburant=@carbu,puissanceFiscale=@fiscal,puissanceReelle=@reelle,boiteVitesses=@vetisse,nbRapports=@rapport,consomation=@conso,emissionCO2=@emission,categorie=@categorie,nombre_portes=@nbPorte,coffre=@coffre,airbag=@airbag,ABS=@abs,EPS=@eps,alarme=@alarm,Antidemmarrage=@demarr,Antipatinage=@patinage,regulateurVitesse=@Rvitesse,fermetureOuvrant=@Fouvrant,AideStationement=@Astationement,ControlElectriquePressionPneus=@controlElecPress,AideFreinageUrgence=@freinageUrgence,climatisation=@clim,retroviseursElectriques=@retroviseur,volantMultiFonctions=@volan,detecteurPluis=@detecteurPluis,ordinateurBord=@OrdinateurBord,GPS=@GPS,ecranTactile=@EcranTactile,startStop=@startSto,demarrageSansCle=@demarrageSansCle,cameraRecul=@cameraRecul,radarSattionnement=@radarSatation,climAutomatique=@climAutomatique,freinMainElectrique=@freinAmain,image1=@imge1,image2=@imge2,image3=@imge3 where idVoiture=@idcar";
                cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.Text;
                SqlParameter para1 = new SqlParameter();
                para1.SqlDbType = SqlDbType.Image;
                para1.ParameterName = "@imge1";
                if (((photo as photo).photo1) != null)
                {
                    para1.Value = (photo as photo).photo1;
                }
                else
                    para1.Value = DBNull.Value;
                cmd.Parameters.Add(para1);
                SqlParameter para2 = new SqlParameter();
                para2.SqlDbType = SqlDbType.Image;
                para2.ParameterName = "@imge2";
                if (((photo as photo).photo2) != null)
                {
                    para2.Value = (photo as photo).photo2;
                }
                else
                    para2.Value = DBNull.Value;

                cmd.Parameters.Add(para2);
                SqlParameter para3 = new SqlParameter();
                para3.SqlDbType = SqlDbType.Image;
                para3.ParameterName = "@imge3";
                if (((photo as photo).photo3) != null)
                {
                    para3.Value = (photo as photo).photo3;
                }
                else
                    para3.Value = DBNull.Value;
                cmd.Parameters.Add(para3);
                cmd.Parameters.AddWithValue("@model", (tech as Technique).txtModel.Text);
                cmd.Parameters.AddWithValue("@annee", (tech as Technique).txtAnne.Text);
                cmd.Parameters.AddWithValue("@carbu", (tech as Technique).cmbCarburan.Text);
                cmd.Parameters.AddWithValue("@fiscal", int.Parse(((tech as Technique).txtFiscal.Text) == "" ? "0" : (tech as Technique).txtFiscal.Text));
                cmd.Parameters.AddWithValue("@reelle", int.Parse(((tech as Technique).txtReel.Text) == "" ? "0" : (tech as Technique).txtReel.Text));
                cmd.Parameters.AddWithValue("@vetisse", (tech as Technique).cmbvitesse.Text);
                cmd.Parameters.AddWithValue("@rapport", int.Parse(((tech as Technique).txtRapport.Text) == "" ? "0" : (tech as Technique).txtRapport.Text));
                cmd.Parameters.AddWithValue("@conso", Convert.ToDouble(((tech as Technique).txtConsomation.Text) == "" ? "0" : (tech as Technique).txtConsomation.Text));
                cmd.Parameters.AddWithValue("@emission", int.Parse(((tech as Technique).txtEmission.Text) == "" ? "0" : (tech as Technique).txtEmission.Text));
                cmd.Parameters.AddWithValue("@categorie", (tech as Technique).txtcat.Text);
                cmd.Parameters.AddWithValue("@nbPorte", int.Parse(((tech as Technique).txtPort.Text) == "" ? "0" : (tech as Technique).txtPort.Text));
                cmd.Parameters.AddWithValue("@coffre", int.Parse(((tech as Technique).txtCofrre.Text) == "" ? "0" : (tech as Technique).txtCofrre.Text));
                cmd.Parameters.AddWithValue("@airbag", (sec as securite).chAir.Checked ? 1 : 0);
                cmd.Parameters.AddWithValue("@abs", (sec as securite).chAbs.Checked ? 1 : 0);
                cmd.Parameters.AddWithValue("@eps", (sec as securite).chEps.Checked ? 1 : 0);
                cmd.Parameters.AddWithValue("@alarm", (sec as securite).chAlarm.Checked ? 1 : 0);
                cmd.Parameters.AddWithValue("@demarr", (sec as securite).chDemmarage.Checked ? 1 : 0);
                cmd.Parameters.AddWithValue("@patinage", (sec as securite).chPatinage.Checked ? 1 : 0);
                cmd.Parameters.AddWithValue("@Rvitesse", (sec as securite).chVitesse.Checked ? 1 : 0);
                cmd.Parameters.AddWithValue("@Fouvrant", (sec as securite).chFermeture.Checked ? 1 : 0);
                cmd.Parameters.AddWithValue("@Astationement", (sec as securite).chStationnement.Checked ? 1 : 0);
                cmd.Parameters.AddWithValue("@controlElecPress", (sec as securite).chControl.Checked ? 1 : 0);
                cmd.Parameters.AddWithValue("@freinageUrgence", (sec as securite).chFreinage.Checked ? 1 : 0);
                cmd.Parameters.AddWithValue("@clim", (confo as Confort).chClima.Checked ? 1 : 0);
                cmd.Parameters.AddWithValue("@retroviseur", (confo as Confort).chRetroviseur.Checked ? 1 : 0);
                cmd.Parameters.AddWithValue("@volan", (confo as Confort).chVolant.Checked ? 1 : 0);
                cmd.Parameters.AddWithValue("@detecteurPluis", (confo as Confort).chDetecteur.Checked ? 1 : 0);
                cmd.Parameters.AddWithValue("@OrdinateurBord", (confo as Confort).chOrdianteur.Checked ? 1 : 0);
                cmd.Parameters.AddWithValue("@GPS", (confo as Confort).chGps.Checked ? 1 : 0);
                cmd.Parameters.AddWithValue("@EcranTactile", (confo as Confort).chEcran.Checked ? 1 : 0);
                cmd.Parameters.AddWithValue("@startSto", (confo as Confort).chStartStop.Checked ? 1 : 0);
                cmd.Parameters.AddWithValue("@demarrageSansCle", (confo as Confort).chDemrrage.Checked ? 1 : 0);
                cmd.Parameters.AddWithValue("@cameraRecul", (confo as Confort).chCamera.Checked ? 1 : 0);
                cmd.Parameters.AddWithValue("@radarSatation", (confo as Confort).chRadar.Checked ? 1 : 0);
                cmd.Parameters.AddWithValue("@climAutomatique", (confo as Confort).chClima.Checked ? 1 : 0);
                cmd.Parameters.AddWithValue("@freinAmain", (confo as Confort).chFreinAmain.Checked ? 1 : 0);
                cmd.Parameters.AddWithValue("@idcar", idVoi);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }
        void detail_car()
        {

        }

    }
}
