using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vestinos_S.A.Persistencia
{
    public class ExistenciaDAO
    {
        private int iduni;
        private int idmat;

        public ExistenciaDAO()
        {

        }

        public ExistenciaDAO(string iduni = "", string idmat = "")
        {
            this.iduni = int.Parse(iduni);
            this.idmat = int.Parse(idmat); 
        }

        public string buscar(string filtro)
        {
            return "select * from `Existencia` where iduni like '" + filtro + "%' limit 5";
        }

        public string consultar()
        {
            return "SELECT * FROM `Existencia` where iduni = '" + iduni + "'";
        }

        public string consultarTodos()
        {
            return "select * FROM `Existencia` ";
        }

        public string insertar()
        {
            return "INSERT INTO `Existencia` ( `idmat`,) VALUES ('" + idmat + ");";
        }
    }
}