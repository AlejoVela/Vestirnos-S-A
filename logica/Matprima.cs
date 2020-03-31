using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vestinos_S.A.Persistencia;

namespace Vestinos_S.A.logica
{
    public class Matprima
    {
        private Conexion conexion;
        public List<Matprima> matprimas;
        public MatprimaDAO MatprimaDAO;
        public int idmat { get; set; }
        public int nommat  {get; set; }
        

        public List<Matprima> Matprimas { get => matprimas; set => matprimas = value; }

        public Matprima()
        {
            this.conexion = new Conexion();
            this.MatprimaDAO = new MatprimaDAO();
        }

        public Matprima(string idmat = "", string nommat = "")
        {
            this.idmat = int.Parse(idmat);
            this.nommat = int.Parse(nommat); 
            this.conexion = new Conexion();
            this.MatprimaDAO = new MatprimaDAO(idmat, nommat);
        }

        public void insertar()
        {
            this.conexion.ejecutar(this.MatprimaDAO.insertar());
            this.conexion.cerrar();
        }

        public List<Matprima> consultarTodos()
        {
            matprimas = new List<Matprima>();
            int i = 0;
            this.conexion.ejecutar(this.MatprimaDAO.consultarTodos());
            Matprima d;
            while (conexion.resultado.Read())
            {
                d = new Matprima("" + conexion.resultado.GetInt32(0), conexion.resultado.GetString(1));
                matprimas.Add(d);
                i++;
            }

            this.conexion.cerrar();
            return matprimas;
        }


    }
}