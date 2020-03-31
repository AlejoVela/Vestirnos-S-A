using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Windows.Forms;
using Vestinos_S.A.Persistencia;

namespace Vestinos_S.A.logica
{
    public class Empleado
    {
        private Conexion conexion;
        public  List<Empleado> empleados;
        private EmpleadoDAO empleadoDAO;
        public int ccemple { get; set; }
        public int iddepa { get; set; }
        public int idcar { get; set; }
        public string nem1 { get; set; }
        public string telefono_emp { get; set; }
        public string apem1 { get; set; }
        public string direcemple { get; set; }
        public string estado { get; set; }
        public string passe { get; set; }
        public string emaile { get; set; }
        public List<Empleado> Empleados { get => empleados; set => empleados = value; }

        public Empleado()
        {
            this.conexion = new Conexion();
            this.empleadoDAO = new EmpleadoDAO ();
        }
         public Empleado(string ccemple = "", string iddepa = "", string idcar = "", string nem1= "", string telefono_emp= "", string apem1= "", string direcemple= "", string estado= "", string passe= "", string emaile= "")
        {
            this.ccemple = int.Parse(idcar);
            this.iddepa = int.Parse(iddepa);
            this.idcar = int.Parse(idcar);
            this.nem1 = nem1;
            this.telefono_emp = telefono_emp;
            this.apem1 = apem1;
            this.direcemple = direcemple;
            this.estado = estado;
            this.passe = passe;
            this.emaile = emaile;
            this.conexion = new Conexion();
            this.empleadoDAO = new EmpleadoDAO(ccemple, iddepa, idcar, nem1, telefono_emp,apem1,direcemple,estado,passe,emaile);
        }

        
        public void insertar()
        {
            this.conexion.ejecutar(this.empleadoDAO.insertar());
            this.conexion.cerrar();
        }

        public List<Empleado> consultarTodos()
        {
            empleados = new List<Empleado>();


            int i = 0;
            this.conexion.ejecutar(this.empleadoDAO.consultarTodos());
            Empleado e;
            while (conexion.resultado.Read())
            {
                e = new Empleado("" + conexion.resultado.GetInt32(0), "" + conexion.resultado.GetInt32(2), "" + conexion.resultado.GetInt32(1), conexion.resultado.GetString(3), "" + conexion.resultado.GetInt32(5), conexion.resultado.GetString(4), conexion.resultado.GetString(7),""+ conexion.resultado.GetInt32(9), conexion.resultado.GetString(8), conexion.resultado.GetString(6));
                empleados.Add(e);
                i++;
            }

            this.conexion.cerrar();
            return empleados;
        }



    }
}