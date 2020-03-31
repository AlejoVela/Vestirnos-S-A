using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vestinos_S.A.Persistencia
{
    public class VentaDAO
    {
        private int idventa;
        private int cc;
        private int ccemple;
        private int fechventa;

        public VentaDAO()
        {

        }

        public VentaDAO(string idventa = "", string cc = "", string ccemple = "", string fechventa = "")
        {
            this.idventa = int.Parse(idventa);
            this.cc = int.Parse(cc);
            this.ccemple = int.Parse(ccemple);
            this.fechventa = int.Parse(fechventa);

        }

        public string buscar(string filtro)
        {
            return "select * from `Venta` where cc like '" + filtro + "%' limit 5";
        }

        public string consultar()
        {
            return "SELECT * FROM `Venta` where idventa = '" + idventa + "'";
        }

        public string consultarTodos()
        {
            return "select * FROM `Venta` ";
        }

        public string insertar()
        {
            return "INSERT INTO `Venta` ( `cc`,`ccemple`,`fechventa`,) VALUES (" + cc + "," + ccemple + "," + DateTime.Now + ");";
        }
        public string ultimo()
        {
            return "SELECT venta.iddventa,venta.ccliente,venta.ccemple,venta.fechaventa "+
                    "FROM venta "+
                    "WHERE iddventa = (SELECT max(venta.iddventa)from venta)";
        }

    }
}