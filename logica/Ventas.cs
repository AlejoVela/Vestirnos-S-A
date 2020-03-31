using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vestinos_S.A.Persistencia;

namespace Vestinos_S.A.logica
{
    public class Venta
    {
        private Conexion conexion;
        public List<Venta> ventas;
        public VentaDAO VentaDAO;
        public int idventa { get; set; }
        public int cc { get; set; }
        public int ccemple { get; set; }
        public int fechventa { get; set; }

        public List<Venta> Ventas { get => ventas; set => ventas = value; }

        public Venta()
        {
            this.conexion = new Conexion();
            this.VentaDAO = new VentaDAO();
        }

        public Venta(string idventa = "", string cc = "", string ccemple = "", string fechventa = "")
        {
            this.idventa = int.Parse(idventa);
            this.cc = int.Parse(cc);
            this.ccemple = int.Parse(ccemple);
            this.fechventa = int.Parse(fechventa);
            this.conexion = new Conexion();
            this.VentaDAO = new VentaDAO(idventa, cc, ccemple, fechventa);
        }

        public void insertar()
        {
            this.conexion.ejecutar(this.VentaDAO.insertar());
            this.conexion.cerrar();
        }

        public List<Venta> consultarTodos()
        {
            ventas = new List<Venta>();


            int i = 0;
            this.conexion.ejecutar(this.VentaDAO.consultarTodos());
            Venta d;
            while (conexion.resultado.Read())
            {
                d = new Venta("" + conexion.resultado.GetInt32(0), ""+ conexion.resultado.GetInt32(1), ""+conexion.resultado.GetInt32(2), ""+conexion.resultado.GetInt32(3));
                ventas.Add(d);
                i++;
            }

            this.conexion.cerrar();
            return ventas;
        }

    }
}