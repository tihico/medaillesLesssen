using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medailleOpdracht
{
    internal class Opdracht5
    {
        public void Start()
        {
            Console.WriteLine("typ in welke tafel je wilt");

            int userInput1 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("nu typ in de 2de getal hoe lang de tafel door gaat");
            int userInput2 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            for (int i = 1; i <= userInput2; i++)
            {
                int userCalculated = userInput1 * i;
                Console.WriteLine($"{userInput1} * {i} = {userCalculated}");
            }
        }
    }
}
