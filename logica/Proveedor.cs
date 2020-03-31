using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vestinos_S.A.Persistencia;

namespace Vestinos_S.A.logica
{
    public class Proveedor
    {

        private Conexion conexion;
        public List<Proveedor> proveedores;
        public ProovedorDAO ProveedorDAO;
        public int nit { get; set; }
        public string nombre  {get; set; }
        public string fprecindir { get; set; }
        public string estadoprove { get; set; }

        public List<Proveedor> Proveedores { get => proveedores; set => proveedores = value; }

        public Proveedor()
        {
            this.conexion = new Conexion();
            this.ProveedorDAO = new ProovedorDAO();
        }

        public Proveedor(string nombre = "", string nit = "", string fprecindir = "", string estadoprove = "")
        {
            this.nit = int.Parse(nit); 
            this.nombre = nombre;
            this.fprecindir = fprecindir;
            this.estadoprove = estadoprove;
            this.conexion = new Conexion();
            this.ProveedorDAO = new ProovedorDAO(nombre, nit,fprecindir,estadoprove);
        }

        public void insertar()
        {
            this.conexion.ejecutar(this.ProveedorDAO.insertar());
            this.conexion.cerrar();
        }

        public List<Proveedor> consultarTodos()
        {
            proveedores = new List<Proveedor>();


            int i = 0;
            this.conexion.ejecutar(this.ProveedorDAO.consultarTodos());
            Proveedor d;
            while (conexion.resultado.Read())
            {
                d = new Proveedor("" + conexion.resultado.GetInt32(0), conexion.resultado.GetString(1), conexion.resultado.GetString(2), conexion.resultado.GetString(3));
                proveedores.Add(d);
                i++;
            }

            this.conexion.cerrar();
            return proveedores;
        }
    }
}