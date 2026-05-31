using Sistema_de_Gestion_de_Farmacia.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Gestion_de_Farmacia.Controlador
{
    public class ProductoControlador
    {
        public static List<Producto> listaProductos =
            new List<Producto>();

        public void AgregarProducto(Producto p)
        {
            listaProductos.Add(p);
        }

        public void EliminarProducto(Producto p)
        {
            listaProductos.Remove(p);
        }
    }
}
