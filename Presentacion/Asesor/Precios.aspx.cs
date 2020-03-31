using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Vestinos_S.A.logica;

namespace Vestinos_S.A.Presentacion.Asesor
{
    public partial class Precios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void listaPrecios()
        {

            Producto p = new Producto();

            foreach (Producto producto in p.consultarTodos())
            {
                Response.Write("<tr>");
                Response.Write("<td>" + producto.idprend + "</td>");
                Response.Write("<td>" + producto.id_t + "</td>");
                Response.Write("<td>" + producto.precio + "</td>");
                Response.Write("<td>" + producto.cantprend + "</td>");

                Response.Write("</tr>");

            }
        }

    }
}