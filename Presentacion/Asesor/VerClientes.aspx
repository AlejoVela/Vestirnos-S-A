<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Asesor/menuAsesor.Master" AutoEventWireup="true" CodeBehind="VerClientes.aspx.cs" Inherits="Vestinos_S.A.Presentacion.Asesor.VerClientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


	<!-- aqui comienza el codigo del proyecto aun con el php incluido-->

	<div class="container">
		<div class="row">
			<div class="col-12">
				<div class="card">
					<div class="card-header bg-info text-white">Clientes</div>
					<div class="card-body">


						<div class="form-group">

						</div>
						<table class="table table-striped table-hover">
							<thead>
								<tr>
									<th scope="col">Identificacion</th>
									<th scope="col">Nombres</th>
									<th scope="col">Apellidos</th>
									<th scope="col"></th>
								</tr>
							</thead>
							<tbody>
							<% listaClientes(); %>
							</tbody>
						</table>
					</div>	
					</div>
				</div>
			</div>
		</div>
	
	<!-- aqui termina -->


</asp:Content>
