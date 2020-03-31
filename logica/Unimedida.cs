using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vestinos_S.A.Persistencia;

namespace Vestinos_S.A.logica
{
    public class Unimedida
    {
        private Conexion conexion;
        public List<Unimedida> unimedidas;
        public UnimedidaDAO UnimedidaDAO;
        public int iduni { get; set; }
        public string unidad { get; set; }

        public List<Unimedida> Unimedidas { get => unimedidas; set => unimedidas = value; }

        public Unimedida()
        {
            this.conexion = new Conexion();
            this.UnimedidaDAO = new UnimedidaDAO();
        }

        public Unimedida(string iduni = "", string unidad = "")
        {
            this.iduni = int.Parse(iduni);
            this.unidad = unidad;
            this.conexion = new Conexion();
            this.UnimedidaDAO = new UnimedidaDAO(iduni, unidad);
        }

        public void insertar()
        {
            this.conexion.ejecutar(this.UnimedidaDAO.insertar());
            this.conexion.cerrar();
        }

        public List<Unimedida> consultarTodos()
        {
            unimedidas = new List<Unimedida>();


            int i = 0;
            this.conexion.ejecutar(this.UnimedidaDAO.consultarTodos());
            Unimedida d;
            while (conexion.resultado.Read())
            {
                d = new Unimedida("" + conexion.resultado.GetInt32(0), ""+conexion.resultado.GetInt32(1));
                unimedidas.Add(d);
                i++;
            }

            this.conexion.cerrar();
            return unimedidas;
        }

    }
}