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
            return "select * from `cliente` where nombre like '" + filtro + "%' limit 5";
        }

        public string consultar()
        {
            return "SELECT * FROM `cliente` where cc = '" + cc + "'";
        }

        public string consultarTodos()
        {
            return "select * FROM `cliente` ";
        }

        public string insertar()
        {
            return "INSERT INTO `cliente` ( `cc`,`nombre`,`ape`) VALUES (" + cc + ",'" + nom1 + "','" + ape1 + "');";
        }

        public string Actualizar()
        {
            return "UPDATE `cliente` SET "+
                   "`nombre`= '"+nom1+"',"+
               "`ape`= '"+ape1+"' "+
                    "where `cc` = '" + cc + "'";
        }

    }
}