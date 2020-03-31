<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Ingeniero/sesionsesionIng.Master" AutoEventWireup="true" CodeBehind="AcPedido.aspx.cs" Inherits="Vestinos_S.A.Presentacion.Ingeniero.AcPedido" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <!-- aqui comienza el codigo del proyecto aun con el php incluido-->
	<?php
		include 'presentacion/Ingeniero/menuIng.php';
		$error = 0;
		if(isset($_POST['registrar'])){

			$Pedido =new Pedido($_GET['id'],$_POST['Materias'],$_POST['pro']);
			$Pedido->Actualizar();
	}

	?>
	<div class="container">
		<div class="row">
			<div class="col-3"></div>
			<div class="col-6">
				<div class="card ">
					<div class="card-header bg-primary text-white">Actualizar Pedidos</div>
					<div class="card-body">
						<?php if (isset($_POST['registrar'])) { ?>
						<div class="alert alert-<?php echo ($error==0) ? "success" : "danger" ?> alert-dismissible fade show"
							role="alert">
							<?php echo ($error==0) ? "Actualizacion exitosa" : $_POST['correo'] . " ya existe"; ?>
							<button type="button" class="close" data-dismiss="alert"
								aria-label="Close">
								<span aria-hidden="true">&times;</span>
							</button>
						</div>
						<?php } ?>
						<form method="post" action="#">
							<div class="form-group">
								<label>Proveedor</label>
					<select name="pro" type="text"
  									class="form-control" required="required">
					  <?php
					  $Proveedor = new Proveedor();
					  $resultado=$Proveedor-> consultarTodos();
					  foreach ($resultado as $a) {
						?><option value="<?php echo $a->getNit();?>"><?php echo "Nit:".$a->getNit()."  -  Nombre: ".$a->getNombre();?></option><?php
					  }

					  ?>
					</select>
							</div>
							<div class="form-group">
								<label>Materiales Manejados</label>
				  <select name="Materias" type="text"
					class="form-control" required="required">
					<?php

					$Existencia=new Existencia();
					$resultado= $Existencia->consultarOpc();
					foreach ($resultado as $a) {
						 ?><option value="<?php echo $a->getidex();?>">
						   <?php echo $a->getcantne()." - ".$a->getcantex();?></option><?php
					}

					?>
				  </select>
							</div>
							<div class="form-group">
								<label>Cantidad ideal a tener</label>
				  <input name="canti" type="number" class="form-control" placeholder="Cantidad ideal"
									required="required">
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
