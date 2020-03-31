using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vestinos_S.A.Persistencia
{
    public class TallaDAO
    {
        private int id_t;
        private string talla;

        public TallaDAO()
             
        {

        }

        public TallaDAO(string id_t = "", string talla = "")
        {
            this.id_t = int.Parse(id_t);
            this.talla = talla;
        }

        public string buscar(string filtro)
        {
            return "select * from `Talla` where talla like '" + filtro + "%' limit 5";
        }

        public string consultar()
        {
            return "SELECT * FROM `Talla` where id_t = '" + id_t + "'";
        }

        public string consultarTodos()
        {
            return "select * FROM `Talla` ";
        }

        public string insertar()
        {
            return "INSERT INTO `Talla` ( `talla`,`) VALUES ('" + talla + "');";
        }
    }
}