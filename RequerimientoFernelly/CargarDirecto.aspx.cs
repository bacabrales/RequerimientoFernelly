using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace RequerimientoFernelly
{
    public partial class CargarDirecto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SqlConnection conexion = Singleton.obtenerConexion();
                SqlCommand comando = new SqlCommand("pa_MostrarProducto", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                DataSet set = new DataSet();
                SqlDataAdapter adap = new SqlDataAdapter(comando);
                adap.Fill(set, "Producto");
                gvDatos.DataSource = set;
                gvDatos.DataBind();
                conexion.Close();


                SqlConnection conexion2 = Singleton.obtenerConexion();
                SqlCommand comando2 = new SqlCommand("pa_MostrarCategoria", conexion2);
                comando2.CommandType = CommandType.StoredProcedure;
                DataSet set2 = new DataSet();
                SqlDataAdapter adap2 = new SqlDataAdapter(comando2);
                adap2.Fill(set2, "Categoria");
                ddLista.DataSource = set2;
                ddLista.DataValueField = "CodCat";
                ddLista.DataTextField = "NomCat";
                ddLista.DataBind();
            }

            
        }

        protected void ddLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            int dato = Convert.ToInt32(ddLista.SelectedValue);
            SqlConnection conexion3 = Singleton.obtenerConexion();
            SqlCommand comando3 = new SqlCommand("pa_idProducto", conexion3);
            comando3.CommandType = CommandType.StoredProcedure;
            comando3.Parameters.Add("@dato", SqlDbType.Int).Value = dato;

            DataSet set3 = new DataSet();
            SqlDataAdapter adap3 = new SqlDataAdapter(comando3);
            adap3.Fill(set3, "Producto");
            gvDatos.DataSource = set3;
            gvDatos.DataBind();
            conexion3.Close();
        }
    }
}