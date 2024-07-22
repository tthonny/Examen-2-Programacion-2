using ExamenProgra2.CAPADATOS;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace ExamenProgra2.VISTAS
{
    public partial class Pagina2 : System.Web.UI.Page
    { 


        protected void Page_Load(object sender, EventArgs e)
        {
         
          
        }


        protected void BtnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los valores de los controles de texto y convertirlos según sea necesario
                int cedula = Convert.ToInt32(txtCedula.Text);
                string nombre = txtNombre.Text;
                string apellido1 = txtApellido1.Text;
                string apellido2 = txtApellido2.Text;
                string ubicacion = txtUbicacion.Text;
                int edad = Convert.ToInt32(txtEdad.Text);

                // Llamar al método IngresarDatos para insertar los datos en la base de datos
                IngresarDatos(cedula, nombre, apellido1, apellido2, ubicacion, edad);

                // Mostrar mensaje de éxito o realizar otras acciones después de insertar los datos
                // Por ejemplo:
                Response.Write("<script>alert('Datos ingresados correctamente.');</script>");
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir durante el proceso
                Response.Write($"<script>alert('Error: {ex.Message}');</script>");
            }
        }

        protected void IngresarDatos(int cedula, string nombre, string apellido1, string apellido2, string ubicacion, int edad)
        {
            // Consulta SQL para insertar datos en la tabla votantes
            string query = "INSERT INTO votantes (cedula, nombre, apellido1, apellido2, ubicacion, edad) " +
                           "VALUES (@cedula, @nombre, @apellido1, @apellido2, @ubicacion, @edad)";

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
                    comando.Parameters.AddWithValue("@cedula", cedula);
                    comando.Parameters.AddWithValue("@nombre", nombre);
                    comando.Parameters.AddWithValue("@apellido1", apellido1);
                    comando.Parameters.AddWithValue("@apellido2", apellido2);
                    comando.Parameters.AddWithValue("@ubicacion", ubicacion);
                    comando.Parameters.AddWithValue("@edad", edad);

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

