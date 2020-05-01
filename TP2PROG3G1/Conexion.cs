using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data.SqlClient;
using System.Data;




namespace TP2PROG3G1
{
    
    public class Conexion
    {
        private string ruta = "Data Source=localhost\\sqlexpress;Initial Catalog = BDSucursales; Integrated Security = True";

        private SqlConnection cn;
        private SqlDataAdapter adaptador;
        private DataSet ds = new DataSet();
        
       


       
      public  void abrirconexion()
        {
            cn = new SqlConnection(ruta);

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