using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoVenta
{
    class Venta
    {
        private int numventa;
        private string fecha;
        private Cliente cliente;
        private List<LineaDeVenta> lineasventa;

        public string Fecha
        {
            get
            {
                return fecha;
            }

            set
            {
                fecha = value;
            }
        }

        internal Cliente Cliente
        {
            get
            {
                return cliente;
            }

            set
            {
                cliente = value;
            }
        }

        public int Numventa
        {
            get
            {
                return numventa;
            }

            set
            {
                numventa = value;
            }
        }

        public List<LineaDeVenta> Lineasventa
        {
            get
            {
                return lineasventa;
            }

            set
            {
                lineasventa = value;
            }
        }

        public Venta(int numventa, string fecha, Cliente cliente, List<LineaDeVenta> lineasventa)
        {
            this.fecha = fecha;
            this.cliente = cliente;
            this.Lineasventa = lineasventa;
            this.numventa = numventa;
        }

        public double calcularTotalVenta()
        {
            double totalventa = 0;
            foreach (LineaDeVenta lineaventa in Lineasventa)
            {
                totalventa += lineaventa.calcularTotal();
            }
            return totalventa;
        }

        public double calcularDescuento()
        {
            return calcularTotalVenta() * 0.16;
        }

        public double precioDescontado()
        {
            return calcularTotalVenta() - calcularDescuento();
        }
    }
}
