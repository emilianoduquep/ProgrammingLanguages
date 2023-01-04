using InstitucionEducativa.clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstitucionEducativa
{
    internal class mainInstitucionEducativa
    {
        static void Main(string[] args)
        {
            Estudiante estud1 = new Estudiante("Emiliano Duque", 71741881);
            Console.WriteLine(estud1);
        }
    }
}
