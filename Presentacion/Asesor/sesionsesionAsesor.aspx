<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Asesor/menuAsesor.Master" AutoEventWireup="true" CodeBehind="sesionsesionAsesor.aspx.cs" Inherits="Vestinos_S.A.Presentacion.Asesor.sesionsesionAsesor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <!-- aqui comienza el codigo del proyecto aun con el php incluido-->


    <h1>Bienvenido Asesor(a) de Ventas  <%  Response.Write(Session["nombresEmpleado"]);%></h1>
    <!-- aqui termina -->


</asp:Content>
