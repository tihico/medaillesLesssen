using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medailleOpdracht
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            double i = 0.000000000000000000000000000000000000000000000000001;
            Console.WriteLine("Hello world!");
            Console.WriteLine("What is your name?");
            string input = Console.ReadLine();
            Console.WriteLine(input);
            if (input == "im 4 years old")
            {
                Console.WriteLine("you are the youngest person EVER");

            }
            else
            {
                Console.WriteLine("wow your name is", Console.ReadLine());
            }
            do
            {
                i = i + i;
            }
            while (true);
            {
                i = i + i;
                Console.WriteLine("will this crash?");
                Console.WriteLine(i);

            }
            Console.WriteLine("ja");
            bool running = true;
            int[] numbers = new int[] {
                1,
                2,
                3,
                4,
                5,
                6,
                7,
                8,
                9,
                10

            };
            foreach(int numbers in numbers)
            {
                Console.WriteLine; a
            }
        }
    }
