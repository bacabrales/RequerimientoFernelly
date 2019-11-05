using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using Newtonsoft.Json;

namespace RequerimientoFernelly
{
    public partial class InformacionBaseDatos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = Singleton.obtenerConexion();
            SqlCommand comando = new SqlCommand("pa_MostrarProducto", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            DataSet set = new DataSet();
            SqlDataAdapter adap = new SqlDataAdapter(comando);
            adap.Fill(set,"Producto");
            gvDatos.DataSource = set;
            //Session["archivo1"] = JsonConvert.SerializeObject(set);
            gvDatos.DataBind();
            conexion.Close();
            

            SqlConnection conexion2 = Singleton.obtenerConexion();
            SqlCommand comando2 = new SqlCommand("pa_MostrarCategoria", conexion2);
            comando2.CommandType = CommandType.StoredProcedure;
            DataSet set2 = new DataSet();
            SqlDataAdapter adap2 = new SqlDataAdapter(comando2);
            adap2.Fill(set2, "Categoria");
            ddLista.DataSource = set2;
            //Session["archivo2"] = JsonConvert.SerializeObject(set2);
            ddLista.DataValueField = "CodCat";
            ddLista.DataTextField = "NomCat";
            ddLista.DataBind();

        }
    }
}