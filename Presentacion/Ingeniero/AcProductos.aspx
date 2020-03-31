<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Ingeniero/sesionsesionIng.Master" AutoEventWireup="true" CodeBehind="AcProductos.aspx.cs" Inherits="Vestinos_S.A.Presentacion.Ingeniero.AcProductos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <!-- aqui comienza el codigo del proyecto aun con el php incluido-->
    <?php
        include 'presentacion/Ingeniero/menuIng.php';
        $error = 0;
        if(isset($_POST['registrar'])){
          $Producto = new Producto($_POST['prenda'],$_POST['talla'],$_POST['precio'],$_POST['cant'],1);
          $Producto->insertar();
        }
    ?>

    <div class="container">
	    <div class="row">
		    <div class="col-3"></div>
		    <div class="col-6">
			    <div class="card ">
				    <div class="card-header bg-primary text-white">Actualizar Producto</div>
				    <div class="card-body">
					    <?php if (isset($_POST['registrar'])) { ?>
  					    <div class="alert alert-<?php echo ($error==0) ? "success" : "danger" ?> alert-dismissible fade show" role="alert">
  						    <?php echo ($error==0) ? "Registro exitoso" : $_POST['correo'] . " ya existe"; ?>
  						    <button type="button" class="close" data-dismiss="alert"
  							    aria-label="Close">
  							    <span aria-hidden="true">&times;</span>
  						    </button>
  					    </div>
					    <?php } ?>
					    <form method="post" action="#">

						    <div class="form-group">
							    <label>Prenda</label>
                    <select name="prenda" type="text"
  								    class="form-control" required="required">
                      <?php
                      $Prenda = new Prenda();
                      $resultado=$Prenda-> consultarTodos();

                      foreach ($resultado as $a) {
                           ?><option value="<?php echo $a->getIdprend();?>"><?php echo $a->getNomprend();?></option><?php
                      }

                      ?>
                    </select>
						    </div>

						    <div class="form-group">
							    <label>Talla</label>
                  <select name="talla" type="text"
                    class="form-control" required="required">
                    <?php
                    $Talla = new Talla();
                    $resultado=$Talla->consultarTodos();
                    foreach ($resultado as $a) {
                         ?><option value="<?php echo $a->getId_t();?>"><?php echo $a->getTalla();?></option><?php
                    }
                    ?>
                  </select>
						    </div>


               <div class="form-group">
                  <label>Precio</label>
                  <input name="precio" type="number" class="form-control" placeholder="Digite el precio" required="required">
              </div>

              <div class="form-group">
              Cantidad     <input type="number" id="" name="cant" value="0" min="0" max="999">
              </div>

						    <button type="submit" name="registrar" class="btn btn-primary">Actualizar</button>
					    </form>
				    </div>
			    </div>
		    </div>
	    </div>
    </div>    
        <!-- aqui termina -->
</asp:Content>
