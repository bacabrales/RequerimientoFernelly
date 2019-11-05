using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Newtonsoft.Json;

namespace RequerimientoFernelly
{
    public partial class ArchivosXML : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               
            }
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            DataSet set = new DataSet();
            DataSet set2 = new DataSet();
            set.ReadXml(Server.MapPath("Categoria.xml"));
            ddLista.DataSource = set;
            Session["archivo1"] = JsonConvert.SerializeObject(set);
            ddLista.DataValueField = "CodigoCategoria";
            ddLista.DataTextField = "NombreCategoria";
            ddLista.DataBind();

            set2.ReadXml(Server.MapPath("Producto.xml"));
            gvDatos.DataSource = set2;
            Session["archivo2"] = JsonConvert.SerializeObject(set2);
            gvDatos.DataBind();
        }
    }
}