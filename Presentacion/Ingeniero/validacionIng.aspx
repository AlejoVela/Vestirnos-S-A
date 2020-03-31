<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Ingeniero/sesionsesionIng.Master" AutoEventWireup="true" CodeBehind="validacionIng.aspx.cs" Inherits="Vestinos_S.A.Presentacion.Ingeniero.validacionIng" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        
    <!-- aqui comienza el codigo del proyecto aun con el php incluido-->    
    <?php
        if(isset($_SESSION['id'])){
            if($_SESSION['rol'] == "ingeniero" ){
                $Empleado = new Empleado($_SESSION['id']);
                $Empleado -> consultar();
                if($Empleado -> getEstado() == 0) {
                    //header('Location: index.php');
                }
            }else{
                $pid = base64_encode("presentacion/error.php");
                header('Location: index.php?pid='. $pid);
            }
        }else{
            header('Location: index.php');
        }
    ?>      
    <!-- aqui termina -->

</asp:Content>
