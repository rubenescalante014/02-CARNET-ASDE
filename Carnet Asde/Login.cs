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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            this.MaximumSize = SystemInformation.PrimaryMonitorMaximizedWindowSize;
        }

        private void tuser_Enter(object sender, EventArgs e)
        {
            if (tuser.Text == "Usuario")
            {
                tuser.Text = "";
                tuser.ForeColor = Color.Black;             
            }
        }

        private void tuser_Leave(object sender, EventArgs e)
        {
            if (tuser.Text == "")
            {
                tuser.Text = "Usuario";
                tuser.ForeColor = Color.DimGray;
            }
        }

        private void tpass_Enter(object sender, EventArgs e)
        {
            if (tpass.Text == "Contraseña")
            {
                tpass.Text = "";
                tpass.ForeColor = Color.Black;
                tpass.UseSystemPasswordChar = true;
            }
        }

        private void tpass_Leave(object sender, EventArgs e)
        {
            if (tpass.Text == "")
            {
                tpass.Text = "Contraseña";
                tpass.ForeColor = Color.DimGray;
                tpass.UseSystemPasswordChar = false;
            }
        }

        private void tpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                blogin_Click(sender, e);
            }
        }

        private void blogin_Click(object sender, EventArgs e)
        {
            if (tuser.Text != "Usuario")
            {
                if (tpass.Text != "Contraseña")
                {
                     Dominio.Login user = new Dominio.Login();
                     var ValidarLogin = user.LoginUser(tuser.Text, tpass.Text);
                     if (ValidarLogin == true)
                     {
                         ListadoEmpleados Listado = new ListadoEmpleados();
                         Listado.Show();
                         this.Hide();
                     }
                    else { }
               //          MensajeError("Usuario o Contraseña Incorrecto.");
                     //tpass.Clear();

                }
                else
                    errorpass.Visible = true;
                tpass.Focus();
            }
            else
                erroruser.Visible = true;
            tuser.Focus();
        }

        private void erroruser_Click(object sender, EventArgs e)
        {

        }
    }
}
