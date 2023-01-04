using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen.Clases
{
    internal class Producto
    {
        private readonly int idProducto;
        private string nombre;
        private double precio;
        private static int contadorProductos;

        public Producto(string nombre, double precio)
        {
            this.idProducto = ++contadorProductos;
            this.nombre = nombre;
            this.precio = precio;   
        }

        public string Nombre
        {
            get { return nombre; }
            set { this.nombre = value; }
        }

        public double Precio
        {
            get { return this.precio; }
            set { this.precio = value; }
        }

        public override string ToString()
        {
            return "IdProducto: " + idProducto + ", Nombre: " + this.nombre + ", Precio: $" + precio;
        }
    }
}
