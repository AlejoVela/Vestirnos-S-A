using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vestinos_S.A.Persistencia;

namespace Vestinos_S.A.logica
{
    public class Prenda
    {
        private Conexion conexion;
        public List<Prenda> prendas;
        public PrendaDAO PrendaDAO;
        public int idprend { get; set; }
        public int nomprend  {get; set; }
        

        public List<Prenda> Prendas { get => prendas; set => prendas = value; }

        public Prenda()
        {
            this.conexion = new Conexion();
            this.PrendaDAO = new PrendaDAO();
        }

        public Prenda(string idprend = "", string nomprend = "")
        {
            this.idprend = int.Parse(idprend);
            this.nomprend = int.Parse(nomprend); 
            this.conexion = new Conexion();
            this.PrendaDAO = new PrendaDAO(idprend, nomprend);
        }

        public void insertar()
        {
            this.conexion.ejecutar(this.PrendaDAO.insertar());
            this.conexion.cerrar();
        }

        public List<Prenda> consultarTodos()
        {
            prendas = new List<Prenda>();
            int i = 0;
            this.conexion.ejecutar(this.PrendaDAO.consultarTodos());
            Prenda d;
            while (conexion.resultado.Read())
            {
                d = new Prenda("" + conexion.resultado.GetInt32(0), conexion.resultado.GetString(1));
                prendas.Add(d);
                i++;
            }

            this.conexion.cerrar();
            return prendas;
        }

    }
}