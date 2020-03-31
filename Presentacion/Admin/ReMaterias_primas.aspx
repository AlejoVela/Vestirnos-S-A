<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Admin/menuAdmin.Master" AutoEventWireup="true" CodeBehind="ReMaterias_primas.aspx.cs" Inherits="Vestinos_S.A.Presentacion.Admin.ReMaterias_primas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        
	<!-- aqui comienza el codigo del proyecto aun con el php incluido-->
	<?php
		include 'presentacion/Admin/menuAdmin.php';
		$Empleado = new Empleado($_SESSION['id']);
		$Empleado -> consultar();
		$Producto = new Reportes();
		$regi=$Producto -> consultarTodos();
		$i=0;

		$error=0;
	?>
	<div class="container">
		<form method="post" action="#">
		<div class="row">
			<div class="col-12">
				<div class="card">
					<div class="card-header bg-info text-white">ReMaterias Primas</div>
					<div class="card-body">
						<?php if (isset($_POST['Registrar'])) { ?>
						<div class="alert alert-<?php echo ($error==0) ? "success" : "danger" ?> alert-dismissible fade show"
							role="alert">
							<?php echo ($error==0) ? "Registro exitoso" : " No tiene productos su Venta"; ?>
							<button type="button" class="close" data-dismiss="alert"
								aria-label="Close">
								<span aria-hidden="true">&times;</span>
							</button>
						</div>
						<?php } ?>
						<div class="form-group">

						</div>
						<table class="table table-striped table-hover">
							<thead>
								<tr>
									<th scope="col">Codigo</wth>
									<th scope="col">Unidades</th>
									<th scope="col">Material</th>
									<th scope="col">Existencia</th>
								</tr>
							</thead>
							<tbody>
								<?php
								$Existencia = new Existencia();
								$regi=$Existencia -> consultarTodos();
								foreach ($regi as $a){
									echo "<tr>";
									echo "<td>" . $a -> getidex() . "</td>";
									echo "<td>" . $a -> getIduni() . "</td>";
										echo "<td>" . $a -> getIdmat() . "</td>";
									echo "<td>" . $a -> getcantex() . "</td>";

									echo "</tr>";
								}
								?>
							</tbody>
						</table>
					</form>
					</div>
				</div>
			</div>
		</div>
	</div>
	<!-- aqui termina -->
</asp:Content>
