<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Asesor/menuAsesor.Master" AutoEventWireup="true" CodeBehind="Factura.aspx.cs" Inherits="Vestinos_S.A.Presentacion.Asesor.Factura" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!-- aqui comienza el codigo del proyecto aun con el php incluido-->
	
	<div class="container">
		<form method="post" action="#">
		<div class="row">
			<div class="col-12">
				<div class="card">
					<div class="card-header bg-info text-white">Factura</div>
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
							<div class="form-group">
								<label>Clientes</label>
					<select name="clientes" type="text"
  									class="form-control" >
					  <?php
										$Cliente = new Cliente();
					  $resultado=$Cliente-> consultarTodos();
					  foreach ($resultado as $a) {
											?><option value="<?php echo $a->getCc();?>"><?php echo  $a->getCc()."-".$a->getNom1();?></option><?php
					  }

					  ?>
					</select>
							</div>
						</div>
						<table class="table table-striped table-hover">
							<thead>
								<tr>
									<th scope="col">Prenda</th>
									<th scope="col">Talla</th>
									<th scope="col">Catidad</th>
									<th scope="col">Precio</th>
									<th scope="col">cantidad solisitada</th>
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
										?>
										 <td>
											 <input type="number" id="" name="<?php echo $i."p"; ?>" value="0"
	        	 						min="0" max="<?php echo $a -> getprecio()-3; ?>">
											</td>
										<?php
									echo "</tr>";
								}
								?>
							</tbody>
						</table>
						<button name="Registrar" class="btn btn-primary">Registrar</button>
					</form>
					</div>
				</div>
			</div>
		</div>
	</div>
    <!-- aqui termina -->
</asp:Content>
