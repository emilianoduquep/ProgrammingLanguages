using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyExpenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            int opt;
            string description;
            double amount;
            double total = 0;


            Dictionary<string, double> dailyExpenses = new Dictionary<string, double>(); 

            do
            {
                Console.Clear();

                Console.WriteLine("1. Enter a new expense");
                Console.WriteLine("2. Show the expenses");
                Console.WriteLine("0. Exit");

                opt = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (opt)
                {
                    case 0:
                        Console.WriteLine("Exit the aplication");
                        flag = false;
                        break;

                    case 1:
                        Console.Write("Type the expense description: ");
                        description = Console.ReadLine();
                        Console.Write("Type the amount you spent: $");
                        amount = Convert.ToDouble(Console.ReadLine());

                        dailyExpenses.Add(description, amount);

                        Console.WriteLine("press any key to go back to the menu");
                        Console.ReadKey();
                        break;

                    case 2:
                        

                        foreach (KeyValuePair<string, double> item in dailyExpenses)
                        {
                            Console.WriteLine($"{item.Key}: ${item.Value}");
                            
                            total = total + item.Value;
                        }

                        Console.WriteLine($"You have spent: ${total}");
                        Console.WriteLine("press any key to go back to the menu");
                        Console.ReadLine();
                        break;
                }


            } while (flag);
        }
    }
}
