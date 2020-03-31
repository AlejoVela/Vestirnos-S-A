<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Admin/menuAdmin.Master" AutoEventWireup="true" CodeBehind="sesionsesionAdmin.aspx.cs" Inherits="Vestinos_S.A.Presentacion.Admin.sesionsesionAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
    <!-- aqui comienza el codigo del proyecto aun con el php incluido-->
    <?php
        include 'Presentacion\Admin\menuAdmin.php';
        $Empleado = new Empleado($_SESSION['id']);
        $Empleado -> consultar();
    ?>
    <h1>Bienvenido Aministrador(a)  <?php echo $Empleado->getNem1(); ?></h1>

    <!-- aqui termina -->

</asp:Content>
