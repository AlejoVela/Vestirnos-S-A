using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vestinos_S.A.Persistencia
{
    public class MatprimaDAO
    {
        private int idmat;
        private string nommat;

        public MatprimaDAO()
        {

        }

        public MatprimaDAO(string id = "", string mat = "")
        {
            this.idmat = int.Parse(id);
            this.nommat = mat;
      
        }

        public string buscar(string filtro)
        {
            return "select * from `Matprima` where nommat like '" + filtro + "%' limit 5";
        }

        public string consultar()
        {
            return "SELECT * FROM `Matprima` where idmat = '" + idmat + "'";
        }

        public string consultarTodos()
        {
            return "select * FROM `Matprima` ";
        }

        public string insertar()
        {
            return "INSERT INTO `Matprima` ( `nommat`) VALUES ('" + nommat + "');";
        }
    }
}