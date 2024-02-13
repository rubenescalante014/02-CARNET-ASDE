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
    public partial class Nuevo_Empleado : Form
    {
        public Nuevo_Empleado()
        {
            InitializeComponent();
        }

        private void bguardar_Click(object sender, EventArgs e)
        {
            if (empleadoid.Text != "")
            {
                if (tarjeta.Text != "")
                {
                    if (nombre.Text != "")
                    {
                        if (cedula.Text != "")
                        {
                            if (puesto.Text != "")
                            {
                                if (direccion.Text != "")
                                {
                                    if (departamento.Text != "")
                                    {
                                     //   try
                                     //   {
                                            var Modelo = new Dominio.Pr_NuevoEmpleado(
                                            empleadoid: empleadoid.Text,
                                            tarjeta: tarjeta.Text,
                                            nombre: nombre.Text,
                                            cedula: cedula.Text,
                                            puesto: puesto.Text,
                                            departamento: departamento.Text,
                                            direccion: direccion.Text);
                                            var result = Modelo.Nuevo();
                                            MessageBox.Show(result, " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            this.Close();
                                   //     }
                                   //     catch
                                   //     {
                                  //          MessageBox.Show("No pueden haber campos vacios.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                  //      }
                                    }
                                    else
                                        MessageBox.Show("No pueden haber campos vacios.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                    MessageBox.Show("No pueden haber campos vacios.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                                MessageBox.Show("No pueden haber campos vacios.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                            MessageBox.Show("No pueden haber campos vacios.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MessageBox.Show("No pueden haber campos vacios.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("No pueden haber campos vacios.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("El EmpleadoID ya existe.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void Nuevo_Empleado_Load(object sender, EventArgs e)
        {
           
        }

        private void direccion_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void direccion_DropDown(object sender, EventArgs e)
        {
            Dominio.Tb_Departamentos modelo1 = new Dominio.Tb_Departamentos();
            direccion.DataSource = modelo1.Datos();
            direccion.ValueMember = "Direccion";
            direccion.DisplayMember = "Direccion";
        }

        private void bmodificar_Click(object sender, EventArgs e)
        {
            if (empleadoid.Text != "")
            {
                if (tarjeta.Text != "")
                {
                    if (nombre.Text != "")
                    {
                        if (cedula.Text != "")
                        {
                            if (puesto.Text != "")
                            {
                                if (direccion.Text != "")
                                {
                                    if (departamento.Text != "")
                                    {
                                      //  try
                                      //  {
                                            var Modelo = new Dominio.Pr_ActualizarEmpleado(
                                            empleadoid: empleadoid.Text,
                                            tarjeta: tarjeta.Text,
                                            nombre: nombre.Text,
                                            cedula: cedula.Text,
                                            puesto: puesto.Text,
                                            departamento: departamento.Text,
                                            direccion: direccion.Text);
                                            var result = Modelo.Nuevo();
                                            MessageBox.Show(result, " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            this.Close();
                                  //      }
                                      /*  catch
                                        {
                                            MessageBox.Show("No pueden haber campos vacios.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }*/
                                    }
                                    else
                                        MessageBox.Show("No pueden haber campos vacios.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                    MessageBox.Show("No pueden haber campos vacios.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                                MessageBox.Show("No pueden haber campos vacios.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                            MessageBox.Show("No pueden haber campos vacios.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MessageBox.Show("No pueden haber campos vacios.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("No pueden haber campos vacios.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("No pueden haber campos vacios.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
