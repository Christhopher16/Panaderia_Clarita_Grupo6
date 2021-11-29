
namespace Panaderia_Clarita
{
    partial class MantenedorProducto
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
            this.DatoProducto = new System.Windows.Forms.DataGridView();
            this.GroupProducto = new System.Windows.Forms.GroupBox();
            this.txtProductoID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ProductoTipoProducto = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ProductoAlmacen = new System.Windows.Forms.ComboBox();
            this.ProductoGrabar = new System.Windows.Forms.Button();
            this.txtProductoPrecio = new System.Windows.Forms.TextBox();
            this.txtProductoStock = new System.Windows.Forms.TextBox();
            this.txtProductoNombre = new System.Windows.Forms.TextBox();
            this.EstadoProducto = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductoNuevo = new System.Windows.Forms.Button();
            this.ProductoEditar = new System.Windows.Forms.Button();
            this.ProductoAnular = new System.Windows.Forms.Button();
            this.ProductoSalir = new System.Windows.Forms.Button();
            this.ProductoModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DatoProducto)).BeginInit();
            this.GroupProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // DatoProducto
            // 
            this.DatoProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatoProducto.Location = new System.Drawing.Point(21, 34);
            this.DatoProducto.Name = "DatoProducto";
            this.DatoProducto.RowHeadersWidth = 51;
            this.DatoProducto.RowTemplate.Height = 24;
            this.DatoProducto.Size = new System.Drawing.Size(668, 209);
            this.DatoProducto.TabIndex = 0;
            this.DatoProducto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatoProducto_CellDoubleClick);
            // 
            // GroupProducto
            // 
            this.GroupProducto.Controls.Add(this.ProductoModificar);
            this.GroupProducto.Controls.Add(this.txtProductoID);
            this.GroupProducto.Controls.Add(this.label6);
            this.GroupProducto.Controls.Add(this.label5);
            this.GroupProducto.Controls.Add(this.ProductoTipoProducto);
            this.GroupProducto.Controls.Add(this.label4);
            this.GroupProducto.Controls.Add(this.ProductoAlmacen);
            this.GroupProducto.Controls.Add(this.ProductoGrabar);
            this.GroupProducto.Controls.Add(this.txtProductoPrecio);
            this.GroupProducto.Controls.Add(this.txtProductoStock);
            this.GroupProducto.Controls.Add(this.txtProductoNombre);
            this.GroupProducto.Controls.Add(this.EstadoProducto);
            this.GroupProducto.Controls.Add(this.label3);
            this.GroupProducto.Controls.Add(this.label2);
            this.GroupProducto.Controls.Add(this.label1);
            this.GroupProducto.Location = new System.Drawing.Point(21, 259);
            this.GroupProducto.Name = "GroupProducto";
            this.GroupProducto.Size = new System.Drawing.Size(540, 247);
            this.GroupProducto.TabIndex = 1;
            this.GroupProducto.TabStop = false;
            this.GroupProducto.Text = "ResgistroProducto";
            // 
            // txtProductoID
            // 
            this.txtProductoID.Location = new System.Drawing.Point(109, 34);
            this.txtProductoID.Name = "txtProductoID";
            this.txtProductoID.Size = new System.Drawing.Size(182, 22);
            this.txtProductoID.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Producto ID: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tipo de Producto: ";
            // 
            // ProductoTipoProducto
            // 
            this.ProductoTipoProducto.FormattingEnabled = true;
            this.ProductoTipoProducto.Location = new System.Drawing.Point(153, 202);
            this.ProductoTipoProducto.Name = "ProductoTipoProducto";
            this.ProductoTipoProducto.Size = new System.Drawing.Size(190, 24);
            this.ProductoTipoProducto.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Almacen: ";
            // 
            // ProductoAlmacen
            // 
            this.ProductoAlmacen.FormattingEnabled = true;
            this.ProductoAlmacen.Location = new System.Drawing.Point(94, 165);
            this.ProductoAlmacen.Name = "ProductoAlmacen";
            this.ProductoAlmacen.Size = new System.Drawing.Size(183, 24);
            this.ProductoAlmacen.TabIndex = 8;
            // 
            // ProductoGrabar
            // 
            this.ProductoGrabar.Location = new System.Drawing.Point(388, 97);
            this.ProductoGrabar.Name = "ProductoGrabar";
            this.ProductoGrabar.Size = new System.Drawing.Size(111, 51);
            this.ProductoGrabar.TabIndex = 7;
            this.ProductoGrabar.Text = "Grabar";
            this.ProductoGrabar.UseVisualStyleBackColor = true;
            this.ProductoGrabar.Click += new System.EventHandler(this.ProductoGrabar_Click);
            // 
            // txtProductoPrecio
            // 
            this.txtProductoPrecio.Location = new System.Drawing.Point(84, 101);
            this.txtProductoPrecio.Name = "txtProductoPrecio";
            this.txtProductoPrecio.Size = new System.Drawing.Size(123, 22);
            this.txtProductoPrecio.TabIndex = 6;
            // 
            // txtProductoStock
            // 
            this.txtProductoStock.Location = new System.Drawing.Point(79, 134);
            this.txtProductoStock.Name = "txtProductoStock";
            this.txtProductoStock.Size = new System.Drawing.Size(128, 22);
            this.txtProductoStock.TabIndex = 5;
            // 
            // txtProductoNombre
            // 
            this.txtProductoNombre.Location = new System.Drawing.Point(94, 64);
            this.txtProductoNombre.Name = "txtProductoNombre";
            this.txtProductoNombre.Size = new System.Drawing.Size(197, 22);
            this.txtProductoNombre.TabIndex = 4;
            // 
            // EstadoProducto
            // 
            this.EstadoProducto.AutoSize = true;
            this.EstadoProducto.Location = new System.Drawing.Point(341, 52);
            this.EstadoProducto.Name = "EstadoProducto";
            this.EstadoProducto.Size = new System.Drawing.Size(158, 21);
            this.EstadoProducto.TabIndex = 3;
            this.EstadoProducto.Text = "Estado del Producto";
            this.EstadoProducto.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stock: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre: ";
            // 
            // ProductoNuevo
            // 
            this.ProductoNuevo.Location = new System.Drawing.Point(593, 257);
            this.ProductoNuevo.Name = "ProductoNuevo";
            this.ProductoNuevo.Size = new System.Drawing.Size(105, 41);
            this.ProductoNuevo.TabIndex = 2;
            this.ProductoNuevo.Text = " Nuevo";
            this.ProductoNuevo.UseVisualStyleBackColor = true;
            // 
            // ProductoEditar
            // 
            this.ProductoEditar.Location = new System.Drawing.Point(593, 309);
            this.ProductoEditar.Name = "ProductoEditar";
            this.ProductoEditar.Size = new System.Drawing.Size(105, 40);
            this.ProductoEditar.TabIndex = 3;
            this.ProductoEditar.Text = "Editar";
            this.ProductoEditar.UseVisualStyleBackColor = true;
            // 
            // ProductoAnular
            // 
            this.ProductoAnular.Location = new System.Drawing.Point(593, 360);
            this.ProductoAnular.Name = "ProductoAnular";
            this.ProductoAnular.Size = new System.Drawing.Size(103, 43);
            this.ProductoAnular.TabIndex = 4;
            this.ProductoAnular.Text = "Anular";
            this.ProductoAnular.UseVisualStyleBackColor = true;
            // 
            // ProductoSalir
            // 
            this.ProductoSalir.Location = new System.Drawing.Point(593, 411);
            this.ProductoSalir.Name = "ProductoSalir";
            this.ProductoSalir.Size = new System.Drawing.Size(103, 42);
            this.ProductoSalir.TabIndex = 5;
            this.ProductoSalir.Text = "Salir";
            this.ProductoSalir.UseVisualStyleBackColor = true;
            // 
            // ProductoModificar
            // 
            this.ProductoModificar.Location = new System.Drawing.Point(388, 157);
            this.ProductoModificar.Name = "ProductoModificar";
            this.ProductoModificar.Size = new System.Drawing.Size(111, 46);
            this.ProductoModificar.TabIndex = 14;
            this.ProductoModificar.Text = "Modificar";
            this.ProductoModificar.UseVisualStyleBackColor = true;
            this.ProductoModificar.Click += new System.EventHandler(this.ProductoModificar_Click);
            // 
            // MantenedorProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 518);
            this.Controls.Add(this.ProductoSalir);
            this.Controls.Add(this.ProductoAnular);
            this.Controls.Add(this.ProductoEditar);
            this.Controls.Add(this.ProductoNuevo);
            this.Controls.Add(this.GroupProducto);
            this.Controls.Add(this.DatoProducto);
            this.Name = "MantenedorProducto";
            this.Text = "Producto";
            ((System.ComponentModel.ISupportInitialize)(this.DatoProducto)).EndInit();
            this.GroupProducto.ResumeLayout(false);
            this.GroupProducto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DatoProducto;
        private System.Windows.Forms.GroupBox GroupProducto;
        private System.Windows.Forms.TextBox txtProductoPrecio;
        private System.Windows.Forms.TextBox txtProductoStock;
        private System.Windows.Forms.TextBox txtProductoNombre;
        private System.Windows.Forms.CheckBox EstadoProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ProductoNuevo;
        private System.Windows.Forms.Button ProductoEditar;
        private System.Windows.Forms.Button ProductoAnular;
        private System.Windows.Forms.Button ProductoSalir;
        private System.Windows.Forms.Button ProductoGrabar;
        private System.Windows.Forms.ComboBox ProductoAlmacen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ProductoTipoProducto;
        private System.Windows.Forms.TextBox txtProductoID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ProductoModificar;
    }
}