using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen.Clases
{
    internal class Orden
    {
        private readonly int idOrden;
        private Producto producto;
        private Producto[] productos = new Producto[5];
        private static int contadorProductos;
        private double total;


        public Orden()
        {
            this.idOrden++;
        }

        public void agregarProducto(Producto producto)
        {
            productos[contadorProductos++] = producto;
            this.total += producto.Precio;
        }

        public void mostrarProductos()
        {
            for(int i = 0; i < contadorProductos; i++)
            {
                Console.WriteLine(productos[i]);
                
            }
        }

        public void totalOrden()
        {
            Console.WriteLine("El total de la compra fue: $" + total);
        }
    }
}
