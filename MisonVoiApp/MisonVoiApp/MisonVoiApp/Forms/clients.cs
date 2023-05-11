using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MisonVoiApp.Forms
{
    public partial class clients : Form
    {
        public  AutoClientDBDataContext db;
        public string CIN = "";
        public clients()
        {
            InitializeComponent();
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

        private void achatCache_MouseHover(object sender, EventArgs e)
        {
            (sender as FontAwesome.Sharp.IconButton).ForeColor = Color.FromArgb(0, 151, 167);
            (sender as FontAwesome.Sharp.IconButton).IconColor = Color.FromArgb(0, 151, 167);
        }

        private void achatCache_MouseLeave(object sender, EventArgs e)
        {
            (sender as FontAwesome.Sharp.IconButton).ForeColor = Color.White;
            (sender as FontAwesome.Sharp.IconButton).IconColor = Color.White;
        }

        private void clients_Load(object sender, EventArgs e)
        {
            db = new AutoClientDBDataContext();
            fill_data();
            cmbType.SelectedIndex = 0;
        }

        private void fill_data()
        {
            var tab = from E in db.clients select new { E.CINclient, E.nomCompletClient, E.adresse, E.phoneNumber };
            dataGridClients.Rows.Clear();
            foreach (var item in tab.ToList())
            {
                dataGridClients.Rows.Add(item.CINclient, item.nomCompletClient, item.adresse, item.phoneNumber);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (cmbType.Text == "CIN")
            {
                dataGridClients.Rows.Clear();
                var tab = from E in db.clients where E.CINclient.Contains(txtSearch.Text) select new { E.CINclient, E.nomCompletClient, E.adresse, E.phoneNumber };
                foreach (var item in tab.ToList())
                {
                    dataGridClients.Rows.Add(item.CINclient, item.nomCompletClient, item.adresse, item.phoneNumber);
                }
            }
            else if (cmbType.Text == "Nom")
            {
                dataGridClients.Rows.Clear();
                var tab = from E in db.clients where E.nomCompletClient.Contains(txtSearch.Text) select new { E.CINclient, E.nomCompletClient, E.adresse, E.phoneNumber };
                foreach (var item in tab.ToList())
                {
                    dataGridClients.Rows.Add(item.CINclient, item.nomCompletClient, item.adresse, item.phoneNumber);
                }
            }
           
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            addClient frm = new addClient();
            frm.btnAjouterCar.Text = "Ajouter";
            frm.db = this.db;
            frm.ShowDialog();
            fill_data();
        }

        private void btnEditClient_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridClients.CurrentRow != null)
                {
                    string cin = dataGridClients.CurrentRow.Cells[0].Value.ToString();
                    client cl = db.clients.SingleOrDefault(C => C.CINclient == cin);
                    addClient frm = new addClient();
                    frm.txtCin.Text = cl.CINclient;
                    frm.txtNom.Text = cl.nomCompletClient;
                    frm.txtAdresse.Text = cl.adresse;
                    frm.txtPhone.Text = cl.phoneNumber;
                    frm.txtOccupation.Text = cl.occupation;
                    frm.naissancePic.Value = DateTime.Parse(cl.dateNaissance.ToString());
                    frm.txtCin.Enabled = false;
                    if (cl.photo != null)
                    {
                        frm.UserPicture.Image = Image.FromStream(new MemoryStream(cl.photo.ToArray()));
                    }
                    frm.btnAjouterCar.Text = "Modifier";
                    frm.db = this.db;
                    frm.ShowDialog();
                    fill_data();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void iconButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridClients.CurrentRow != null || CIN!="")
                {
                    string cin;
                    if (CIN != "")
                        cin = CIN;
                    else
                        cin= dataGridClients.CurrentRow.Cells[0].Value.ToString();
                    client cl = db.clients.SingleOrDefault(C => C.CINclient == cin);
                    addClient frm = new addClient();
                    frm.txtCin.Text = cl.CINclient;
                    frm.txtNom.Text = cl.nomCompletClient;
                    frm.txtAdresse.Text = cl.adresse;
                    frm.txtPhone.Text = cl.phoneNumber;
                    frm.txtOccupation.Text = cl.occupation;
                    frm.naissancePic.Value = DateTime.Parse(cl.dateNaissance.ToString());
                    if (cl.photo != null)
                    {
                        frm.UserPicture.Image = Image.FromStream(new MemoryStream(cl.photo.ToArray()));
                    }
                    foreach (BunifuMaterialTextbox item in frm.Controls.OfType<BunifuMaterialTextbox>())
                    {
                        item.Enabled = false;
                    }
                    frm.naissancePic.Enabled = false;
                    frm.btnAjouterCar.Visible = false;
                    (frm.Controls["picPicture"] as FontAwesome.Sharp.IconButton).Visible = false;
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridClients.CurrentRow != null)
                {
                    if (MessageBox.Show("est ce que tu veux supprimer ce client", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string str = dataGridClients.CurrentRow.Cells[0].Value.ToString();
                        db.clients.DeleteOnSubmit(db.clients.SingleOrDefault(E => E.CINclient == str));
                        db.SubmitChanges();
                        fill_data();
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void achatCache_Click(object sender, EventArgs e)
        {
            string cin = dataGridClients.CurrentRow.Cells[0].Value.ToString();
            var tab = from c in db.AchatCaches where c.idClient == cin select c;
            var tab1 = from c in db.AchatLoyers where c.idClient == cin select c;
            if(tab.ToList().Count>0 || tab1.ToList().Count > 0)
            {
                ventesCli frm = new ventesCli();
                frm.idCl = cin;
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Il n'y a pas de vente pour ce client");
            }
        }

      
    }
}
