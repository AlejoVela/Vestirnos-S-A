<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Asesor/menuAsesor.Master" AutoEventWireup="true" CodeBehind="VerClientes.aspx.cs" Inherits="Vestinos_S.A.Presentacion.Asesor.VerClientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


	<!-- aqui comienza el codigo del proyecto aun con el php incluido-->

    <?php
		include 'presentacion/Asesor/menuAcesor.php';
		$Empleado = new Empleado($_SESSION['id']);
		$Empleado -> consultar();
		$Cliente = new Cliente();
		$regi=$Cliente ->consultarTodos();
		$i=0;

		$error=0;
	?>
	<div class="container">
		<form method="post" action="#">
		<div class="row">
			<div class="col-12">
				<div class="card">
					<div class="card-header bg-info text-white">Clientes</div>
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
									<th scope="col">Identificacion</th>
									<th scope="col">Nombres</th>
									<th scope="col">Apellidos</th>
									<th scope="col">Telefono</th>
									<th scope="col"></th>
								</tr>
							</thead>
							<tbody>
								<?php
								$i=0;
								foreach ($regi as $a){
									$i++;

									echo "<tr>";
									echo "<td>" . $a -> getCc() . "</td>";
									echo "<td>" . $a -> getNom1() . "</td>";
									echo "<td>" . $a -> getApe1() . "</td>";
									echo "<td>" . $a -> gettel() . "</td>";
										echo "<td>";
										echo "<a href='index.php?pid=" . base64_encode("Presentacion/Asesor/AcCliente.php") . "&idAdministrador=" .$a -> getCc(). "&estado=1'>";
										echo "<i class='fas fa-user-check' data-toggle='tooltip' data-placement='left' title='Actualizar'></i>";
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
