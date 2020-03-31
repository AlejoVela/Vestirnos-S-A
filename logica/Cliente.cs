using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Windows.Forms;
using Vestinos_S.A.Persistencia;

namespace Vestinos_S.A.logica
{
    public class Cliente
    {

        private Conexion conexion;
        public List<Cliente> clientes;
        private ClienteDAO ClienteDAO;
        public int cc { get; set; }
        public string nom1 { get; set; }
        public string ape1 { get; set; }
        public List<Cliente> Clientes { get => clientes; set => clientes = value; }

        public Cliente()
        {
            this.conexion = new Conexion();
            this.ClienteDAO = new ClienteDAO();
        }

        public Cliente(string cc = "", string nom1 = "", string ape1 = "")
        {
            this.cc = int.Parse(cc);
            this.nom1 = nom1;
            this.ape1 = ape1;
            this.conexion = new Conexion();
            this.ClienteDAO = new ClienteDAO(cc, nom1, ape1);
        }

        public void insertar()
        {
            this.conexion.ejecutar(this.ClienteDAO.insertar());
            this.conexion.cerrar();
        }

        public List<Cliente> consultarTodos()
        {
            clientes = new List<Cliente>();


            int i = 0;
            this.conexion.ejecutar(this.ClienteDAO.consultarTodos());
            Cliente c;
            while (conexion.resultado.Read())
            {
                c = new Cliente("" + conexion.resultado.GetInt32(0), conexion.resultado.GetString(1), conexion.resultado.GetString(2));
                clientes.Add(c);
                i++;
            }

            this.conexion.cerrar();
            return clientes;
        }
    }
}