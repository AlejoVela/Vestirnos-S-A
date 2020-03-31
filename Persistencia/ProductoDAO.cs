using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vestinos_S.A.Persistencia
{
    public class ProductoDAO
    {
        private int idprend;
        private int id_t;
        private string cantprend;
        private double precio;

        public ProductoDAO()
        {

        }

        public ProductoDAO(string idprend = "", string cantprend = "", string precio = "", string id_t = "")
        {
            this.idprend = int.Parse(idprend);
            this.id_t = int.Parse(id_t);
            this.cantprend = cantprend;
            this.precio = Double.Parse(precio);
        }

        public string buscar(string filtro)
        {
            return "select * from `Producto` where cantprend like '" + filtro + "%' limit 5";
        }

        public string consultar()
        {
            return "SELECT * FROM `Producto` where idprend = '" + idprend + "'";
        }

        public string consultarTodos()
        {
            return "select * FROM `Producto` ";
        }

        public string insertar()
        {
            return "INSERT INTO `Producto` ( `cantprend`,`precio`) VALUES ('" + cantprend + "'," + precio + ");";
        }
    }
}