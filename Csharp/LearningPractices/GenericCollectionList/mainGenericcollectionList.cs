using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollectionList
{
    internal class mainGenericcollectionList
    {
        static void Main(string[] args)
        {
            listCollectionGeneric();

            //Automovil auto1 = new Automovil("Renault", "2020");
            //auto1.agregarAutomovil(auto1);
            //auto1.mostrarAutomoviles();

            
        }
        static void listCollectionGeneric()
        {
            int opt;
            string studentName;

            List<string> StudentsList = new List<string>();

            do
            {
                Console.Clear();
                Console.WriteLine("1. Add a new Student");
                Console.WriteLine("2. List all student on the screen");
                Console.WriteLine("3. Look for a student");
                Console.WriteLine("4. Delete a student from the list");
                Console.WriteLine("5. Edit an entry");
                Console.WriteLine("0. Log out");

                opt = Convert.ToInt32(Console.ReadLine());

                switch (opt)
                {
                    case 0:
                        Console.Clear();
                        Console.WriteLine("Bye");
                        break;

                    case 1:
                        Console.Clear();
                        Console.Write("Type the student's name: ");
                        StudentsList.Add(Console.ReadLine());
                        break;

                    case 2:
                        Console.Clear();
                        if (StudentsList.Count == 0)
                        {
                            Console.WriteLine("Sorry, at the moment there are no students in the list");
                        }
                        if (StudentsList.Count == 1)
                        {
                            Console.WriteLine("There is one student in the list:");
                        }
                        if (StudentsList.Count > 1)
                        {
                            Console.WriteLine("There are {0} students in the list:", StudentsList.Count);
                        }

                        showStudensList(StudentsList);
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.Clear();
                        Console.Write("Type the name of the student you are looking for: ");
                        studentName = Console.ReadLine();
                        if (StudentsList.IndexOf(studentName) == -1)
                        {
                            Console.WriteLine("({0}), is not in the list", studentName);
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("({0}),is in the list in the position {1}", studentName, StudentsList.IndexOf(studentName));
                            Console.ReadKey();
                        }
                        break;

                    case 4:
                        Console.Clear();
                        Console.Write("Type the name of the student you want to delete: ");
                        studentName = Console.ReadLine();
                        if (StudentsList.IndexOf(studentName) == -1)
                        {
                            Console.WriteLine("This name is not in the list");
                            Console.ReadKey();
                        }
                        else
                        {
                            StudentsList.RemoveAt(StudentsList.IndexOf(studentName));
                            Console.WriteLine("The person ({0}) was removed from the list", studentName);
                            Console.ReadKey();
                        }

                        break;

                    case 5:
                        Console.Clear();
                        Console.Write("Type the name of the student you want to edit: ");
                        studentName = Console.ReadLine();
                        if (StudentsList.IndexOf(studentName) == -1)
                        {
                            Console.WriteLine("This name ({0}) is not in the list!", studentName);
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("here you should be able to edit a student's name");
                            Console.ReadKey();
                        }

                        break;

                    default:
                        Console.WriteLine("You selected a wrong option. Please select any key to try it again.");
                        Console.ReadKey();
                        break;

                }


            } while (opt != 0);
        }

        static void showStudensList(List<string> StudentsList)
        {
            StudentsList.Sort();
            int i = 0;
            foreach (string student in StudentsList)
            {
                Console.WriteLine($"{++i}. {student}");
            }
        }
    }


    class Automovil
    {
        private string marca;
        private string modelo;

        private List<Automovil> ListaAutomoviles = new List<Automovil>();

        public Automovil(string marca, string modelo) 
        {
            this.marca = marca;
            this.modelo = modelo;
        }

        public void agregarAutomovil(Automovil auto)
        {
            ListaAutomoviles.Add(auto); 
        }

        public void mostrarAutomoviles()
        {
            foreach(Automovil auto in ListaAutomoviles)
            {
                Console.WriteLine("Automovil: " + auto);
            }
        }

        public override string ToString()
        {
            return "Automovil {" + "Marca: " + this.marca + ", Modelo: " + this.modelo + "}";
        }
    }
}
