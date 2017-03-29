using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squaring_Cubing
{
    class Program
    {
        public static int NumberSquared(int num)
        {
            int square = num * num;
            Console.WriteLine("Square: " + square);
            return square;
        }
       
        public static int NumberCubed(int num)
        {
            int cube = num * num * num;
            Console.WriteLine("Cube: " + cube);
            return cube;
        }

        public static bool Continue()
        {
            Console.WriteLine("Continue? (y/n)");
            string input = Console.ReadLine();
            input.ToLower();
            bool run;

            if (input == "n")
            {
                Console.WriteLine("Goodbye!");
                run = false;
            }
            else if (input == "y")
            {
                run = true;
            }
            else
            {
                Console.WriteLine("Sorry, that is not a vaild input.");
                run = Continue();
            }
            return run;
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter the number you would like to square and cube: ");
            int num = int.Parse(Console.ReadLine());

            bool run = true;


            for (int i = 0; i <= num; i++)
            {
                Console.WriteLine($"The cube and square of {i} is: ");
                NumberSquared(i);
                NumberCubed(i);
               
            }
            run = Continue();

        }
    }
}
