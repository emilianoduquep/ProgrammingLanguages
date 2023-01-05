using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaComputadores.clases
{
    internal class Teclado : DispositivoEntrada
    {
        private readonly int idTeclado;
        private static int contadorTeclados;


        public Teclado(string tipoEntrada, string marca) : base(tipoEntrada, marca)
        {
            this.idTeclado = ++Teclado.contadorTeclados;
        }

        public override string ToString()
        {
            return "\nidTeclado:" + idTeclado + "\n" +
                base.ToString();
        }
    }
}
