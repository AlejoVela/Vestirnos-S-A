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
        private int cantcompra;
        public Venta_productoDAO()
        {

        }

        public Venta_productoDAO(string idproducto = "", string idventa = "", string cantcompra = "")
        {
            this.idproducto = int.Parse(idproducto);
            this.idventa = int.Parse(idventa);
            this.cantcompra = int.Parse(cantcompra);
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
            return "INSERT INTO `Venta_producto` (`idproducto`, `idventa`, `cantcompra`) VALUES ("+idproducto+","+idventa+","+cantcompra+");";
        }

        public string consultar_factura()
        {
            return "SELECT talla.talla,prenda.nomprend,venta_producto.cantcompra,producto.precio "+
                    "FROM `venta_producto` "+
                "INNER JOIN producto on producto.idpro = venta_producto.idproducto "+
                    "INNER JOIN talla on talla.id_t = producto.id_t "+
                    "INNER JOIN prenda on producto.idprend = prenda.idprend "+
                    "where `idventa`= "+idventa+"; ";
        }

        public void setcantcompra(int cantcompra)
        {
        this.cantcompra = cantcompra;
        }

        public void setIdproducto(int idproducto)
        {
        this.idproducto = idproducto;
        }

    }
}