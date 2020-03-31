using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vestinos_S.A.Persistencia;

namespace Vestinos_S.A.logica
{
    public class Venta_producto
    {
        private Conexion conexion;
        public List<Venta_producto> unimedidas;
        public Venta_productoDAO Venta_productoDAO;
        public int idproducto { get; set; }
        public string idventa { get; set; }

        public List<Venta_producto> Venta_Productos;

        public Venta_producto()
        {
            this.conexion = new Conexion();
            this.Venta_productoDAO = new Venta_productoDAO();
        }

        public Venta_producto(string idproducto = "", string idventa = "")
        {
            this.idproducto = int.Parse(idproducto);
            this.idventa = idventa;
            this.conexion = new Conexion();
            this.Venta_productoDAO = new Venta_productoDAO(idproducto, idventa);
        }

        public void insertar()
        {
            this.conexion.ejecutar(this.Venta_productoDAO.insertar());
            this.conexion.cerrar();
        }

        public List<Venta_producto> consultarTodos()
        {
            Venta_Productos = new List<Venta_producto>();


            int i = 0;
            this.conexion.ejecutar(this.Venta_productoDAO.consultarTodos());
            Venta_producto d;
            while (conexion.resultado.Read())
            {
                d = new Venta_producto("" + conexion.resultado.GetInt32(0), ""+conexion.resultado.GetInt32(1));
                Venta_Productos.Add(d);
                i++;
            }

            this.conexion.cerrar();
            return Venta_Productos;
        }
    }
}
