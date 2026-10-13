/*
 * Created by SharpDevelop.
 * User: Miguel Rico
 * Date: 12/10/2026
 * Time: 07:28 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Hash_y_encryptación
{
	partial class VerUsuariosForm
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnRegresar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
			this.dataGridView1.Location = new System.Drawing.Point(1, -2);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(1415, 546);
			this.dataGridView1.TabIndex = 2;
			// 
			// btnRegresar
			// 
			this.btnRegresar.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnRegresar.Location = new System.Drawing.Point(634, 561);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(132, 42);
			this.btnRegresar.TabIndex = 1;
			this.btnRegresar.Text = "Regresar al Menú";
			this.btnRegresar.UseVisualStyleBackColor = true;
			this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
			// 
			// VerUsuariosForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1416, 618);
			this.Controls.Add(this.btnRegresar);
			this.Controls.Add(this.dataGridView1);
			this.Name = "VerUsuariosForm";
			this.Text = "VerUsuarios";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VerUsuariosForm_FormClosed);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnRegresar;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}
