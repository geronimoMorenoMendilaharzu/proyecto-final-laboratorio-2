using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
using System.Data.SqlClient;


namespace CapaNegocio
{ 
    public class CN_productos
    {
        private CD_productos objetoCD = new CD_productos();

        
        public DataTable mostrarProd()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.mostar();
            return tabla;
        }
        public DataTable mostrarProd1()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.mostar1();
            return tabla;
        }
        public void InsertarPRod(string precio,string nombre, string tamaño, string bebidas)
        {
            objetoCD.insertar(Convert.ToInt32(precio),nombre,tamaño,bebidas);
        }
        public void EditarPRod(string precio, string nombre, string tamaño, string bebidas, string id)
        {
            objetoCD.Editar(Convert.ToInt32(precio), nombre, tamaño, bebidas, Convert.ToInt32(id));
        }
        public void EliminarPRod(string id)
        {
            objetoCD.Eliminar(Convert.ToInt32(id));
        }
    }
   
}
