using Sistema_de_Gestion_de_Farmacia.Controlador;
using Sistema_de_Gestion_de_Farmacia.Entidades;
using Sistema_de_Gestion_de_Farmacia.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Gestion_de_Farmacia
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }
        private void frmMenu_Load(object sender, EventArgs e)
        {
            CargarDatosIniciales();
        }
        private void CargarDatosIniciales()
        {
            if (ProductoControlador.listaProductos.Count == 0)
            {
                ProductoControlador.listaProductos.Add(
                    new Producto("P001", "Paracetamol", "Medicamentos", 2.50, 50));

                ProductoControlador.listaProductos.Add(
                    new Producto("P002", "Ibuprofeno", "Medicamentos", 3.00, 30));

                ProductoControlador.listaProductos.Add(
                    new Producto("P003", "Vitamina C", "Vitaminas", 5.00, 25));

                ProductoControlador.listaProductos.Add(
                    new Producto("P004", "Alcohol", "Higiene", 1.75, 40));

                ProductoControlador.listaProductos.Add(
                    new Producto("P005", "Mascarillas", "Higiene", 0.50, 100));
            }

            if (ClienteControlador.listaClientes.Count == 0)
            {
                ClienteControlador.listaClientes.Add(
                    new Cliente("0701234567", "Juan Perez", "0991111111"));

                ClienteControlador.listaClientes.Add(
                    new Cliente("0702345678", "Maria Torres", "0992222222"));

                ClienteControlador.listaClientes.Add(
                    new Cliente("0703456789", "Carlos Mendoza", "0993333333"));

                ClienteControlador.listaClientes.Add(
                    new Cliente("0704567890", "Ana Rodriguez", "0994444444"));

                ClienteControlador.listaClientes.Add(
                    new Cliente("0705678901", "Pedro Castro", "0995555555"));
            }
        }

        private void BTNCLIENTES_Click(object sender, EventArgs e)
        {
            frmClientes cli = new frmClientes();
            cli.ShowDialog();
        }

        private void BTNPRODUCTOS_Click(object sender, EventArgs e)
        {
            frmProductos pro = new frmProductos();
            pro.ShowDialog();
        }

        private void BTNVENTAS_Click(object sender, EventArgs e)
        {
            frmVentas ven = new frmVentas();
            ven.ShowDialog();
        }

        private void BTNCONSULTAS_Click(object sender, EventArgs e)
        {
            frmConsultas con = new frmConsultas();
            con.ShowDialog();
        }

        private void BTNREPORTES_Click(object sender, EventArgs e)
        {
            frmReportes rep = new frmReportes();
            rep.ShowDialog();
        }
    }
}
