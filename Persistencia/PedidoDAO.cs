using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vestinos_S.A.Persistencia
{
    public class PedidoDAO
    {
        private int idpedido;
        private int idunimat;
        private int nit;
        private int fechap;

        public PedidoDAO()
        {

        }

        public PedidoDAO(string idpedido = "", string idunimat = "", string nit = "", string fechap = "")
        {
            this.idpedido=int.Parse(idpedido);
            this.idunimat = int.Parse(idunimat);
            this.nit = int.Parse(nit);
            this.fechap = int.Parse(fechap);
        }  

        public string buscar(string filtro)
        {
            return "select * from `Pedido` where idpedido like '" + filtro + "%' limit 5";
        }

        public string consultar()
        {
            return "SELECT * FROM `Pedido` where idunimat = '" + idunimat + "'";
        }

        public string consultarTodos()
        {
            return "select * FROM `Pedido` ";
        }

        public string insertar()
        {
            return "INSERT INTO `Pedido` ( `idunimat`,`nit`,`fechap`) VALUES ('" + idunimat + "'," + nit + "," + fechap + ");";
        }
    }
}