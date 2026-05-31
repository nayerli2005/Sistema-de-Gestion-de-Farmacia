using Sistema_de_Gestion_de_Farmacia.Controlador;
using Sistema_de_Gestion_de_Farmacia.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Gestion_de_Farmacia.Formularios
{
    public partial class frmProductos : Form
    {
        ProductoControlador pc = new ProductoControlador();

        int indice = -1;

        bool editar = false;
        public frmProductos()
        {
            InitializeComponent();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            //Módulo de productos
            cmbCategoria.Items.Add("Medicamentos");
            cmbCategoria.Items.Add("Vitaminas");
            cmbCategoria.Items.Add("Higiene");
            cmbCategoria.Items.Add("Bebidas");

            MostrarProductos();
        }
        public void MostrarProductos()
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource =
                ProductoControlador.listaProductos.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Producto p = new Producto();

            p.Codigo = txtCodigo.Text;
            p.Nombre = txtNombre.Text;
            p.Categoria = cmbCategoria.Text;
            p.Precio = Convert.ToDouble(txtPrecio.Text);
            p.Stock = Convert.ToInt32(txtStock.Text);

            pc.AgregarProducto(p);

            MostrarProductos();

            Limpiar();

            MessageBox.Show("Producto registrado correctamente");
        }
        public void Limpiar()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtPrecio.Clear();
            txtStock.Clear();

            cmbCategoria.SelectedIndex = -1;

            txtCodigo.Focus();

            indice = -1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow != null)
            {
                Producto p =
                    (Producto)dgvProductos.CurrentRow.DataBoundItem;

                ProductoControlador.listaProductos.Remove(p);

                MostrarProductos();

                MessageBox.Show("Producto eliminado");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // PRIMER CLICK
            // CARGA DATOS

            if (editar == false)
            {
                if (dgvProductos.CurrentRow != null)
                {
                    indice = dgvProductos.CurrentRow.Index;

                    txtCodigo.Text =
                        dgvProductos.Rows[indice].Cells[0].Value.ToString();

                    txtNombre.Text =
                        dgvProductos.Rows[indice].Cells[1].Value.ToString();

                    cmbCategoria.Text =
                        dgvProductos.Rows[indice].Cells[2].Value.ToString();

                    txtPrecio.Text =
                        dgvProductos.Rows[indice].Cells[3].Value.ToString();

                    txtStock.Text =
                        dgvProductos.Rows[indice].Cells[4].Value.ToString();

                    editar = true;

                    MessageBox.Show("Modifique los datos y presione nuevamente MODIFICAR");
                }
            }

            // SEGUNDO CLICK
            // GUARDA CAMBIOS

            else
            {
                ProductoControlador.listaProductos[indice].Codigo =
                    txtCodigo.Text;

                ProductoControlador.listaProductos[indice].Nombre =
                    txtNombre.Text;

                ProductoControlador.listaProductos[indice].Categoria =
                    cmbCategoria.Text;

                ProductoControlador.listaProductos[indice].Precio =
                    Convert.ToDouble(txtPrecio.Text);

                ProductoControlador.listaProductos[indice].Stock =
                    Convert.ToInt32(txtStock.Text);

                MostrarProductos();

                Limpiar();

                editar = false;

                MessageBox.Show("Producto modificado correctamente");
            }
        }
    }
}
