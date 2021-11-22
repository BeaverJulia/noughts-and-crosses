using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace NoughtsAndCrosses
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            char[] board = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};
            var players = new Dictionary<int, string>();
            var nextPlayer = 1;
            var continueGame = 0;
            int row;
            var checkBoard = new CheckBoard();
            var drawOnBoard = new DrawOnBoard();

            //Get names
            Console.WriteLine("Player one name:");
            var name = Console.ReadLine();
            players.Add(1, name);
            Console.WriteLine("Player two name:");
            name = Console.ReadLine();
            players.Add(2, name);
            Console.Clear();
            Console.WriteLine("{0} and {1}, let the game begin ", players.Values.ElementAt(0),
                players.Values.ElementAt(1));
            Console.Write("Loading");
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(500);
                Console.Write(".");
            }
            //Begin game
            do
            {
                Console.Clear();
                Console.WriteLine("{0} : x vs {1} : o", players.Values.ElementAt(0), players.Values.ElementAt(1));
                if (nextPlayer % 2 == 0)
                    Console.WriteLine("{0} Your move..", players.Values.ElementAt(1));
                else
                    Console.WriteLine("{0} Your move...", players.Values.ElementAt(0));
                Console.WriteLine("\n");
                DrawBoard(board);
                row = int.Parse(Console.ReadLine());

                //Insert o or x
                if (board[row] != 'x' && board[row] != 'o')
                {
                    board=drawOnBoard.Execute(board, nextPlayer, row);
                    nextPlayer++;
                }
                else
                {
                    //there's already x or o in that row
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Try again");
                    Thread.Sleep(2000);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                }

                //check for winner
                continueGame = checkBoard.Execute(board);
            } while (continueGame != 1 && continueGame != -1);

            Console.Clear();
            DrawBoard(board);
            if (continueGame == 1)
            {
                Console.Clear();
                for (int i = 0; i < 5; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("{0} won! Congratulations", players.Values.ElementAt(nextPlayer % 2));
                    Console.ForegroundColor = ConsoleColor.White;
                    Thread.Sleep(1000);
                    Console.Clear();
                }
              
            }
            else
            {
                Console.WriteLine("Draw, try again");
            }
        }

        public static void DrawBoard(char[] board)

        {
            Console.WriteLine("   |   |   ");

            Console.WriteLine(" {0} | {1} | {2} ", board[1], board[2], board[3]);

            Console.WriteLine("___|___|___");

            Console.WriteLine("   |   |   ");

            Console.WriteLine(" {0} | {1} | {2} ", board[4], board[5], board[6]);

            Console.WriteLine("___|___|___");

            Console.WriteLine("   |   |   ");

            Console.WriteLine(" {0} | {1} | {2} ", board[7], board[8], board[9]);

            Console.WriteLine("   |   |   ");
        }
    }
}