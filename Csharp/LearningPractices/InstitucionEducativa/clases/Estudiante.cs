using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstitucionEducativa.clases
{
    internal class Estudiante : Persona
    {
        private readonly int carnet;

        private static int contadorEstudiantes;

        public Estudiante(string nombreCompleto, int cedula) : base(nombreCompleto, cedula)
        {
            this.carnet = ++contadorEstudiantes;
        }

        public override string ToString()
        {
            return base.ToString() + "\nEstudiante: {" + "Carnet: " + this.carnet + "}";
        }
    }
}
