using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vestinos_S.A.Persistencia
{
    public class ClienteDAO
    {
        private int cc;
        private string nom1;
        private string ape1;

        public ClienteDAO()
        {

        }

        public ClienteDAO(string cc = "", string nom1 = "", string ape1 = "")
        {
            this.cc = int.Parse(cc);
            this.nom1 = nom1;
            this.ape1 = ape1;
        }

        public string buscar(string filtro)
        {
            return "select * from `cargo` where nombre like '" + filtro + "%' limit 5";
        }

        public string consultar()
        {
            return "SELECT * FROM `cargo` where cc = '" + cc + "'";
        }

        public string consultarTodos()
        {
            return "select * FROM `cargo` ";
        }

        public string insertar()
        {
            return "INSERT INTO `cargo` ( `nombre`,`apellido`) VALUES ('" + nom1 + "'," + ape1 + ");";
        }
    }
}