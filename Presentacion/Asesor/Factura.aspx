<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Asesor/menuAsesor.Master" AutoEventWireup="true" CodeBehind="Factura.aspx.cs" Inherits="Vestinos_S.A.Presentacion.Asesor.Factura" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!-- aqui comienza el codigo del proyecto aun con el php incluido-->
	
	<div class="container">

		<div class="row">
			<div class="col-12">
				<div class="card">
					<div class="card-header bg-info text-white">Factura</div>
					<div class="card-body">

						<div class="form-group">
							<div class="form-group">
								<label>Clientes</label>
					<select name="clientes" type="text" class="form-control" >
					  <% generarClientes(); %>
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
								<% listaProductos(); %>
							</tbody>
						</table>
						<asp:button runat="server" name="Registrar" class="btn btn-primary" Text="Registrar" OnClick="Unnamed1_Click"></asp:button>
					</div>
				</div>
			</div>
		</div>
	</div>
					
    <!-- aqui termina -->
</asp:Content>
