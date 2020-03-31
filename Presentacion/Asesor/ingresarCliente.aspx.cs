using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Vestinos_S.A.logica;

namespace Vestinos_S.A.Presentacion.Asesor
{
    public partial class ingresarCliente : System.Web.UI.Page
    {
        Cliente c;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void botonCli_Click(object sender, EventArgs e)
        {
            c = new Cliente(cedula.Value, nombre.Value, apellido.Value);
            c.insertar();
        }
    }
}