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
		private System.ComponentModel.IContainer components = null;
		
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerUsuariosForm));
			this.btnRegresar = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.btnModificar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.SuspendLayout();
			// 
			// btnRegresar
			// 
			this.btnRegresar.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnRegresar.Location = new System.Drawing.Point(353, 507);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(132, 42);
			this.btnRegresar.TabIndex = 1;
			this.btnRegresar.Text = "Regresar al Menú";
			this.btnRegresar.UseVisualStyleBackColor = true;
			this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToOrderColumns = true;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(0, 0);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(875, 561);
			this.dataGridView1.TabIndex = 2;
			// 
			// dataGridView2
			// 
			this.dataGridView2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView2.BackgroundColor = System.Drawing.Color.MidnightBlue;
			this.dataGridView2.Location = new System.Drawing.Point(28, 12);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView2.Size = new System.Drawing.Size(1286, 572);
			this.dataGridView2.TabIndex = 0;
			// 
			// btnModificar
			// 
			this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnModificar.BackColor = System.Drawing.Color.DodgerBlue;
			this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnModificar.ForeColor = System.Drawing.Color.White;
			this.btnModificar.Location = new System.Drawing.Point(601, 600);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(132, 35);
			this.btnModificar.TabIndex = 1;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.UseVisualStyleBackColor = false;
			this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnEliminar.BackColor = System.Drawing.Color.DodgerBlue;
			this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEliminar.ForeColor = System.Drawing.Color.White;
			this.btnEliminar.Location = new System.Drawing.Point(862, 600);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(132, 35);
			this.btnEliminar.TabIndex = 2;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = false;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// button3
			// 
			this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.button3.BackColor = System.Drawing.Color.DodgerBlue;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.White;
			this.button3.Location = new System.Drawing.Point(339, 600);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(138, 35);
			this.button3.TabIndex = 3;
			this.button3.Text = "Regresar al Menú";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.btnRegresar_Click);
			// 
			// VerUsuariosForm
			// 
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(1338, 647);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnModificar);
			this.Controls.Add(this.dataGridView2);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "VerUsuariosForm";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VerUsuariosForm_FormClosed);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnModificar;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnRegresar;
	}
}