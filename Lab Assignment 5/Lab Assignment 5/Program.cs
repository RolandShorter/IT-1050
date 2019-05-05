using System;


namespace Lab_Assignment_5
{
        class Program
        {
            static void Main(string[] args)
            {
                string input = "";

                PrintBoard();
                int inputX = int.Parse(PromptUser());

                while (inputX < 0 || inputX > 7)
                {
                    Console.Clear();
                    PrintBoard();
                    inputX = int.Parse(PromptUser());
                }
            }

            static string PromptUser()
            {
                Console.WriteLine();
                Console.Write(" ---> ");
                return Console.ReadLine();
            }

            static void PrintBoard()
            {
                Console.WriteLine();

                for (int row = 0; row < 8; row++)
                {
                    printDivider();


                    printRow(row);
                }

                printDivider();
            }

            static void printRow(int row)
            {
                for (int col = 0; col < 8; col++)
                {
                    bool shouldHaveX = row <= 1 || row >= 6;
                    string text = shouldHaveX ? " | X" : " |  ";
                    Console.Write(text);
                }

                Console.WriteLine(" |");
            }

            static void printDivider()
            {
                Console.WriteLine(" +-------------------------------+");
            }
        }
    }