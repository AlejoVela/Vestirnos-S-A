<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="Vestinos_S.A.Presentacion.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


<div class="container">
	<div class="row">
		<div class="col-12">
			<div class="card">
				<div class="card-header bg-info text-white">Bienvenido</div>
				<div class="card-body">
					<div class="row">
						<div class="col-4">
							<div class="card ">
								<div class="card-header bg-primary text-white">Autenticacion</div>
								<div class="card-body">
									<!--
										<?php if ($error == 1) { ?>
									<div class="alert alert-danger alert-dismissible fade show"
										role="alert">
										Error de correo o clave
										<button type="button" class="close" data-dismiss="alert"
											aria-label="Close">
											<span aria-hidden="true">&times;</span>
										</button>
									</div>
									<?php }?>
										-->
									<!-- <form method="post" action="index.php"> -->
										<div class="form-group">
											<label>Correo</label> 
											<input  id="correo" name="correo" type="email" runat="server" class="form-control" placeholder="Digite Correo" required="required">
										</div>
										<div class="form-group">
											<label>Clave</label> 
											<input id="pass" name="clave" runat="server" type="password" class="form-control" placeholder="Clave" required="required">
										</div>
										<asp:button runat="server" type="submit" name="autenticar" class="btn btn-primary" Text="Autentificar" OnClick="Unnamed1_Click"></asp:button>
									<!-- </form> -->
								</div>
							</div>
						</div>
						<div class="col-8 text-center">
							<img src="img/red.png"><br>
						</div>

					</div>
				</div>
			</div>
		</div>
	</div>
</div>


</asp:Content>
