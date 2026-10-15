using System;
using System.Drawing;
using System.Windows.Forms;
using Hash_y_encryptación.Datos;

namespace Hash_y_encryptación
{
    public partial class AgregarEmpleado : Form
    {
        private int? idUsuarioModificar = null;

        public AgregarEmpleado()
        {
            InitializeComponent(); 
        }

        public AgregarEmpleado(int id, string userName, string firstName, string lastName, string gender, string email, string sucursal, string puesto, string rol, string phone, string address, string birthdate, string curp, string rfc, string cuenta, string salario)
        {
            InitializeComponent();
            idUsuarioModificar = id;

            txtUserName.Text = userName;
            txtFirstName.Text = firstName;
            txtLastName.Text = lastName;
            cmbGender.SelectedItem = gender;
            txtEmail.Text = email;
            txtSucursal.Text = sucursal;
            txtPuesto.Text = puesto;
            cmbRol.SelectedItem = rol;
            txtPhone.Text = phone;
            txtAddress.Text = address;
            if (!string.IsNullOrEmpty(birthdate))
		    {
		        DateTime fecha;
		        if (DateTime.TryParse(birthdate, out fecha))
		        {
		            dtpBirthdate.Value = fecha;
		        }
		    }
            txtCurp.Text = curp;
            txtRfc.Text = rfc;
            txtCuentaBancaria.Text = cuenta;
            txtSalario.Text = salario;
        }
        
        void BtnGuardarClick(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtUserName.Text) || 
                    string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    MessageBox.Show("Por favor, completa los campos obligatorios.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string genero = "Masculino";
                if (cmbGender.SelectedItem != null)
                {
                    genero = cmbGender.SelectedItem.ToString();
                }

                string rol = "Empleado";
                if (cmbRol.SelectedItem != null)
                {
                    rol = cmbRol.SelectedItem.ToString();
                }

                UsuarioDAO dao = new UsuarioDAO();
                bool resultado = false;

                if (idUsuarioModificar == null)
                {
                    resultado = dao.RegistrarEmpleado(
                        txtUserName.Text.Trim(),
                        txtPassword.Text.Trim(),
                        txtFirstName.Text.Trim(),
                        txtLastName.Text.Trim(),
                        genero,
                        txtEmail.Text.Trim(),
                        txtSucursal.Text.Trim(),
                        txtPuesto.Text.Trim(),
                        rol,
                        txtPhone.Text.Trim(),
                        txtAddress.Text.Trim(),
                        dtpBirthdate.Value.ToString("yyyy-MM-dd"),
                        txtCurp.Text.Trim(),
                        txtRfc.Text.Trim(),
                        txtCuentaBancaria.Text.Trim(),
                        txtSalario.Text.Trim()
                    );
                }
                else
                {
                    resultado = dao.ActualizarEmpleado(
                        idUsuarioModificar.Value,
                        txtUserName.Text.Trim(),
                        txtFirstName.Text.Trim(),
                        txtLastName.Text.Trim(),
                        genero,
                        txtEmail.Text.Trim(),
                        txtSucursal.Text.Trim(),
                        txtPuesto.Text.Trim(),
                        rol,
                        txtPhone.Text.Trim(),
                        txtAddress.Text.Trim(),
                        dtpBirthdate.Value.ToString("yyyy-MM-dd"), 
	                    txtCurp.Text.Trim(),                       
	                    txtRfc.Text.Trim(),                        
	                    txtCuentaBancaria.Text.Trim(),             
	                    txtSalario.Text.Trim()
	                        
                    );
                }

                if (resultado)
                {
                    string mensaje = idUsuarioModificar == null ? "¡Empleado agregado exitosamente a la base de datos!" : "¡Empleado actualizado exitosamente!";
                    MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo completar la operación en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void AgregarEmpleadoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form menuForm = Application.OpenForms["MenuPrincipal"];
            if (menuForm != null)
            {
                menuForm.Show();
            }
        }
    }
}