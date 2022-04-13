using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CD_Conexion
    {
        private string cadenaConexion;
        public SqlConnection conectarDB;
        
        public CD_Conexion()
        {
            cadenaConexion = ("Data Source = DESKTOP-9NUI6O6\\SQLEXPRESS; DataBase= Bd_mcdonals; User ID = sa; Password = 1234");
            conectarDB = new SqlConnection();
            conectarDB.ConnectionString = cadenaConexion;
        }
        public SqlConnection AbrirConexion()
        {
            conectarDB.Open();
               
            return conectarDB;
        }

        public SqlConnection CerrarConexion()
        {
            conectarDB.Close();
                 return conectarDB;
        }
        public SqlConnection getconexion() {
            return conectarDB;
        }
        


    }
}
