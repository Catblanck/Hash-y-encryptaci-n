/*
 * Created by SharpDevelop.
 * User: Miguel Rico
 * Date: 12/10/2026
 * Time: 06:32 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Hash_y_encryptación
{
	partial class MenuPrincipalForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnVerUsuarios = new System.Windows.Forms.Button();
			this.btnAgregarUsuario = new System.Windows.Forms.Button();
			this.btnSalir = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnVerUsuarios
			// 
			this.btnVerUsuarios.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnVerUsuarios.Location = new System.Drawing.Point(117, 53);
			this.btnVerUsuarios.Name = "btnVerUsuarios";
			this.btnVerUsuarios.Size = new System.Drawing.Size(128, 43);
			this.btnVerUsuarios.TabIndex = 0;
			this.btnVerUsuarios.Text = "Ver Empleados";
			this.btnVerUsuarios.UseVisualStyleBackColor = true;
			this.btnVerUsuarios.Click += new System.EventHandler(this.btnVerUsuarios_Click);
			// 
			// btnAgregarUsuario
			// 
			this.btnAgregarUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnAgregarUsuario.Location = new System.Drawing.Point(117, 146);
			this.btnAgregarUsuario.Name = "btnAgregarUsuario";
			this.btnAgregarUsuario.Size = new System.Drawing.Size(128, 45);
			this.btnAgregarUsuario.TabIndex = 1;
			this.btnAgregarUsuario.Text = "Agregar Empleado";
			this.btnAgregarUsuario.UseVisualStyleBackColor = true;
			// 
			// btnSalir
			// 
			this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnSalir.Location = new System.Drawing.Point(117, 239);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(128, 43);
			this.btnSalir.TabIndex = 2;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// MenuPrincipalForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(355, 359);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.btnAgregarUsuario);
			this.Controls.Add(this.btnVerUsuarios);
			this.Name = "MenuPrincipalForm";
			this.Text = "MenuPrincipal";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuPrincipalForm_FormClosed);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Button btnAgregarUsuario;
		private System.Windows.Forms.Button btnVerUsuarios;
	}
}
