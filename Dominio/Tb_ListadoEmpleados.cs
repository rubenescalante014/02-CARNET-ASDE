using Acceso_Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Tb_ListadoEmpleados
    {
        User_Datos UserDatos = new User_Datos();

        public Tb_ListadoEmpleados(string direccion)
        {
            this.direccion = direccion;
        }

        private string direccion { get; set; }
        public DataTable Datos()
        {
            DataTable tabla = new DataTable();
            tabla = UserDatos.Tb_ListadoEmpleados(direccion);
            return tabla;
        }
    }
}
