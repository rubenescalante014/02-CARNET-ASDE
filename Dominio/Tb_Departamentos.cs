using Acceso_Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Tb_Departamentos
    {
        User_Datos UserDatos = new User_Datos();

        public DataTable Datos()
        {
            DataTable tabla = new DataTable();
            tabla = UserDatos.Tb_Departamentos();
            return tabla;
        }
    }
}
