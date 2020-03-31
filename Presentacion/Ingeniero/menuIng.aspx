<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Ingeniero/sesionsesionIng.Master" AutoEventWireup="true" CodeBehind="menuIng.aspx.cs" Inherits="Vestinos_S.A.Presentacion.Ingeniero.menuIng" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <!-- aqui comienza el codigo del proyecto aun con el php incluido-->
    <?php
        include 'presentacion/Ingeniero/validacionIng.php';
        $Empleado = new Empleado($_SESSION['id']);
        $Empleado -> consultar();
    ?>
    <nav class="navbar navbar-expand-lg navbar-light bg-light">
      <a class="navbar-brand" href="#"><i class="fas fa-home"></i></a>
      <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
        <span class="navbar-toggler-icon"></span>
      </button>
      <div class="collapse navbar-collapse" id="navbarSupportedContent">
        <ul class="navbar-nav mr-auto">
          <li class="nav-item dropdown">
            <a class="nav-link dropdown-toggle" href="#" id="navbarDropdown" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
              Materias Primas
            </a>
            <div class="dropdown-menu" aria-labelledby="navbarDropdown">
              <a class="dropdown-item" href="index.php?pid=<?php echo base64_encode("Presentacion/Ingeniero/RegistroTipoMaterial.php")?>">Nuevos Tipos Materiales</a>
                <a class="dropdown-item" href="index.php?pid=<?php echo base64_encode("Presentacion/Ingeniero/RegistroCantidades.php")?>">Nuevos Cantidades</a>
                <a class="dropdown-item" href="index.php?pid=<?php echo base64_encode("Presentacion/Ingeniero/RegistroMaterial.php")?>">Nuevos Materiales</a>
            </div>
          </li>
          <li class="nav-item dropdown">
            <a class="nav-link dropdown-toggle" href="#" id="navbarDropdown" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
              Pedidos
            </a>
            <div class="dropdown-menu" aria-labelledby="navbarDropdown">
              <a class="dropdown-item" href="index.php?pid=<?php echo base64_encode("Presentacion\Ingeniero\RegistroPedido.php")?>">Ingreso Pedidos</a>
                <a class="dropdown-item" href="index.php?pid=<?php echo base64_encode("Presentacion\Ingeniero\RegistroPreovedor.php")?>">Ingreso Provedores</a>
                <a class="dropdown-item" href="index.php?pid=<?php echo base64_encode("Presentacion/Ingeniero/ConPedidos.php")?>">Consulta Pedidos</a>
                <a class="dropdown-item" href="index.php?pid=<?php echo base64_encode("Presentacion/Ingeniero/ConProveedor.php")?>">Consulta Provedores</a>
            </div>
          </li>
          <li class="nav-item dropdown">
            <a class="nav-link dropdown-toggle" href="#" id="navbarDropdown" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
              Generar Productos
            </a>
            <div class="dropdown-menu" aria-labelledby="navbarDropdown">
              <a class="dropdown-item" href="index.php?pid=<?php echo base64_encode("Presentacion/Ingeniero/insertarPrenda.php")?>">Prenda</a>
                <a class="dropdown-item" href="index.php?pid=<?php echo base64_encode("Presentacion/Ingeniero/insertarTalla.php")?>">Talla</a>
              <a class="dropdown-item" href="index.php?pid=<?php echo base64_encode("Presentacion/Ingeniero/insertarProductos.php")?>">Productos</a>
                <a class="dropdown-item" href="index.php?pid=<?php echo base64_encode("Presentacion/Ingeniero/ConProductos.php")?>">Consultar Productos</a>
            </div>
          </li>
          <li class="nav-item">
            <a class="nav-link" href="index.php?salir=1" tabindex="-1" >Salida</a>
          </li>
        </ul>
      </div>
    </nav>    
    <!-- aqui termina -->

</asp:Content>
