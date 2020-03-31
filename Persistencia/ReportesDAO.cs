using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vestinos_S.A.Persistencia
{
    public class ReportesDAO
    {
        private int idprend;
        private int id_t;
        private double precio;
        private int cantprend;

        public ReportesDAO(){
            
        }
        
        public ReportesDAO(string idprend = "", string id_t = "", string precio = "", string cantprend = "")
        {
            this.idprend = int.Parse(idprend);
            this.id_t     =  int.Parse(id_t);
            this.precio      = Double.Parse(precio);
            this.cantprend = int.Parse(cantprend);
            
        }   
    public string insertar(){
        return "INSERT INTO `Producto`( `idprend`,`id_t`,`precio`,`cantprenda`) VALUES ("+idprend+"," + id_t+","+ precio+","+cantprend+");";
    }


    public string consultar(){
        return "SELECT * FROM `Producto` where id = '" + idprend + "'";
    }


    public string consultarTodos(){
        return "SELECT * from hirico_produc";
    }

    public string buscar(String filtro){
            return "select * from `Producto` where nombre like '" + filtro + "%' limit 5";
        }
    }
}