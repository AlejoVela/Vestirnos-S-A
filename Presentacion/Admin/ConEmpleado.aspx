<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Admin/menuAdmin.Master" AutoEventWireup="true" CodeBehind="ConEmpleado.aspx.cs" Inherits="Vestinos_S.A.Presentacion.Admin.ConEmpleado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        
    <!-- aqui comienza el codigo del proyecto aun con el php incluido-->
	<?php
		include 'Presentacion\Admin\menuAdmin.php';
		$Empleado = new Empleado($_SESSION['id']);
		$Empleado -> consultar();
		if(isset($_GET['idAdministrador']) && isset($_GET['estado']) && $_GET['idAdministrador'] != $_SESSION['id']){
			$EmpleadoEstado = new Empleado($_GET['idAdministrador'],"","", "","","","",$_GET['estado']);
			$EmpleadoEstado->cambiarEstado();
		}

		$resultado=$Empleado-> consultarTodos();
	?>
	<div class="container">
		<form method="post" action="#">
		<div class="row">
			<div class="col-12">
				<div class="card">
					<div class="card-header bg-info text-white">Empleados</div>
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
									<th scope="col">CC empleado</th>
									<th scope="col">Nombre</th>
									<th scope="col">Apellido</th>
									<th scope="col">Telefono</th>
									<th scope="col">Direccion</th>
									<th scope="col">Cargo</th>
									<th scope="col">Estados</th>
									<th scope="col">Actualisar</th>
								</tr>
							</thead>
							<tbody>
								<?php
								$i=0;
								foreach ($resultado as $a){
									$i++;
										//$Cargo = new Cargo($a->getIdcar());
										//$Cargo->consultar();

									echo "<tr>";
									echo "<td>" . $a-> getCcemple(). "</td>";
										echo "<td>" . $a-> getNem1() . "</td>";
										echo "<td>" . $a-> getApem1() . "</td>";
										echo "<td>" . $a-> getTelefono_emp() . "</td>";
									echo "<td>" . $a-> getDirecemple() . "</td>";
									echo "<td>" . $a->getIdcar() . "</td>";

										echo "<td>";
									if($_SESSION['id'] != $a-> getCcemple()){
										if($a->getEstado()==1){
											echo "<a href='index.php?pid=" . base64_encode("Presentacion/Admin/ConEmpleado.php") . "&idAdministrador=" . $a-> getCcemple() . "&estado=0'>";
											echo "<i class='fas fa-user-times' data-toggle='tooltip' data-placement='left' title='Deshabilitar'></i>";
											echo "</a>";
										}else{
											echo "<a href='index.php?pid=" . base64_encode("Presentacion/Admin/ConEmpleado.php") . "&idAdministrador=" . $a-> getCcemple() . "&estado=1'>";
											echo "<i class='fas fa-user-check' data-toggle='tooltip' data-placement='left' title='Habilitar'></i>";
											echo "</a>";
										}
									}

									echo "</td>";
										echo "<td>";
										echo "<a href='index.php?pid=" . base64_encode("Presentacion/Admin/AcEmpleado.php") .
													"&idAdministrador=" . $a-> getCcemple() .
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
