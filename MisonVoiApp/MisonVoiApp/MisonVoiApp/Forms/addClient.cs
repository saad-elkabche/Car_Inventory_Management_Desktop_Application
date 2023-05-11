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
    public partial class addClient : Form
    {
        byte[] img;
        public DataSet ds;
        public AutoClientDBDataContext db;
        public addClient()
        {
            InitializeComponent();
        }

        private void addClient_Load(object sender, EventArgs e)
        {
            this.Size = new Size(794, 714);
            new Core.DropShaddow().ApplyShadows(this);
        }

        private void addPic_Click(object sender, EventArgs e)
        {

        }

        private void labelClose_MouseHover(object sender, EventArgs e)
        {
            this.labelClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.2F, System.Drawing.FontStyle.Bold);
        }

        private void labelClose_MouseLeave(object sender, EventArgs e)
        {
            this.labelClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F, System.Drawing.FontStyle.Bold);

        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "pictures |*.jpg;*.jpeg;*.jfif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (openFileDialog1.OpenFile() != null)
                    {
                        UserPicture.Image = Image.FromStream(openFileDialog1.OpenFile());
                        img = File.ReadAllBytes(openFileDialog1.FileName);
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
       
        private void btnAjouterCar_Click(object sender, EventArgs e)
        {
            if (btnAjouterCar.Text == "Ajouter")
            {
                ajouterClient();
            }
            else if (btnAjouterCar.Text == "Modifier")
            {
                Modifierclient();
            }
            this.Close();
        }

        private void Modifierclient()
        {
            client cl = db.clients.SingleOrDefault(C => C.CINclient == txtCin.Text);
            if (cl != null)
            {
                cl.nomCompletClient = txtNom.Text;
                cl.dateNaissance = DateTime.Parse(naissancePic.Value.ToShortDateString());
                cl.phoneNumber = txtPhone.Text;
                cl.adresse = txtAdresse.Text;
                cl.occupation = txtOccupation.Text;
                if (img != null)
                    cl.photo =new System.Data.Linq.Binary(img);
                db.SubmitChanges();
            }
        }

        private void ajouterClient()
        {
            try
            {
                client cl = db.clients.SingleOrDefault(C => C.CINclient == txtCin.Text);
                if (cl == null)
                {
                    cl = new client()
                    {
                        CINclient = txtCin.Text,
                        nomCompletClient = txtNom.Text,
                        dateNaissance = DateTime.Parse(naissancePic.Value.ToShortDateString()),
                        phoneNumber = txtPhone.Text,
                        adresse = txtAdresse.Text,
                        occupation = txtOccupation.Text,
                    };
                    if (img != null)
                        cl.photo = new System.Data.Linq.Binary(img);
                    db.clients.InsertOnSubmit(cl);
                    db.SubmitChanges();
                }
                else
                {
                    MessageBox.Show("ce client est déjà exister");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
            if((sender as BunifuMaterialTextbox).Name== "txtPhone" && txtPhone.Text.Length >= 10 && e.KeyChar!=(char)Keys.Back)
            {
                e.Handled = true; 
            }
        }
    }
}
