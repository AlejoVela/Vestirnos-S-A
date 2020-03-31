<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Asesor/menuAsesor.Master" AutoEventWireup="true" CodeBehind="ingresarCliente.aspx.cs" Inherits="Vestinos_S.A.Presentacion.Asesor.ingresarCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
	    <div class="row">
		    <div class="col-3"></div>
		    <div class="col-6">
			    <div class="card ">
				    <div class="card-header bg-primary text-white">Registrar Cliente</div>
				    <div class="card-body">
					    <!--
                        <?php if (isset($_POST['registrar'])) { ?>
  					    <div class="alert alert-<?php echo ($error==0) ? "success" : "danger" ?> alert-dismissible fade show" role="alert">
  						    <?php echo ($error==0) ? "Registro exitoso" : $_POST['correo'] . " ya existe"; ?>
  						    <button type="button" class="close" data-dismiss="alert"
  							    aria-label="Close">
  							    <span aria-hidden="true">&times;</span>
  						    </button>
  					    </div>
					    <?php } ?>
                        -->

                <div class="form-group">
                  <label>Cedula</label>
                  <input runat="server" name="cedula" id="cedula" type="number" class="form-control" placeholder="Digite su Cedula" required="required">
						    </div>

                <div class="form-group">
                  <label>Nombres</label>
                  <input runat="server" name="nombre" type="text" id="nombre" class="form-control" placeholder="Digite sus nombres" required="required">
						    </div>

                <div class="form-group">
                  <label>Apellidos</label>
                  <input runat="server" name="apellido" id="apellido" type="text" class="form-control" placeholder="Digite sus apellidos" required="required">
						    </div>

                <div class="form-group">
                  <label>Telefono</label>
                  <input runat="server" name="telefono" id="telefono" type="number" class="form-control" placeholder="Digite su telefono" required="required">
						    </div>
                        
                        <asp:button runat="server" Text="Registrar" id="botonCli" type="submit" name="registrar" class="btn btn-primary" OnClick="botonCli_Click"></asp:button>


				    </div>
			    </div>
		    </div>
	    </div>
    </div>
    <!-- aqui termina -->

</asp:Content>
