
namespace Panaderia_Clarita
{
    partial class Venta
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
            this.DatoVenta = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EstadoVenta = new System.Windows.Forms.CheckBox();
            this.VentaCliente = new System.Windows.Forms.ComboBox();
            this.VentaProducto = new System.Windows.Forms.ComboBox();
            this.txtVentaPrecio = new System.Windows.Forms.TextBox();
            this.txtVentaCantidad = new System.Windows.Forms.TextBox();
            this.GroupVenta = new System.Windows.Forms.GroupBox();
            this.VentaGrabar = new System.Windows.Forms.Button();
            this.VentaNuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DatoVenta)).BeginInit();
            this.GroupVenta.SuspendLayout();
            this.SuspendLayout();
            // 
            // DatoVenta
            // 
            this.DatoVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatoVenta.Location = new System.Drawing.Point(22, 22);
            this.DatoVenta.Name = "DatoVenta";
            this.DatoVenta.RowHeadersWidth = 51;
            this.DatoVenta.RowTemplate.Height = 24;
            this.DatoVenta.Size = new System.Drawing.Size(585, 214);
            this.DatoVenta.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Producto: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Precio: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cantidad: ";
            // 
            // EstadoVenta
            // 
            this.EstadoVenta.AutoSize = true;
            this.EstadoVenta.Location = new System.Drawing.Point(292, 34);
            this.EstadoVenta.Name = "EstadoVenta";
            this.EstadoVenta.Size = new System.Drawing.Size(135, 21);
            this.EstadoVenta.TabIndex = 5;
            this.EstadoVenta.Text = "Estado de Venta";
            this.EstadoVenta.UseVisualStyleBackColor = true;
            // 
            // VentaCliente
            // 
            this.VentaCliente.FormattingEnabled = true;
            this.VentaCliente.Location = new System.Drawing.Point(70, 32);
            this.VentaCliente.Name = "VentaCliente";
            this.VentaCliente.Size = new System.Drawing.Size(182, 24);
            this.VentaCliente.TabIndex = 6;
            // 
            // VentaProducto
            // 
            this.VentaProducto.FormattingEnabled = true;
            this.VentaProducto.Location = new System.Drawing.Point(88, 62);
            this.VentaProducto.Name = "VentaProducto";
            this.VentaProducto.Size = new System.Drawing.Size(175, 24);
            this.VentaProducto.TabIndex = 7;
            // 
            // txtVentaPrecio
            // 
            this.txtVentaPrecio.Location = new System.Drawing.Point(70, 90);
            this.txtVentaPrecio.Name = "txtVentaPrecio";
            this.txtVentaPrecio.Size = new System.Drawing.Size(163, 22);
            this.txtVentaPrecio.TabIndex = 8;
            // 
            // txtVentaCantidad
            // 
            this.txtVentaCantidad.Location = new System.Drawing.Point(87, 117);
            this.txtVentaCantidad.Name = "txtVentaCantidad";
            this.txtVentaCantidad.Size = new System.Drawing.Size(158, 22);
            this.txtVentaCantidad.TabIndex = 9;
            // 
            // GroupVenta
            // 
            this.GroupVenta.Controls.Add(this.VentaGrabar);
            this.GroupVenta.Controls.Add(this.txtVentaCantidad);
            this.GroupVenta.Controls.Add(this.EstadoVenta);
            this.GroupVenta.Controls.Add(this.txtVentaPrecio);
            this.GroupVenta.Controls.Add(this.VentaProducto);
            this.GroupVenta.Controls.Add(this.VentaCliente);
            this.GroupVenta.Controls.Add(this.label4);
            this.GroupVenta.Controls.Add(this.label3);
            this.GroupVenta.Controls.Add(this.label2);
            this.GroupVenta.Controls.Add(this.label1);
            this.GroupVenta.Location = new System.Drawing.Point(22, 256);
            this.GroupVenta.Name = "GroupVenta";
            this.GroupVenta.Size = new System.Drawing.Size(439, 153);
            this.GroupVenta.TabIndex = 0;
            this.GroupVenta.TabStop = false;
            this.GroupVenta.Text = "RegistroVenta";
            // 
            // VentaGrabar
            // 
            this.VentaGrabar.Location = new System.Drawing.Point(292, 78);
            this.VentaGrabar.Name = "VentaGrabar";
            this.VentaGrabar.Size = new System.Drawing.Size(113, 47);
            this.VentaGrabar.TabIndex = 10;
            this.VentaGrabar.Text = "Grabar";
            this.VentaGrabar.UseVisualStyleBackColor = true;
            this.VentaGrabar.Click += new System.EventHandler(this.VentaGrabar_Click);
            // 
            // VentaNuevo
            // 
            this.VentaNuevo.Location = new System.Drawing.Point(492, 290);
            this.VentaNuevo.Name = "VentaNuevo";
            this.VentaNuevo.Size = new System.Drawing.Size(103, 47);
            this.VentaNuevo.TabIndex = 1;
            this.VentaNuevo.Text = "Nuevo";
            this.VentaNuevo.UseVisualStyleBackColor = true;
            // 
            // Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 435);
            this.Controls.Add(this.VentaNuevo);
            this.Controls.Add(this.GroupVenta);
            this.Controls.Add(this.DatoVenta);
            this.Name = "Venta";
            this.Text = "DetalleVenta";
            ((System.ComponentModel.ISupportInitialize)(this.DatoVenta)).EndInit();
            this.GroupVenta.ResumeLayout(false);
            this.GroupVenta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DatoVenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox EstadoVenta;
        private System.Windows.Forms.ComboBox VentaCliente;
        private System.Windows.Forms.ComboBox VentaProducto;
        private System.Windows.Forms.TextBox txtVentaPrecio;
        private System.Windows.Forms.TextBox txtVentaCantidad;
        private System.Windows.Forms.GroupBox GroupVenta;
        private System.Windows.Forms.Button VentaGrabar;
        private System.Windows.Forms.Button VentaNuevo;
    }
}