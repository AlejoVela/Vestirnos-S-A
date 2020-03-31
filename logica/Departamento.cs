using System.Collections.Generic;
using System.Windows.Forms;
using Vestinos_S.A.Persistencia;

namespace Vestinos_S.A.logica
{
    public class Departamento
    {
        private Conexion conexion;
        public List<Departamento> departamentos;
        public DepartamentoDAO DepartamentoDAO;
        public int iddepa { get; set; }
        public string nomdepa { get; set; }

        public List<Departamento> Departamentos { get => departamentos; set => departamentos = value; }

        public Departamento()
        {
            this.conexion = new Conexion();
            this.DepartamentoDAO = new DepartamentoDAO();
        }

        public Departamento(string iddepa = "", string nomdepa = "")
        {
           
            this.iddepa = int.Parse(iddepa);
            this.nomdepa = nomdepa;
            this.conexion = new Conexion();
            this.DepartamentoDAO = new DepartamentoDAO(iddepa, nomdepa);
        }

        public void insertar()
        {
            this.conexion.ejecutar(this.DepartamentoDAO.insertar());
            this.conexion.cerrar();
        }

        public List<Departamento> consultarTodos()
        {
            departamentos = new List<Departamento>();


            int i = 0;
            this.conexion.ejecutar(this.DepartamentoDAO.consultarTodos());
            Departamento d;
            while (conexion.resultado.Read())
            {
                d = new Departamento("" + conexion.resultado.GetInt32(0), conexion.resultado.GetString(1));
                departamentos.Add(d);
                
                i++;
            }

            this.conexion.cerrar();
            return departamentos;
        }
    }
}