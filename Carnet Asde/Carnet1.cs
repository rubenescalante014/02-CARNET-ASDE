using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CARNET_ASDE
{
    public partial class Carnet1 : Form
    {
        public Carnet1()
        {
            InitializeComponent();
        }

        private void nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void imagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog fo = new OpenFileDialog();
            fo.Filter = "Text files (*.jpg)|*.jpg|All files (*.*)|*.*";
            DialogResult rs = fo.ShowDialog();
            if (rs == DialogResult.OK)
            {
                imagen.Image = Image.FromFile(fo.FileName);
            }
        }

        private void bimprimir_Click(object sender, EventArgs e)
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

                var Modelo = new Dominio.ActualizarCarnet(
                    cedula: cedula.Text);
                var result = Modelo.Carnet();
             //   MessageBox.Show(result, " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void Carnet1_Load(object sender, EventArgs e)
        {
            tcodigo.Text = label1.Text;
         //   verticalLabel1.Text = label2.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  var textBox = (TextBox)client.Controls[0];
            // nombre.Font = new Font(nombre.Font.FontFamily,, 23);

            nombre.Font = new Font("Roboto", 22, FontStyle.Bold);
        }

        private void verticalLabel4_Click(object sender, EventArgs e)
        {
            

        }


        private void button2_Click(object sender, EventArgs e)
        {
            /* Image image = new Bitmap(imagen.Image);

             // Draw the image unaltered with its upper-left corner at (0, 0).
             e.Graphics.DrawImage(image, 0, 0);

             // Make the destination rectangle 30 percent wider and
             // 30 percent taller than the original image.
             // Put the upper-left corner of the destination
             // rectangle at (150, 20).
             int width = image.Width;
             int height = image.Height;
             RectangleF destinationRect = new RectangleF(
                 150,
                 20,
                 1.3f * width,
                 1.3f * height);

             // Draw a portion of the image. Scale that portion of the image
             // so that it fills the destination rectangle.
             RectangleF sourceRect = new RectangleF(0, 0, .75f * width, .75f * height);
             e.Graphics.DrawImage(
                 image,
                 destinationRect,
                 sourceRect,
                 GraphicsUnit.Pixel);*/

            this.imagen.SizeMode = PictureBoxSizeMode.CenterImage;
            this.imagen.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void imagen_MouseUp(object sender, MouseEventArgs e)
        {

        }




        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void cedula_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
