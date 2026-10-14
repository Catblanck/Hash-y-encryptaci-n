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

        private void btnEliminar_Click(object sender, EventArgs e)
{
    if (dataGridView1.SelectedRows.Count > 0)
    {
        int idUsuario = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
        
        DialogResult resultado = MessageBox.Show("¿Estás seguro de eliminar este empleado?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        
        if (resultado == DialogResult.Yes)
        {
            UsuarioDAO dao = new UsuarioDAO();
            bool eliminado = dao.EliminarEmpleado(idUsuario);
            
            if (eliminado)
            {
                MessageBox.Show("Empleado eliminado correctamente.");
                CargarDatos();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar el empleado.");
            }
        }
    }
    else
    {
        MessageBox.Show("selecciona una fila completa en la tabla.");
    }
}
	private void btnModificar_Click(object sender, EventArgs e)
		{
    if (dataGridView1.SelectedRows.Count > 0)
    		{
        int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
        string userName = dataGridView1.SelectedRows[0].Cells["USER ID"].Value.ToString();
        string firstName = dataGridView1.SelectedRows[0].Cells["FIRST NAME"].Value.ToString();
        string lastName = dataGridView1.SelectedRows[0].Cells["LAST NAME"].Value.ToString();
        string email = dataGridView1.SelectedRows[0].Cells["EMAIL ADDRESS"].Value.ToString();
        string sucursal = dataGridView1.SelectedRows[0].Cells["SUCURSAL"].Value.ToString();
        string puesto = dataGridView1.SelectedRows[0].Cells["PUESTO"].Value.ToString();
        string rol = dataGridView1.SelectedRows[0].Cells["ROLE"].Value.ToString();

        AgregarEmpleadoForm formModificar = new AgregarEmpleadoForm(
            id, userName, firstName, lastName, "Masculino", email, sucursal, puesto, rol, "", ""
        	);
        
        formModificar.ShowDialog();
        CargarDatos();
    		}
    	else
    	{
        MessageBox.Show("selecciona una fila para modificar.");
    	}
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
