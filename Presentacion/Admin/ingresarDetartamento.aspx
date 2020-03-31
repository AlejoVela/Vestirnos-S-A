<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Admin/menuAdmin.Master" AutoEventWireup="true" CodeBehind="ingresarDetartamento.aspx.cs" Inherits="Vestinos_S.A.Presentacion.Admin.ingresarDetartamento" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        
    <!-- aqui comienza el codigo del proyecto aun con el php incluido-->
    <?php
        include 'Presentacion\Admin\menuAdmin.php';
        $error = 0;
        if(isset($_POST['registrar'])){

            $Departamento = new Departamento(1,$_POST['depa']);
            $Departamento->insertar();

        }
    ?>

    <div class="container">
	    <div class="row">
		    <div class="col-3"></div>
		    <div class="col-6">
			    <div class="card ">
				    <div class="card-header bg-primary text-white">Ingresar Departamento</div>
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
                  <label>Nombre del Departamento</label>
                  <input name="depa" type="text" class="form-control" placeholder="Digite el nombre del departamento" required="required">
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
