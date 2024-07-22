<%@ Page Title="" Language="C#" MasterPageFile="~/VISTAS/Pagina.Master" AutoEventWireup="true" CodeBehind="Pagina2.aspx.cs" Inherits="ExamenProgra2.VISTAS.Pagina2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

  <asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../CSS/FormularioRegistroV.css" rel="stylesheet" />

    <h2>Formulario de Registro de Votantes</h2>

    <div>
        <label for="cedula">Cédula:</label>
        <asp:TextBox ID="txtCedula" runat="server" ClientIDMode="Static" type="number"></asp:TextBox><br /><br />
        
        <label for="nombre">Nombre:</label>
        <asp:TextBox ID="txtNombre" runat="server" ClientIDMode="Static"></asp:TextBox><br /><br />
        
        <label for="apellido1">Primer Apellido:</label>
        <asp:TextBox ID="txtApellido1" runat="server" ClientIDMode="Static"></asp:TextBox><br /><br />
        
        <label for="apellido2">Segundo Apellido:</label>
        <asp:TextBox ID="txtApellido2" runat="server" ClientIDMode="Static"></asp:TextBox><br /><br />
        
        <label for="ubicacion">Ubicación:</label>
        <asp:TextBox ID="txtUbicacion" runat="server" ClientIDMode="Static"></asp:TextBox><br /><br />
          
        <label for="edad">Edad:</label>
        <asp:TextBox ID="txtEdad" runat="server" ClientIDMode="Static" type="number"></asp:TextBox><br /><br />

        <asp:Button ID="btnRegistrar" CssClass="Section_form_inputBox" runat="server" Text="Registrar" OnClick="BtnRegistrar_Click" />
    </div>
</asp:Content>
       

