<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Ingeniero/sesionsesionIng.Master" AutoEventWireup="true" CodeBehind="RegistroMaterial.aspx.cs" Inherits="Vestinos_S.A.Presentacion.Ingeniero.RegistroMaterial" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <!-- aqui comienza el codigo del proyecto aun con el php incluido-->
	<?php
		include 'presentacion/Ingeniero/menuIng.php';
		$error = 0;
		if(isset($_POST['registrar'])){
			$Existencia =new Existencia($_POST['Medida'],$_POST['Material'],$_POST['canti']);
			$Existencia->insertar();
		}
	?>
	<div class="container">
		<div class="row">
			<div class="col-3"></div>
			<div class="col-6">
				<div class="card ">
					<div class="card-header bg-primary text-white">Registro Material</div>
					<div class="card-body">
						<?php if (isset($_POST['registrar'])) { ?>
						<div class="alert alert-<?php echo ($error==0) ? "success" : "danger" ?> alert-dismissible fade show"
							role="alert">
							<?php echo ($error==0) ? "Registro exitoso" : $_POST['correo'] . " ya existe"; ?>
							<button type="button" class="close" data-dismiss="alert"
								aria-label="Close">
								<span aria-hidden="true">&times;</span>
							</button>
						</div>
						<?php } ?>
						<form method="post" action="#">
							<div class="form-group">
								<label>Tipo Material</label>
					<select name="Material" type="text"
  									class="form-control" required="required">
					  <?php
					  $Matprima = new Matprima();
					  $resultado=$Matprima-> consultarTodos();
					  foreach ($resultado as $a) {
						   ?><option value="<?php echo $a->getIdmat();?>"><?php echo $a->getNommat();?></option><?php
					  }

					  ?>
					</select>
							</div>
							<div class="form-group">
								<label>Unidad de Medida</label>
				  <select name="Medida" type="text"
					class="form-control" required="required">
					<?php
					$Unimedida = new Unimedida();
					$resultado=$Unimedida->consultarTodos();
					foreach ($resultado as $a) {
						 ?><option value="<?php echo $a->getiduni();?>"><?php echo $a->getunidad();?></option><?php
					}

					?>
				  </select>
							</div>
							<div class="form-group">
								<label>Cantidad ideal a tener</label>
				  <input name="canti" type="number" class="form-control" placeholder="Cantidad ideal"
									required="required">
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
