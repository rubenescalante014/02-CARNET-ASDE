using Acceso_Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Pr_ActualizarEmpleado
    {
        User_Datos UserDatos = new User_Datos();

        private string empleadoid;
        private string tarjeta;
        private string nombre;
        private string cedula;
        private string puesto;
        private string departamento;
        private string direccion;

        public Pr_ActualizarEmpleado(string empleadoid, string tarjeta, string nombre, string cedula, 
            string puesto, string departamento, string direccion
            )
        {
            this.empleadoid = empleadoid;
            this.nombre = nombre;
            this.puesto = puesto;
            this.departamento = departamento;
            this.direccion = direccion;
            this.tarjeta = tarjeta;
            this.cedula = cedula;
        }

        public string Nuevo()
        {
            UserDatos.Pr_ActualizarEmpleado(empleadoid, tarjeta, nombre, cedula, puesto, direccion, departamento);
            return "Actualizado correctamente!";
        }
    }
}
