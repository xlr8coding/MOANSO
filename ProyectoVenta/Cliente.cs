using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoVenta
{
    class Cliente
    {
        private string nombre;

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }
        public Cliente(string nombre)
        {
            this.nombre = nombre;
        }
    }
}
