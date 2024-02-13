using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Comun;

namespace CARNET_ASDE
{
    public partial class ListadoEmpleados : Form
    {
        public ListadoEmpleados()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.MaximumSize = SystemInformation.PrimaryMonitorMaximizedWindowSize;
        }

        private void ListadoEmpleados_Load(object sender, EventArgs e)
        {
            if(CacheInicioSesion.privilegio == 1 || CacheInicioSesion.privilegio == 3)
            {
                bllave.Visible = true;
            }

            Dominio.Tb_Departamentos modelo1 = new Dominio.Tb_Departamentos();
            cbdepartamento.DataSource = modelo1.Datos();
            cbdepartamento.ValueMember = "Direccion";
            cbdepartamento.DisplayMember = "Direccion";
        }

        /*private void brefrescar_Click(object sender, EventArgs e)
        {
            tbusquedacodigo.Text = "Buscar por codigo";
            tbusquedanombre.Text = "Buscar por nombre";

        }*/

        private void tbusquedacodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
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

        private void tbusquedanombre_Leave(object sender, EventArgs e)
        {
            if (tbusquedanombre.Text == "")
            {
                tbusquedanombre.Text = "Buscar por nombre";
                tbusquedanombre.ForeColor = Color.DimGray;
            }
        }

        private void dtgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (CacheInicioSesion.privilegio == 1 || CacheInicioSesion.privilegio == 2)
            {
                Carnet1 c = new Carnet1();

                c.label1.Text = dtgv.CurrentRow.Cells[1].Value.ToString();
                c.nombre.Text = dtgv.CurrentRow.Cells[2].Value.ToString();
                c.cargo.Text = dtgv.CurrentRow.Cells[4].Value.ToString();
                c.departamento.Text = dtgv.CurrentRow.Cells[5].Value.ToString();
                c.cedula.Text = dtgv.CurrentRow.Cells[3].Value.ToString();

                c.ShowDialog();
            }
            else
            {
                MessageBox.Show("No tienes permiso para imprimir");
            }
            
        }

        private void bbuscar_Click(object sender, EventArgs e)
        {
            Dominio.Tb_ListadoEmpleados Modelo = new Dominio.Tb_ListadoEmpleados(cbdepartamento.Text);
            dtgv.DataSource = Modelo.Datos();
        }

        private void ListadoEmpleados_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void bnuevo_Click(object sender, EventArgs e)
        {
            if(CacheInicioSesion.privilegio == 1 || CacheInicioSesion.privilegio == 2)
            {
                Nuevo_Empleado n = new Nuevo_Empleado();
                n.ShowDialog();
            }
            else
            {
                MessageBox.Show("No tienes permiso para crear nuevo");
            }
                
        }

        private void bllave_Click(object sender, EventArgs e)
        {
            Llave l = new Llave();
            l.ShowDialog();
        }

        private void dtgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            // Ignore if a column or row header is clicked
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if (e.Button == MouseButtons.Right)
                {
                    DataGridViewCell clickedCell = (sender as DataGridView).Rows[e.RowIndex].Cells[e.ColumnIndex];

                    // Here you can do whatever you want with the cell
                    this.dtgv.CurrentCell = clickedCell;  // Select the clicked cell, for instance

                    // Get mouse position relative to the vehicles grid
                    var relativeMousePosition = dtgv.PointToClient(Cursor.Position);

                    // Show the context menu
                    this.contextMenuStrip1.Show(dtgv, relativeMousePosition);
                }
            }


        }

        private void llaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CacheInicioSesion.privilegio == 1 || CacheInicioSesion.privilegio == 3 || CacheInicioSesion.privilegio == 4) 
            {
                string chec;
                chec = Convert.ToString(dtgv.CurrentRow.Cells[8].Value);

                if (chec == "True")
                {
                    MessageBox.Show("Este Empleado ya tiene Tarjeta");

                }
                else
                {
                    LlaveAsignar c = new LlaveAsignar();

                    c.nombre.Text = dtgv.CurrentRow.Cells[2].Value.ToString();
                    c.cedula.Text = dtgv.CurrentRow.Cells[3].Value.ToString();

                    c.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("No tienes permiso para asignar tarjeta");
            }
            
            
            
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nuevo_Empleado n = new Nuevo_Empleado();

            n.bguardar.Visible = false;
            n.bmodificar.Visible = true;

            n.titulomodificar.Visible = true;

            n.textBox1.Text = dtgv.CurrentRow.Cells[0].Value.ToString();
            n.empleadoid.Text = dtgv.CurrentRow.Cells[0].Value.ToString();
         //   n.empleadoid.Enabled = false;
            n.tarjeta.Text = dtgv.CurrentRow.Cells[1].Value.ToString();
          // n.tarjeta.Enabled = false;
            n.nombre.Text = dtgv.CurrentRow.Cells[2].Value.ToString();
            n.cedula.Text = dtgv.CurrentRow.Cells[3].Value.ToString();
          //  n.cedula.Enabled = false;
            n.puesto.Text = dtgv.CurrentRow.Cells[4].Value.ToString();
            n.direccion.ValueMember = dtgv.CurrentRow.Cells[6].Value.ToString();
            n.departamento.Text = dtgv.CurrentRow.Cells[5].Value.ToString();

            n.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Carnet_Honorifico c = new Carnet_Honorifico();
            c.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Carnet_Acceso_VIP c = new Carnet_Acceso_VIP();
            c.ShowDialog();
        }
    }
}