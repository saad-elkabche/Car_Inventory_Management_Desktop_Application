using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MisonVoiApp
{
    public partial class Login : Form
    {
        SqlConnection con = Connection.con;
        SqlCommand cmd;
        public Login()
        {
            InitializeComponent();
            //pictureBox2.Image = MisonVoiApp.Properties.Resources.
        }

        private void btnEye_Click(object sender, EventArgs e)
        {
            if(btnEye.IconChar == FontAwesome.Sharp.IconChar.EyeSlash)
            {
                btnEye.IconChar = FontAwesome.Sharp.IconChar.Eye;
                txtPass.UseSystemPasswordChar = true;
            }
            else
            {
                btnEye.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                txtPass.UseSystemPasswordChar = false;
                txtPass.Text = txtPass.Text;
            }

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand($"select * from users where [user]='{txtLogin.Text}' and password='{txtPass.Text}'", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                pictureBox2.Image = MisonVoiApp.Properties.Resources._9c4904c7730fde517a3d2fba6641ff0c;
                timer1.Start();
            }
            else
            {
                MessageBox.Show("password or login not right");
            }
            con.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            MainForm frm = new MainForm();
            frm.Show();
            
        }
    }
}
