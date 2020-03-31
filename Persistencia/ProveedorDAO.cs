using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vestinos_S.A.Persistencia
{
    public class ProovedorDAO
    {
        private int    nit        ;
        private string nombre     ;
        private string razon      ;
        private string fprecindir ;
        private string estadoprove;

        public ProovedorDAO()
        {

        }

        public ProovedorDAO(string nit = "", string nombre = "", string razon = "", string fprecindir = "", string estadoprove = "")
        {
            this.nit = int.Parse(nit);
            this.nombre     = nombre;
            this.razon      = razon;
            this.fprecindir = fprecindir;
            this.estadoprove =estadoprove;
        }   
        public string buscar(string filtro)
        {
            return "select * from `Proveedor` where nombre like '" + filtro + "%' limit 5";
        }

        public string consultar()
        {
            return "SELECT * FROM `Proveedor` where nit = '" + nit + "'";
        }

        public string consultarTodos()
        {
            return "select * FROM `Proveedor` ";
        }

        public string insertar()
        {
            return "INSERT INTO `Proveedor` ( `nombre`,`razon`,`fprecindir`,`estadoprove`) VALUES ('" + nombre + "'," + razon + "," + fprecindir + "," + estadoprove + ");";
        }
    }
}