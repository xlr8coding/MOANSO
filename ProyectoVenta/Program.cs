using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoVenta
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente("Pedro Pablo");
            List<LineaDeVenta> lineasdeventa = new List<LineaDeVenta>();
            LineaDeVenta lineadeventa1 = new LineaDeVenta();
            lineadeventa1.agregarProducto(1, "Cuaderno", 10,10);
            lineadeventa1.agregarProducto(2, "Lapiz", 5, 5);
            lineasdeventa.Add(lineadeventa1);
            Venta venta1 = new Venta(100,"19/18/17", cliente1, lineasdeventa);
            Reporte reporte = new Reporte(venta1);
            Console.WriteLine(reporte.getEncabezado());
            Console.WriteLine(reporte.getDetalle());
            Console.WriteLine(reporte.getTotales());
            
        }
    }
}
