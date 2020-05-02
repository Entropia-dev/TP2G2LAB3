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
        conexiones conectar = new conexiones();
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

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {

        }

        protected void btnMostrar_Click(object sender, EventArgs e)
        {
            String consulta = "select ID_Sucursal, NombreSucursal AS NombreSucursal, DescripcionSucursal AS Descripción, DescripcionProvincia AS Provincia, DireccionSucursal AS Dirección from Sucursal INNER JOIN Provincia on Sucursal.Id_ProvinciaSucursal = Provincia.Id_Provincia";

            conectar.abrirconexion();
            conectar.conectaradaptador(consulta);
            conectar.cargar_tabla("Sucursal");
            grdListadoSucursal.DataSource = conectar.devolvertabla("Sucursal");
            grdListadoSucursal.DataBind();
            conectar.cortarconexion();
            limpiar();
        }
        public void limpiar()
        {
            txtIngreseSucursal.Text = " ";
        }

        protected void btnFiltrar_Click1(object sender, EventArgs e)
        {
            string consulta = "select ID_Sucursal, NombreSucursal AS NombreSucursal, DescripcionSucursal AS Descripción, DescripcionProvincia AS Provincia, DireccionSucursal AS Dirección from Sucursal INNER JOIN Provincia on Sucursal.Id_ProvinciaSucursal = Provincia.Id_Provincia where ID_Sucursal ='" + txtIngreseSucursal.Text + "'";

            conectar.abrirconexion();
            conectar.conectaradaptador(consulta);
            conectar.cargar_tabla("Sucursal");
            grdListadoSucursal.DataSource = conectar.devolvertabla("Sucursal");
            grdListadoSucursal.DataBind();
            conectar.cortarconexion();
            limpiar();
        }

        protected void btnMostrar_Click1(object sender, EventArgs e)
        {
            String consulta = "select ID_Sucursal, NombreSucursal AS NombreSucursal, DescripcionSucursal AS Descripción, DescripcionProvincia AS Provincia, DireccionSucursal AS Dirección from Sucursal INNER JOIN Provincia on Sucursal.Id_ProvinciaSucursal = Provincia.Id_Provincia";

            conectar.abrirconexion();
            conectar.conectaradaptador(consulta);
            conectar.cargar_tabla("Sucursal");
            grdListadoSucursal.DataSource = conectar.devolvertabla("Sucursal");
            grdListadoSucursal.DataBind();
            conectar.cortarconexion();
            limpiar();
        }
    }
}