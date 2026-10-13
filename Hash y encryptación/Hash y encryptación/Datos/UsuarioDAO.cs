using System;
using MySql.Data.MySqlClient;
using System.Data;

namespace Hash_y_encryptación.Datos
{
    public class UsuarioDAO
    {
        private ConexionBD conexionBd = new ConexionBD();

        public string Login(string usuario, string password_ingresada)
        {
            string rol = null;
            try
            {
                using (MySqlConnection conexion = conexionBd.ObtenerConexion())
                {
                    conexion.Open();
                    string query = "SELECT rol FROM EmpleadosTienda WHERE userName = @user AND password = SHA2(@pass, 256) AND userStatus = 'Active'";
                    
                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@user", usuario);
                        cmd.Parameters.AddWithValue("@pass", password_ingresada);
                        
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            rol = result.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error en BD: " + ex.Message);
            }
            return rol;
        }
        
        public DataTable ObtenerUsuarios(string rolUsuarioActual)
		{
		    DataTable dt = new DataTable();
		    try
		    {
		        using (MySqlConnection conexion = conexionBd.ObtenerConexion())
		        {
		            conexion.Open();
		            string query = "";
		            if (rolUsuarioActual == "Administrador")
		            {
		                query = @"SELECT 
		                            userName as 'USER ID', firstName as 'FIRST NAME', lastName as 'LAST NAME', 
		                            email as 'EMAIL ADDRESS', sucursal as 'SUCURSAL', puesto as 'PUESTO', 
		                            userStatus as 'STATUS', rol as 'ROLE', 
		                            CAST(AES_DECRYPT(curp, 'TuClaveSecreta') AS CHAR) as 'CURP',
		                            CAST(AES_DECRYPT(rfc, 'TuClaveSecreta') AS CHAR) as 'RFC',
		                            CAST(AES_DECRYPT(cuentaBancaria, 'TuClaveSecreta') AS CHAR) as 'CUENTA',
		                            CAST(AES_DECRYPT(salario, 'TuClaveSecreta') AS CHAR) as 'SALARIO'
		                          FROM EmpleadosTienda";
		            }
		            else
		            {
		                query = @"SELECT 
		                            userName as 'USER ID', firstName as 'FIRST NAME', lastName as 'LAST NAME', 
		                            email as 'EMAIL ADDRESS', sucursal as 'SUCURSAL', puesto as 'PUESTO', 
		                            userStatus as 'STATUS', rol as 'ROLE', 
		                            '*** OCULTO ***' as 'CURP',
		                            '*** OCULTO ***' as 'RFC',
		                            '*** OCULTO ***' as 'CUENTA',
		                            '*** OCULTO ***' as 'SALARIO'
		                          FROM EmpleadosTienda";
		            }
		
		            using (MySqlCommand cmd = new MySqlCommand(query, conexion))
		            {
		                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
		                {
		                    da.Fill(dt);
		                }
		            }
		        }
		    }
		    catch (Exception ex)
		    {
		        System.Windows.Forms.MessageBox.Show("Error al cargar la lista: " + ex.Message);
		    }
		    return dt;
		}
    }
}