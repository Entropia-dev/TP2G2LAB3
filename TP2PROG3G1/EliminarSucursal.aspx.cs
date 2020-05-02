using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace TP2PROG3G1
{
    public partial class Actividad2 : System.Web.UI.Page
    {
        private conexiones conexion = new conexiones();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string consulta = "DELETE FROM SUCURSAL WHERE ID_SUCURSAL=" + txtIdELiminar.Text;
            conexion.ejecutarTransaccion(consulta);
            txtIdELiminar.Text = "";
            lblMensaje.Text = "Sucursal eliminada con exito! ";
        }
    }
}