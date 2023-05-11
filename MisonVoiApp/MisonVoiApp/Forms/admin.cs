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
    public partial class admin : Form
    {
        SqlConnection con = Connection.con;
        SqlCommand cmd;
        SqlDataReader dr;
        public admin()
        {
            InitializeComponent();
            new Core.DropShaddow().ApplyShadows(this);
        }

        private void admin_Load(object sender, EventArgs e)
        {
            fill_data();
        }
        void fill_data()
        {
            try
            {
                cmd = new SqlCommand("select * from users", con);
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    dataGridUsers.Rows.Clear();
                    foreach (DataRow item in dt.Rows)
                    {
                        dataGridUsers.Rows.Add(item[0], item[1]);
                    }
                }
                else
                {
                    dataGridUsers.Rows.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
        private void btnAddClient_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtLogin.Text))
            {
                cmd = new SqlCommand("select * from users where [user]=@u", con);
                cmd.Parameters.AddWithValue("@u", txtLogin.Text);
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows==false)
                {
                    con.Close();
                    try
                    {
                        cmd = new SqlCommand("insert into users values(@u,@l)", con);
                        cmd.Parameters.AddWithValue("@u", txtLogin.Text);
                        cmd.Parameters.AddWithValue("@l", txtPass.Text);
                        Connection.close_connection();
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    con.Close();
                    fill_data();
                }
                else
                {
                    MessageBox.Show("ce utilisateur est exist deja");
                }
                Connection.close_connection();
                
            }
        }

        private void btnEditClient_Click(object sender, EventArgs e)
        {
            if (dataGridUsers.CurrentRow!=null)
            {
                cmd = new SqlCommand($"update [users] set password= @pass where [user]='{dataGridUsers.CurrentRow.Cells[0].Value.ToString()}'", con);
                cmd.Parameters.AddWithValue("@pass", txtPass.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                fill_data();
            }
            else
            {
                MessageBox.Show("aucaun utilasateur"); ;
            }
            Connection.close_connection();
           
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            if (dataGridUsers.CurrentRow != null)
            {
                try
                {


                    cmd = new SqlCommand($"delete from [users] where [user]='{dataGridUsers.CurrentRow.Cells[0].Value.ToString()}'", con);
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

        private void labaleClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
