using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vestinos_S.A.Persistencia;

namespace Vestinos_S.A.logica
{
    public class Elaboracion
    {
        private Conexion conexion;
        public List<Elaboracion> elaboraciones;
        public ElaboracionDAO ElaboracionDAO;
        public int idexistencia { get; set; }
        public int idelaboracion  {get; set; }
        public int idproducto { get; set; }
        public string canmat { get; set; }

        public List<Elaboracion> Elaboraciones { get => elaboraciones; set => elaboraciones = value; }

        public Elaboracion()
        {
            this.conexion = new Conexion();
            this.ElaboracionDAO = new ElaboracionDAO();
        }

        public Elaboracion(string idelaboracion = "", string idexistencia = "", string idproducto = "", string canmat = "")
        {
            this.idelaboracion = int.Parse(idelaboracion);
            this.idexistencia = int.Parse(idexistencia); 
            this.idproducto = int.Parse(idproducto);
            this.canmat = canmat;
            this.conexion = new Conexion();
            this.ElaboracionDAO = new ElaboracionDAO(idelaboracion, idexistencia,idproducto,canmat);
        }

        public void insertar()
        {
            this.conexion.ejecutar(this.ElaboracionDAO.insertar());
            this.conexion.cerrar();
        }

        public List<Elaboracion> consultarTodos()
        {
            elaboraciones = new List<Elaboracion>();


            int i = 0;
            this.conexion.ejecutar(this.ElaboracionDAO.consultarTodos());
            Elaboracion d;
            while (conexion.resultado.Read())
            {
                d = new Elaboracion("" + conexion.resultado.GetInt32(0), conexion.resultado.GetString(1),conexion.resultado.GetString(2), conexion.resultado.GetString(3));
                elaboraciones.Add(d);
                i++;
            }

            this.conexion.cerrar();
            return elaboraciones;
        }

    }
}