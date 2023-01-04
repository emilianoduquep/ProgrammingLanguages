using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.clases
{
    internal class Curso
    {
        private string nombreCurso;
        private double precioCurso;
        private Instructor creadorCurso;
        private readonly int cursoId;
        private static int contadorCursos;

        


        public Curso(string nombreCurso, double precioCurso, Instructor creadorCurso)
        {
            this.nombreCurso = nombreCurso;
            this.precioCurso = precioCurso;
            this.creadorCurso = creadorCurso;
            this.cursoId = ++contadorCursos;
            
        }   

        public string NombreCurso 
        { 
            get { return this.nombreCurso; }
            set { this.nombreCurso = value; }
        }

        public double PrecioCurso
        {
            get { return this.precioCurso;}
            set { this.precioCurso = value;}
        }

        public Instructor CreadorCurso
        {
            get { return this.creadorCurso;}
            set { this.creadorCurso = value; }
        }

        public int CursoId
        {
            get { return this.cursoId; }
        }


        public override string ToString()
        {
            return "Curso {" + "Nombre Curso: " + this.nombreCurso + ", Precio: " + this.precioCurso + ", Ceador: " + this.creadorCurso + "}";
        }
    }
}
