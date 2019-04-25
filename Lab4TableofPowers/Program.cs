using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4TableofPowers
{
    class Program
    {
        static void Main(string[] args)
        {

            string response = "y";

            while (response == "y")
            {
                Console.WriteLine("Welcome to numbers, squares, and cubes!");
                Console.WriteLine("Please enter an integer.");
                int input = int.Parse(Console.ReadLine());

                Console.WriteLine("Number\t" + "Squared\t" + "Cube\t");
                Console.WriteLine("=======\t" + "=======\t" + "=======\t");

                for (int i = 1; i <= input; i++)
                {

                    Console.WriteLine($"{ +i}\t{ i * i }\t{ i * i * i }\t");
                }
                Console.WriteLine("Would you like to continue? y or n");
                response = Console.ReadLine();
            }
            Console.WriteLine("Have a great day!");
        }
    }
}
