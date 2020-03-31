<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Asesor/menuAsesor.Master" AutoEventWireup="true" CodeBehind="Precios.aspx.cs" Inherits="Vestinos_S.A.Presentacion.Asesor.Precios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

	<!-- aqui comienza el codigo del proyecto aun con el php incluido-->

	<div class="container">

		<div class="row">
			<div class="col-12">
				<div class="card">
					<div class="card-header bg-info text-white">Productos</div>
					<div class="card-body">

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
								<% listaPrecios(); %>
							</tbody>
						</table>
					</div>
					</div>
				</div>
			</div>
	</div>

	<!-- aqui termina -->

</asp:Content>
