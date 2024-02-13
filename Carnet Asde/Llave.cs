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
    public partial class Llave : Form
    {
        public Llave()
        {
            InitializeComponent();
        }

        private void Llave_Load(object sender, EventArgs e)
        {
            Dominio.Tb_Departamentos modelo1 = new Dominio.Tb_Departamentos();
            cbdepartamento.DataSource = modelo1.Datos();
            cbdepartamento.ValueMember = "Direccion";
            cbdepartamento.DisplayMember = "Direccion";
        }

        private void bbuscar_Click(object sender, EventArgs e)
        {
            Dominio.EmpleadosConLlave Modelo = new Dominio.EmpleadosConLlave(cbdepartamento.Text);
            dtgv.DataSource = Modelo.Datos();
        }

        private void tbusquedacodigo_KeyUp(object sender, KeyEventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dtgv.DataSource;
            // bs.Filter = "Nombre like '%" + tbusquedanombre + "%'";
            bs.Filter = "Convert(EmpleadoID, 'System.String') Like '" + tbusquedacodigo.Text + "%'";
            dtgv.DataSource = bs;
        }

        private void tbusquedanombre_KeyUp(object sender, KeyEventArgs e)
        {
            BindingSource bsn = new BindingSource();
            bsn.DataSource = dtgv.DataSource;
            // bsn.Filter = "Nombre like '%" + tbusquedanombre + "%'";
            bsn.Filter = string.Format("Nombre LIKE '%{0}%'", tbusquedanombre.Text);
            //   bs.Filter = "Convert(ProductoID, 'System.String') Like '" + tbusqueda.Text + "%'";
            dtgv.DataSource = bsn;
        }

        private void tbusquedacodigo_Enter(object sender, EventArgs e)
        {
            if (tbusquedacodigo.Text == "Buscar por codigo")
            {
                tbusquedacodigo.Text = "";
                tbusquedacodigo.ForeColor = Color.Black;
            }
        }

        private void tbusquedacodigo_Leave(object sender, EventArgs e)
        {
            if (tbusquedacodigo.Text == "")
            {
                tbusquedacodigo.Text = "Buscar por codigo";
                tbusquedacodigo.ForeColor = Color.DimGray;
            }
        }

        private void tbusquedanombre_Enter(object sender, EventArgs e)
        {
            if (tbusquedanombre.Text == "Buscar por nombre")
            {
                tbusquedanombre.Text = "";
                tbusquedanombre.ForeColor = Color.Black;
            }
        }

        private void tbusquedanombre_Validated(object sender, EventArgs e)
        {

        }

        private void tbusquedanombre_Leave(object sender, EventArgs e)
        {
            if (tbusquedanombre.Text == "Buscar por nombre")
            {
                tbusquedanombre.Text = "";
                tbusquedanombre.ForeColor = Color.Black;
            }
        }
    }
}
