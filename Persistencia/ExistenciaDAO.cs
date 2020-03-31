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
        private int cantne;
        public ExistenciaDAO()
        {

        }

        public ExistenciaDAO(string iduni = "", string idmat = "", string cantne = "")
        {
            this.iduni = int.Parse(iduni);
            this.idmat = int.Parse(idmat);
            this.cantne = int.Parse(cantne);
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
            return "select existencia.id_ex,existencia.iduni,existencia.idmat,unimedida.unidad,matprima.nommat,existencia.cantexist,existencia.cantnece"+
                " FROM `existencia`"+
                " INNER join unimedida on unimedida.iduni = existencia.iduni"+
                " INNER join matprima on matprima.idmat = existencia.idmat ";
        }

        public string insertar()
        {
            return "INSERT INTO `Existencia` (`iduni`, `idmat`, `cantexist`, `cantnece`) VALUES ("+iduni+","+idmat+",0,"+cantne+");";
        }
    }
}