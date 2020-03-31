using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vestinos_S.A.Persistencia
{
    public class CLADepartamentoDAO
    {
        private int iddepa;
        private string nomdepa;

        public CLADepartamentoDAO()
        {

        }

        public CLADepartamentoDAO(string iddepa = "", string nomdepa = "")
        {
            this.iddepa = int.Parse(iddepa);
            this.nomdepa = nomdepa;
        }

        public string buscar(string filtro)
        {
            return "select * from `Departamento` where nomdepa like '" + filtro + "%' limit 5";
        }

        public string consultar()
        {
            return "SELECT * FROM `Departamento` where iddepa = '" + iddepa + "'";
        }

        public string consultarTodos()
        {
            return "select * FROM `Departamento` ";
        }

        public string insertar()
        {
            return "INSERT INTO `Departamento` ( `nomdepa`) VALUES ('" + nomdepa + "');";
        }
    }
}