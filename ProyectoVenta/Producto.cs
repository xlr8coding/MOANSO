using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoVenta
{
    class Producto
    {
        private int idProducto;
        private string descripcionProducto;
        private double precio;
        private int cantidad;

        public double Precio
        {
            get
            {
                return precio;
            }

            set
            {
                precio = value;
            }
        }

        public string DescripcionProducto
        {
            get
            {
                return descripcionProducto;
            }

            set
            {
                descripcionProducto = value;
            }
        }

        public int IdProducto
        {
            get
            {
                return idProducto;
            }

            set
            {
                idProducto = value;
            }
        }

        public int Cantidad
        {
            get
            {
                return cantidad;
            }

            set
            {
                cantidad = value;
            }
        }

        public Producto(int idproducto, string descripcion, double precio, int cantidad)
        {
            this.idProducto = idproducto;
            this.descripcionProducto = descripcion;
            this.precio = precio;
            this.cantidad = cantidad;
        }
        public double calcularCostoProducto()
        {
            return this.cantidad * this.precio;
        }
    }
}
