using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vestinos_S.A.Persistencia;

namespace Vestinos_S.A.logica
{
    public class Telefono_pro
    {
        private Conexion conexion;
        public List<Telefono_pro> telefono_s;
        public Telefono_proDAO Telefono_proDAO;
        public int nit { get; set; }
        public int telefono { get; set; }
        public string nomcontac { get; set; }

        public List<Telefono_pro> Telefono_s { get => telefono_s; set => telefono_s = value; }

        public Telefono_pro()
        {
            this.conexion = new Conexion();
            this.Telefono_proDAO = new Telefono_proDAO();
        }

        public Telefono_pro(string nit = "", string telefono = "", string nomcontac = "")
        {
            this.nit = int.Parse(nit);
            this.telefono = int.Parse(telefono);
            this.nomcontac = nomcontac;
            this.conexion = new Conexion();
            this.Telefono_proDAO = new Telefono_proDAO(nit, telefono, nomcontac);
        }

        public void insertar()
        {
            this.conexion.ejecutar(this.Telefono_proDAO.insertar());
            this.conexion.cerrar();
        }

        public List<Telefono_pro> consultarTodos()
        {
            telefono_s = new List<Telefono_pro>();


            int i = 0;
            this.conexion.ejecutar(this.Telefono_proDAO.consultarTodos());
            Telefono_pro d;
            while (conexion.resultado.Read())
            {
                d = new Telefono_pro("" + conexion.resultado.GetInt32(0), conexion.resultado.GetString(1), conexion.resultado.GetString(2));
                telefono_s.Add(d);
                i++;
            }

            this.conexion.cerrar();
            return telefono_s;
        }

    }
}