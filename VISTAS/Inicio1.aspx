<%@ Page Title="" Language="C#" MasterPageFile="~/VISTAS/Pagina.Master" AutoEventWireup="true" CodeBehind="Inicio1.aspx.cs" Inherits="ExamenProgra2.VISTAS.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  
           <head>

       <link href="../CSS/Inicio.css" rel="stylesheet" />
     </head>

    <body>
      <div class="container">

        <h1>Bienvenido al Sistema de Elecciones 2024</h1>
        <p>Esta aplicación web ha sido creada con el propósito de facilitar votaciones en diversos ámbitos. A continuación, exploraremos su funcionamiento y navegación dentro del sitio.</p>

        <h2>Funcionamiento del Sistema</h2>
        <ol>
            <li><strong>Página de Registro:</strong> En esta sección, los votantes pueden registrarse proporcionando todos los datos requeridos. Es crucial completar el formulario sin dejar ningún campo en blanco. Es importante destacar que no se permite el registro duplicado para mantener la integridad del proceso electoral.</li>
              <img src="../Imagenes/Pagina1.png"   class="image">
            <li><strong>Página de Registro de Electos:</strong> Similar a la página de registro de votantes, esta área permite que cualquier persona se registre como electo para ser considerado en las votaciones. Es necesario haber completado el registro en la página de votantes para poder participar como electo y ejercer el derecho al voto.</li>
                <img src="../Imagenes/Pagina3.png"   class="image">
            <li><strong>Página de Votación:</strong> Aquí se lleva a cabo la votación para los candidatos electos. Los usuarios pueden emitir su voto por los candidatos o dejar el voto en blanco.</li>
                <img src="../Imagenes/Pagina4.png"   class="image">
            <li><strong>Página de Resultados de Votación:</strong> En este apartado se muestra el total de votos que han recibido los candidatos electos, proporcionando transparencia en el proceso electoral.</li>
            <img src="../Imagenes/Pagina44.png"   class="image">
            <li><strong>Opción de Salir:</strong> Permite al usuario cerrar sesión y salir del sistema de manera segura.</li>
        </ol>
    <div>
</body>
</asp:Content>

