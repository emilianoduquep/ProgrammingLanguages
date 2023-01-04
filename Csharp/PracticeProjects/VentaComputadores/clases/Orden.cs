using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaComputadores.clases
{
    internal class Orden
    {
        private int idOren;
        private Computadora[] computadoras;
        private static int contadorOrdenes;
        private int contadorComputadoras;
        private readonly int MAX_COMPUTADORAS = 10;

        public Orden() 
        {
            this.idOren = ++Orden.contadorOrdenes;
            this.computadoras = new Computadora[MAX_COMPUTADORAS];
        }

        public void agregarComputadora(Computadora computadora)
        {
            this.computadoras[contadorComputadoras++] = computadora;
        }

        public void mostrarOrden()
        {
            for (int i = 0; i < this.contadorComputadoras ; i++)
            {
                Console.WriteLine(this.computadoras[i] );
            }
        }
    }
}
