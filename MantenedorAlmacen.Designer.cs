
namespace Panaderia_Clarita
{
    partial class MantenedorAlmacen
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
            this.DatoAlmacen = new System.Windows.Forms.DataGridView();
            this.GroupAlmacen = new System.Windows.Forms.GroupBox();
            this.AlmacenModificar = new System.Windows.Forms.Button();
            this.txtAlmacenIDEmp = new System.Windows.Forms.TextBox();
            this.txtAlmacenNombre = new System.Windows.Forms.TextBox();
            this.txtAlmacenID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AlmacenBuscar = new System.Windows.Forms.Button();
            this.AlmacenEditar = new System.Windows.Forms.Button();
            this.AlmacenSalir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAlmacenBuscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DatoAlmacen)).BeginInit();
            this.GroupAlmacen.SuspendLayout();
            this.SuspendLayout();
            // 
            // DatoAlmacen
            // 
            this.DatoAlmacen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatoAlmacen.Location = new System.Drawing.Point(21, 85);
            this.DatoAlmacen.Name = "DatoAlmacen";
            this.DatoAlmacen.RowHeadersWidth = 51;
            this.DatoAlmacen.RowTemplate.Height = 24;
            this.DatoAlmacen.Size = new System.Drawing.Size(577, 209);
            this.DatoAlmacen.TabIndex = 0;
            this.DatoAlmacen.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatoAlmacen_CellDoubleClick);
            // 
            // GroupAlmacen
            // 
            this.GroupAlmacen.Controls.Add(this.AlmacenModificar);
            this.GroupAlmacen.Controls.Add(this.txtAlmacenIDEmp);
            this.GroupAlmacen.Controls.Add(this.txtAlmacenNombre);
            this.GroupAlmacen.Controls.Add(this.txtAlmacenID);
            this.GroupAlmacen.Controls.Add(this.label3);
            this.GroupAlmacen.Controls.Add(this.label2);
            this.GroupAlmacen.Controls.Add(this.label1);
            this.GroupAlmacen.Location = new System.Drawing.Point(21, 316);
            this.GroupAlmacen.Name = "GroupAlmacen";
            this.GroupAlmacen.Size = new System.Drawing.Size(441, 152);
            this.GroupAlmacen.TabIndex = 1;
            this.GroupAlmacen.TabStop = false;
            this.GroupAlmacen.Text = "RegistroAlmacen";
            // 
            // AlmacenModificar
            // 
            this.AlmacenModificar.Location = new System.Drawing.Point(310, 55);
            this.AlmacenModificar.Name = "AlmacenModificar";
            this.AlmacenModificar.Size = new System.Drawing.Size(104, 47);
            this.AlmacenModificar.TabIndex = 6;
            this.AlmacenModificar.Text = "Modificar";
            this.AlmacenModificar.UseVisualStyleBackColor = true;
            this.AlmacenModificar.Click += new System.EventHandler(this.AlmacenModificar_Click);
            // 
            // txtAlmacenIDEmp
            // 
            this.txtAlmacenIDEmp.Location = new System.Drawing.Point(115, 98);
            this.txtAlmacenIDEmp.Name = "txtAlmacenIDEmp";
            this.txtAlmacenIDEmp.Size = new System.Drawing.Size(154, 22);
            this.txtAlmacenIDEmp.TabIndex = 5;
            // 
            // txtAlmacenNombre
            // 
            this.txtAlmacenNombre.Location = new System.Drawing.Point(85, 67);
            this.txtAlmacenNombre.Name = "txtAlmacenNombre";
            this.txtAlmacenNombre.Size = new System.Drawing.Size(184, 22);
            this.txtAlmacenNombre.TabIndex = 4;
            // 
            // txtAlmacenID
            // 
            this.txtAlmacenID.Location = new System.Drawing.Point(106, 36);
            this.txtAlmacenID.Name = "txtAlmacenID";
            this.txtAlmacenID.Size = new System.Drawing.Size(163, 22);
            this.txtAlmacenID.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID Empleado: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Almacen: ";
            // 
            // AlmacenBuscar
            // 
            this.AlmacenBuscar.Location = new System.Drawing.Point(493, 25);
            this.AlmacenBuscar.Name = "AlmacenBuscar";
            this.AlmacenBuscar.Size = new System.Drawing.Size(105, 41);
            this.AlmacenBuscar.TabIndex = 2;
            this.AlmacenBuscar.Text = "Buscar";
            this.AlmacenBuscar.UseVisualStyleBackColor = true;
            // 
            // AlmacenEditar
            // 
            this.AlmacenEditar.Location = new System.Drawing.Point(493, 337);
            this.AlmacenEditar.Name = "AlmacenEditar";
            this.AlmacenEditar.Size = new System.Drawing.Size(105, 41);
            this.AlmacenEditar.TabIndex = 3;
            this.AlmacenEditar.Text = "Editar";
            this.AlmacenEditar.UseVisualStyleBackColor = true;
            // 
            // AlmacenSalir
            // 
            this.AlmacenSalir.Location = new System.Drawing.Point(493, 395);
            this.AlmacenSalir.Name = "AlmacenSalir";
            this.AlmacenSalir.Size = new System.Drawing.Size(105, 41);
            this.AlmacenSalir.TabIndex = 4;
            this.AlmacenSalir.Text = "Salir";
            this.AlmacenSalir.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "ID Almacen: ";
            // 
            // txtAlmacenBuscar
            // 
            this.txtAlmacenBuscar.Location = new System.Drawing.Point(127, 34);
            this.txtAlmacenBuscar.Name = "txtAlmacenBuscar";
            this.txtAlmacenBuscar.Size = new System.Drawing.Size(335, 22);
            this.txtAlmacenBuscar.TabIndex = 6;
            // 
            // MantenedorAlmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 492);
            this.Controls.Add(this.txtAlmacenBuscar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AlmacenSalir);
            this.Controls.Add(this.AlmacenEditar);
            this.Controls.Add(this.AlmacenBuscar);
            this.Controls.Add(this.GroupAlmacen);
            this.Controls.Add(this.DatoAlmacen);
            this.Name = "MantenedorAlmacen";
            this.Text = "Almacen";
            ((System.ComponentModel.ISupportInitialize)(this.DatoAlmacen)).EndInit();
            this.GroupAlmacen.ResumeLayout(false);
            this.GroupAlmacen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DatoAlmacen;
        private System.Windows.Forms.GroupBox GroupAlmacen;
        private System.Windows.Forms.Button AlmacenModificar;
        private System.Windows.Forms.TextBox txtAlmacenNombre;
        private System.Windows.Forms.TextBox txtAlmacenID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AlmacenBuscar;
        private System.Windows.Forms.Button AlmacenEditar;
        private System.Windows.Forms.Button AlmacenSalir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAlmacenBuscar;
        private System.Windows.Forms.TextBox txtAlmacenIDEmp;
    }
}