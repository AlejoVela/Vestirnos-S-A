using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vestinos_S.A.Persistencia
{
    public class UnimedidaDAO
    {
        private int iduni;
        private string unidad;
        public UnimedidaDAO()
        {

        }

        public UnimedidaDAO(string iduni = "", string unidad = "")
        {
            this.iduni = int.Parse(iduni);
            this.unidad = unidad;
        }

        public string buscar(string filtro)
        {
            return "select * from `Unimedida` where unidad like '" + filtro + "%' limit 5";
        }

        public string consultar()
        {
            return "SELECT * FROM `Unimedida` where iduni = '" + iduni + "'";
        }

        public string consultarTodos()
        {
            return "select * FROM `Unimedida` ";
        }

        public string insertar()
        {
            return "INSERT INTO `Unimedida` ( `unidad`) VALUES ('" + unidad + "');";
        }
    }
}