
namespace Panaderia_Clarita
{
    partial class MantenedorEmpleado
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
            this.DatoEmpleado = new System.Windows.Forms.DataGridView();
            this.GroupEmpleado = new System.Windows.Forms.GroupBox();
            this.EmpleadoEstado = new System.Windows.Forms.CheckBox();
            this.EmpleadoGrabar = new System.Windows.Forms.Button();
            this.dateEmpleadoFecha = new System.Windows.Forms.DateTimePicker();
            this.txtEmpleadoApellido = new System.Windows.Forms.TextBox();
            this.txtEmpleadoNombre = new System.Windows.Forms.TextBox();
            this.txtEmpleadoDNI = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EmpleadoNuevo = new System.Windows.Forms.Button();
            this.EmpleadoInhabilitar = new System.Windows.Forms.Button();
            this.EmpleadoEditar = new System.Windows.Forms.Button();
            this.EmpleadoSalir = new System.Windows.Forms.Button();
            this.EmpleadoModificar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProductoID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DatoEmpleado)).BeginInit();
            this.GroupEmpleado.SuspendLayout();
            this.SuspendLayout();
            // 
            // DatoEmpleado
            // 
            this.DatoEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatoEmpleado.Location = new System.Drawing.Point(21, 34);
            this.DatoEmpleado.Name = "DatoEmpleado";
            this.DatoEmpleado.RowHeadersWidth = 51;
            this.DatoEmpleado.RowTemplate.Height = 24;
            this.DatoEmpleado.Size = new System.Drawing.Size(668, 209);
            this.DatoEmpleado.TabIndex = 0;
            this.DatoEmpleado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatoEmpleado_CellDoubleClick);
            // 
            // GroupEmpleado
            // 
            this.GroupEmpleado.Controls.Add(this.txtProductoID);
            this.GroupEmpleado.Controls.Add(this.label5);
            this.GroupEmpleado.Controls.Add(this.EmpleadoModificar);
            this.GroupEmpleado.Controls.Add(this.EmpleadoEstado);
            this.GroupEmpleado.Controls.Add(this.EmpleadoGrabar);
            this.GroupEmpleado.Controls.Add(this.dateEmpleadoFecha);
            this.GroupEmpleado.Controls.Add(this.txtEmpleadoApellido);
            this.GroupEmpleado.Controls.Add(this.txtEmpleadoNombre);
            this.GroupEmpleado.Controls.Add(this.txtEmpleadoDNI);
            this.GroupEmpleado.Controls.Add(this.label4);
            this.GroupEmpleado.Controls.Add(this.label3);
            this.GroupEmpleado.Controls.Add(this.label2);
            this.GroupEmpleado.Controls.Add(this.label1);
            this.GroupEmpleado.Location = new System.Drawing.Point(21, 259);
            this.GroupEmpleado.Name = "GroupEmpleado";
            this.GroupEmpleado.Size = new System.Drawing.Size(540, 193);
            this.GroupEmpleado.TabIndex = 1;
            this.GroupEmpleado.TabStop = false;
            this.GroupEmpleado.Text = "RegistroEmpleado";
            // 
            // EmpleadoEstado
            // 
            this.EmpleadoEstado.AutoSize = true;
            this.EmpleadoEstado.Location = new System.Drawing.Point(349, 35);
            this.EmpleadoEstado.Name = "EmpleadoEstado";
            this.EmpleadoEstado.Size = new System.Drawing.Size(164, 21);
            this.EmpleadoEstado.TabIndex = 9;
            this.EmpleadoEstado.Text = "Estado del Empleado";
            this.EmpleadoEstado.UseVisualStyleBackColor = true;
            // 
            // EmpleadoGrabar
            // 
            this.EmpleadoGrabar.Location = new System.Drawing.Point(409, 71);
            this.EmpleadoGrabar.Name = "EmpleadoGrabar";
            this.EmpleadoGrabar.Size = new System.Drawing.Size(104, 47);
            this.EmpleadoGrabar.TabIndex = 8;
            this.EmpleadoGrabar.Text = "Grabar";
            this.EmpleadoGrabar.UseVisualStyleBackColor = true;
            this.EmpleadoGrabar.Click += new System.EventHandler(this.EmpleadoGrabar_Click);
            // 
            // dateEmpleadoFecha
            // 
            this.dateEmpleadoFecha.Location = new System.Drawing.Point(174, 155);
            this.dateEmpleadoFecha.Name = "dateEmpleadoFecha";
            this.dateEmpleadoFecha.Size = new System.Drawing.Size(182, 22);
            this.dateEmpleadoFecha.TabIndex = 7;
            // 
            // txtEmpleadoApellido
            // 
            this.txtEmpleadoApellido.Location = new System.Drawing.Point(91, 122);
            this.txtEmpleadoApellido.Name = "txtEmpleadoApellido";
            this.txtEmpleadoApellido.Size = new System.Drawing.Size(155, 22);
            this.txtEmpleadoApellido.TabIndex = 6;
            // 
            // txtEmpleadoNombre
            // 
            this.txtEmpleadoNombre.Location = new System.Drawing.Point(91, 91);
            this.txtEmpleadoNombre.Name = "txtEmpleadoNombre";
            this.txtEmpleadoNombre.Size = new System.Drawing.Size(155, 22);
            this.txtEmpleadoNombre.TabIndex = 5;
            // 
            // txtEmpleadoDNI
            // 
            this.txtEmpleadoDNI.Location = new System.Drawing.Point(64, 59);
            this.txtEmpleadoDNI.Name = "txtEmpleadoDNI";
            this.txtEmpleadoDNI.Size = new System.Drawing.Size(149, 22);
            this.txtEmpleadoDNI.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha de Nacimiento: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "DNI: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre: ";
            // 
            // EmpleadoNuevo
            // 
            this.EmpleadoNuevo.Location = new System.Drawing.Point(583, 259);
            this.EmpleadoNuevo.Name = "EmpleadoNuevo";
            this.EmpleadoNuevo.Size = new System.Drawing.Size(105, 41);
            this.EmpleadoNuevo.TabIndex = 2;
            this.EmpleadoNuevo.Text = "Nuevo";
            this.EmpleadoNuevo.UseVisualStyleBackColor = true;
            // 
            // EmpleadoInhabilitar
            // 
            this.EmpleadoInhabilitar.Location = new System.Drawing.Point(583, 306);
            this.EmpleadoInhabilitar.Name = "EmpleadoInhabilitar";
            this.EmpleadoInhabilitar.Size = new System.Drawing.Size(105, 46);
            this.EmpleadoInhabilitar.TabIndex = 3;
            this.EmpleadoInhabilitar.Text = "Inhabilitar";
            this.EmpleadoInhabilitar.UseVisualStyleBackColor = true;
            // 
            // EmpleadoEditar
            // 
            this.EmpleadoEditar.Location = new System.Drawing.Point(583, 358);
            this.EmpleadoEditar.Name = "EmpleadoEditar";
            this.EmpleadoEditar.Size = new System.Drawing.Size(105, 41);
            this.EmpleadoEditar.TabIndex = 4;
            this.EmpleadoEditar.Text = "Editar";
            this.EmpleadoEditar.UseVisualStyleBackColor = true;
            // 
            // EmpleadoSalir
            // 
            this.EmpleadoSalir.Location = new System.Drawing.Point(585, 405);
            this.EmpleadoSalir.Name = "EmpleadoSalir";
            this.EmpleadoSalir.Size = new System.Drawing.Size(104, 47);
            this.EmpleadoSalir.TabIndex = 5;
            this.EmpleadoSalir.Text = "Salir";
            this.EmpleadoSalir.UseVisualStyleBackColor = true;
            // 
            // EmpleadoModificar
            // 
            this.EmpleadoModificar.Location = new System.Drawing.Point(409, 129);
            this.EmpleadoModificar.Name = "EmpleadoModificar";
            this.EmpleadoModificar.Size = new System.Drawing.Size(104, 50);
            this.EmpleadoModificar.TabIndex = 10;
            this.EmpleadoModificar.Text = "Modificar";
            this.EmpleadoModificar.UseVisualStyleBackColor = true;
            this.EmpleadoModificar.Click += new System.EventHandler(this.EmpleadoModificar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Producto ID: ";
            // 
            // txtProductoID
            // 
            this.txtProductoID.Location = new System.Drawing.Point(115, 30);
            this.txtProductoID.Name = "txtProductoID";
            this.txtProductoID.Size = new System.Drawing.Size(131, 22);
            this.txtProductoID.TabIndex = 12;
            // 
            // MantenedorEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 472);
            this.Controls.Add(this.EmpleadoSalir);
            this.Controls.Add(this.EmpleadoEditar);
            this.Controls.Add(this.EmpleadoInhabilitar);
            this.Controls.Add(this.EmpleadoNuevo);
            this.Controls.Add(this.GroupEmpleado);
            this.Controls.Add(this.DatoEmpleado);
            this.Name = "MantenedorEmpleado";
            this.Text = "Empleado";
            ((System.ComponentModel.ISupportInitialize)(this.DatoEmpleado)).EndInit();
            this.GroupEmpleado.ResumeLayout(false);
            this.GroupEmpleado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DatoEmpleado;
        private System.Windows.Forms.GroupBox GroupEmpleado;
        private System.Windows.Forms.DateTimePicker dateEmpleadoFecha;
        private System.Windows.Forms.TextBox txtEmpleadoApellido;
        private System.Windows.Forms.TextBox txtEmpleadoNombre;
        private System.Windows.Forms.TextBox txtEmpleadoDNI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EmpleadoNuevo;
        private System.Windows.Forms.Button EmpleadoInhabilitar;
        private System.Windows.Forms.Button EmpleadoGrabar;
        private System.Windows.Forms.Button EmpleadoEditar;
        private System.Windows.Forms.Button EmpleadoSalir;
        private System.Windows.Forms.CheckBox EmpleadoEstado;
        private System.Windows.Forms.Button EmpleadoModificar;
        private System.Windows.Forms.TextBox txtProductoID;
        private System.Windows.Forms.Label label5;
    }
}