using Sistema_de_Gestion_de_Farmacia.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Gestion_de_Farmacia.Controlador
{
    public class VentaControlador
    {
        public static List<Venta> listaVentas =
            new List<Venta>();

        public void AgregarVenta(Venta v)
        {
            listaVentas.Add(v);
        }
    }
}
