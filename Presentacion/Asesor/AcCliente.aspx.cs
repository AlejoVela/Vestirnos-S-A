using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Vestinos_S.A.logica;

namespace Vestinos_S.A.Presentacion.Asesor
{
    public partial class AcCliente : System.Web.UI.Page
    {
        Cliente c;
        protected void Page_Load(object sender, EventArgs e)
        {
            c = new Cliente();
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            c = new Cliente(cedula.Value, nombre.Value, apellido.Value);
            c.actualizar();
        }

        public void generarClientes()
        {


            foreach (Cliente cliente in c.consultarTodos())
            {
                Response.Write("<option value='" + cliente.cc + "'>" + cliente.cc + " - " + cliente.nom1 + "</option>");
            }
            // < option value = "<% Response.Write(c.consultarTodos()..cc); %>" ><% Response.Write(c.cc + " " + c.nom1); %></ option >

        }
    }
}