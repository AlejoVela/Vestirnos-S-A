<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Admin/menuAdmin.Master" AutoEventWireup="true" CodeBehind="ingresarEmpleado.aspx.cs" Inherits="Vestinos_S.A.Presentacion.Admin.ingresarEmpleado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        
    <!-- aqui comienza el codigo del proyecto aun con el php incluido-->
    <?php
        include 'Presentacion\Admin\menuAdmin.php';
        $error = 0;
        if(isset($_POST['registrar'])){

            $Empleado = new Empleado($_POST['cedula'],$_POST['Departamento'],$_POST['Cargo'],$_POST['nombre'],$_POST['telefono'],$_POST['apellido'],$_POST['direccion'],1,$_POST['pass'],$_POST['email']);
            $Empleado->insertar();
    }
    ?>

    <div class="container">
	    <div class="row">
		    <div class="col-3"></div>
		    <div class="col-6">
			    <div class="card ">
				    <div class="card-header bg-primary text-white">Registrar Empleado</div>
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
                  <label>Cedula</label>
                  <input name="cedula" type="number" class="form-control" placeholder="Digite su Cedula" required="required">
						    </div>

                <div class="form-group">
                  <label>Nombres</label>
                  <input name="nombre" type="text" class="form-control" placeholder="Digite sus nombres" required="required">
						    </div>

                <div class="form-group">
                  <label>Apellidos</label>
                  <input name="apellido" type="text" class="form-control" placeholder="Digite sus apellidos" required="required">
						    </div>

                <div class="form-group">
                  <label>Telefono</label>
                  <input name="telefono" type="number" class="form-control" placeholder="Digite su telefono" required="required">
						    </div>

                <div class="form-group">
                  <label>Dirección</label>
                  <input name="direccion" type="text" class="form-control" placeholder="Digite si dirección" required="required">
						    </div>

                <div class="form-group">
                  <label>Email</label>
                  <input name="email" type="email" class="form-control" placeholder="Digite su email" required="required">
						    </div>

                <div class="form-group">
                  <label>Password</label>
                  <input name="pass" type="password" class="form-control" placeholder="Digite su password" required="required">
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

						    <button type="submit" name="registrar" class="btn btn-primary">Registrar</button>
					    </form>
				    </div>
			    </div>
		    </div>
	    </div>
    </div>    
    <!-- aqui termina -->

</asp:Content>
