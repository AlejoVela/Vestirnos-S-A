using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vestinos_S.A.Persistencia;

namespace Vestinos_S.A.logica
{
    public class Pedido
    {

        private Conexion conexion;
        public List<Pedido> pedidos;
        public PedidoDAO PedidoDAO;
        public int idpedido { get; set; }
        public int idunimat  {get; set; }
        public int nit  {get; set; }
        public int fechap  {get; set; }

        public List<Pedido> Pedidos { get => pedidos; set => pedidos = value; }

        public Pedido()
        {
            this.conexion = new Conexion();
            this.PedidoDAO = new PedidoDAO();
        }

        public Pedido(string idpedido = "", string idunimat = "", string nit = "", string fechap = "")
        {
            this.idpedido = int.Parse(idpedido);
            this.idunimat = int.Parse(idunimat); 
            this.nit = int.Parse(nit);
            this.fechap = int.Parse(fechap);
            this.conexion = new Conexion();
            this.PedidoDAO = new PedidoDAO(idpedido, idunimat);
        }

        public void insertar()
        {
            this.conexion.ejecutar(this.PedidoDAO.insertar());
            this.conexion.cerrar();
        }

        public List<Pedido> consultarTodos()
        {
            pedidos = new List<Pedido>();
            int i = 0;
            this.conexion.ejecutar(this.PedidoDAO.consultarTodos());
            Pedido d;
            while (conexion.resultado.Read())
            {
                d = new Pedido("" + conexion.resultado.GetInt32(0), conexion.resultado.GetString(1), conexion.resultado.GetString(2), conexion.resultado.GetString(3));
                pedidos.Add(d);
                i++;
            }

            this.conexion.cerrar();
            return pedidos;
        }

    }
}