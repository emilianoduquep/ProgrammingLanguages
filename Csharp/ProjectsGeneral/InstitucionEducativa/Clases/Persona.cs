using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstitucionEducativa.clases
{
    internal class Persona
    {
        private string nombreCompleto;
        private int cedula;

        public Persona(string nombreCompleto, int cedula)
        {
            this.nombreCompleto = nombreCompleto;
            this.cedula = cedula;
        }

        public override string ToString()
        {
            return "Nombre Completo: " + nombreCompleto + ", Cedula: " + cedula;
        }
    }
}
