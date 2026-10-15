using System;
using System.Drawing;
using System.Windows.Forms;

namespace Hash_y_encryptación
{
    public partial class MenuPrincipalForm : Form
    {        
        private string rolUsuarioActual;
        
        public MenuPrincipalForm(string rol)
        {
            InitializeComponent();
            rolUsuarioActual = rol;
        }
        
        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
        	if (rolUsuarioActual != null && rolUsuarioActual.Trim().Equals("Empleado", StringComparison.OrdinalIgnoreCase))
			{
			    MessageBox.Show("Tu nivel de usuario no tiene permisos para agregar nuevos registros.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			    return;
			}
        	this.Hide();
            AgregarEmpleado form = new AgregarEmpleado();
			form.ShowDialog();
			this.Show();
        }
        
        private void btnVerEmpleado_Click(object sender, EventArgs e)
        {
        	this.Hide();
            VerUsuariosForm formGrid = new VerUsuariosForm(rolUsuarioActual);
            formGrid.ShowDialog();
            this.Show();
        }
        
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Estás seguro de que deseas cerrar sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (respuesta == DialogResult.Yes)
            {
                this.Close(); 
            }
        }
        
        private void MenuPrincipalForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form loginForm = Application.OpenForms["MainForm"];
            if (loginForm != null)
            {
                loginForm.Show();
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
