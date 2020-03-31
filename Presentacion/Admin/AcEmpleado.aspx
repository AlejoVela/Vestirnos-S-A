<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Admin/menuAdmin.Master" AutoEventWireup="true" CodeBehind="AcEmpleado.aspx.cs" Inherits="Vestinos_S.A.Presentacion.Admin.AcEmpleado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <!-- aqui comienza el codigo del proyecto aun con el php incluido-->
    <?php
        include 'Presentacion\Admin\menuAdmin.php';
        $error = 0;
        $Empleado = new Empleado($_GET['idAdministrador']);
        $Empleado -> consultar();
        if(isset($_POST['Actualisar'])){

            $Empleadoac = new Empleado($_GET['idAdministrador'],$_POST['Departamento'],$_POST['Cargo'],$_POST['nombre'],$_POST['telefono'],$_POST['apellido'],$_POST['direccion'],1,"","");
            $Empleadoac->Actualisar();

        }
    ?>

    <div class="container">
	    <div class="row">
		    <div class="col-3"></div>
		    <div class="col-6">
			    <div class="card ">
				    <div class="card-header bg-primary text-white">Actualizar Empleado</div>
				    <div class="card-body">
					    <?php if (isset($_POST['Actualisar'])) { ?>
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
                  <label>Cedula</label>
                  <input type="number" name="cedula"  class="form-control" disabled="" value="<?php echo  $Empleado-> getCcemple();   ?>" >
						    </div>
                <div class="form-group">
                  <label>Nombres</label>
                  <input name="nombre" type="text" class="form-control" placeholder="Digite sus nombres" required="required" value="<?php echo  $Empleado-> getNem1() ; ?>">
						    </div>

                <div class="form-group">
                  <label>Apellidos</label>
                  <input name="apellido" type="text" class="form-control" placeholder="Digite sus apellidos" required="required" value="<?php
                  echo  $Empleado-> getApem1() ; ?>">
						    </div>

                <div class="form-group">
                  <label>Telefono</label>
                  <input name="telefono" type="number" class="form-control" placeholder="Digite su telefono" required="required" value="<?php
                              echo  $Empleado-> getTelefono_emp() ; ?>">
						    </div>

                <div class="form-group">
                  <label>Dirección</label>
                  <input name="direccion" type="text" class="form-control" placeholder="Digite si dirección" required="required" value="<?php
                              echo  $Empleado-> getDirecemple() ; ?>">
						    </div>

						    <div class="form-group">
							    <label>Cargo</label>
                    <select name="Cargo" type="text"
  								    class="form-control" required="required">
                      <?php
                      $Cargo = new Cargo();
                      $resultado=$Cargo-> consultarTodos();

                      foreach ($resultado as $a) {
                           ?><option value="<?php echo $a->getIdcar();?>"><?php echo $a->getNcargo();?></option><?php
                      }

                      ?>
                    </select>
						    </div>

						    <div class="form-group">
							    <label>Departamento</label>
                  <select name="Departamento" type="text"
                    class="form-control" required="required">
                    <?php
                    $Departamento = new Departamento();
                    $resultado=$Departamento->consultarTodos();
                    foreach ($resultado as $a) {
                         ?><option value="<?php echo $a->getIddepa();?>"><?php echo $a->getNomdepa();?></option><?php
                    }
                    ?>
                  </select>
						    </div>

						    <button type="submit" name="Actualisar" class="btn btn-primary">Actualizar</button>
					    </form>
				    </div>
			    </div>
		    </div>
	    </div>
    </div>  
    <!-- aqui termina -->
</asp:Content>
