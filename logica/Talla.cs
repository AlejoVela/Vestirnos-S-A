using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vestinos_S.A.Persistencia;

namespace Vestinos_S.A.logica
{
    public class Talla
    {
        private Conexion conexion;
        public List<Talla> Tallas;
        public TallaDAO TallaDAO;
        public int id_t { get; set; }
        public string talla { get; set; }
        public List<Talla> tallas;

        public Talla()
        {
            this.conexion = new Conexion();
            this.TallaDAO = new TallaDAO();
        }

        public Talla(string id_t = "", string talla = "")
        {
            this.id_t = int.Parse(id_t);
            this.talla = talla;
            this.conexion = new Conexion();
            this.TallaDAO = new TallaDAO(id_t, talla);
        }

        public void insertar()
        {
            this.conexion.ejecutar(this.TallaDAO.insertar());
            this.conexion.cerrar();
        }

        public List<Talla> consultarTodos()
        {
            tallas = new List<Talla>();


            int i = 0;
            this.conexion.ejecutar(this.TallaDAO.consultarTodos());
            Talla d;
            while (conexion.resultado.Read())
            {
                d = new Talla("" + conexion.resultado.GetInt32(0), conexion.resultado.GetString(1));
                tallas.Add(d);
                i++;
            }

            this.conexion.cerrar();
            return tallas;
        }

    }
}