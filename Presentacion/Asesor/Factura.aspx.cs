using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Vestinos_S.A.logica;

namespace Vestinos_S.A.Presentacion.Asesor
{
    public partial class Factura : System.Web.UI.Page
    {
        public Cliente c;
        protected void Page_Load(object sender, EventArgs e)
        {
            c = new Cliente();
            bool registrar = false;
            Producto p = new Producto();
            List<Producto> regi = p.consultarTodos();
            int i = 0;

            foreach (Cliente cliente in c.consultarTodos())
            {

            }


            if (registrar)
            {





                //insertar producto


            }
        }

        public void generarClientes()
        {
            string h = "";


            foreach (Cliente cliente in c.consultarTodos())
            {
                Response.Write("<option value='" + cliente.cc + "'>" + cliente.cc + " - " + cliente.nom1 + "</option>");
            }
            // < option value = "<% Response.Write(c.consultarTodos()..cc); %>" ><% Response.Write(c.cc + " " + c.nom1); %></ option >

        }

        public void listaProductos()
        {
            Producto p = new Producto();

            foreach (Producto producto in p.consultarTodos())
            {
                Response.Write("<tr>");
                Response.Write("<td>" + producto.idprend + "</td>");
                Response.Write("<td>" + producto.id_t + "</td>");
                Response.Write("<td>" + producto.precio + "</td>");
                Response.Write("<td>" + producto.cantprend + "</td>");
                //Response.Write("");
                Response.Write("<td><input type="+"number"+" value="+0+" min = "+0+" max = '" + (producto.precio - 3) + "'></td>");
                //Response.Write("");
                Response.Write("</tr>");
            }
        }
    }
}