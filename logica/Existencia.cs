using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vestinos_S.A.Persistencia;

namespace Vestinos_S.A.logica
{
    public class Existencia
    {

        private Conexion conexion;
        public List<Existencia> existencias;
        public ExistenciaDAO ExistenciaDAO;
        public int iduni { get; set; }
        public int idmat  {get; set; }
        

        public List<Existencia> Existencias { get => existencias; set => existencias = value; }

        public Existencia()
        {
            this.conexion = new Conexion();
            this.ExistenciaDAO = new ExistenciaDAO();
        }

        public Existencia(string iduni = "", string idmat = "")
        {
            this.iduni = int.Parse(iduni);
            this.idmat = int.Parse(idmat); 
            this.conexion = new Conexion();
            this.ExistenciaDAO = new ExistenciaDAO(iduni, idmat);
        }

        public void insertar()
        {
            this.conexion.ejecutar(this.ExistenciaDAO.insertar());
            this.conexion.cerrar();
        }

        public List<Existencia> consultarTodos()
        {
            existencias = new List<Existencia>();


            int i = 0;
            this.conexion.ejecutar(this.ExistenciaDAO.consultarTodos());
            Existencia d;
            while (conexion.resultado.Read())
            {
                d = new Existencia("" + conexion.resultado.GetInt32(0), conexion.resultado.GetString(1));
                existencias.Add(d);
                i++;
            }

            this.conexion.cerrar();
            return existencias;
        }

    }
}