
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Windows.Forms;

namespace Vestinos_S.A.Persistencia
{
    public class Conexion
    {
        MySqlCommand Query = new MySqlCommand();
        public MySqlDataReader resultado;
        private MySqlConnection con;



        public void abrir()
        {
            //cramos conexion
            con = new MySqlConnection("Server=localhost; Database=VESTIRNOS S.A; Uid=root; Pwd=;");

            try
            {
                con.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("" + e);
            }
        }

        public void cerrar()
        {
            //cerramos conexion
            con.Close();
        }

        //"SELECT id, nombre, telefono FROM clientes LIMIT 1"
      public void empleado(String sentencia)
        {
            try
            {
                abrir();
                Query.CommandText = sentencia;
                Query.Connection = con;
                resultado = Query.ExecuteReader();

                while (resultado.Read())
                {
                    int id = resultado.GetInt32(0);
                    string nombre = resultado.GetString(1);
                    MessageBox.Show("Cliente:\n" + id + " " + nombre + "\n");
                }
                cerrar();
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void ultimoId()
        {

        }

        public void ejecutar(string sentencia)
        {
            try
            {
                abrir();
                Query.CommandText = sentencia;
                Query.Connection = con;
                resultado = Query.ExecuteReader();
                //cerrar();
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
            }


        }

        public int numFilas()
        {
            abrir();
            if (resultado != null)
            {
                int cont = 0;
                while (resultado.Read())
                {
                    cont++;
                }
                cerrar();
                return cont; 
            }
            else
            {
                cerrar();
                return 0;
            }
        }

        public bool sentenciaEjecutada()
        {
            if (resultado.HasRows == true){
                return true;
            }else
            {
                return false;
            }
        }
    }
}


//            Conexion con = new Conexion();

//Consultar todos OK!!
/*String info = "";
Cargo c = new Cargo();

foreach (Cargo cargo in c.consultarTodos())
{
    info += cargo.nomcargo + " \n";
}
MessageBox.Show(info);
*/



//insersion OK!
/*Cargo c = new Cargo("1", "Domador de chitas", "80000");
c.insertar();*/




/*
 * 
 *         <div class="navbar navbar-inverse navbar-fixed-top">
            <div class="container">
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    <a class="navbar-brand" runat="server" href="~/">Nombre de la aplicación</a>
                </div>
                <div class="navbar-collapse collapse">
                    <ul class="nav navbar-nav">
                        <li><a runat="server" href="~/">Inicio</a></li>
                        <li><a runat="server" href="~/About">Acerca de</a></li>
                        <li><a runat="server" href="~/Contact">Contacto</a></li>
                    </ul>
                </div>
            </div>
        </div>
        */
     
