using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acceso_Datos
{
    public class Conexion
    {
        private readonly string ConectionString;

        public Conexion()
        {
            ConectionString = "Server=tcp:172.16.24.214,1433; DataBase=CarnetAsde; User Id=sa; Password=Asde123456";

           /* ConectionString = "Server=tcp:escalantedeveloper.database.windows.net,1433;Initial Catalog=CarnetAsde;Persist Security Info=False;User ID=EscaAdmin;Password=Mellonlo14++14;" +
                "MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";*/

            //ConectionString = "workstation id=CarnetAsde.mssql.somee.com;packet size=4096;user id=escalante014_SQLLogin_1;pwd=bbkzrhxtaz;data source=CarnetAsde.mssql.somee.com;persist security info=False;initial catalog=CarnetAsde";

          //  ConectionString = "Server=CarnetAsde.mssql.somee.com; DataBase=CarnetAsde"
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(ConectionString);

        }
    }
}
