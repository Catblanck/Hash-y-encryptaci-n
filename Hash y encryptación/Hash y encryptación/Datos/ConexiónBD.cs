using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Hash_y_encryptación.Datos
{
    public class ConexionBD
    {
        private string servidor = "tallerbasededatos.mysql.database.azure.com";
        private string baseDatos = "empresa_db";
        private string usuario = "SaulJasso";
        private string password = "Soulkzj14";
        private string puerto = "3306";
        
        private MySqlConnection conexion;

        public ConexionBD()
        {
        }

        public MySqlConnection ObtenerConexion()
        {
            string cadenaConexion = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4};SslMode=Required;", servidor, puerto, baseDatos, usuario, password);
            conexion = new MySqlConnection(cadenaConexion);
            return conexion;
        }

        public void AbrirConexion()
        {
            if (conexion != null && conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }
        }

        public void CerrarConexion()
        {
            if (conexion != null && conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
        }
    }
}
