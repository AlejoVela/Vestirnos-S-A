using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vestinos_S.A.Persistencia
{
    public class Telefono_proDAO
    {
        private int nit;
        private int telefono;
        private string nomcontac;
     

        public Telefono_proDAO()
        {

        }

        public Telefono_proDAO(string nit = "", string nomcontac = "", string telefono = "")
        {
            this.nit = int.Parse(nit);
            this.nomcontac = nomcontac;
            this.telefono = int.Parse(telefono);
        }

        public string buscar(string filtro)
        {
            return "select * from `Telefono_pro` where nomcontac like '" + filtro + "%' limit 5";
        }

        public string consultar()
        {
            return "SELECT * FROM `Telefono_pro` where nit = '" + nit + "'";
        }

        public string consultarTodos()
        {
            return "select * FROM `Telefono_pro` ";
        }

        public string insertar()
        {
            return "INSERT INTO `Telefono_pro` ( `nomcontac`,`telefono`) VALUES ('" + nomcontac + "'," + telefono + ");";
        }
    }
}