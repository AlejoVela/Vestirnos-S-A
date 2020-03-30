using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Windows.Forms;
using Vestinos_S.A.Persistencia;


namespace Vestinos_S.A.logica
{
    
    public class Cargo
    {

        private Conexion conexion;
        public  List<Cargo> registros;
        private CargoDAO cargoDAO;
        public int idcar { get; set; }
        public string nomcargo { get; set; }
        public double salario { get; set; }
        public List<Cargo> Registros { get => registros; set => registros = value; }

        public Cargo()
        {
            this.conexion = new Conexion();
            this.cargoDAO = new CargoDAO();
        }
        public Cargo(string idcar = "", string nomcargo = "", string salario = "")
        {
            this.idcar = int.Parse(idcar);
            this.nomcargo = nomcargo;
            this.salario = Double.Parse(salario);
            this.conexion = new Conexion();
            this.cargoDAO = new CargoDAO(idcar, nomcargo, salario);
        }

        
        public void insertar()
        {
            this.conexion.ejecutar(this.cargoDAO.insertar());
            this.conexion.cerrar();
        }

        public List<Cargo> consultarTodos()
        {
            registros = new List<Cargo>();
            

            int i = 0;
            this.conexion.ejecutar(this.cargoDAO.consultarTodos());
            Cargo c;
            while (conexion.resultado.Read())
            {
                c = new Cargo("" + conexion.resultado.GetInt32(0), conexion.resultado.GetString(1), conexion.resultado.GetString(2));
                registros.Add(c);
                MessageBox.Show("nom:\n" + conexion.resultado.GetString(1) + "\n");
                i++;
            }

            this.conexion.cerrar();
            return registros;
        }

        /*
        public int getIdcar() {
            return idcar;
        }
        public void setIdcar(int id)
        {
            idcar = id;
        }

        public string getNomcargo()
        {
            return nomcargo;
        }

        public void setNomcargo(string nom)
        {
            nomcargo = nom;
        }

        public double getSalario()
        {
            return salario;
        }
        public void setSalario(double sal)
        {
            salario = sal;
        }*/
    }

}