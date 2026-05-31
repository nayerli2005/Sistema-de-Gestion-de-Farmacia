using Sistema_de_Gestion_de_Farmacia.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Gestion_de_Farmacia.Controlador
{
    public class ClienteControlador
    {
        public static List<Cliente> listaClientes =
            new List<Cliente>();

        public void AgregarCliente(Cliente c)
        {
            listaClientes.Add(c);
        }

        public void EliminarCliente(Cliente c)
        {
            listaClientes.Remove(c);
        }
    }
}
