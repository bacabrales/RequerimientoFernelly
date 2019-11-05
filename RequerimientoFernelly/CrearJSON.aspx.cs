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
    public partial class CrearJSON : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCrear_Click(object sender, EventArgs e)
        {
            File.WriteAllText(@"C:\Users\BRYAM\source\repos\RequerimientoFernelly\JSON\Categoria.json","["+Session["archivo1"].ToString()+"]");

            File.WriteAllText(@"C:\Users\BRYAM\source\repos\RequerimientoFernelly\JSON\Producto.json", "[" + Session["archivo2"].ToString() + "]");

            alerta.InnerHtml = "<div class='alert alert-success text-center'><p class='mb-0'><strong>Archivo JSON creado</strong></p></div>";

        }
    }
}