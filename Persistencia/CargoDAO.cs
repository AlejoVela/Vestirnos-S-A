using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vestinos_S.A.Persistencia
{
    public class CargoDAO
    {
        private int idcar;
        private string nomcargo;
        private double salario;

        public CargoDAO()
        {

        }

        public CargoDAO(string idcar = "", string nomcargo = "", string salario = "")
        {
            this.idcar = int.Parse(idcar);
            this.nomcargo = nomcargo;
            this.salario = Double.Parse (salario);
        }

        public string buscar(string filtro)
        {
            return "select * from `cargo` where nomcargo like '" + filtro + "%' limit 5";
        }

        public string consultar()
        {
            return "SELECT * FROM `cargo` where idcar = '" + idcar + "'";
        }

        public string consultarTodos()
        {
            return "select * FROM `cargo` ";
        }

        public string insertar()
        {
            return "INSERT INTO `cargo` ( `nomcargo`,`salario`) VALUES ('" + nomcargo + "'," + salario + ");";
        }
    }
}