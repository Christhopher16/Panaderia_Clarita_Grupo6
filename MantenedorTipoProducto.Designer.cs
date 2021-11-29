
namespace Panaderia_Clarita
{
    partial class MantenedorTipoProducto
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EstadoTipoProducto = new System.Windows.Forms.CheckBox();
            this.txtTipoProductoID = new System.Windows.Forms.TextBox();
            this.txtTipoProductoDescripcion = new System.Windows.Forms.TextBox();
            this.DatoTipoProducto = new System.Windows.Forms.DataGridView();
            this.GroupTipoProducto = new System.Windows.Forms.GroupBox();
            this.TipoProductoGrabar = new System.Windows.Forms.Button();
            this.TipoProductoModificar = new System.Windows.Forms.Button();
            this.TipoProductoNuevo = new System.Windows.Forms.Button();
            this.TipoProductoEditar = new System.Windows.Forms.Button();
            this.TipoProductoSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DatoTipoProducto)).BeginInit();
            this.GroupTipoProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Tipo Producto: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion: ";
            // 
            // EstadoTipoProducto
            // 
            this.EstadoTipoProducto.AutoSize = true;
            this.EstadoTipoProducto.Location = new System.Drawing.Point(20, 97);
            this.EstadoTipoProducto.Name = "EstadoTipoProducto";
            this.EstadoTipoProducto.Size = new System.Drawing.Size(210, 21);
            this.EstadoTipoProducto.TabIndex = 2;
            this.EstadoTipoProducto.Text = "Estado del Tipo de Producto";
            this.EstadoTipoProducto.UseVisualStyleBackColor = true;
            // 
            // txtTipoProductoID
            // 
            this.txtTipoProductoID.Location = new System.Drawing.Point(145, 31);
            this.txtTipoProductoID.Name = "txtTipoProductoID";
            this.txtTipoProductoID.Size = new System.Drawing.Size(141, 22);
            this.txtTipoProductoID.TabIndex = 3;
            // 
            // txtTipoProductoDescripcion
            // 
            this.txtTipoProductoDescripcion.Location = new System.Drawing.Point(113, 61);
            this.txtTipoProductoDescripcion.Name = "txtTipoProductoDescripcion";
            this.txtTipoProductoDescripcion.Size = new System.Drawing.Size(173, 22);
            this.txtTipoProductoDescripcion.TabIndex = 4;
            // 
            // DatoTipoProducto
            // 
            this.DatoTipoProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatoTipoProducto.Location = new System.Drawing.Point(30, 170);
            this.DatoTipoProducto.Name = "DatoTipoProducto";
            this.DatoTipoProducto.RowHeadersWidth = 51;
            this.DatoTipoProducto.RowTemplate.Height = 24;
            this.DatoTipoProducto.Size = new System.Drawing.Size(602, 210);
            this.DatoTipoProducto.TabIndex = 5;
            this.DatoTipoProducto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatoTipoProducto_CellDoubleClick);
            // 
            // GroupTipoProducto
            // 
            this.GroupTipoProducto.Controls.Add(this.TipoProductoGrabar);
            this.GroupTipoProducto.Controls.Add(this.TipoProductoModificar);
            this.GroupTipoProducto.Controls.Add(this.txtTipoProductoID);
            this.GroupTipoProducto.Controls.Add(this.label1);
            this.GroupTipoProducto.Controls.Add(this.txtTipoProductoDescripcion);
            this.GroupTipoProducto.Controls.Add(this.label2);
            this.GroupTipoProducto.Controls.Add(this.EstadoTipoProducto);
            this.GroupTipoProducto.Location = new System.Drawing.Point(30, 21);
            this.GroupTipoProducto.Name = "GroupTipoProducto";
            this.GroupTipoProducto.Size = new System.Drawing.Size(470, 133);
            this.GroupTipoProducto.TabIndex = 6;
            this.GroupTipoProducto.TabStop = false;
            this.GroupTipoProducto.Text = "ResgistroTipoProducto";
            // 
            // TipoProductoGrabar
            // 
            this.TipoProductoGrabar.Location = new System.Drawing.Point(327, 74);
            this.TipoProductoGrabar.Name = "TipoProductoGrabar";
            this.TipoProductoGrabar.Size = new System.Drawing.Size(104, 47);
            this.TipoProductoGrabar.TabIndex = 6;
            this.TipoProductoGrabar.Text = "Grabar";
            this.TipoProductoGrabar.UseVisualStyleBackColor = true;
            this.TipoProductoGrabar.Click += new System.EventHandler(this.TipoProductoGrabar_Click);
            // 
            // TipoProductoModificar
            // 
            this.TipoProductoModificar.Location = new System.Drawing.Point(327, 21);
            this.TipoProductoModificar.Name = "TipoProductoModificar";
            this.TipoProductoModificar.Size = new System.Drawing.Size(104, 47);
            this.TipoProductoModificar.TabIndex = 5;
            this.TipoProductoModificar.Text = "Modificar";
            this.TipoProductoModificar.UseVisualStyleBackColor = true;
            this.TipoProductoModificar.Click += new System.EventHandler(this.TipoProductoModificar_Click);
            // 
            // TipoProductoNuevo
            // 
            this.TipoProductoNuevo.Location = new System.Drawing.Point(527, 16);
            this.TipoProductoNuevo.Name = "TipoProductoNuevo";
            this.TipoProductoNuevo.Size = new System.Drawing.Size(105, 41);
            this.TipoProductoNuevo.TabIndex = 7;
            this.TipoProductoNuevo.Text = "Nuevo";
            this.TipoProductoNuevo.UseVisualStyleBackColor = true;
            // 
            // TipoProductoEditar
            // 
            this.TipoProductoEditar.Location = new System.Drawing.Point(527, 68);
            this.TipoProductoEditar.Name = "TipoProductoEditar";
            this.TipoProductoEditar.Size = new System.Drawing.Size(105, 41);
            this.TipoProductoEditar.TabIndex = 8;
            this.TipoProductoEditar.Text = "Editar";
            this.TipoProductoEditar.UseVisualStyleBackColor = true;
            // 
            // TipoProductoSalir
            // 
            this.TipoProductoSalir.Location = new System.Drawing.Point(527, 118);
            this.TipoProductoSalir.Name = "TipoProductoSalir";
            this.TipoProductoSalir.Size = new System.Drawing.Size(105, 41);
            this.TipoProductoSalir.TabIndex = 9;
            this.TipoProductoSalir.Text = "Salir";
            this.TipoProductoSalir.UseVisualStyleBackColor = true;
            // 
            // MantenedorTipoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 406);
            this.Controls.Add(this.TipoProductoSalir);
            this.Controls.Add(this.TipoProductoEditar);
            this.Controls.Add(this.TipoProductoNuevo);
            this.Controls.Add(this.GroupTipoProducto);
            this.Controls.Add(this.DatoTipoProducto);
            this.Name = "MantenedorTipoProducto";
            this.Text = "MantenedorTipoProducto";
            ((System.ComponentModel.ISupportInitialize)(this.DatoTipoProducto)).EndInit();
            this.GroupTipoProducto.ResumeLayout(false);
            this.GroupTipoProducto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox EstadoTipoProducto;
        private System.Windows.Forms.TextBox txtTipoProductoID;
        private System.Windows.Forms.TextBox txtTipoProductoDescripcion;
        private System.Windows.Forms.DataGridView DatoTipoProducto;
        private System.Windows.Forms.GroupBox GroupTipoProducto;
        private System.Windows.Forms.Button TipoProductoGrabar;
        private System.Windows.Forms.Button TipoProductoModificar;
        private System.Windows.Forms.Button TipoProductoNuevo;
        private System.Windows.Forms.Button TipoProductoEditar;
        private System.Windows.Forms.Button TipoProductoSalir;
    }
}