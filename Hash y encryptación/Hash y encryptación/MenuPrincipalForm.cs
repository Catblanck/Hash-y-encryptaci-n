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
            AplicarPermisos(); 
        }

        private void AplicarPermisos()
        {
            if (rolUsuarioActual == "Empleado")
            {
                btnAgregarUsuario.Enabled = false; 
            }
        }
        
        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            AgregarEmpleadoForm form = new AgregarEmpleadoForm();
			form.ShowDialog();
        }
        
        private void btnVerUsuarios_Click(object sender, EventArgs e)
        {
            VerUsuariosForm formGrid = new VerUsuariosForm(rolUsuarioActual);
            formGrid.ShowDialog();
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
