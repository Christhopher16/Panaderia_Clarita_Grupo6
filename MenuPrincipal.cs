using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Panaderia_Clarita
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal() 
        {
            InitializeComponent();
            GroupPrincipal.Enabled = false;
        }
        private void IngresarPrincipal_Click(object sender, EventArgs e)
        {
            if (RegistroBienvenidoUsuario.Text == "Alejandro" && RegistroBienvenidoContraseña.Text == "123456")
            {
                GroupPrincipal.Enabled = true;
            }
        }
        private void ManCliente_Click(object sender, EventArgs e)
        {
            MantenedorCliente Clie = new MantenedorCliente();
            Clie.Show();
        }

        private void ManProducto_Click(object sender, EventArgs e)
        {
            MantenedorProducto Prod = new MantenedorProducto();
            Prod.Show();
        }

        private void ManEmpleado_Click(object sender, EventArgs e)
        {
            MantenedorEmpleado Empl = new MantenedorEmpleado();
            Empl.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MantenedorAlmacen Alm = new MantenedorAlmacen();
            Alm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MantenedorTipoProducto TPro = new MantenedorTipoProducto();
            TPro.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MantenedorTipoCliente TCli = new MantenedorTipoCliente();
            TCli.Show();
        }
        private void VentaDirecta_Click(object sender, EventArgs e)
        {
            Venta Ven = new Venta();
            Ven.Show();
        }
    }
}
