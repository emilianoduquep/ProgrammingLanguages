using Almacen.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Almacen
{
    internal class mainAlmacen
    {
        static void Main(string[] args)
        {

            Producto prod1 = new Producto("iPhoneX", 850.4);
            Producto prod2 = new Producto("Huawei", 689.5);
            Producto prod3 = new Producto("Motorola", 770.3);

            Orden orden1 = new Orden();
            orden1.agregarProducto(prod3);
            orden1.agregarProducto(prod1);
            orden1.agregarProducto(prod2);
            
            orden1.mostrarProductos();
            orden1.totalOrden();

            Console.WriteLine();

            Orden orden2 = new Orden();
            orden2.agregarProducto(prod3);
            orden2.mostrarProductos();
            orden2.totalOrden();


        }

    }
}
