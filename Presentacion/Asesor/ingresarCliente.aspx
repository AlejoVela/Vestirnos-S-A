<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Asesor/menuAsesor.Master" AutoEventWireup="true" CodeBehind="ingresarCliente.aspx.cs" Inherits="Vestinos_S.A.Presentacion.Asesor.ingresarCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!-- aqui comienza el codigo del proyecto aun con el php incluido-->
    <?php
        include 'presentacion/Asesor/menuAcesor.php';$error = 0;
        if(isset($_POST['registrar'])){

            $Cliente = new Cliente($_POST['cedula'],$_POST['nombre'],$_POST['apellido'],$_POST['telefono']);
            $Cliente->insertar();

        }
    ?>

    <div class="container">
	    <div class="row">
		    <div class="col-3"></div>
		    <div class="col-6">
			    <div class="card ">
				    <div class="card-header bg-primary text-white">Registrar Cliente</div>
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
						    <button type="submit" name="registrar" class="btn btn-primary">Registrar</button>
					    </form>
				    </div>
			    </div>
		    </div>
	    </div>
    </div>
    <!-- aqui termina -->

</asp:Content>
