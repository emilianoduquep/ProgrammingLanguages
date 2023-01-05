using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using VentaComputadores.clases;
using Monitor = VentaComputadores.clases.Monitor;

namespace VentaComputadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Raton raton1 = new Raton("cableada", "Lenovo");
            Raton raton2 = new Raton("inalambrico", "Asus");

            Teclado teclado1 = new Teclado("bluetooth", "HP");
            Teclado teclado2 = new Teclado("inalambrico", "Samsung");

            clases.Monitor monitor1 = new Monitor("iMac", 21.5);
            clases.Monitor monitor2 = new Monitor("LG", 27.0);

            Computadora compu1 = new Computadora("nueva", monitor1, raton1, teclado1);
            Computadora compu2 = new Computadora("iMac", monitor2, raton2, teclado2);

            Orden orden1 = new Orden();
            orden1.agregarComputadora(compu1);
            orden1.agregarComputadora(compu2);
            orden1.mostrarOrden();

        }
    }
}
