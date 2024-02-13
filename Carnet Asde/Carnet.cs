using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CARNET_ASDE
{
    public partial class Carnet : Form
    {
        public Carnet()
        {
            InitializeComponent();
        }

        private void bimprimir_Click(object sender, EventArgs e)
        {
          /*  Bitmap bmp;
            System.IO.MemoryStream ms = new System.IO.MemoryStream();

            bmp = new Bitmap(panel1.Width, panel1.Height);
            panel1.DrawToBitmap(bmp, new Rectangle(0, 0, Width, Height));
            bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);

            // bmp.Save(@"C:\");*/
            SaveFileDialog fd = new SaveFileDialog();
            fd.Filter = "Text files (*.png)|*.jpg|All files (*.*)|*.*";
            fd.FileName = cedula.Text;


            // fo.FileName = textBox4.Text;
            // bmp.Save(
            // new Bitmap(image).Save(ms, ImageFormat.Jpeg);

          //  bmp.Save("C:\\"+ cedula.Text +".png");
            DialogResult rs = fd.ShowDialog();
            if (rs == DialogResult.OK)
            {
                Bitmap bmp;
                System.IO.MemoryStream ms = new System.IO.MemoryStream();

                bmp = new Bitmap(panel1.Width, panel1.Height);
                panel1.DrawToBitmap(bmp, new Rectangle(0, 0, Width, Height));
                bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);

                // bmp = (Bitmap)Image.FromFile(fd.FileName);
                bmp.Save(fd.FileName);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void verticalLabel_UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Paint(object sender, PaintEventArgs e)
        {
          /*  Font myfont = new Font("Roboto", 12, FontStyle.Bold);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
            e.Graphics.TranslateTransform(30, 170);
            e.Graphics.RotateTransform(-90);
            e.Graphics.DrawString(codigo.Text, myfont, mybrush, 0, 0);*/
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fo = new OpenFileDialog();
            fo.Filter = "Text files (*.jpg)|*.jpg|All files (*.*)|*.*";
            DialogResult rs = fo.ShowDialog();
            if (rs == DialogResult.OK)
            {
                imagen.Image = Image.FromFile(fo.FileName);
            }
        }

        private void Carnet_Load(object sender, EventArgs e)
        {
            verticalLabel1.Text = label1.Text;
        }

        private void bimprimir_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.Filter = "Text files (*.png)|*.jpg|All files (*.*)|*.*";
            fd.FileName = cedula.Text;

            DialogResult rs = fd.ShowDialog();
            if (rs == DialogResult.OK)
            {
                Bitmap bmp;
                System.IO.MemoryStream ms = new System.IO.MemoryStream();

                bmp = new Bitmap(panel1.Width, panel1.Height);
                panel1.DrawToBitmap(bmp, new Rectangle(0, 0, Width, Height));
                bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);

                // bmp = (Bitmap)Image.FromFile(fd.FileName);
                bmp.Save(fd.FileName);
            }
        }
    }
}
