using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaLogica;

namespace Panaderia_Clarita
{
    public partial class Venta : Form
    {
        public Venta()
        {
            InitializeComponent();
            listarVenta();
            LlenarDatosComboBoxCliente();
            LlenarDatosComboBoxProducto();
        }
        public void listarVenta()
        {
            List<EntVenta> listaVenta = LogVenta.Instancia.ListarVenta();
            if (listaVenta.Count > 0)
            {
                DatoVenta.Columns.Clear();
                BindingSource datosEnlazados = new BindingSource();
                datosEnlazados.DataSource = listaVenta;
                DatoVenta.DataSource = datosEnlazados;
                DatoVenta.Rows[0].Selected = false;
            }
        }
        private void VentaGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                EntVenta v = new EntVenta();
                v.ClienteID = Convert.ToInt32(VentaCliente.SelectedValue);
                v.ProductoID = Convert.ToInt32(VentaProducto.SelectedValue);
                v.Precio_total = decimal.Parse(txtVentaPrecio.Text.Trim());
                v.Cantidad = int.Parse(txtVentaCantidad.Text.Trim());
                v.Estado_vent = EstadoVenta.Checked;
                LogVenta.Instancia.InsertarVenta(v);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            GroupVenta.Enabled = false;
            listarVenta();
        }
        private void LlenarDatosComboBoxCliente()
        {
            VentaCliente.DataSource = LogCliente.Instancia.ListarCliente();
            VentaCliente.DisplayMember = "Apellidos_cli";
            VentaCliente.ValueMember = "ClienteID";
        }
        private void LlenarDatosComboBoxProducto()
        {
            VentaProducto.DataSource = LogProducto.Instancia.ListarProducto();
            VentaProducto.DisplayMember = "Nombre_pro";
            VentaProducto.ValueMember = "ProductoID";
        }
        private void LimpiarVariables()
        {
            txtVentaPrecio.Text = " ";
            txtVentaCantidad.Text = " ";
            EstadoVenta.Checked = false;
        }
    }
}
