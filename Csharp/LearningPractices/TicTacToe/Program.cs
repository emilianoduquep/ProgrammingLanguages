using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            startingMethod();
        }

        static void startingMethod()
        {
            // this is the possible array we are going to have at the endo of the game
            string[,] triqui = new string[,] { {"o", "x", "o"}, 
                                               {"o", "o", "x"}, 
                                               {"o", "x", "x"} };

            string result = "No Winner";
            
                result =verifyForWinner(triqui);
            Console.WriteLine(result);

        }

        static string verifyForWinner(string[,] triqui)
        {
            string token = "o";
            string resp = "No winner";

            if(triqui[0, 0].Equals(token) && triqui[0, 1].Equals(token) && triqui[0, 2].Equals(token) )
            {
                resp = "Winner";
                
            }
            if (triqui[1, 0].Equals(token) && triqui[1, 1].Equals(token) && triqui[1, 2].Equals(token))
            {
                resp = "Winner";

            }
            if (triqui[2, 0].Equals(token) && triqui[2, 1].Equals(token) && triqui[2, 2].Equals(token))
            {
                resp = "Winner";

            }
            if (triqui[0, 0].Equals(token) && triqui[1, 0].Equals(token) && triqui[2, 0].Equals(token))
            {
                resp = "Winner";

            }
            if (triqui[0, 1].Equals(token) && triqui[1, 1].Equals(token) && triqui[2, 1].Equals(token))
            {
                resp = "Winner";

            }
            if (triqui[0, 2].Equals(token) && triqui[1, 2].Equals(token) && triqui[2, 2].Equals(token))
            {
                resp = "Winner";

            }
            if (triqui[0, 0].Equals(token) && triqui[1, 1].Equals(token) && triqui[2, 2].Equals(token))
            {
                resp = "Winner";

            }
            if (triqui[2, 0].Equals(token) && triqui[1, 1].Equals(token) && triqui[0, 2].Equals(token))
            {
                resp = "Winner";

            }
            return resp;
        }
    }
}
