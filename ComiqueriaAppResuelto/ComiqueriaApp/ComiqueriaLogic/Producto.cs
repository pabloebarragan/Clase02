using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public abstract class Producto
    {
        private int stock;
        private double precio;
        private Guid codigo;
        private string descripcion;

        /// <summary>
        /// Al instanciar un producto se asigna un código utilizando GUID.
        /// </summary>
        /// <param name="stock">Stock Inicial</param>
        /// <param name="precio">Precio</param>
        protected Producto(string descripcion, int stock, double precio)
        {
            this.codigo = Guid.NewGuid();
            this.stock = stock;
            this.precio = precio;
            this.descripcion = descripcion;
        }

        /// <summary>
        /// Propiedad de Stock. Valida que el nuevo stock sea mayor a cero, sino no lo actualiza. 
        /// </summary>
        public int Stock
        {
            get
            {
                return this.stock;
            }
            set
            {
                if(value >= 0)
                {
                    this.stock = value;
                }
            }
        } 

        /// <summary>
        /// Precio. Sólo lectura. 
        /// </summary>
        public double Precio
        {
            get
            {
                return this.precio;
            }
        }

        /// <summary>
        /// Descripción. Sólo lectura.
        /// </summary>
        public string Descripcion
        {
            get
            {
                return this.descripcion;
            }
        }

        /// <summary>
        /// Conversión explícita de producto a Guid. Retorna el código del producto. 
        /// </summary>
        /// <param name="p"></param>
        public static explicit operator Guid(Producto p)
        {
            return p.codigo;
        }

        /// <summary>
        /// Devuelve un string con los datos de un producto: descripción, código, precio y stock. 
        /// Utilizar StringBuilder y/o algún método de la clase String. 
        /// No utilizar operador + y derivados.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(String.Format("Descripción: {0}", this.descripcion));
            sb.AppendLine(String.Format("Código: {0}", this.codigo));
            sb.AppendLine(String.Format("Precio: ${0:0.00}", this.precio));
            sb.AppendLine(String.Format("Stock: {0} unidades", this.stock));

            return sb.ToString();
        }
    }
}
