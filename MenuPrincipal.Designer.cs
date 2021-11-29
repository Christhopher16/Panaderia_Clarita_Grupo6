
namespace Panaderia_Clarita
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ManCliente = new System.Windows.Forms.Button();
            this.ManProducto = new System.Windows.Forms.Button();
            this.ManEmpleado = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.VentaDirecta = new System.Windows.Forms.Button();
            this.GroupPrincipal = new System.Windows.Forms.GroupBox();
            this.RegistroBienvenidoUsuario = new System.Windows.Forms.TextBox();
            this.RegistroBienvenidoContraseña = new System.Windows.Forms.TextBox();
            this.IngresarPrincipal = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.GroupPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // ManCliente
            // 
            this.ManCliente.Location = new System.Drawing.Point(11, 24);
            this.ManCliente.Margin = new System.Windows.Forms.Padding(2);
            this.ManCliente.Name = "ManCliente";
            this.ManCliente.Size = new System.Drawing.Size(87, 41);
            this.ManCliente.TabIndex = 0;
            this.ManCliente.Text = "Cliente";
            this.ManCliente.UseVisualStyleBackColor = true;
            this.ManCliente.Click += new System.EventHandler(this.ManCliente_Click);
            // 
            // ManProducto
            // 
            this.ManProducto.Location = new System.Drawing.Point(119, 24);
            this.ManProducto.Margin = new System.Windows.Forms.Padding(2);
            this.ManProducto.Name = "ManProducto";
            this.ManProducto.Size = new System.Drawing.Size(87, 43);
            this.ManProducto.TabIndex = 1;
            this.ManProducto.Text = "Producto";
            this.ManProducto.UseVisualStyleBackColor = true;
            this.ManProducto.Click += new System.EventHandler(this.ManProducto_Click);
            // 
            // ManEmpleado
            // 
            this.ManEmpleado.Location = new System.Drawing.Point(11, 88);
            this.ManEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.ManEmpleado.Name = "ManEmpleado";
            this.ManEmpleado.Size = new System.Drawing.Size(87, 37);
            this.ManEmpleado.TabIndex = 2;
            this.ManEmpleado.Text = "Empleado";
            this.ManEmpleado.UseVisualStyleBackColor = true;
            this.ManEmpleado.Click += new System.EventHandler(this.ManEmpleado_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(119, 88);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "Almacen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(112, 140);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 42);
            this.button2.TabIndex = 4;
            this.button2.Text = "TipoProducto";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(8, 139);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 43);
            this.button3.TabIndex = 5;
            this.button3.Text = "TipoCliente";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // VentaDirecta
            // 
            this.VentaDirecta.Location = new System.Drawing.Point(59, 212);
            this.VentaDirecta.Margin = new System.Windows.Forms.Padding(2);
            this.VentaDirecta.Name = "VentaDirecta";
            this.VentaDirecta.Size = new System.Drawing.Size(82, 36);
            this.VentaDirecta.TabIndex = 7;
            this.VentaDirecta.Text = "VentaDirecta";
            this.VentaDirecta.UseVisualStyleBackColor = true;
            this.VentaDirecta.Click += new System.EventHandler(this.VentaDirecta_Click);
            // 
            // GroupPrincipal
            // 
            this.GroupPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.GroupPrincipal.Controls.Add(this.ManCliente);
            this.GroupPrincipal.Controls.Add(this.VentaDirecta);
            this.GroupPrincipal.Controls.Add(this.ManProducto);
            this.GroupPrincipal.Controls.Add(this.button2);
            this.GroupPrincipal.Controls.Add(this.button3);
            this.GroupPrincipal.Controls.Add(this.ManEmpleado);
            this.GroupPrincipal.Controls.Add(this.button1);
            this.GroupPrincipal.Location = new System.Drawing.Point(297, 63);
            this.GroupPrincipal.Margin = new System.Windows.Forms.Padding(2);
            this.GroupPrincipal.Name = "GroupPrincipal";
            this.GroupPrincipal.Padding = new System.Windows.Forms.Padding(2);
            this.GroupPrincipal.Size = new System.Drawing.Size(211, 255);
            this.GroupPrincipal.TabIndex = 8;
            this.GroupPrincipal.TabStop = false;
            this.GroupPrincipal.Text = "BotonesPrincipales";
            // 
            // RegistroBienvenidoUsuario
            // 
            this.RegistroBienvenidoUsuario.Location = new System.Drawing.Point(92, 138);
            this.RegistroBienvenidoUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.RegistroBienvenidoUsuario.Name = "RegistroBienvenidoUsuario";
            this.RegistroBienvenidoUsuario.Size = new System.Drawing.Size(188, 20);
            this.RegistroBienvenidoUsuario.TabIndex = 11;
            // 
            // RegistroBienvenidoContraseña
            // 
            this.RegistroBienvenidoContraseña.Location = new System.Drawing.Point(92, 205);
            this.RegistroBienvenidoContraseña.Margin = new System.Windows.Forms.Padding(2);
            this.RegistroBienvenidoContraseña.Name = "RegistroBienvenidoContraseña";
            this.RegistroBienvenidoContraseña.PasswordChar = '*';
            this.RegistroBienvenidoContraseña.Size = new System.Drawing.Size(188, 20);
            this.RegistroBienvenidoContraseña.TabIndex = 12;
            // 
            // IngresarPrincipal
            // 
            this.IngresarPrincipal.Location = new System.Drawing.Point(30, 251);
            this.IngresarPrincipal.Margin = new System.Windows.Forms.Padding(2);
            this.IngresarPrincipal.Name = "IngresarPrincipal";
            this.IngresarPrincipal.Size = new System.Drawing.Size(238, 36);
            this.IngresarPrincipal.TabIndex = 13;
            this.IngresarPrincipal.Text = "Ingresar";
            this.IngresarPrincipal.UseVisualStyleBackColor = true;
            this.IngresarPrincipal.Click += new System.EventHandler(this.IngresarPrincipal_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Panaderia_Clarita.Properties.Resources.usuario;
            this.pictureBox1.Location = new System.Drawing.Point(12, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Panaderia_Clarita.Properties.Resources.password;
            this.pictureBox2.Location = new System.Drawing.Point(12, 184);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(68, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Panaderia_Clarita.Properties.Resources.logo1;
            this.pictureBox3.Location = new System.Drawing.Point(92, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(138, 95);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Panaderia_Clarita.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(536, 319);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.IngresarPrincipal);
            this.Controls.Add(this.RegistroBienvenidoContraseña);
            this.Controls.Add(this.RegistroBienvenidoUsuario);
            this.Controls.Add(this.GroupPrincipal);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.GroupPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ManCliente;
        private System.Windows.Forms.Button ManProducto;
        private System.Windows.Forms.Button ManEmpleado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button VentaDirecta;
        private System.Windows.Forms.GroupBox GroupPrincipal;
        private System.Windows.Forms.TextBox RegistroBienvenidoUsuario;
        private System.Windows.Forms.TextBox RegistroBienvenidoContraseña;
        private System.Windows.Forms.Button IngresarPrincipal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

