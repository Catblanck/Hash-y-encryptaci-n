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
            AplicarPermisos();
        }
        
        private void AplicarPermisos()
        {
            if (rolActual != null && rolActual.Trim().Equals("Empleado", StringComparison.OrdinalIgnoreCase))
            {
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
            }
        }
        
        private void CargarDatos()
        {
            UsuarioDAO dao = new UsuarioDAO();
            DataTable datos = dao.ObtenerUsuarios(rolActual);
            dataGridView2.DataSource = datos; 
        }
        
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                int idUsuario = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value);
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
                MessageBox.Show("Selecciona una fila completa en la tabla.");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dataGridView2.SelectedRows[0];
                
                int id = fila.Cells[0].Value != null ? Convert.ToInt32(fila.Cells[0].Value) : 0;
                string userName = fila.Cells[1].Value != null ? fila.Cells[1].Value.ToString() : "";
                string firstName = fila.Cells[2].Value != null ? fila.Cells[2].Value.ToString() : "";
                string lastName = fila.Cells[3].Value != null ? fila.Cells[3].Value.ToString() : "";
                string email = fila.Cells[4].Value != null ? fila.Cells[4].Value.ToString() : "";
                string sucursal = fila.Cells[5].Value != null ? fila.Cells[5].Value.ToString() : "";
                string puesto = fila.Cells[6].Value != null ? fila.Cells[6].Value.ToString() : "";
                string rol = fila.Cells[8].Value != null ? fila.Cells[8].Value.ToString() : "";
                string curp = fila.Cells.Count > 9 && fila.Cells[9].Value != null ? fila.Cells[9].Value.ToString() : "";
                string rfc = fila.Cells.Count > 10 && fila.Cells[10].Value != null ? fila.Cells[10].Value.ToString() : "";
                string cuenta = fila.Cells.Count > 11 && fila.Cells[11].Value != null ? fila.Cells[11].Value.ToString() : "";
                string salario = fila.Cells.Count > 12 && fila.Cells[12].Value != null ? fila.Cells[12].Value.ToString() : "";

                string phone = "";
                string address = "";

                AgregarEmpleado formModificar = new AgregarEmpleado(
                    id, userName, firstName, lastName, "Masculino", email, sucursal, puesto, rol, phone, address, curp, rfc, cuenta, salario
                );
                
                formModificar.ShowDialog();
                CargarDatos();
            }
            else
            {
                MessageBox.Show("Selecciona una fila para modificar.");
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
