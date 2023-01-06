using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehiculo vehiculo = new Vehiculo();

            //vehiculo.prenderMotor();
            //vehiculo.conducir();
            //vehiculo.apagarMotor();


            // Here, I am using Polymorphism to change the way every vehicle is driven.
            List<Vehiculo> vehiculos= new List<Vehiculo>()
            {
                new Coche(),
                new Avion()
            };

            foreach (Vehiculo item in vehiculos)
            {
                item.prenderMotor();
                item.conducir();    
                item.apagarMotor();
                Console.WriteLine("\n*************\n");
            }
        }
    }

    public class Vehiculo
    {
        public void prenderMotor()
        {
            Console.WriteLine("prendiendo el motor...");
        }

        public virtual void conducir()
        {
            Console.WriteLine("conduciendo el vehiculo");
        }

        public void apagarMotor()
        {
            Console.WriteLine("apagando el motor...");
        }
    }

    public class Coche : Vehiculo
    {
        public override void conducir()
        {
            base.conducir();
            Console.WriteLine("Estoy conduciendo un carro");
        }
    }

    public class Avion : Vehiculo
    {
        public override void conducir()
        {
            base.conducir();
            Console.WriteLine("Estoy piloteando un avion");
        }
    }
}
