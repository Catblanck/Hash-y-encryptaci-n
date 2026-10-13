using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Hash_y_encryptación.Datos;
using MySql.Data.MySqlClient;
using System.Data;

namespace Hash_y_encryptación
{
	public partial class VerUsuariosForm : Form
	{
		private string rolActual;
		
		public VerUsuariosForm(string rol)
		{
			InitializeComponent();
			rolActual = rol;
            CargarDatos();
		}
		
		private void CargarDatos()
        {
            UsuarioDAO dao = new UsuarioDAO();
            DataTable datos = dao.ObtenerUsuarios(rolActual); 
            dataGridView1.DataSource = datos; 
        }
		
		private void btnRegresar_Click(object sender, EventArgs e)
		{
		    this.Close();
		}
		private void VerUsuariosForm_FormClosed(object sender, FormClosedEventArgs e)
		{
		    Form menuForm = Application.OpenForms["MenuPrincipalForm"];
		    if (menuForm != null)
		    {
		        menuForm.Show();
		    }
		}
	}
}
