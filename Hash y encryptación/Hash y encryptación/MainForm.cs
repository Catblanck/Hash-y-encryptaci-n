using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Hash_y_encryptación.Datos;
using MySql.Data.MySqlClient;

namespace Hash_y_encryptación
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
        }
        
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string usuarioIngresado = txtUsername.Text;
            string passwordIngresado = txtPassword.Text;

            if (usuarioIngresado == "Username" || string.IsNullOrWhiteSpace(usuarioIngresado))
            {
                MessageBox.Show("Por favor ingresa un usuario válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ConexionBD conexionBd = new ConexionBD();
            try
            {
                var conexion = conexionBd.ObtenerConexion();
                conexion.Open();

                MessageBox.Show("¡Conexión exitosa!", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error al conectar con la base de datos", ex.Message), "Fallo de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Text = "";
                labelUsername.Visible = true; 
            }
        }
        
        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                txtUsername.Text = "Username";
                labelUsername.Visible = false;
            }
        }
        
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
                txtPassword.PasswordChar = '*'; 
                labelpassword.Visible = true; 
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtPassword.Text = "Password";
                txtPassword.PasswordChar = '\0';
                labelpassword.Visible = false;
            }
        }
    }
