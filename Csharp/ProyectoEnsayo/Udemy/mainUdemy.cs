using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Udemy.clases;

namespace Udemy
{
    internal class mainUdemy
    {
        static void Main(string[] args)
        {

            Estudiante estd1 = new Estudiante("Jaime Valdez", 4879461);

            Instructor inst1 = new Instructor("Emiliano Duque", 123456789);
            Instructor inst2 = new Instructor("Fredy Viracacha", 124563);
            Instructor inst3 = new Instructor("Juan Perez", 789456);

            Curso curso1 = new Curso("C# para pricipiantes", 9.99, inst1);
            Curso curso2 = new Curso("Venta de pollitos", 4.5, inst1);
            Curso curso3 = new Curso("SQL Server", 9.0, inst2);
            Curso curso4 = new Curso("Front End", 15.5, inst3);

            inst1.agregarCursos(curso1);
            inst1.agregarCursos(curso2);
            inst1.mostrarCursosInstructor();

            inst2.agregarCursos(curso3);
            inst2.mostrarCursosInstructor();

            estd1.comprarCurso(curso1);
            estd1.mostrarCursosEstudiante();

        }
    }
}
