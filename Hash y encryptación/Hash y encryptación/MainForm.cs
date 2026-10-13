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
		    if (passwordIngresado == "Password" || string.IsNullOrWhiteSpace(passwordIngresado))
		    {
		        MessageBox.Show("Por favor ingresa una contraseña.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		        return;
		    }
		
		    UsuarioDAO dao = new UsuarioDAO();
		    string rol = dao.Login(usuarioIngresado, passwordIngresado);
		
		    if (rol != null)
		    {
		        MenuPrincipalForm menu = new MenuPrincipalForm(rol);
		        LimpiarCampos();
		        this.Hide();
		        menu.Show();
		    }
		    else
		    {
		        MessageBox.Show("Usuario o contraseña incorrectos, o usuario inactivo.", "Error de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
		    }
		    
		    
		}
        
        private void LimpiarCampos()
		{
		    txtUsername.Text = "Username";
		    labelUsername.Visible = false;
		    
		    txtPassword.Text = "Password";
		    txtPassword.PasswordChar = '\0';
		    labelpassword.Visible = false;
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
}