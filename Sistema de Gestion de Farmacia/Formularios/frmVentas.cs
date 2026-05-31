using Sistema_de_Gestion_de_Farmacia.Controlador;
using Sistema_de_Gestion_de_Farmacia.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Gestion_de_Farmacia.Formularios
{
    public partial class frmVentas : Form
    {
        VentaControlador vc = new VentaControlador();
        public frmVentas()
        {
            InitializeComponent();
        }
        // CARGAR FORMULARIO
        private void frmVentas_Load(object sender, EventArgs e)
        {
            CargarClientes();
            CargarProductos();

            dgvDetalleVenta.Columns.Clear();

            dgvDetalleVenta.Columns.Add("Producto", "Producto");
            dgvDetalleVenta.Columns.Add("Cantidad", "Cantidad");
            dgvDetalleVenta.Columns.Add("Precio", "Precio");
            dgvDetalleVenta.Columns.Add("Subtotal", "Subtotal");

            dgvDetalleVenta.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvDetalleVenta.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
        }

        // CARGAR CLIENTES
        public void CargarClientes()
        {
            cmbCliente.DataSource = null;
            cmbCliente.DataSource =
                ClienteControlador.listaClientes.ToList();

            cmbCliente.DisplayMember = "Nombre";
        }

        // CARGAR PRODUCTOS
        public void CargarProductos()
        {
            cmbProducto.DataSource = null;
            cmbProducto.DataSource =
                ProductoControlador.listaProductos.ToList();

            cmbProducto.DisplayMember = "Nombre";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbProducto.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un producto");
                return;
            }

            if (txtCantidad.Text == "")
            {
                MessageBox.Show("Ingrese una cantidad");
                return;
            }

            Producto p =
                (Producto)cmbProducto.SelectedItem;

            int cantidad =
                Convert.ToInt32(txtCantidad.Text);

            double subtotal =
                p.Precio * cantidad;

            dgvDetalleVenta.Rows.Add(
                p.Nombre,
                cantidad,
                p.Precio,
                subtotal
            );

            txtCantidad.Clear();
            txtCantidad.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double subtotalGeneral = 0;

            foreach (DataGridViewRow fila in dgvDetalleVenta.Rows)
            {
                if (fila.Cells[3].Value != null)
                {
                    subtotalGeneral +=
                        Convert.ToDouble(
                            fila.Cells[3].Value);
                }
            }

            double iva =
                subtotalGeneral * 0.15;

            double total =
                subtotalGeneral + iva;

            txtSubtotal.Text =
                subtotalGeneral.ToString("0.00");

            txtIVA.Text =
                iva.ToString("0.00");

            txtTotal.Text =
                total.ToString("0.00");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dgvDetalleVenta.CurrentRow != null)
            {
                dgvDetalleVenta.Rows.Remove(
                    dgvDetalleVenta.CurrentRow);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (cmbCliente.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un cliente");
                return;
            }

            if (dgvDetalleVenta.Rows.Count == 0)
            {
                MessageBox.Show("Agregue productos a la venta");
                return;
            }

            Venta v = new Venta();

            v.Cliente = cmbCliente.Text;
            v.Producto = "VARIOS";
            v.Cantidad = dgvDetalleVenta.Rows.Count;
            v.Precio = 0;
            v.Subtotal = Convert.ToDouble(txtSubtotal.Text);
            v.Iva = Convert.ToDouble(txtIVA.Text);
            v.Total = Convert.ToDouble(txtTotal.Text);

            vc.AgregarVenta(v);

            MessageBox.Show("Venta registrada correctamente");

            Limpiar();
        }
        public void Limpiar()
        {
            cmbCliente.SelectedIndex = -1;
            cmbProducto.SelectedIndex = -1;

            txtCantidad.Clear();
            txtSubtotal.Clear();
            txtIVA.Clear();
            txtTotal.Clear();

            dgvDetalleVenta.Rows.Clear();
        }
    }
}
