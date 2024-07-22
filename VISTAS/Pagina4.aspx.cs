using ExamenProgra2.CAPADATOS;using System;using System.Collections.Generic;using System.Configuration;using System.Data.SqlClient;using System.Linq;using System.Security.Policy;using System.Web;using System.Web.UI;using System.Web.UI.WebControls;namespace ExamenProgra2.VISTAS{    public partial class Pagina_4 : System.Web.UI.Page    {


        protected void BtnEnviar_Click(object sender, EventArgs e)
        {

            try
            {
                int votar = 0;
                int votarNulo = 0;


                if (rbVotar.Checked)
                {
                  votar = 1;
                    Response.Write("<script>alert('Datos ingresados correctamente.');</script>");
                }
                else if (rbVotarNulo.Checked)
                {
          
                   votarNulo =1;
                    Response.Write("<script>alert('Datos ingresados correctamente.');</script>");
                }

                IngresarDatos(votar, votarNulo);
                // Mostrar mensaje de éxito o realizar otras acciones después de insertar los datos
              
                Response.Write("<script>alert('Datos ingresados correctamente.');</script>");
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir durante el proceso
                Response.Write($"<script>alert('Error: {ex.Message}');</script>");
            }
        }


        protected void IngresarDatos(int votar, int votarNulo)
        {
            // Consulta SQL para insertar datos en la tabla votantes
            string query = "INSERT INTO votos (votar, votarNulo) " +
                           "VALUES (@CANTIDAD_VOTOS, @CANTIDAD_NULOS)";

            // Obtener la cadena de conexión desde la configuración
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

            // Crear una nueva conexión y comando dentro de un bloque using para asegurar que se liberen los recursos correctamente
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                // Abrir la conexión
                conexion.Open();

                // Crear el comando SQL con la consulta y la conexión
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    // Agregar parámetros al comando para evitar la inyección SQL y asegurar la correcta asignación de tipos de datos
                    comando.Parameters.AddWithValue("@CANTIDAD_VOTOS", votar);
                    comando.Parameters.AddWithValue("@CANTIDAD_NULOS", votarNulo);


                    // Ejecutar el comando SQL para insertar los datos
                    int filasAfectadas = comando.ExecuteNonQuery();

                    // Verificar si se insertaron filas correctamente
                    if (filasAfectadas > 0)
                    {
                        // Éxito: los datos se insertaron correctamente
                        Console.WriteLine("Datos insertados correctamente en la base de datos.");
                    }
                    else
                    {
                        // Manejar el caso en que no se insertaron filas (esto debería ser poco probable si no hay errores)
                        Console.WriteLine("No se pudo insertar los datos en la base de datos.");
                    }
                }
            }
        }

       
    }
}

    


