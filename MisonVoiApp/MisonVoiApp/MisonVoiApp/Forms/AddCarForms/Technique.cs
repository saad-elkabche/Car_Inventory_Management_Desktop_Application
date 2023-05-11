using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MisonVoiApp.Forms.AddCarForms
{
    public partial class Technique : Form
    {
        
        public Technique()
        {
            InitializeComponent();
        }
        private void Technique_Load(object sender, EventArgs e)
        {
           
        }

        private void bunifuMaterialTextbox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtConsomation_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.' )
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && txtConsomation.Text.Length == 0)
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && txtConsomation.Text.Contains("."))
            {
                e.Handled = true;

            }
            if (txtConsomation.Text.Length > 2 && e.KeyChar!=(char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtEmission_KeyPress(object sender, KeyPressEventArgs e)
        {
             if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back )
            {
                e.Handled = true;
            }
           
        }

        private void cmbCarburan_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
