<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Asesor/menuAsesor.Master" AutoEventWireup="true" CodeBehind="Precios.aspx.cs" Inherits="Vestinos_S.A.Presentacion.Asesor.Precios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

	<!-- aqui comienza el codigo del proyecto aun con el php incluido-->
    <?php
		include 'presentacion/Asesor/menuAcesor.php';
		$Empleado = new Empleado($_SESSION['id']);
		$Empleado -> consultar();
		$Producto = new Producto();
		$regi=$Producto -> consultarTodos();
		$i=0;

		$error=0;
	?>
	<div class="container">
		<form method="post" action="#">
		<div class="row">
			<div class="col-12">
				<div class="card">
					<div class="card-header bg-info text-white">Productos</div>
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
									<th scope="col">Prenda</th>
									<th scope="col">Talla</th>
									<th scope="col">Catidad</th>
									<th scope="col">Precio</th>
								</tr>
							</thead>
							<tbody>
								<?php
								$Producto = new Producto();
								$regi=$Producto -> consultarTodos();
								$i=0;
								foreach ($regi as $a){
									$i++;

									echo "<tr>";
									echo "<td>" . $a -> getidprend() . "</td>";
									echo "<td>" . $a -> getid_t() . "</td>";
									echo "<td>" . $a -> getprecio() . "</td>";
									echo "<td>" . $a -> getcantprend() . "</td>";

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
