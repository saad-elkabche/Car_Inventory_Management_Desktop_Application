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
    public partial class photo : Form
    {
        int ind = 1;
        bool choosePicture = false;
        public byte[] photo1,photo2,photo3;
        Size picOriginalSize;
        public photo()
        {
            InitializeComponent();
        }

        private void pictureEdit(object sender, MouseEventArgs e)
        {

            PictureBox pic = sender as PictureBox;
            if (pic.Image != null)
            {
                picOriginalSize = pic.Size;
                string txt = pic.Tag.ToString();
                if (txt == "1")
                {
                    ind = 1;
                }
                else if (txt == "2")
                {
                   
                    ind = 2;
                }
                else
                {
                    ind = 3;
                }
                MainPic.Image = pic.Image;
                addPic.Enabled = false;
            }

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            pic1.Size = pic2.Size = pic3.Size = picOriginalSize;
        }

        private void photo_Click(object sender, EventArgs e)
        {
            picOriginalSize = pic1.Size;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            addPic.Enabled = true;
            openFileDialog1.Filter = "pictures |*.jpg;*.jpeg;*.jfif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (openFileDialog1.OpenFile() != null)
                    {
                        MainPic.Image = Image.FromStream(openFileDialog1.OpenFile());
                        choosePicture = true;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (choosePicture)
            {
                MemoryStream str = new MemoryStream();
                MainPic.Image.Save(str, System.Drawing.Imaging.ImageFormat.Jpeg);
                if (ind == 1)
                {
                    pic1.Image = Image.FromStream(str);
                    photo1 = str.ToArray();
                }

                else if (ind == 2)
                {
                    pic2.Image = Image.FromStream(str);
                    photo2 = str.ToArray();
                }

                else
                {
                    pic3.Image = Image.FromStream(str);
                    photo3 = str.ToArray();
                    ind = 1;
                    return;
                }
                ind++;
            }
           
        }
    }
}
