<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Ingeniero/sesionsesionIng.Master" AutoEventWireup="true" CodeBehind="ConProductos.aspx.cs" Inherits="Vestinos_S.A.Presentacion.Ingeniero.ConProductos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <!-- aqui comienza el codigo del proyecto aun con el php incluido-->
	<?php
		include 'Presentacion\Ingeniero\menuIng.php';
		$Empleado = new Empleado($_SESSION['id']);
		$Empleado -> consultar();
		$Producto= new Producto();
		$resultado=$Producto-> consultarTodos();
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
							<?php echo ($error==0) ? "Registro exitoso" : $_POST['correo'] . " ya existe"; ?>
							<button type="button" class="close" data-dismiss="alert"
								aria-label="Close">
								<span aria-hidden="true">&times;</span>
							</button>
						</div>
						<?php } ?>
						<table class="table table-striped table-hover">
							<thead>
								<tr>
									<th scope="col">Prenda</th>
									<th scope="col">Talla</th>
									<th scope="col">Cantida Stock</th>
					<th scope="col">Costo</th>
									<th scope="col"></th>
								</tr>
							</thead>
							<tbody>
								<?php
								$i=0;
								foreach ($resultado as $a){
									$i++;

									echo "<tr>";
									echo "<td>" . $a-> getidprend(). "</td>";
										echo "<td>" . $a-> getid_t() . "</td>";
										echo "<td>" . $a-> getprecio() . "</td>";
										echo "<td>" . $a-> getcantprend() . "</td>";


										echo "<td>";
										echo "<a href='index.php?pid=" . base64_encode("Presentacion/Ingeniero/AcProductos.php") .
													"&idAdministrador=" .
													"'>";
										 echo "<i class='fas fa-user-check' data-toggle='tooltip' data-placement='left' title='Actualisar'></i>";
										echo "</a>";
									echo "</td>";
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
