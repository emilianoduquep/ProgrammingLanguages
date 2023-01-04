using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstitucionEducativa.clases
{
    internal class Profesor : Persona
    {
        private string asignatura;
        private double salario;

        public Profesor(string nombreCompleto, int cedula, string asignatura, double salario) : base(nombreCompleto, cedula)
        {
            this.asignatura = asignatura;
            this.salario = salario;
        }

        public override string ToString()
        {
            return base.ToString() + ", Asignatura: " + asignatura + ", Salario: $" + salario;
        }
    }
}
