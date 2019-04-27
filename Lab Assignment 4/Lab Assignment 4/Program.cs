using System;


namespace Lab_Assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double ticketPrices = 0;
            double snackPrices = 0;

            Console.WriteLine("Would you like to go in the evening?");
            bool evening = Console.ReadLine().ToLower()[0] == 'y';

            Console.WriteLine("How many children tickets?");
            int children = int.Parse(Console.ReadLine());


            Console.WriteLine("How many Adult tickets?");
            int Adult = int.Parse(Console.ReadLine());


            Console.WriteLine("How many Senior tickets?");
            int Senior = int.Parse(Console.ReadLine());


            Console.WriteLine("How many small sodas would you like?");
            int smallSoda = int.Parse(Console.ReadLine());


            Console.WriteLine("How many large soda's would you like?");
            int largeSoda= int.Parse(Console.ReadLine());


            Console.WriteLine("How many Hot Dogs's would like?");
            int hotDog = int.Parse(Console.ReadLine());


            Console.WriteLine("How many Popcorns would you like?");
            int popCorn = int.Parse(Console.ReadLine());


            Console.WriteLine("How many candies would you like?");
            int candy = int.Parse(Console.ReadLine());

            if (evening)
            {
                ticketPrices = children * 6.99;
                ticketPrices += Adult * 10.99;
                ticketPrices += Senior * 8.50;

            }
            else
            {
                ticketPrices= children * 3.99;
                ticketPrices += Adult *5.99;
                ticketPrices += Senior *4.50;
            }         

            snackPrices += smallSoda * 3.50;
            snackPrices += largeSoda * 5.99;
            snackPrices += hotDog * 3.99;
            snackPrices += popCorn * 4.50;
            snackPrices += candy * 1.99;

            ticketPrices -= Math.Min(popCorn, largeSoda) * 2;

            if (children + Adult + Senior >= 3 && evening) snackPrices -= 4.50;

           snackPrices -= 1.99 * Math.Floor(candy / 4d);

            System.Console.WriteLine(snackPrices + ticketPrices);
            System.Console.ReadKey();
        }
    }
}
