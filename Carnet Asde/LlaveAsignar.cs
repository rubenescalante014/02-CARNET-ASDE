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
    public partial class LlaveAsignar : Form
    {
        public LlaveAsignar()
        {
            InitializeComponent();
        }

        private void bimprimir_Click(object sender, EventArgs e)
        {
            var Modelo = new Dominio.AsignarCodigoLlave(
                cedula: cedula.Text,
                codigollave: codigollave.Text);
            var result = Modelo.Nuevo();
            MessageBox.Show(result, " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void codigollave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
