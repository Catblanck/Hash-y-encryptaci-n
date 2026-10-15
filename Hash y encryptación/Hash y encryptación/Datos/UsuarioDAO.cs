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
		                            idUsuario as 'ID',
		                            userName as 'USER ID', firstName as 'FIRST NAME', lastName as 'LAST NAME', 
		                            email as 'EMAIL ADDRESS', sucursal as 'SUCURSAL', puesto as 'PUESTO', 
		                            userStatus as 'STATUS', rol as 'ROLE', createdDate as 'CREATED DATE', phone as 'PHONE',
									address	as 'ADDRESS', birthdate as 'BIRTHDATE',
		                            CAST(AES_DECRYPT(curp, 'ClaveSecretaCURP') AS CHAR) as 'CURP',
		                            CAST(AES_DECRYPT(rfc, 'ClaveSecretaRFC') AS CHAR) as 'RFC',
		                            CAST(AES_DECRYPT(cuentaBancaria, 'ClaveSecretaCuentaB') AS CHAR) as 'CUENTA',
		                            CAST(AES_DECRYPT(salario, 'ClaveSecretaSalario') AS CHAR) as 'SALARIO'
		                          FROM EmpleadosTienda";
		            }
		            else
		            {
		                query = @"SELECT 
		                            idUsuario as 'ID',
		                            userName as 'USER ID', firstName as 'FIRST NAME', lastName as 'LAST NAME', 
		                            email as 'EMAIL ADDRESS', sucursal as 'SUCURSAL', puesto as 'PUESTO', 
		                            userStatus as 'STATUS', rol as 'ROLE', createdDate as 'CREATED DATE', phone as 'PHONE',
									address	as 'ADDRESS', birthdate as 'BIRTHDATE'
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

        public bool RegistrarEmpleado(string userName, string password, string firstName, string lastName, string gender, string email, string sucursal, string puesto, string rol, string phone, string address, string birthdate, string curp, string rfc, string cuentaBancaria, string salario)
        {
            bool exito = false;
            string query = "INSERT INTO EmpleadosTienda (userName, password, firstName, lastName, gender, email, sucursal, puesto, rol, phone, address, birthdate, curp, rfc, cuentaBancaria, salario) VALUES (@userName, SHA2(@password, 256), @firstName, @lastName, @gender, @email, @sucursal, @puesto, @rol, @phone, @address, @birthdate, AES_ENCRYPT(@curp, 'ClaveSecretaCURP'), AES_ENCRYPT(@rfc, 'ClaveSecretaRFC'), AES_ENCRYPT(@cuentaBancaria, 'ClaveSecretaCuentaB'), AES_ENCRYPT(@salario, 'ClaveSecretaSalario'))";

            try
            {
                using (MySqlConnection conexion = conexionBd.ObtenerConexion())
                {
                    conexion.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@userName", userName);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.Parameters.AddWithValue("@firstName", firstName);
                        cmd.Parameters.AddWithValue("@lastName", lastName);
                        cmd.Parameters.AddWithValue("@gender", gender);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@sucursal", sucursal);
                        cmd.Parameters.AddWithValue("@puesto", puesto);
                        cmd.Parameters.AddWithValue("@rol", rol);
                        cmd.Parameters.AddWithValue("@phone", phone);
                        cmd.Parameters.AddWithValue("@address", address);
                        cmd.Parameters.AddWithValue("@birthdate", birthdate);
                        cmd.Parameters.AddWithValue("@curp", curp);
                        cmd.Parameters.AddWithValue("@rfc", rfc);
                        cmd.Parameters.AddWithValue("@cuentaBancaria", cuentaBancaria);
                        cmd.Parameters.AddWithValue("@salario", salario);

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            exito = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al registrar empleado: " + ex.Message);
            }

            return exito;
        }

        public bool ActualizarEmpleado(int idUsuario, string userName, string firstName, string lastName, string gender, string email, string sucursal, string puesto, string rol, string phone, string address, string birthdate, string curp, string rfc, string cuentaBancaria, string salario)
		{
	    using (MySqlConnection conexion = conexionBd.ObtenerConexion())
	    	{
	        string query = "UPDATE EmpleadosTienda SET userName = @userName, firstName = @firstName, lastName = @lastName, gender = @gender, email = @email, sucursal = @sucursal, puesto = @puesto, rol = @rol, phone = @phone, address = @address, birthdate = @birthdate, curp = AES_ENCRYPT(@curp, 'ClaveSecretaCURP'), rfc = AES_ENCRYPT(@rfc, 'ClaveSecretaRFC'), cuentaBancaria = AES_ENCRYPT(@cuentaBancaria, 'ClaveSecretaCuentaB'),  salario = AES_ENCRYPT(@salario, 'ClaveSecretaSalario') WHERE idUsuario = @idUsuario";
	        
	        using (MySqlCommand comando = new MySqlCommand(query, conexion))
	        	{
	            comando.Parameters.AddWithValue("@idUsuario", idUsuario);
	            comando.Parameters.AddWithValue("@userName", userName);
	            comando.Parameters.AddWithValue("@firstName", firstName);
	            comando.Parameters.AddWithValue("@lastName", lastName);
	            comando.Parameters.AddWithValue("@gender", gender);
	            comando.Parameters.AddWithValue("@email", email);
	            comando.Parameters.AddWithValue("@sucursal", sucursal);
	            comando.Parameters.AddWithValue("@puesto", puesto);
	            comando.Parameters.AddWithValue("@rol", rol);
	            comando.Parameters.AddWithValue("@phone", phone);
	            comando.Parameters.AddWithValue("@address", address);
	            comando.Parameters.AddWithValue("@birthdate", birthdate);
                comando.Parameters.AddWithValue("@curp", curp);
                comando.Parameters.AddWithValue("@rfc", rfc);
                comando.Parameters.AddWithValue("@cuentaBancaria", cuentaBancaria);
	            comando.Parameters.AddWithValue("@salario", salario);
	            
	
	            try
	            {
	                conexion.Open();
	                int filasAfectadas = comando.ExecuteNonQuery();
	                return filasAfectadas > 0;
	            }
	            catch (Exception ex)
	            	{
	                System.Windows.Forms.MessageBox.Show("Error al actualizar: " + ex.Message);
	                return false;
	            	}
	        	}
	   		}
		}	

        public bool EliminarEmpleado(int idUsuario)
        {
            using (MySqlConnection conexion = conexionBd.ObtenerConexion())
            {
                string query = "DELETE FROM EmpleadosTienda WHERE idUsuario = @idUsuario";
                
                using (MySqlCommand comando = new MySqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@idUsuario", idUsuario);

                    try
                    {
                        conexion.Open();
                        int filasAfectadas = comando.ExecuteNonQuery();
                        return filasAfectadas > 0;
                    }
                    catch (Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show("Error al eliminar: " + ex.Message);
                        return false;
                    }
                }
            }
        }
    }
}
