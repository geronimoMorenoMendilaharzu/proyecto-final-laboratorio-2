using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;



namespace CapaDatos
{
    public class CD_productos
    {

        private CD_Conexion conn = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();


        public DataTable CargarCombo() 
        {
            SqlDataAdapter da = new SqlDataAdapter("CargarBebidas", conn.conectarDB);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable mostar()
        {
            comando.Connection = conn.AbrirConexion();
             comando.CommandText = "SELECT * FROM Ventas";
             leer = comando.ExecuteReader();
             tabla.Load(leer);
             conn.CerrarConexion();
             return tabla;
            
        }

        public void insertar(int precio,string nombre, string tamaño, string bebidas)
        {
            SqlCommand comando = new SqlCommand();

            comando.Connection = conn.AbrirConexion();
            comando.CommandText = "INSERT INTO Ventas VALUES(" +precio+" ,'" +nombre+"','"+tamaño+"','"+bebidas+"')";
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conn.CerrarConexion();
        }

        //Tabla 2
        public DataTable mostar1()
        {
            comando.Connection = conn.AbrirConexion();
            comando.CommandText = "SELECT * FROM Stock";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conn.CerrarConexion();
            return tabla;
        }

        public void Editar(int precio, string nombre, string tamaño, string bebidas,int id)
        {
            SqlCommand comando = new SqlCommand();

            comando.Connection = conn.AbrirConexion();
            comando.CommandText = "EditarCombo";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@precio", precio);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@tamaño", tamaño);
            comando.Parameters.AddWithValue("@bebidas", bebidas);
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conn.CerrarConexion();
        }
        public void Eliminar(int id)
        {


            comando.Connection = conn.AbrirConexion();
            comando.CommandText = "EliminarVenta";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idpro", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conn.CerrarConexion();

        }
    }
}
