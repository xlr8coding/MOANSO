using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoVenta
{
    class LineaDeVenta
    {
        
        private List<Producto> productos;

        public LineaDeVenta()
        {
            Productos = new List<Producto>();
            
        }

        internal List<Producto> Productos
        {
            get
            {
                return productos;
            }

            set
            {
                productos = value;
            }
        }

        public void agregarProducto(int idproducto, string descripcion, double precio, int cantidad)
        { 
            
           productos.Add(new Producto(idproducto,descripcion,precio, cantidad));
        }
        
        public double calcularTotal()
        {
            double total = 0;
            foreach(Producto producto in productos)
            {
                total += producto.Cantidad * producto.Precio;
            }
            return total;
        }

    }
}
