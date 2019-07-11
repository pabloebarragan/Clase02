using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public sealed class Venta
    {
        private static int porcentajeIva;
        private DateTime fecha;
        private Producto producto;
        private double precioFinal;

        static Venta()
        {
            Venta.porcentajeIva = 21;
        }

        internal Venta(Producto producto, int cantidad)
        {
            this.producto = producto;
            this.Vender(cantidad);
        }


        internal DateTime Fecha
        {
            get
            {
                return this.fecha;
            }
        }

        private void Vender(int cantidad)
        {
            producto.Stock -= cantidad;
            this.fecha = DateTime.Now;
            this.precioFinal = Venta.CalcularPrecioFinal(producto.Precio, cantidad);        
        }
        
        public static double CalcularPrecioFinal(double precioUnidad, int cantidad)
        {
            double precioSinIva = precioUnidad * cantidad;
            return precioSinIva + precioSinIva * Venta.porcentajeIva / 100;
        }

        public string ObtenerDescripcionBreve()
        {
            return String.Format("{0} - {1} - ${2:0.00}", this.fecha, this.producto.Descripcion, this.precioFinal);
        }
    }
}
