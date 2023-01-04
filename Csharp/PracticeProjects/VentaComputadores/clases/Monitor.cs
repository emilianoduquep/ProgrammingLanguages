using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaComputadores.clases
{
    internal class Monitor
    {
        private int idMonitor;
        private string marca;
        private double tamanio;
        private static int contadorMonitores;

        private Monitor()
        {
            
        }

        public Monitor(string marca, double tamanio)
        {
            //new Monitor();
            this.marca = marca;
            this.tamanio = tamanio;
            this.idMonitor = ++Monitor.contadorMonitores;
        }

        public string Marca
        {
            get { return this.marca; }
            set { this.marca = value; }
        }

        public double Tamanio
        {
            get { return this.tamanio; }
            set { this.tamanio = value; }
        }

        public override string ToString()
        {
            return "idMonitor" + this.idMonitor +", marca: " + marca + ", tamaño: " + tamanio;
        }
    }
}
