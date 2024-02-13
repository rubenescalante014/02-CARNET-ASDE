using Acceso_Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Pr_NuevoEmpleado
    {
        User_Datos UserDatos = new User_Datos();

        private string empleadoid;
        private string tarjeta;
        private string nombre;
        private string cedula;
        private string puesto;
        private string departamento;
        private string direccion;

        public Pr_NuevoEmpleado(string empleadoid, string tarjeta, string nombre, 
            string cedula, string puesto, string departamento, string direccion)
        {
            this.empleadoid = empleadoid;
            this.tarjeta = tarjeta;
            this.nombre = nombre;
            this.cedula = cedula;
            this.puesto = puesto;
            this.departamento = departamento;
            this.direccion = direccion;
        }

        public string Nuevo()
        {
            UserDatos.Pr_NuevoEmpleado(empleadoid, tarjeta, nombre, cedula, puesto, direccion, departamento);
            return "Agregado correctamente!";
        }
    }
}
