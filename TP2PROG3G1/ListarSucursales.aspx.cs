using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace TP2PROG3G1
{
    public partial class Actividad3 : System.Web.UI.Page
    {
        Conexion conectar = new Conexion();
        protected void Page_Load(object sender, EventArgs e)
        {

              String consulta = "select ID_Sucursal, NombreSucursal AS NombreSucursal, DescripcionSucursal AS Descripción, DescripcionProvincia AS Provincia, DireccionSucursal AS Dirección from Sucursal INNER JOIN Provincia on Sucursal.Id_ProvinciaSucursal = Provincia.Id_Provincia";
            if (!IsPostBack)
            {

                conectar.abrirconexion();
                conectar.conectaradaptador(consulta);
                conectar.cargar_tabla("Sucursal");
                grdListadoSucursal.DataSource = conectar.devolvertabla("Sucursal");
                grdListadoSucursal.DataBind();
                conectar.cortarconexion();
                
            }

          
       
        }
    }
}