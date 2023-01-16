/*This program was developed by Emiliano Duque Padilla
 * 
 * This is a Tic-Tac-Toe game, also known as "Triqui" in spanish. 
 * 
 * This is to be played by 2 players. The program will ask the players what symbol is the first one to start and the user will be able to select beteween "o" or "x". Be aware that at this point it is case sensitive, so please only use lower case letters.
 * 
*/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriquiProj
{
    internal class Program
    {

        static void Main(string[] args)
        {
            bool resultado = true;
            string linea, turno = "";
            byte fila, columna;

            // Declare the matrix 3x3
            string[,] ttt = new string[3, 3];
        

            

            // Inicialize the matrix
            for (byte f = 0; f < 3; f++)
            {
                for (byte c = 0; c < 3; c++)
                {
                    ttt[f, c] = "_";
                }
            }


            // here I select what symbol to use
            do
            {
                Console.WriteLine("Which symbol do you want to start with? \"o\" \"x\"");
                linea = Console.ReadLine();
                if (linea == "o" || linea == "x")
                {
                    turno = linea;
                    resultado = false;
                }
                else
                {
                    Console.WriteLine("Rember to use lower case letters \"o\" \"x\" ");
                    Console.Clear();
                }
            } while (resultado);


            // here is the main cycle
            bool ended = true;
            byte counter = 1;
            while (ended)
            {
                //counter++;
                
                Console.WriteLine("\nThis is the turn of \"{0}\"", turno);

                

                //Ask for the row
                resultado = true;
                if (counter == 1)
                {
                    drawRowsColumns();
                }
                
                if (counter <= 9)
                {
                    do
                    {
                        Console.WriteLine("Select the row in which you want your symbol? 1, 2, 3");
                        fila = Convert.ToByte(Console.ReadLine());
                        if (fila < 1 || fila > 3)
                        {
                            Console.WriteLine("There are only three rows... try again");
                        }
                        else
                        {
                            resultado = false;
                        }

                    } while (resultado);

                    //Ask for the column
                    resultado = true;
                    do
                    {
                        Console.WriteLine("Select the colum in which you want your symbol? 1, 2, 3");
                        columna = Convert.ToByte(Console.ReadLine());
                        if (columna < 1 || columna > 3)
                        {
                            Console.WriteLine("There are only three columns... try again");
                        }
                        else
                        {
                            resultado = false;
                        }

                    } while (resultado);

                    if (ttt[fila - 1, columna - 1] == "_")
                    {
                        ttt[fila - 1, columna - 1] = turno;
                        counter++;

                        bool win = verifyWinner2(ttt, turno);

                        if (win == true)
                        {
                            Console.Clear();
                            Console.WriteLine("WINNER..... WINNER......WINNER..... WINNER......WINNER..... WINNER......WINNER");
                            ended = false;
                        }
                        else
                        {
                            Console.Clear();
                            //Console.Beep();
                        }

                        //Se cambia el turno
                        if (turno == "o")
                        {
                            turno = "x";
                        }
                        else
                        {
                            turno = "o";
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("This field has a value.... try again!!");
                    }

                    //This draws the matrix
                    drawMatrix(ttt);
                }
                else
                {
                    Console.WriteLine("Yo have no more trys available");
                    ended = false;
                }

            }

        }



        /* ******************************** Static Methods ********************************************** */

        static void drawRowsColumns()
        {
            Console.WriteLine("");
            Console.WriteLine("      Columns");
            Console.WriteLine("       1 2 3");
            Console.WriteLine("     1 _ _ _");
            Console.WriteLine("Rows 2 _ _ _");
            Console.WriteLine("     3 _ _ _");
            Console.WriteLine("");
        }
        static bool verifyWinner2(string[,] tttPa, string turnoPa)
        {
            /* 
             * This method si to verify no matter the position in the array. The only paratmeter it used is the symbol used at the moment it is verifying and it does it in the 8 possible directions to win.
             
             */

            bool winner = false;

            if (tttPa[0, 0] == turnoPa && tttPa[0, 1] == turnoPa && tttPa[0, 2] == turnoPa) { winner = true; }
            if (tttPa[1, 0] == turnoPa && tttPa[1, 1] == turnoPa && tttPa[1, 2] == turnoPa) { winner = true; }
            if (tttPa[2, 0] == turnoPa && tttPa[2, 1] == turnoPa && tttPa[2, 2] == turnoPa) { winner = true; }
            if (tttPa[0, 0] == turnoPa && tttPa[1, 0] == turnoPa && tttPa[2, 0] == turnoPa) { winner = true; }
            if (tttPa[0, 1] == turnoPa && tttPa[1, 1] == turnoPa && tttPa[2, 1] == turnoPa) { winner = true; }
            if (tttPa[0, 2] == turnoPa && tttPa[1, 2] == turnoPa && tttPa[2, 2] == turnoPa) { winner = true; }
            if (tttPa[0, 0] == turnoPa && tttPa[1, 1] == turnoPa && tttPa[2, 2] == turnoPa) { winner = true; }
            if (tttPa[2, 0] == turnoPa && tttPa[1, 1] == turnoPa && tttPa[0, 2] == turnoPa) { winner = true; }

            return winner;

        }

        static bool verifyWinner(string[,] tttPa, byte filaPa, byte columnaPa, string turnoPa)
        {
            /*
             * This method is can be used in case I want to verify if the symbol is currently used in making 3 in a row in any direction based the position selected.
             * For this program I decided not to use it.
             */
            byte f, c;
            bool winner = false;

            f = (byte)(filaPa - 1);
            c = (byte)(columnaPa - 1);

            switch (f)
            {
                case 0:
                    if (c == 0)
                    {
                        if (tttPa[0, 1] == turnoPa && tttPa[0, 2] == turnoPa) { winner = true; }
                        if (tttPa[1, 0] == turnoPa && tttPa[2, 0] == turnoPa) { winner = true; }
                        if (tttPa[1, 1] == turnoPa && tttPa[2, 2] == turnoPa) { winner = true; }
                    }
                    if (c == 1)
                    {
                        if (tttPa[0, 0] == turnoPa && tttPa[0, 2] == turnoPa) { winner = true; }
                        if (tttPa[1, 1] == turnoPa && tttPa[2, 1] == turnoPa) { winner = true; }
                    }
                    if (c == 2)
                    {
                        if (tttPa[0, 0] == turnoPa && tttPa[0, 1] == turnoPa) { winner = true; }
                        if (tttPa[1, 2] == turnoPa && tttPa[2, 2] == turnoPa) { winner = true; }
                        if (tttPa[1, 1] == turnoPa && tttPa[2, 0] == turnoPa) { winner = true; }
                    }
                    break;

                case 1:
                    if (c == 0)
                    {
                        if (tttPa[0, 0] == turnoPa && tttPa[2, 0] == turnoPa) { winner = true; }
                        if (tttPa[1, 1] == turnoPa && tttPa[1, 2] == turnoPa) { winner = true; }
                    }
                    if (c == 1)
                    {
                        if (tttPa[0, 1] == turnoPa && tttPa[2, 1] == turnoPa) { winner = true; }
                        if (tttPa[1, 0] == turnoPa && tttPa[1, 2] == turnoPa) { winner = true; }
                        if (tttPa[0, 0] == turnoPa && tttPa[2, 2] == turnoPa) { winner = true; }
                        if (tttPa[0, 2] == turnoPa && tttPa[2, 0] == turnoPa) { winner = true; }
                    }
                    if (c == 2)
                    {
                        if (tttPa[1, 0] == turnoPa && tttPa[1, 1] == turnoPa) { winner = true; }
                        if (tttPa[0, 2] == turnoPa && tttPa[2, 2] == turnoPa) { winner = true; }
                    }
                    break;

                case 2:
                    if (c == 0)
                    {
                        if (tttPa[2, 1] == turnoPa && tttPa[2, 2] == turnoPa) { winner = true; }
                        if (tttPa[1, 0] == turnoPa && tttPa[0, 0] == turnoPa) { winner = true; }
                        if (tttPa[1, 1] == turnoPa && tttPa[0, 2] == turnoPa) { winner = true; }
                    }
                    if (c == 1)
                    {
                        if (tttPa[2, 0] == turnoPa && tttPa[2, 2] == turnoPa) { winner = true; }
                        if (tttPa[1, 1] == turnoPa && tttPa[0, 1] == turnoPa) { winner = true; }
                    }
                    if (c == 2)
                    {
                        if (tttPa[2, 0] == turnoPa && tttPa[2, 1] == turnoPa) { winner = true; }
                        if (tttPa[1, 2] == turnoPa && tttPa[0, 2] == turnoPa) { winner = true; }
                        if (tttPa[1, 1] == turnoPa && tttPa[0, 0] == turnoPa) { winner = true; }
                    }
                    break;
            }
            return winner;

        }

        static void drawMatrix(string[,] tttPa)
        {

            string[,] ensayis = new string[5, 12] { {" ", " ", " ", " ", " ", "C", "o", "l", "u", "m", "n", "s" },
                                                    {" ", " ", " ", " ", " ", " ", "1", " ", "2", " ", "3", " " },
                                                    {" ", " ", " ", " ", "1", " ", "_", " ", "_", " ", "_", " " },
                                                    {"R", "o", "w", "s", "2", " ", "_", " ", "_", " ", "_", " " },
                                                    {" ", " ", " ", " ", "3", " ", "_", " ", "_", " ", "_", " " } };

            Console.WriteLine("");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    if (i == 2 && j == 6) { ensayis[i, j] = tttPa[0, 0]; }
                    if (i == 2 && j == 8) { ensayis[i, j] = tttPa[0, 1]; }
                    if (i == 2 && j == 10) { ensayis[i, j] = tttPa[0, 2]; }
                    if (i == 3 && j == 6) { ensayis[i, j] = tttPa[1, 0]; }
                    if (i == 3 && j == 8) { ensayis[i, j] = tttPa[1, 1]; }
                    if (i == 3 && j == 10) { ensayis[i, j] = tttPa[1, 2]; }
                    if (i == 4 && j == 6) { ensayis[i, j] = tttPa[2, 0]; }
                    if (i == 4 && j == 8) { ensayis[i, j] = tttPa[2, 1]; }
                    if (i == 4 && j == 10) { ensayis[i, j] = tttPa[2, 2]; }

                    Console.Write(ensayis[i, j]);

                }
                Console.WriteLine("");
            }

        }
    }

}

