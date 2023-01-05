using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaComputadores.clases
{
    internal class DispositivoEntrada
    {
        private string tipoEntrada;
        private string marca;

        public DispositivoEntrada(string tipoEntrada, string marca)
        {
            this.tipoEntrada = tipoEntrada;
            this.marca = marca;
        }

        public string TipoEntrada
        {
            get { return this.tipoEntrada; }
            set { this.tipoEntrada = value; }
        }

        public string Marca
        {
            get { return this.marca; }
            set { this.marca = value; }
        }

        public override string ToString()
        {
            return "DispositivoEntrada { " +
                "tipoEntrada: " + this.tipoEntrada +
                ", marca: " + marca + " } ";
        }
    }
}
