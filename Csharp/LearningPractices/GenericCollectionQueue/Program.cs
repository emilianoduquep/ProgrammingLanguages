using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollectionQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Queue

            // This is FIFO: First In First Out
            Queue<char> miQueue = new Queue<char>();

            //Enqueue: Adds an object at the end of the queue
            miQueue.Enqueue('h'); 
            miQueue.Enqueue('o');
            miQueue.Enqueue('l');
            miQueue.Enqueue('a');

            int i = 0;

            // Reading the Queue
            foreach (char item in miQueue)
            {
                Console.WriteLine($"{i++}. {item}");
            }

            // Dequeue: Removes the first element we added to the queue
            Console.WriteLine("\nAfter removing the first element using Dequeue");
            miQueue.Dequeue();

            i = 0;

            // Reading the Queue
            foreach (char item in miQueue)
            {
                Console.WriteLine($"{i++}. {item}");
            }

            Console.WriteLine("the first element in my queue is: " + miQueue.Peek()); ;
        }
    }
}
