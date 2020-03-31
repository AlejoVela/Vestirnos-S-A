<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Asesor/menuAsesor.Master" AutoEventWireup="true" CodeBehind="AcCliente.aspx.cs" Inherits="Vestinos_S.A.Presentacion.Asesor.AcCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!-- aqui comienza el codigo del proyecto aun con el php incluido-->

    <div class="container">
	    <div class="row">
		    <div class="col-3"></div>
		    <div class="col-6">
			    <div class="card ">
				    <div class="card-header bg-primary text-white">Actualizar Cliente</div>
				    <div class="card-body">
					    

                <div class="form-group">
                  <label>Cedula</label>			   
					<select  runat="server" id="cedula" name="clientes" type="text" class="form-control" >
					  <% generarClientes(); %>
					</select>
						</div>
                <div class="form-group">
                  <label>Nombres</label>
                  <input runat="server" id="nombre" name="nombre" type="text" class="form-control" placeholder="Digite sus nombres" required="required" value="">
						    </div>

                <div class="form-group">
                  <label>Apellidos</label>
                  <input runat="server" id="apellido" name="apellido" type="text" class="form-control" placeholder="Digite sus apellidos" required="required" value="">
						    </div>

                <div class="form-group">
                  <label>Telefono</label>
                  <input runat="server" id="telefono" name="telefono" type="number" class="form-control" placeholder="Digite su telefono" required="required" value="">
						    </div>
						    <asp:button runat="server" Text="Actualizar" type="submit" name="Actualizar" class="btn btn-primary" OnClick="Unnamed1_Click"></asp:button>
					  
				    </div>
			    </div>
		    </div>
	    </div>
    </div>
    <!-- aqui termina-->
</asp:Content>
