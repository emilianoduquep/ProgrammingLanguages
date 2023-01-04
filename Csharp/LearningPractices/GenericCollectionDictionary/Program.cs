using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollectionDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dictionary< TKey, Tvalue >

            Dictionary<string, int> miDictionary = new Dictionary<string, int>();

            miDictionary.Add("Emiliano", 71741881);
            miDictionary.Add("Diana", 1110453567);
            miDictionary.Add("Mia", 123456789);

            int i = 0;

            foreach(KeyValuePair<string, int> item in miDictionary)
            {
                Console.WriteLine($"{i++}. {item.Key}: {item.Value}");
            }

            // item[] property. The difference with add is that this overrides a value if it exists
            // collection[key] = value

            Console.WriteLine("\nAfter adding an element with item[]");

            miDictionary["Miguel"] = 8794651;

            i = 0;

            foreach (KeyValuePair<string, int> item in miDictionary)
            {
                Console.WriteLine($"{i++}. {item.Key}: {item.Value}");
            }

            // Using the 'get' from the Item[] property
            Console.WriteLine("\nThe Emiliano's Id is: " + miDictionary["Emiliano"]);

            Console.WriteLine("\nAfter removing an element");
            miDictionary.Remove("Emiliano");

            i = 0;

            foreach (KeyValuePair<string, int> item in miDictionary)
            {
                Console.WriteLine($"{i++}. {item.Key}: {item.Value}");
            }

            Console.WriteLine(miDictionary.ContainsKey("Diana"));
            Console.WriteLine(miDictionary.ContainsValue(45));

        }
    }
}
