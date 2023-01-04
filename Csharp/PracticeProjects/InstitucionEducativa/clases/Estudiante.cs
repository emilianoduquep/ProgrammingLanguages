using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstitucionEducativa.clases
{
    internal class Estudiante : Persona
    {
        // fields
        private int carnetEstudiantil;
        private int semestre;

        // Constructor
        public Estudiante(string nombreCompleto, int cedula, int carnetEstudiantil, int semestre) : base(nombreCompleto, cedula)
        { 
            this.carnetEstudiantil= carnetEstudiantil;
            this.semestre= semestre;
        }

        // Properties
        public int CarnetStudiantil
        {
            get { return this.carnetEstudiantil;}
            set { this.carnetEstudiantil = value;}
        }

        public int Semestre
        {
            get { return this.semestre;}
            set { this.semestre = value;}
        }

        public override string ToString()
        {
            return base.ToString() +
                ", Carnet Estudiantil: " + this.carnetEstudiantil;
        }
    }
}
