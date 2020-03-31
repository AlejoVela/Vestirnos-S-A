using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vestinos_S.A.Persistencia
{
    public class EmpleadoDAO
    {
        private int ccemple;
        private int iddepa;
        private int idcar;
        private string nem1;
        private string telefono_emp;
        private string apem1;
        private string direcemple;
        private string estado;
        private string passe;
        private string emaile;


        public EmpleadoDAO()
        {

        }

        public EmpleadoDAO(string ccemple = "", string iddepa = "", string idcar = "", string nem1= "", string telefono_emp= "", string apem1= "", string direcemple= "", string estado= "", string passe= "", string emaile= "")
        {
            this.ccemple      = int.Parse(idcar);
            this.iddepa       = int.Parse(iddepa);
            this.idcar        = int.Parse(idcar);
            this.nem1         = nem1;
            this.telefono_emp = telefono_emp;
            this.apem1        = apem1;
            this.direcemple   = direcemple;
            this.estado       = estado;
            this.passe        = passe  ;
            this.emaile       = emaile;
        }   

        public string buscar(string filtro)
        {
            return "select * from `Empleado` where nem1 like '" + filtro + "%' limit 5";
        }

        public string consultar()
        {
            return "SELECT * FROM `Empleado` where ccemple = '" + ccemple + "'";
        }

        public string consultarTodos()
        {
            return "select * FROM `Empleado` ";
        }

        public string insertar()
        {
            return "INSERT INTO `Empleado` ( `nomEmpleado`,`salario`) VALUES ('" + nem1 + "'," + telefono_emp + "," + apem1 + "," + direcemple + "," + estado + "," + passe + "," + emaile + ");";
        }
    }
}