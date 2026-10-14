/*
 * Created by SharpDevelop.
 * User: Miguel Rico
 * Date: 08/10/2026
 * Time: 12:04 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Hash_y_encryptación
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.buttonLogin = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.labelpassword = new System.Windows.Forms.Label();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.labelUsername = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.SuspendLayout();
			// 
			// txtPassword
			// 
			this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtPassword.BackColor = System.Drawing.Color.MidnightBlue;
			this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPassword.ForeColor = System.Drawing.Color.White;
			this.txtPassword.Location = new System.Drawing.Point(118, 289);
			this.txtPassword.Multiline = true;
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(197, 44);
			this.txtPassword.TabIndex = 2;
			this.txtPassword.Text = "Password";
			this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
			this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
			// 
			// buttonLogin
			// 
			this.buttonLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.buttonLogin.BackColor = System.Drawing.Color.DodgerBlue;
			this.buttonLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonLogin.FlatAppearance.BorderSize = 0;
			this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonLogin.ForeColor = System.Drawing.Color.Cornsilk;
			this.buttonLogin.Location = new System.Drawing.Point(164, 351);
			this.buttonLogin.Name = "buttonLogin";
			this.buttonLogin.Size = new System.Drawing.Size(109, 50);
			this.buttonLogin.TabIndex = 3;
			this.buttonLogin.Text = "Log in";
			this.buttonLogin.UseVisualStyleBackColor = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox1.Location = new System.Drawing.Point(114, 25);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(201, 160);
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// labelpassword
			// 
			this.labelpassword.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.labelpassword.BackColor = System.Drawing.Color.Transparent;
			this.labelpassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelpassword.ForeColor = System.Drawing.Color.White;
			this.labelpassword.Location = new System.Drawing.Point(118, 264);
			this.labelpassword.Name = "labelpassword";
			this.labelpassword.Size = new System.Drawing.Size(201, 22);
			this.labelpassword.TabIndex = 6;
			this.labelpassword.Text = "Password";
			this.labelpassword.Visible = false;
			this.labelpassword.Enter += new System.EventHandler(this.txtPassword_Enter);
			this.labelpassword.Leave += new System.EventHandler(this.txtPassword_Leave);
			// 
			// txtUsername
			// 
			this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtUsername.BackColor = System.Drawing.Color.MidnightBlue;
			this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUsername.ForeColor = System.Drawing.Color.White;
			this.txtUsername.Location = new System.Drawing.Point(118, 216);
			this.txtUsername.Multiline = true;
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(197, 45);
			this.txtUsername.TabIndex = 1;
			this.txtUsername.Text = "Username";
			this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);
			this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
			// 
			// labelUsername
			// 
			this.labelUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.labelUsername.BackColor = System.Drawing.Color.Transparent;
			this.labelUsername.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelUsername.ForeColor = System.Drawing.Color.White;
			this.labelUsername.Location = new System.Drawing.Point(118, 190);
			this.labelUsername.Name = "labelUsername";
			this.labelUsername.Size = new System.Drawing.Size(197, 23);
			this.labelUsername.TabIndex = 9;
			this.labelUsername.Text = "Username";
			this.labelUsername.Visible = false;
			this.labelUsername.Enter += new System.EventHandler(this.txtUsername_Enter);
			this.labelUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
			this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
			this.pictureBox2.Location = new System.Drawing.Point(61, 207);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(51, 54);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 10;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
			this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox3.Location = new System.Drawing.Point(61, 279);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(51, 54);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 11;
			this.pictureBox3.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.Gold;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(431, 426);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.labelUsername);
			this.Controls.Add(this.txtUsername);
			this.Controls.Add(this.labelpassword);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.buttonLogin);
			this.Controls.Add(this.txtPassword);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "Hash y encryptación";
			this.TransparencyKey = System.Drawing.Color.Turquoise;
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label labelUsername;
		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.Label labelpassword;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button buttonLogin;
		private System.Windows.Forms.TextBox txtPassword;
	}
}
