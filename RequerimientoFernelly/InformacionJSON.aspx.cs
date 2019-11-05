using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;
using Newtonsoft.Json;

namespace RequerimientoFernelly
{
    public partial class InformacionJSON : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
            }
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            string archivo1 = File.ReadAllText(Server.MapPath("Producto.json"));
            DataTable dtInformacion = (DataTable)JsonConvert.DeserializeObject(archivo1, typeof(DataTable));
            gvDatos.DataSource = dtInformacion.DefaultView;
            gvDatos.DataBind();

            string archivo2 = File.ReadAllText(Server.MapPath("Categoria.json"));
            DataTable dtInformacion1 = (DataTable)JsonConvert.DeserializeObject(archivo2, typeof(DataTable));
            ddLista.DataSource = dtInformacion1.DefaultView;
            ddLista.DataValueField = "CodigoCategoria";
            ddLista.DataTextField = "NombreCategoria";
            ddLista.DataBind();
        }
    }
}