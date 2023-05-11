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
        char pass;
        public Login()
        {
            InitializeComponent();
            new Core.DropShaddow().ApplyShadows(this);
            pass = txtPass.PasswordChar;
        }

        private void btnEye_Click(object sender, EventArgs e)
        {
            if(btnEye.IconChar == FontAwesome.Sharp.IconChar.EyeSlash)
            {
                btnEye.IconChar = FontAwesome.Sharp.IconChar.Eye;
                txtPass.PasswordChar = pass;
            }
            else
            {
                btnEye.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                txtPass.UseSystemPasswordChar = false;
                txtPass.PasswordChar='\0';
            }

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            try
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
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Visible = false;
            timer1.Stop();
            MainForm frm = new MainForm();
            frm.StartPosition = FormStartPosition.CenterScreen;

            frm.Login = this;
            frm.Show();
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
