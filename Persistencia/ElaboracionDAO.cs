using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vestinos_S.A.Persistencia
{
    public class ElaboracionDAO
    {
        private int idelaboracion;
        private int idexistencia;
        private int idproducto;
        private string canmat;

        public ElaboracionDAO()
        {

        }

        public ElaboracionDAO(string idelaboracion = "", string idexistencia = "", string idproducto = "", string canmat = "")
        {
            this.idelaboracion = int.Parse(idelaboracion);
            this.idexistencia = int.Parse(idexistencia); ;
            this.idproducto = int.Parse(idproducto);
            this.canmat = canmat;

        }

        public string buscar(string filtro)
        {
            return "select * from `cargo` where idexistencia like '" + filtro + "%' limit 5";
        }

        public string consultar()
        {
            return "SELECT * FROM `cargo` where idelaboracion = '" + idelaboracion + "'";
        }

        public string consultarTodos()
        {
            return "select * FROM `cargo` ";
        }

        public string insertar()
        {
            return "INSERT INTO `cargo` ( `idexistencia`,`idproducto`,`canmat`) VALUES ('" + idexistencia + "'," + idproducto + "," + canmat + ");";
        }

        
    }
}