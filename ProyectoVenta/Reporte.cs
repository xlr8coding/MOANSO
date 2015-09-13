using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoVenta
{
    class Reporte
    {
        private Venta venta;

        internal Venta Venta
        {
            get
            {
                return venta;
            }

            set
            {
                venta = value;
            }
        }
        public Reporte(Venta venta)
        {
            this.venta = venta;
        }

        public string getEncabezado()
        {
            return string.Format("REPORTE DE VENTA\n" + 
                                 "Numero de venta: {0}\n" +
                                 "Fecha: {1}\n" + 
                                 "Cliente: {2}\n"
                                 ,venta.Numventa,venta.Fecha, venta.Cliente.Nombre);
        }

        public string getDetalle()
        {
            string detalle = "LINEAS DE VENTA\n";
            foreach(LineaDeVenta lineaventa in venta.Lineasventa)
            {
                foreach(Producto producto in lineaventa.Productos)
                {
                    detalle += string.Format("Item: {0}\n" + 
                                             "Producto: {1}\n" + 
                                             "Precio: {2:C}\n" + 
                                             "Cantidad: {3}\n" +
                                             "Subtotal: {4:C}\n", 
                                             producto.IdProducto,producto.DescripcionProducto,producto.Precio,producto.Cantidad,producto.calcularCostoProducto());
                }
            }
            return detalle;
        }
        public string getTotales()
        {
            double totalventa = 0;

            return string.Format("TOTALES \n" + 
                                 "Total: {0:C}\n" + 
                                 "Descuento: {1:C}\n" + 
                                 "Monto a Pagar: {2:C}\n",
                                 venta.calcularTotalVenta(),venta.calcularDescuento(), venta.precioDescontado());
        }
    }
}
