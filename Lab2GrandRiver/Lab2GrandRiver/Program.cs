using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2GrandRiver
{
    class Program
    {
        static void Main(string[] args)
        {
            double Length = 0;
            double Width = 0;
            string Continue = "y";

            while (Continue == "y")
            {
                Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");
                Console.WriteLine("Enter Length: ");
                Length = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter Width: ");
                Width = double.Parse(Console.ReadLine());
                Console.WriteLine("Area: " + (Length * Width));
                Console.WriteLine("Perimeter: " + (Length * 2 + Width * 2));
                Console.WriteLine("Continue? (y/n)");
                Continue = Console.ReadLine();
                Continue.ToLower();
            }

        }
    }
}
