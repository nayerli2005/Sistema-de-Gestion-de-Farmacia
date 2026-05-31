using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Gestion_de_Farmacia.Entidades
{
    public class Venta
    {
        private string cliente;
        private string producto;
        private int cantidad;
        private double precio;
        private double subtotal;
        private double iva;
        private double total;

        public string Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        public string Producto
        {
            get { return producto; }
            set { producto = value; }
        }

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public double Subtotal
        {
            get { return subtotal; }
            set { subtotal = value; }
        }

        public double Iva
        {
            get { return iva; }
            set { iva = value; }
        }

        public double Total
        {
            get { return total; }
            set { total = value; }
        }

        public Venta()
        {

        }

        public Venta(string cliente, string producto,
                     int cantidad, double precio,
                     double subtotal, double iva,
                     double total)
        {
            Cliente = cliente;
            Producto = producto;
            Cantidad = cantidad;
            Precio = precio;
            Subtotal = subtotal;
            Iva = iva;
            Total = total;
        }
    }
}
