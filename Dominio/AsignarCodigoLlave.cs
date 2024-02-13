using Acceso_Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class AsignarCodigoLlave
    {
        User_Datos UserDatos = new User_Datos();


        private string cedula;
        private string codigollave;

        public AsignarCodigoLlave(string cedula, string codigollave)
        {
            this.cedula = cedula;
            this.codigollave = codigollave;
        }

        public string Nuevo()
        {
            UserDatos.AsignarCodigoLlave(codigollave, cedula);
            return "Hecho!";
        }
    }
}
