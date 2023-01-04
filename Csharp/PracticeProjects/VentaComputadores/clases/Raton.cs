using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaComputadores.clases
{
    internal class Raton: DispositivoEntrada
    {
        private readonly int idRaton;
        private static int contadorRatones;



        public Raton(string tipoEntrada, string marca)
            : base (tipoEntrada, marca)
        {
            this.idRaton = ++Raton.contadorRatones;
        }

        public override string ToString()
        {
            return "\nidRaton: " + this.idRaton + "\n" +
                base.ToString();
        }
    }
}
