using Acceso_Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ActualizarCarnet
    {
        User_Datos UserDatos = new User_Datos();

        private string cedula;

        public ActualizarCarnet(string cedula)
        {
            this.cedula = cedula;
        }

        public string Carnet()
        {
            UserDatos.ActualizarCarnet(cedula);
            return "Hecho!";
        }
    }
}
