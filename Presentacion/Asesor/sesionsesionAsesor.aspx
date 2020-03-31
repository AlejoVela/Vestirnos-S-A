<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Asesor/menuAsesor.Master" AutoEventWireup="true" CodeBehind="sesionsesionAsesor.aspx.cs" Inherits="Vestinos_S.A.Presentacion.Asesor.sesionsesionAsesor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <!-- aqui comienza el codigo del proyecto aun con el php incluido-->
    <?php
        include 'Presentacion\Asesor\menuAcesor.php';
        $Empleado = new Empleado($_SESSION['id']);
        $Empleado -> consultar();
    ?>

    <h1>Bienvenido Asesor(a) de Ventas  <?php echo $Empleado->getNem1(); ?></h1>
    <!-- aqui termina -->


</asp:Content>
