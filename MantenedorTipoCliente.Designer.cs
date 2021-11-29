
namespace Panaderia_Clarita
{
    partial class MantenedorTipoCliente
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
            this.GroupTipoCliente = new System.Windows.Forms.GroupBox();
            this.TipoClienteGrabar = new System.Windows.Forms.Button();
            this.TipoClienteModificar = new System.Windows.Forms.Button();
            this.txtTipoClienteDescripcion = new System.Windows.Forms.TextBox();
            this.txtTipoClienteID = new System.Windows.Forms.TextBox();
            this.EstadoTipoCliente = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TipoClienteNuevo = new System.Windows.Forms.Button();
            this.TipoClienteEditar = new System.Windows.Forms.Button();
            this.TipoClienteSalir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTipoClienteIDBuscar = new System.Windows.Forms.TextBox();
            this.TipoClienteBuscar = new System.Windows.Forms.Button();
            this.DatoTipoCliente = new System.Windows.Forms.DataGridView();
            this.GroupTipoCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatoTipoCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupTipoCliente
            // 
            this.GroupTipoCliente.Controls.Add(this.TipoClienteGrabar);
            this.GroupTipoCliente.Controls.Add(this.TipoClienteModificar);
            this.GroupTipoCliente.Controls.Add(this.txtTipoClienteDescripcion);
            this.GroupTipoCliente.Controls.Add(this.txtTipoClienteID);
            this.GroupTipoCliente.Controls.Add(this.EstadoTipoCliente);
            this.GroupTipoCliente.Controls.Add(this.label2);
            this.GroupTipoCliente.Controls.Add(this.label1);
            this.GroupTipoCliente.Location = new System.Drawing.Point(29, 17);
            this.GroupTipoCliente.Name = "GroupTipoCliente";
            this.GroupTipoCliente.Size = new System.Drawing.Size(470, 133);
            this.GroupTipoCliente.TabIndex = 0;
            this.GroupTipoCliente.TabStop = false;
            this.GroupTipoCliente.Text = "RegistroTipoCliente";
            // 
            // TipoClienteGrabar
            // 
            this.TipoClienteGrabar.Location = new System.Drawing.Point(325, 73);
            this.TipoClienteGrabar.Name = "TipoClienteGrabar";
            this.TipoClienteGrabar.Size = new System.Drawing.Size(104, 47);
            this.TipoClienteGrabar.TabIndex = 6;
            this.TipoClienteGrabar.Text = "Grabar";
            this.TipoClienteGrabar.UseVisualStyleBackColor = true;
            this.TipoClienteGrabar.Click += new System.EventHandler(this.TipoClienteGrabar_Click);
            // 
            // TipoClienteModificar
            // 
            this.TipoClienteModificar.Location = new System.Drawing.Point(325, 20);
            this.TipoClienteModificar.Name = "TipoClienteModificar";
            this.TipoClienteModificar.Size = new System.Drawing.Size(104, 47);
            this.TipoClienteModificar.TabIndex = 5;
            this.TipoClienteModificar.Text = "Modificar";
            this.TipoClienteModificar.UseVisualStyleBackColor = true;
            this.TipoClienteModificar.Click += new System.EventHandler(this.TipoClienteModificar_Click);
            // 
            // txtTipoClienteDescripcion
            // 
            this.txtTipoClienteDescripcion.Location = new System.Drawing.Point(113, 62);
            this.txtTipoClienteDescripcion.Name = "txtTipoClienteDescripcion";
            this.txtTipoClienteDescripcion.Size = new System.Drawing.Size(173, 22);
            this.txtTipoClienteDescripcion.TabIndex = 4;
            // 
            // txtTipoClienteID
            // 
            this.txtTipoClienteID.Location = new System.Drawing.Point(127, 32);
            this.txtTipoClienteID.Name = "txtTipoClienteID";
            this.txtTipoClienteID.Size = new System.Drawing.Size(159, 22);
            this.txtTipoClienteID.TabIndex = 3;
            // 
            // EstadoTipoCliente
            // 
            this.EstadoTipoCliente.AutoSize = true;
            this.EstadoTipoCliente.Location = new System.Drawing.Point(20, 97);
            this.EstadoTipoCliente.Name = "EstadoTipoCliente";
            this.EstadoTipoCliente.Size = new System.Drawing.Size(196, 21);
            this.EstadoTipoCliente.TabIndex = 2;
            this.EstadoTipoCliente.Text = "Estado del Tipo de Cliente";
            this.EstadoTipoCliente.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID TipoCliente: ";
            // 
            // TipoClienteNuevo
            // 
            this.TipoClienteNuevo.Location = new System.Drawing.Point(525, 21);
            this.TipoClienteNuevo.Name = "TipoClienteNuevo";
            this.TipoClienteNuevo.Size = new System.Drawing.Size(105, 41);
            this.TipoClienteNuevo.TabIndex = 2;
            this.TipoClienteNuevo.Text = "Nuevo";
            this.TipoClienteNuevo.UseVisualStyleBackColor = true;
            // 
            // TipoClienteEditar
            // 
            this.TipoClienteEditar.Location = new System.Drawing.Point(525, 70);
            this.TipoClienteEditar.Name = "TipoClienteEditar";
            this.TipoClienteEditar.Size = new System.Drawing.Size(105, 41);
            this.TipoClienteEditar.TabIndex = 3;
            this.TipoClienteEditar.Text = "Editar";
            this.TipoClienteEditar.UseVisualStyleBackColor = true;
            // 
            // TipoClienteSalir
            // 
            this.TipoClienteSalir.Location = new System.Drawing.Point(525, 117);
            this.TipoClienteSalir.Name = "TipoClienteSalir";
            this.TipoClienteSalir.Size = new System.Drawing.Size(105, 41);
            this.TipoClienteSalir.TabIndex = 4;
            this.TipoClienteSalir.Text = "Salir";
            this.TipoClienteSalir.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "ID TipoCliente: ";
            // 
            // txtTipoClienteIDBuscar
            // 
            this.txtTipoClienteIDBuscar.Location = new System.Drawing.Point(142, 167);
            this.txtTipoClienteIDBuscar.Name = "txtTipoClienteIDBuscar";
            this.txtTipoClienteIDBuscar.Size = new System.Drawing.Size(316, 22);
            this.txtTipoClienteIDBuscar.TabIndex = 6;
            // 
            // TipoClienteBuscar
            // 
            this.TipoClienteBuscar.Location = new System.Drawing.Point(479, 164);
            this.TipoClienteBuscar.Name = "TipoClienteBuscar";
            this.TipoClienteBuscar.Size = new System.Drawing.Size(151, 29);
            this.TipoClienteBuscar.TabIndex = 7;
            this.TipoClienteBuscar.Text = "Buscar";
            this.TipoClienteBuscar.UseVisualStyleBackColor = true;
            // 
            // DatoTipoCliente
            // 
            this.DatoTipoCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatoTipoCliente.Location = new System.Drawing.Point(29, 210);
            this.DatoTipoCliente.Name = "DatoTipoCliente";
            this.DatoTipoCliente.RowHeadersWidth = 51;
            this.DatoTipoCliente.RowTemplate.Height = 24;
            this.DatoTipoCliente.Size = new System.Drawing.Size(601, 217);
            this.DatoTipoCliente.TabIndex = 1;
            this.DatoTipoCliente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatoTipoCliente_CellDoubleClick);
            // 
            // MantenedorTipoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 454);
            this.Controls.Add(this.TipoClienteBuscar);
            this.Controls.Add(this.txtTipoClienteIDBuscar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TipoClienteSalir);
            this.Controls.Add(this.TipoClienteEditar);
            this.Controls.Add(this.TipoClienteNuevo);
            this.Controls.Add(this.DatoTipoCliente);
            this.Controls.Add(this.GroupTipoCliente);
            this.Name = "MantenedorTipoCliente";
            this.Text = "TipoCliente";
            this.GroupTipoCliente.ResumeLayout(false);
            this.GroupTipoCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatoTipoCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupTipoCliente;
        private System.Windows.Forms.CheckBox EstadoTipoCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTipoClienteDescripcion;
        private System.Windows.Forms.TextBox txtTipoClienteID;
        private System.Windows.Forms.Button TipoClienteGrabar;
        private System.Windows.Forms.Button TipoClienteModificar;
        private System.Windows.Forms.Button TipoClienteNuevo;
        private System.Windows.Forms.Button TipoClienteEditar;
        private System.Windows.Forms.Button TipoClienteSalir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTipoClienteIDBuscar;
        private System.Windows.Forms.Button TipoClienteBuscar;
        private System.Windows.Forms.DataGridView DatoTipoCliente;
    }
}