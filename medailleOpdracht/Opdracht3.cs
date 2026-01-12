using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medailleOpdracht
{
    internal class Opdracht3
    {
        public void Start()
        {
            Console.WriteLine("Wat weer is het?");
            Console.WriteLine("Zonnig");
            Console.WriteLine("Regen");
            Console.WriteLine("Bewolkt");
            string userInput1 = (Console.ReadLine());
            if (userInput1 == "Zonnig")
            {
                Console.WriteLine("Wat temperatuur is het?");
                int userInputTemperature = Convert.ToInt32(Console.ReadLine());
                if (userInputTemperature >= 20)
                {
                    Console.WriteLine("Geniet van de lekkere zon zonder een jas aan");
                }
                else if (userInputTemperature >= 10) { Console.WriteLine("Je hebt wel echt een jas nodig, het is koud"); };
            }
            if (userInput1 == "Regen")
            {
                Console.WriteLine("Neem een paraplu mee!");
            }
            if (userInput1 == "Bewolkt") { Console.WriteLine("Jammer, dan kan je de zon niet zien vaak"); }
        }


    }
}
