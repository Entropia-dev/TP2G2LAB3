using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace TP2PROG3G1
{
    public class Conexion
    {
        private string ruta = "Data Source=localhost\\sqlexpress;Initial Catalog=BDSucursales;Integrated Security=True";

        public int ejecutarTransaccion(string consulta) // insertar, eliminar, modificar 
        {
            SqlConnection conexion = new SqlConnection(ruta);
            conexion.Open();
            //sqlCommand me sirve para realizar instrucciones de tipo insert, delete y update
            SqlCommand comando = new SqlCommand(consulta, conexion);

            //Ejecutar el comando 
            int filasAfectadas = comando.ExecuteNonQuery();

            //  if (filasAfectadas == 0)
            //{
            //      //No se pudo agregar a la BASE DE DATOS
            //}
            //else
            //{

            //Se pudo agregar a la BASE DE DATOS correctamente
            //}

            conexion.Close();

            return filasAfectadas;
        }

    }
}