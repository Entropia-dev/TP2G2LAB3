using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data;

namespace TP2PROG3G1
{
    public class conexiones
    {
        private string ruta_sucursalesdb = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=BDSucursales;Integrated Security=True";


       public int Ejecutar_consunta(string consulta)
        {
            SqlConnection conexion = new SqlConnection(ruta_sucursalesdb);
            conexion.Open();
            SqlCommand comando = new SqlCommand(consulta, conexion);
            int fillas_afectadas = comando.ExecuteNonQuery();
            if (fillas_afectadas == 0)
            {
                //no se pudo agregar en la base de datos
            }
            else
            {
                //se agrego exitosamente
            }
            conexion.Close();
            return fillas_afectadas;

        }

    }

    
}