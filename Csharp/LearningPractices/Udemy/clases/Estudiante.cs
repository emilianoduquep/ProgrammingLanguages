using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.clases
{
    internal class Estudiante : Persona
    {
        private List<Curso> ListaCursosEstudiante = new List<Curso>();
        private readonly int estudianteId;
        private static int contadorEstudiantes;

        public Estudiante(string nombreCompleto, int id) : base(nombreCompleto, id)
        {
            this.estudianteId = ++contadorEstudiantes;
        }

        public void comprarCurso(Curso curso)
        {
            ListaCursosEstudiante.Add(curso);
        }

        public void mostrarCursosEstudiante()
        {
            Console.WriteLine("\nCuros Comprados");
            Console.WriteLine(ToString());
            foreach(Curso item in ListaCursosEstudiante)
            {
                Console.WriteLine("Curso Id: " + item.CursoId + ", Nombre Curso: " + item.NombreCurso);
            }
        }

        public override string ToString()
        {
            return "Estudiante {" + "Nombre Estudiante: " + base.NombreCompleto + ", ID: " + estudianteId + "}";
        }
    }
}
