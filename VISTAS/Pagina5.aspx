<%@ Page Title="" Language="C#" MasterPageFile="~/VISTAS/Pagina.Master" AutoEventWireup="true" CodeBehind="Pagina5.aspx.cs" Inherits="ExamenProgra2.VISTAS.Pagina_5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <link href="../CSS/totalVotaciones.css" rel="stylesheet" />
    <div>
        <h2>VOTACIONES TOTALES</h2>
       <table>
            <tr>
                <th>ELECTOS</th>
                <th>VOTOS</th>
            </tr>

      
            <% 
            try
            {
                   // El método de Mostrar la tabla de Votos y Electos el cual se implementó desde el código HTML para su funcionamiento

                string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

                using (var conn = new System.Data.SqlClient.SqlConnection(connectionString))
                {
                    conn.Open();
                    var sql = "SELECT electos, votos FROM totalvotos";
                    using (var cmd = new System.Data.SqlClient.SqlCommand(sql, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                %>
                                <tr>
                                    <td><%= reader["electos"] %></td>
                                    <td><%= reader["votos"] %></td>
                                </tr>
                                <% 
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de la excepción
                Response.Write($"Error: {ex.Message}");
            }
            %>
        </table>
    </div>
    </div>
</asp:Content>