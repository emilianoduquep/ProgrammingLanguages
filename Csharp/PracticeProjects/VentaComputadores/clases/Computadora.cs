using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaComputadores.clases
{
    internal class Computadora
    {
        private int idComputadora;
        private string nombre;
        private Monitor monitor;
        private Raton raton;
        private Teclado teclado;
        private static int contadorComputadores;

        public Computadora(string nombre, Monitor monitor, Raton raton, Teclado teclado)
        {
            this.nombre = nombre;
            this.monitor = monitor;
            this.raton = raton;
            this.teclado = teclado;
            this.idComputadora = ++Computadora.contadorComputadores;
        }

        public override string ToString()
        {
            return "idComputador:" + this.idComputadora +
                "\nNombre: " + this.nombre +
                "Monitor: " + this.monitor +
                "Raton:" + this.raton +
                "Teclado: " + this.teclado;

        }
    }
}
