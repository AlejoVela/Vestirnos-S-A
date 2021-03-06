﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Windows.Forms;
using Vestinos_S.A.Persistencia;

namespace Vestinos_S.A.logica
{
    public class Producto
    {

        private Conexion conexion;
        public List<Producto> productos;
        private ProductoDAO productoDAO;
        public int idprend { get; set; }
        public int id_t { get; set; }
        public string cantprend { get; set; }
        public double precio { get; set; }
        public List <Producto> Productos { get => productos; set => productos = value; }

        public Producto()
        {
            this.conexion = new Conexion();
            this.productoDAO = new ProductoDAO();
        }

        public Producto(string idprend = "", string cantprend = "", string precio = "", string id_t = "")
        {
            this.idprend = int.Parse(idprend);
            this.id_t = int.Parse(id_t);
            this.cantprend = cantprend;
            this.precio = Double.Parse(precio);
            this.conexion = new Conexion();
            this.productoDAO = new ProductoDAO(idprend,id_t,cantprend,precio);
        }

        public void insertar()
        {
            this.conexion.ejecutar(this.productoDAO.insertar());
            this.conexion.cerrar();
        }

        public List<Producto> consultarTodos()
        {
            productos = new List<Producto>();


            int i = 0;
            this.conexion.ejecutar(this.productoDAO.consultarTodos());
            Producto p;
            while (conexion.resultado.Read())
            {
                p = new Producto("" + conexion.resultado.GetInt32(1), "" + conexion.resultado.GetInt32(4), "" + conexion.resultado.GetInt32(3), "" + conexion.resultado.GetInt32(2));
                productos.Add(p);
                i++;
            }

            this.conexion.cerrar();
            return productos;
        }
    }
}