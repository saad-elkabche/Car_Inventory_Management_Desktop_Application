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
    public partial class specialite : Form
    {
        SqlConnection con = Connection.con;
        SqlCommand cmd;
        public specialite()
        {
            InitializeComponent();
            new Core.DropShaddow().ApplyShadows(this);
        }

        private void specialite_Load(object sender, EventArgs e)
        {
            fill_data();
        }

        private void fill_data()
        {
            cmd = new SqlCommand("select * from specialites", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = dr;
                listSpe.DataSource = bs;
                listSpe.DisplayMember = "nomSpecialites";
                listSpe.ValueMember = "idSpec";
                
            }
            else
            {
                listSpe.Items.Clear();
            }
            con.Close();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (listSpe.SelectedItem != null)
            {

                try
                {
                    cmd = new SqlCommand($"delete from specialites where idSpec={int.Parse(listSpe.SelectedValue.ToString())} ", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    fill_data();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNomSpecialite.Text))
            {
                try
                {
                    cmd = new SqlCommand("insert into specialites values(@nom)", con);
                    cmd.Parameters.AddWithValue("@nom", txtNomSpecialite.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    fill_data();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
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
    }
}
