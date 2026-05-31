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
    public partial class frmClientes : Form
    {
        ClienteControlador cc = new ClienteControlador();

        int indice = -1;

        bool editar = false;

        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            MostrarClientes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente();

            c.Cedula = txtCedula.Text;
            c.Nombre = txtNombre.Text;
            c.Telefono = txtTelefono.Text;

            cc.AgregarCliente(c);

            MostrarClientes();

            Limpiar();

            MessageBox.Show("Cliente registrado correctamente");
        }
        public void MostrarClientes()
        {
            dgvClientes.DataSource = null;
            dgvClientes.DataSource =
                ClienteControlador.listaClientes.ToList();
        }
        public void Limpiar()
        {
            txtCedula.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();

            txtCedula.Focus();

            indice = -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // PRIMER CLICK
            // CARGA DATOS

            if (editar == false)
            {
                if (dgvClientes.CurrentRow != null)
                {
                    indice = dgvClientes.CurrentRow.Index;

                    txtCedula.Text =
                        dgvClientes.Rows[indice].Cells[0].Value.ToString();

                    txtNombre.Text =
                        dgvClientes.Rows[indice].Cells[1].Value.ToString();

                    txtTelefono.Text =
                        dgvClientes.Rows[indice].Cells[2].Value.ToString();

                    editar = true;

                    MessageBox.Show("Modifique los datos y presione nuevamente MODIFICAR");
                }
            }

            // SEGUNDO CLICK
            // GUARDA CAMBIOS

            else
            {
                ClienteControlador.listaClientes[indice].Cedula =
                    txtCedula.Text;

                ClienteControlador.listaClientes[indice].Nombre =
                    txtNombre.Text;

                ClienteControlador.listaClientes[indice].Telefono =
                    txtTelefono.Text;

                MostrarClientes();

                Limpiar();

                editar = false;

                MessageBox.Show("Cliente modificado correctamente");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow != null)
            {
                Cliente c =
                    (Cliente)dgvClientes.CurrentRow.DataBoundItem;

                ClienteControlador.listaClientes.Remove(c);

                MostrarClientes();

                Limpiar();

                MessageBox.Show("Cliente eliminado");
            }
        }
    }
}
