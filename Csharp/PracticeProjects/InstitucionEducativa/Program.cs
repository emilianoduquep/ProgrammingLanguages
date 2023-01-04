using InstitucionEducativa.clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstitucionEducativa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante estd1 = new Estudiante("Emiliano Duque", 71741881, 123002501, 1);
            Console.WriteLine(estd1.ToString());
        }
    }
}
