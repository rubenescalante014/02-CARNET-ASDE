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
    public partial class Carnet_Acceso_VIP : Form
    {
        public Carnet_Acceso_VIP()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nombre_Enter(object sender, EventArgs e)
        {
            if (nombre.Text == "#NOMBRE")
            {
                nombre.Text = "";
            }
        }

        private void nombre_Leave(object sender, EventArgs e)
        {
            if (nombre.Text == "")
            {
                nombre.Text = "#NOMBRE";
            }
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
    }
}
