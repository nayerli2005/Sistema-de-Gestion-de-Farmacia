using Sistema_de_Gestion_de_Farmacia.Controlador;
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
    public partial class frmConsultas : Form
    {
        public frmConsultas()
        {
            InitializeComponent();
        }
        private void frmConsultas_Load(object sender, EventArgs e)
        {

        }

        private void productosConStockBajoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var consulta =
                ProductoControlador.listaProductos
                .Where(p => p.Stock < 10)
                .ToList();

            dgvConsultas.DataSource = null;
            dgvConsultas.DataSource = consulta;
        }

        private void productosOrdenadosPorNombreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var consulta =
                ProductoControlador.listaProductos
                .OrderBy(p => p.Nombre)
                .ToList();

            dgvConsultas.DataSource = null;
            dgvConsultas.DataSource = consulta;
        }

        private void productosMásCarosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var consulta =
                ProductoControlador.listaProductos
                .OrderByDescending(p => p.Precio)
                .ToList();

            dgvConsultas.DataSource = null;
            dgvConsultas.DataSource = consulta;
        }

        private void clientesOrdenadosPorNombreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var consulta =
                ClienteControlador.listaClientes
                .OrderBy(c => c.Nombre)
                .ToList();

            dgvConsultas.DataSource = null;
            dgvConsultas.DataSource = consulta;
        }

        private void ventasMayoresA50ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var consulta =
                VentaControlador.listaVentas
                .Where(v => v.Total > 50)
                .ToList();

            dgvConsultas.DataSource = null;
            dgvConsultas.DataSource = consulta;
        }

        private void productosSinStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var consulta =
            ProductoControlador.listaProductos
            .Where(p => p.Stock == 0)
            .ToList();

            dgvConsultas.DataSource = null;
            dgvConsultas.DataSource = consulta;
        }

        private void ventaDeMayorValorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var consulta =
               VentaControlador.listaVentas
               .OrderByDescending(v => v.Total)
               .Take(1)
               .ToList();

            dgvConsultas.DataSource = null;
            dgvConsultas.DataSource = consulta;
        }

        private void ventaDeMenorValorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var consulta =
               VentaControlador.listaVentas
               .OrderBy(v => v.Total)
               .Take(1)
               .ToList();

            dgvConsultas.DataSource = null;
            dgvConsultas.DataSource = consulta;
        }
    }
}
