using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Vestinos_S.A.logica;

namespace Vestinos_S.A.Presentacion.Admin
{
    public partial class AcEmpleado : System.Web.UI.Page
    {
        public Cargo ca;
        public Departamento de;
        protected void Page_Load(object sender, EventArgs e)
        {

            Empleado p = new Empleado();
            ca = new Cargo();
            Departamento de = new Departamento();
            List<Empleado> regi = p.consultarTodos();
        }

        public void generarDepartamento()
        {
            foreach (Departamento Departamento in de.consultarTodos())
            {
                Response.Write("<option value='" + Departamento.iddepa + "'>" + Departamento.nomdepa + "</option>");
            }

        }

        public void generarCargo()
        {
            foreach (Cargo Cargo in ca.consultarTodos())
            {
                Response.Write("<option value='" + Cargo.idcar + "'>" + Cargo.nomcargo + "</option>");
            }

        }

        public void listaEmpleados()
        {
            Empleado p = new Empleado();

            foreach (Empleado Empleado in p.consultarTodos())
            {
                Response.Write("<tr>");
                Response.Write("<td>" + Empleado.ccemple + "</td>");
                Response.Write("<td>" + Empleado.nem1 + "</td>");
                Response.Write("<td>" + Empleado.apem1 + "</td>");
                Response.Write("<td>" + Empleado.idcar + "</td>");
                Response.Write("<td>" + Empleado.iddepa + "</td>");
                Response.Write("<td>" + Empleado.telefono_emp + "</td>");
                Response.Write("<td>" + Empleado.emaile + "</td>");
                Response.Write("<td>" + Empleado.passe + "</td>");
                Response.Write("<td>" + Empleado.estado + "</td>");

                //Response.Write("");
                Response.Write("<td><input type=" + "number" + " value=" + 0 + " min = " + 0 + " max = '" + (Empleado.Empleados) + "'></td>");
                //Response.Write("");
                Response.Write("</tr>");
            }
        }

    }
}