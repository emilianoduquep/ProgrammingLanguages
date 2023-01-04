using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollectionStack
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            // Stack is type LIFO (Last In First Out)
            //Stack<> nombre = new Stack<T>();

            Stack<double> miPila = new Stack<double>();

            //adds an item at the beginning of the stack (on top), but each time you enter an element, it will take the index = 0
            miPila.Push(5.9);
            miPila.Push(7.8);
            miPila.Push(10.5);
            miPila.Push(13.4);

            int i = 0;
            foreach (double item in miPila)
            {
                Console.WriteLine($"{i++}. {item}");
            }

            Console.WriteLine("\nAfter adding a new element, the index value changes");
            miPila.Push(2.3);

            i = 0;
            foreach (double item in miPila)
            {
                Console.WriteLine($"{i++}. {item}");
            }

            // Now we will remove the last item that entered into the stack
            miPila.Pop();
            
            Console.WriteLine("\nAfter removing the last item that entered");

            i = 0;
            foreach (double item in miPila)
            {
                Console.WriteLine($"{i++}. {item}");
            }


            //Peek gives the last entered element but it does not delete it

            var miPrimerObjeto = miPila.Peek();
            Console.WriteLine($"El primer elemento del Stack es {miPrimerObjeto}");

            // Contains

            // this is to know if the stack contains an element
            bool contiene;
            double findElement;

            Console.WriteLine("Enter the element you are looking for: ");
            findElement = Convert.ToDouble(Console.ReadLine());

            contiene = miPila.Contains(findElement);

            if (contiene)
            {
                Console.WriteLine("The element is in the stack");
            }
            else
            {
                Console.WriteLine("The element is not in the stack");
            }


            // Count nos permite saber la cantidad de elemtntos en el Stack
            Console.WriteLine($"the stack has {miPila.Count} elements");
        }
    }
}
