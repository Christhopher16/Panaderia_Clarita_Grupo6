
namespace Panaderia_Clarita
{
    partial class MantenedorCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DatoCliente = new System.Windows.Forms.DataGridView();
            this.GroupCliente = new System.Windows.Forms.GroupBox();
            this.ClienteModificar = new System.Windows.Forms.Button();
            this.txtClienteID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ComCliente = new System.Windows.Forms.ComboBox();
            this.txtClienteNombre = new System.Windows.Forms.TextBox();
            this.txtClienteDNI = new System.Windows.Forms.TextBox();
            this.ClienteEstado = new System.Windows.Forms.CheckBox();
            this.ClienteGrabar = new System.Windows.Forms.Button();
            this.txtClienteDireccion = new System.Windows.Forms.TextBox();
            this.txtClienteApellidos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ClienteNuevo = new System.Windows.Forms.Button();
            this.ClienteEditar = new System.Windows.Forms.Button();
            this.ClienteAnular = new System.Windows.Forms.Button();
            this.ClienteSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DatoCliente)).BeginInit();
            this.GroupCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // DatoCliente
            // 
            this.DatoCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatoCliente.Location = new System.Drawing.Point(16, 28);
            this.DatoCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DatoCliente.Name = "DatoCliente";
            this.DatoCliente.RowHeadersWidth = 51;
            this.DatoCliente.RowTemplate.Height = 24;
            this.DatoCliente.Size = new System.Drawing.Size(501, 170);
            this.DatoCliente.TabIndex = 0;
            this.DatoCliente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatoCliente_CellDoubleClick);
            // 
            // GroupCliente
            // 
            this.GroupCliente.Controls.Add(this.ClienteModificar);
            this.GroupCliente.Controls.Add(this.txtClienteID);
            this.GroupCliente.Controls.Add(this.label6);
            this.GroupCliente.Controls.Add(this.label5);
            this.GroupCliente.Controls.Add(this.ComCliente);
            this.GroupCliente.Controls.Add(this.txtClienteNombre);
            this.GroupCliente.Controls.Add(this.txtClienteDNI);
            this.GroupCliente.Controls.Add(this.ClienteEstado);
            this.GroupCliente.Controls.Add(this.ClienteGrabar);
            this.GroupCliente.Controls.Add(this.txtClienteDireccion);
            this.GroupCliente.Controls.Add(this.txtClienteApellidos);
            this.GroupCliente.Controls.Add(this.label4);
            this.GroupCliente.Controls.Add(this.label3);
            this.GroupCliente.Controls.Add(this.label2);
            this.GroupCliente.Controls.Add(this.label1);
            this.GroupCliente.Location = new System.Drawing.Point(16, 210);
            this.GroupCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GroupCliente.Name = "GroupCliente";
            this.GroupCliente.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GroupCliente.Size = new System.Drawing.Size(405, 192);
            this.GroupCliente.TabIndex = 1;
            this.GroupCliente.TabStop = false;
            this.GroupCliente.Text = "RegistroCliente";
            // 
            // ClienteModificar
            // 
            this.ClienteModificar.Location = new System.Drawing.Point(295, 114);
            this.ClienteModificar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ClienteModificar.Name = "ClienteModificar";
            this.ClienteModificar.Size = new System.Drawing.Size(78, 43);
            this.ClienteModificar.TabIndex = 15;
            this.ClienteModificar.Text = "Modificar";
            this.ClienteModificar.UseVisualStyleBackColor = true;
            this.ClienteModificar.Click += new System.EventHandler(this.ClienteModificar_Click);
            // 
            // txtClienteID
            // 
            this.txtClienteID.Location = new System.Drawing.Point(71, 24);
            this.txtClienteID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtClienteID.Name = "txtClienteID";
            this.txtClienteID.Size = new System.Drawing.Size(116, 20);
            this.txtClienteID.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 27);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "ClienteID: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 149);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tipo de Cliente: ";
            // 
            // ComCliente
            // 
            this.ComCliente.FormattingEnabled = true;
            this.ComCliente.Location = new System.Drawing.Point(102, 146);
            this.ComCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ComCliente.Name = "ComCliente";
            this.ComCliente.Size = new System.Drawing.Size(152, 21);
            this.ComCliente.TabIndex = 11;
            // 
            // txtClienteNombre
            // 
            this.txtClienteNombre.Location = new System.Drawing.Point(74, 71);
            this.txtClienteNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtClienteNombre.Name = "txtClienteNombre";
            this.txtClienteNombre.Size = new System.Drawing.Size(145, 20);
            this.txtClienteNombre.TabIndex = 10;
            // 
            // txtClienteDNI
            // 
            this.txtClienteDNI.Location = new System.Drawing.Point(45, 48);
            this.txtClienteDNI.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtClienteDNI.Name = "txtClienteDNI";
            this.txtClienteDNI.Size = new System.Drawing.Size(142, 20);
            this.txtClienteDNI.TabIndex = 9;
            // 
            // ClienteEstado
            // 
            this.ClienteEstado.AutoSize = true;
            this.ClienteEstado.Location = new System.Drawing.Point(280, 38);
            this.ClienteEstado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ClienteEstado.Name = "ClienteEstado";
            this.ClienteEstado.Size = new System.Drawing.Size(118, 21);
            this.ClienteEstado.TabIndex = 8;
            this.ClienteEstado.Text = "Estado del Cliente";
            this.ClienteEstado.UseVisualStyleBackColor = true;
            // 
            // ClienteGrabar
            // 
            this.ClienteGrabar.Location = new System.Drawing.Point(295, 71);
            this.ClienteGrabar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ClienteGrabar.Name = "ClienteGrabar";
            this.ClienteGrabar.Size = new System.Drawing.Size(78, 38);
            this.ClienteGrabar.TabIndex = 5;
            this.ClienteGrabar.Text = "Grabar";
            this.ClienteGrabar.UseVisualStyleBackColor = true;
            this.ClienteGrabar.Click += new System.EventHandler(this.ClienteGrabar_Click);
            // 
            // txtClienteDireccion
            // 
            this.txtClienteDireccion.Location = new System.Drawing.Point(75, 118);
            this.txtClienteDireccion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtClienteDireccion.Name = "txtClienteDireccion";
            this.txtClienteDireccion.Size = new System.Drawing.Size(180, 20);
            this.txtClienteDireccion.TabIndex = 7;
            // 
            // txtClienteApellidos
            // 
            this.txtClienteApellidos.Location = new System.Drawing.Point(74, 95);
            this.txtClienteApellidos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtClienteApellidos.Name = "txtClienteApellidos";
            this.txtClienteApellidos.Size = new System.Drawing.Size(145, 20);
            this.txtClienteApellidos.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 120);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Direccion: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellidos: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "DNI:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombres: ";
            // 
            // ClienteNuevo
            // 
            this.ClienteNuevo.Location = new System.Drawing.Point(438, 210);
            this.ClienteNuevo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ClienteNuevo.Name = "ClienteNuevo";
            this.ClienteNuevo.Size = new System.Drawing.Size(79, 33);
            this.ClienteNuevo.TabIndex = 1;
            this.ClienteNuevo.Text = "Nuevo";
            this.ClienteNuevo.UseVisualStyleBackColor = true;
            // 
            // ClienteEditar
            // 
            this.ClienteEditar.Location = new System.Drawing.Point(438, 249);
            this.ClienteEditar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ClienteEditar.Name = "ClienteEditar";
            this.ClienteEditar.Size = new System.Drawing.Size(79, 37);
            this.ClienteEditar.TabIndex = 2;
            this.ClienteEditar.Text = "Editar";
            this.ClienteEditar.UseVisualStyleBackColor = true;
            // 
            // ClienteAnular
            // 
            this.ClienteAnular.Location = new System.Drawing.Point(438, 291);
            this.ClienteAnular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ClienteAnular.Name = "ClienteAnular";
            this.ClienteAnular.Size = new System.Drawing.Size(79, 33);
            this.ClienteAnular.TabIndex = 3;
            this.ClienteAnular.Text = "Anular";
            this.ClienteAnular.UseVisualStyleBackColor = true;
            // 
            // ClienteSalir
            // 
            this.ClienteSalir.Location = new System.Drawing.Point(439, 329);
            this.ClienteSalir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ClienteSalir.Name = "ClienteSalir";
            this.ClienteSalir.Size = new System.Drawing.Size(78, 38);
            this.ClienteSalir.TabIndex = 4;
            this.ClienteSalir.Text = "Salir";
            this.ClienteSalir.UseVisualStyleBackColor = true;
            // 
            // MantenedorCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 424);
            this.Controls.Add(this.ClienteSalir);
            this.Controls.Add(this.ClienteAnular);
            this.Controls.Add(this.GroupCliente);
            this.Controls.Add(this.ClienteEditar);
            this.Controls.Add(this.DatoCliente);
            this.Controls.Add(this.ClienteNuevo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MantenedorCliente";
            this.Text = "Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.DatoCliente)).EndInit();
            this.GroupCliente.ResumeLayout(false);
            this.GroupCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DatoCliente;
        private System.Windows.Forms.GroupBox GroupCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ClienteNuevo;
        private System.Windows.Forms.Button ClienteEditar;
        private System.Windows.Forms.Button ClienteAnular;
        private System.Windows.Forms.Button ClienteSalir;
        private System.Windows.Forms.Button ClienteGrabar;
        private System.Windows.Forms.TextBox txtClienteDireccion;
        private System.Windows.Forms.TextBox txtClienteApellidos;
        //private System.Windows.Forms.TextBox txtClienteNombres;
        //private System.Windows.Forms.TextBox //txtClienteNombres;
        private System.Windows.Forms.CheckBox ClienteEstado;
        private System.Windows.Forms.TextBox txtClienteNombre;
        private System.Windows.Forms.TextBox txtClienteDNI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ComCliente;
        private System.Windows.Forms.TextBox txtClienteID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ClienteModificar;
    }
}