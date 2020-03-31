using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Vestinos_S.A.logica;

namespace Vestinos_S.A.Presentacion
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        string url;
        protected void Page_Load(object sender, EventArgs e)
        {
            url = HttpContext.Current.Request.Url.AbsoluteUri;
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            String passw = GetMd5Hash(pass.Value);
            String corr = correo.Value;


            Empleado c = new Empleado();
            foreach (Empleado empleado in c.consultarTodos())
            {

                if (corr.Equals(empleado.emaile) && passw.Equals(empleado.passe))
                {
                    Session["nombresEmpleado"] = empleado.nem1;
                    Session["apellidosEmpleado"] = empleado.apem1;
                    Session["Cargo"] = empleado.idcar;
                    Session["email"] = empleado.emaile;
                    Session["pass"] = empleado.passe;

                    switch (empleado.idcar)
                    {
                        case 1001:
                            Response.Redirect("~/Presentacion/Asesor/sesionsesionAsesor.aspx");
                            break;
                        case 3001:
                            Response.Redirect("~/Presentacion/Admin/sesionsesionAdmin.aspx");
                            break;
                        case 4001:
                            Response.Redirect("~/Presentacion/Ingeniero/sesionsesionIng.aspx");
                            break;
                    }

                    //Response.Redirect("Destino.aspx?parametro=" + txtoracion.Text);
                }
            }

            MessageBox.Show("Error en el usuario o la contraseña");
        }

        static string GetMd5Hash(string input)
        {
            MD5 md5Hash = MD5.Create();
            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }
    }
}