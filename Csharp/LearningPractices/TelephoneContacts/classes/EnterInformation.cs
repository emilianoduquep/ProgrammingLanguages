using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TelephoneContacts.classes
{
    internal class EnterInformation
    {
        private int option;
        private string name;
        private long phoneNumber;
        private bool flag = true;
        private int answer;

        Dictionary<string, long> contacts = new Dictionary<string, long>();

        public void startingProgram()
        {
            do
            {
                Console.Clear();

                Console.WriteLine("1. Add a new contact");
                Console.WriteLine("2. Find a contact");
                Console.WriteLine("3. Delete a contact");
                Console.WriteLine("4. Show all contacts");
                Console.WriteLine("5. Update a contact");
                Console.WriteLine("0. Exit the application");

                answer = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                switch (answer)
                {
                    case 0:
                        Console.WriteLine("Have an excellent day. Press a key twice to leave the application");
                        flag = false;
                        Console.ReadKey();
                        break;
                    case 1:
                        Console.WriteLine("Adding a new contact...");
                        Console.Write("Type the name of the contact: ");
                        name = Console.ReadLine();
                        Console.Write("Type the phone number: ");
                        phoneNumber = Convert.ToInt64(Console.ReadLine());    

                        contacts.Add(name, phoneNumber);
                        
                        Console.WriteLine("Press any key to return to the menu");
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.WriteLine("Finding a contact...");
                        Console.Write("Type the name of the contact that you are looking for: ");
                        name = Console.ReadLine();
                        if (contacts.ContainsKey(name))
                        {
                            Console.WriteLine($"Name: {name}, Phone: {contacts[name]}");
                        }else
                        {
                            Console.WriteLine($"The contact ({name}) is not in your contacts list");
                        }
                        Console.WriteLine("Press any key to return to the menu");
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.WriteLine("Deleting a contact...");
                        Console.Write("Type the name of the contact that you want to delete: ");
                        name = Console.ReadLine();
                        if (contacts.ContainsKey(name))
                        {
                            Console.WriteLine($"The contact: {name} has been deleted");
                            contacts.Remove(name);
                        }
                        else
                        {
                            Console.WriteLine($"The contact ({name}) is not in your contacts list");
                        }
                        Console.WriteLine("Press any key to return to the menu");
                        Console.ReadKey();
                        break;

                    case 4:
                        Console.WriteLine("Showing all contacts...");

                        foreach (KeyValuePair<string , long> item in contacts)
                        {
                            Console.WriteLine($"Name: {item.Key}, Phone: {item.Value}");
                        }
                        Console.WriteLine("Press any key to return to the menu");
                        Console.ReadKey();
                        break;

                    case 5:
                        Console.WriteLine("Updating a contact...");
                        Console.Write("Type the name of the contact that you want to Update: ");
                        name = Console.ReadLine();
                        if (contacts.ContainsKey(name))
                        {
                            
                            Console.Write("Type the new phone number: ");
                            phoneNumber = Convert.ToInt64(Console.ReadLine());
                            contacts[name] = phoneNumber;
                        }
                        else
                        {
                            Console.WriteLine($"The contact ({name}) is not in your contacts list");
                        }
                        Console.WriteLine("Press any key to return to the menu");
                        Console.ReadKey();
                        break;


                }

            } while (flag);
        }

    }
}
