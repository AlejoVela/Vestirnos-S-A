using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vestinos_S.A.Persistencia
{
    public class PrendaDAO
    {
        private int idprend;
        private string nomprend;

        public PrendaDAO()
        {

        }

        public PrendaDAO(string idprend = "", string nomprend = "")
        {
            this.idprend = int.Parse(idprend);
            this.nomprend = nomprend;
        }

        public string buscar(string filtro)
        {
            return "select * from `Prenda` where nomprend like '" + filtro + "%' limit 5";
        }

        public string consultar()
        {
            return "SELECT * FROM `Prenda` where idprend = '" + idprend + "'";
        }

        public string consultarTodos()
        {
            return "select * FROM `Prenda` ";
        }

        public string insertar()
        {
            return "INSERT INTO `Prenda` ( `nomprend`) VALUES ('" + nomprend + "');";
        }
    }
}