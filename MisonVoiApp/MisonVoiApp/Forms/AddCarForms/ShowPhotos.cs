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

namespace MisonVoiApp.Forms.AddCarForms
{
    public partial class ShowPhotos : Form
    {
        public MemoryStream ms1, ms2, ms3;
        int nb = 1;
        public ShowPhotos()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            nb++;
            if (nb > 3)
                nb = 1;
            navigi();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            nb--;
            if (nb < 1)
                nb= 3;
            navigi();
        }

        private void ShowPhotos_Load(object sender, EventArgs e)
        {
            navigi();
        }

        private void navigi()
        {
            if (nb == 1) 
            {
                if (ms1 != null)
                    pictureBox1.Image = Image.FromStream(ms1);
            }
            if (nb == 2)
            {
                if (ms2 != null)
                    pictureBox1.Image = Image.FromStream(ms2);
            }
            if (nb == 3)
            {
                if (ms3 != null)
                    pictureBox1.Image = Image.FromStream(ms3);
            }
        }
    }
}
