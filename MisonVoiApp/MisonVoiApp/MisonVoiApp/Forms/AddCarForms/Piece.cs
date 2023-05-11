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

namespace MisonVoiApp.Forms.AddCarForms
{
    public partial class Piece : Form
    {
        SqlCommand cmd;
        SqlConnection con = Connection.con;
        SqlDataReader dr;
        BindingSource bs;
        public Piece()
        {
            InitializeComponent();
        }

        private void Piece_Load(object sender, EventArgs e)
        {
            fill_Data();
        }

        private void fill_Data()
        {
            //combo
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
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }
            //dataGrd
            cmd = new SqlCommand("select piece.idPiece,piece.nomPiece,piece.quantiti,piece.prix,voiture.modele from piece join voiture on piece.idVoiture=voiture.idVoiture", con);
            try
            {
                con.Open();
                dr = cmd.ExecuteReader();
                dataGridPiece.Rows.Clear();
                while (dr.Read())
                {
                    dataGridPiece.Rows.Add(dr["idPiece"], dr["nomPiece"],dr["quantiti"], dr["prix"], dr["modele"]);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }

        }

        private void CRUD(object sender, EventArgs e)
        {
            string txt = (sender as FontAwesome.Sharp.IconButton).Text;
            if (txt == "Ajouter")
            {
                cmd = new SqlCommand("insert into piece values(@nom,@idVoi,@prix)",con);
                excute_Query(cmd, "insert");
            }
            else if (txt == "Modifier")
            {
                cmd = new SqlCommand("update piece set idVoiture =@idVoi, nomPiece =@nom, prix =@prix where idPiece =@id ",con);
                excute_Query(cmd, "");
            }
            else
            {
                cmd = new SqlCommand(@"delete from piece where idPiece=@id", con);
                excute_Query(cmd, "delete");
            }
        }
        void excute_Query(SqlCommand command,string str)
        {
            if (str != "delete")
            {
                command.Parameters.AddWithValue("@nom", txtNomPierce.Text);
                command.Parameters.AddWithValue("@prix", Convert.ToDouble(txtPrixPierc.Text==""?"0": txtPrixPierc.Text));
                command.Parameters.AddWithValue("@idVoi", int.Parse(cmbVoture.SelectedValue.ToString()));
            }
            if (str != "insert")
            {
                if (dataGridPiece.CurrentRow != null)
                {
                    command.Parameters.AddWithValue("@id", int.Parse(dataGridPiece.CurrentRow.Cells[0].Value.ToString()));
                }
                else
                {
                    return;
                }
                dataGridPiece.Enabled = true;
            }
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            fill_Data();
        }

        private void txtPrixPierc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar!=(char)Keys.Back && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if(e.KeyChar=='.' && txtPrixPierc.Text.Length == 0)
            {
                e.Handled = true;
            }
            if(e.KeyChar=='.' && txtPrixPierc.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            foreach (GunaTextBox item in this.Controls.OfType< GunaTextBox>())
            {
                item.Clear();
            }
        }

        private void dataGridPiece_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridPiece.CurrentRow != null)
            {
                cmbVoture.Text = dataGridPiece.CurrentRow.Cells[4].Value.ToString();
                txtNomPierce.Text = dataGridPiece.CurrentRow.Cells[1].Value.ToString();
                txtQuantiti.Text = dataGridPiece.CurrentRow.Cells[2].Value.ToString();
                txtPrixPierc.Text = dataGridPiece.CurrentRow.Cells[3].Value.ToString();
            }
          
        }
    }
}
