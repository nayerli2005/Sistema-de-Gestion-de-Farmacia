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
    public partial class frmReportes : Form
    {
        public frmReportes()
        {
            InitializeComponent();
        }

        private void frmReportes_Load(object sender, EventArgs e)
        {

        }
        private void reportesProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvReportes.DataSource = null;
            dgvReportes.DataSource =
                ProductoControlador.listaProductos.ToList();
        }

        private void reporteClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvReportes.DataSource = null;
            dgvReportes.DataSource =
                ClienteControlador.listaClientes.ToList();
        }

        private void reporteVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvReportes.DataSource = null;
            dgvReportes.DataSource =
                VentaControlador.listaVentas.ToList();
        }
    }
}
