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


       public int Ejecutar_consulta(string consulta)
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

        //las consultas tienen funcionalidad parecida por que no    
        //pudimos coordinar la creacionde una clase en comun.
        public int ejecutarTransaccion(string consulta) // insertar, eliminar, modificar 
        {
            SqlConnection conexion = new SqlConnection(ruta_sucursalesdb);
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

        //METODOS NECESARIOS PARA EL APARTADO DE LISTAR SUCURSALES
        private SqlConnection cn;
        private SqlDataAdapter adaptador;
        private DataSet ds = new DataSet();





        public void abrirconexion()
        {
            cn = new SqlConnection(ruta_sucursalesdb);

            cn.Open();
        }



        public void conectaradaptador(string consulta)
        {
            adaptador = new SqlDataAdapter(consulta, cn);
        }



        public void cargar_tabla(string tabla)
        {

            adaptador.Fill(ds, tabla);
        }

        public DataTable devolvertabla(string tabla)
        {
            return ds.Tables[tabla];


        }

        public void cortarconexion()

        {

            cn.Close();
        }
    }

    
}