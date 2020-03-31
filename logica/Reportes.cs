using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vestinos_S.A.Persistencia;

namespace Vestinos_S.A.logica
{
    public class Reportes
    {
        private Conexion conexion;
        public List<Reportes> reportess;
        public ReportesDAO ReportesDAO;
        public int idprend { get; set; }
        public int id_t  {get; set; }
        public double precio { get; set; }
        public int cantprend { get; set; }

        public List<Reportes> Reportess { get => reportess; set => reportess = value; }

        public Reportes()
        {
            this.conexion = new Conexion();
            this.ReportesDAO = new ReportesDAO();
        }

        public Reportes(string id_t = "", string idprend = "", string precio = "", string cantprend = "")
        {
            this.id_t = int.Parse(id_t);
            this.idprend = int.Parse(idprend); 
            this.precio = Double.Parse(precio);
            this.cantprend = int.Parse(cantprend);
            this.conexion = new Conexion();
            this.ReportesDAO = new ReportesDAO(id_t, idprend,precio,cantprend);
        }

        public void insertar()
        {
            this.conexion.ejecutar(this.ReportesDAO.insertar());
            this.conexion.cerrar();
        }

        public List<Reportes> consultarTodos()
        {
            reportess = new List<Reportes>();


            int i = 0;
            this.conexion.ejecutar(this.ReportesDAO.consultarTodos());
            Reportes d;
            while (conexion.resultado.Read())
            {
                d = new Reportes("" + conexion.resultado.GetInt32(0), conexion.resultado.GetString(1),conexion.resultado.GetString(2), conexion.resultado.GetString(3));
                reportess.Add(d);
                i++;
            }

            this.conexion.cerrar();
            return reportess;
        }


    }
}