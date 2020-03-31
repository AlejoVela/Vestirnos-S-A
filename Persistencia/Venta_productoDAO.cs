using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vestinos_S.A.Persistencia
{
    public class Venta_productoDAO
    {
        private int idproducto;
        private int idventa;

        public Venta_productoDAO()
        {

        }

        public Venta_productoDAO(string idproducto = "", string idventa = "")
        {
            this.idproducto = int.Parse(idproducto);
            this.idventa = int.Parse(idventa);

        }

        public string buscar(string filtro)
        {
            return "select * from `Venta_producto` where idventa like '" + filtro + "%' limit 5";
        }

        public string consultar()
        {
            return "SELECT * FROM `Venta_producto` where idproducto = '" + idproducto + "'";
        }

        public string consultarTodos()
        {
            return "select * FROM `Venta_producto` ";
        }

        public string insertar()
        {
            return "INSERT INTO `Venta_producto` ( `idventa`) VALUES ('" + idventa + ");";
        }
    }
}