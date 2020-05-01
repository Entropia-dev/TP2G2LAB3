using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data;
using System.Data.SqlClient;

namespace TP2PROG3G1
{
    public partial class Actividad1 : System.Web.UI.Page
    {

       

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargar_provincias();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string consulta = "insert into Sucursal(NombreSucursal,DescripcionSucursal,Id_ProvinciaSucursal,DireccionSucursal,Id_HorarioSucursal)values('" + txtNombresc.Text+ "','" + txtDesc.Text+ "'," + ddlpcias.SelectedValue+ ",'" + txtDireccion.Text+ "','2')";
            conexiones con = new conexiones();
            con.Ejecutar_consunta(consulta);
        }

        private void cargar_provincias()
        {
            ddlpcias.DataSource = Consultar("SELECT * FROM Provincia");
            ddlpcias.DataTextField = "DescripcionProvincia";
            ddlpcias.DataValueField = "Id_Provincia";
            ddlpcias.DataBind();
            ddlpcias.Items.Insert(0, new ListItem("[Seleccionar]", "0"));
            ddlpcias.Items.Insert(0, new ListItem("[Seleccionar]", "0"));
        }

        public DataSet Consultar(string strSQL)
        {
            string strconn = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=BDSucursales;Integrated Security=True";
            SqlConnection con = new SqlConnection(strconn);
            con.Open();
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            return ds;
        }

    }
}