using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Vestinos_S.A.logica;

namespace Vestinos_S.A.Presentacion.Asesor
{
    public partial class VerClientes : System.Web.UI.Page
    {
        Cliente c;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void listaClientes()
        {

            c = new Cliente();

            foreach (Cliente cliente in c.consultarTodos())
            {
                Response.Write("<tr>");
                Response.Write("<td>" + cliente.cc + "</td>");
                Response.Write("<td>" + cliente.nom1 + "</td>");
                Response.Write("<td>" + cliente.ape1 + "</td>");
                Response.Write("<td><a href='Presentacion/Asesor/AcCliente.aspx'><i class='fas fa-user-check' data-toggle='tooltip' data-placement='left' title='Actualizar'></i></td>");
                Response.Write("</tr>");

            }
        }
    }
}