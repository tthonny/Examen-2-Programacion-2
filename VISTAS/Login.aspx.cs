using ExamenProgra2.CAPADATOS;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace ExamenProgra2.VISTAS
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bingresar_Click(object sender, EventArgs e)
        {
             ValidarUsuario(tusuario.Text,tclave.Text);


        }

        //Metodo validar usuario que permite el ingreso de usuario con correo y contraseña 
        protected void ValidarUsuario(string email , string clave)
        {
            
            Clsusuario.correo = email;
            Clsusuario.clave = clave;
            String s = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand("select email, clave from usuarios where email = '" + email + "' " +
                "and clave = '" + clave + "'", conexion);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                Response.Redirect("inicio1.aspx");
            }
            else
            {
              Console.WriteLine( " usuario o contraseña incorrecto");
            }
            conexion.Close();


        }

        protected void ayuda_Click(object sender, EventArgs e)
        {
            Response.Redirect("PaginaAyuda.html");

        }
    }
}