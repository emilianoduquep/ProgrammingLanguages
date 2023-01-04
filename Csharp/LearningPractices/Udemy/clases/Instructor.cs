using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.clases
{
    internal class Instructor : Persona
    {
        private List<Curso> ListaCursosInstructor = new List<Curso>();

        private readonly int instructorId;
        private double salario;
        private static int contadorInstructores;

        public Instructor(string nombreCompleto, int id) : base(nombreCompleto, id)
        {
            this.instructorId = ++contadorInstructores;
        }
        public void agregarCursos(Curso curso)
        {
            ListaCursosGeneral.Add(curso);
            ListaCursosInstructor.Add(curso);
        }

        public void mostrarCursosInstructor()
        {
            Console.WriteLine("\nCuroso Creados");
            Console.WriteLine(ToString());
            foreach (Curso item in ListaCursosInstructor)
            {
                Console.WriteLine("Curso ID: " + item.CursoId + ", Nombre Curso: "+ item.NombreCurso);
            }
        }


        public override string ToString()
        {
            return "Instructor {" + "Instructor ID:" + this.instructorId + ", Nombre: " + base.NombreCompleto + ", Salario: " + this.salario + "}";
        }
    }
}
