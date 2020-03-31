using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Vestinos_S.A.logica;

namespace Vestinos_S.A.Presentacion.Asesor
{
    public partial class Factura : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*
            Producto p = new Producto();
            List<Producto> regi = p.consultarTodos();
            int i = 0;

		$error = 0;

            if (isset($_POST['Registrar']))
            {

			$v = 0;
                foreach ($regi as $a){
				$i++;
                    if ($_POST[$i."p"] > 0) {
						$v++;
                    }
                }
                if ($v > 0){
			$Venta = new Venta("",$_POST['clientes'],$_SESSION['id']);
			$Venta->insertar();
			$Venta->ultimo();
			$Venta_producto = new Venta_producto("",$Venta->getIdventa(), "");
			/*$Detalle= new DetalleFactura("","","",$Facturas->getId());
			$i = 0;
                    foreach ($regi as $a){
				$i++;
                        if ($_POST[$i."p"] > 0) {
						$Venta_producto->setcantcompra($_POST[$i."p"]);
						$Venta_producto->setIdproducto($a->getidpro());
						$Venta_producto->insertar();
                            /*$Detalle-> setCantidad($_POST[$i."p"]);
                            $Detalle-> setProducto($a->getId());
                            $Detalle->insertar();*
                        }
                    }
                    header('Location:generarfactura.php');
                }

            else
                {
				$error = 1;
                }
			$Producto = new Producto();
			$regi =$Producto->consultarTodos();
                
            }
   */
        }
    }
}