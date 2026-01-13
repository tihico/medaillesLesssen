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
            // Klaar
            Console.WriteLine("Wat weer is het?");
            Console.WriteLine("Zonnig");
            Console.WriteLine("Regen");
            Console.WriteLine("Bewolkt");
            string userInput1 = (Console.ReadLine());
            if (userInput1.ToLower() == "zonnig")
            {
                Console.WriteLine("Wat temperatuur is het?");
                int userInputTemperature = Convert.ToInt32(Console.ReadLine());
                if (userInputTemperature >= 20)
                {
                    Console.WriteLine("Geniet van de lekkere zon zonder een jas aan");
                }
                else if (userInputTemperature <= 19) { Console.WriteLine("Je hebt wel echt een jas nodig, het is koud"); }
                
            }
            if (userInput1.ToLower() == "regen")
            {
                Console.WriteLine("Wat temperatuur is het?");
                int userInputTemperature = Convert.ToInt32(Console.ReadLine());
                if (userInputTemperature >= 20)
                {
                    Console.WriteLine("Warme regen valt! neem een paraplu mee! het kan nogsteeds fris voelen");
                }
                else if (userInputTemperature <= 19) { Console.WriteLine("Koude regen valt, het is heel koud! Jas en paraplu aan! "); }
                
            }
        
    
            if (userInput1.ToLower() == "bewolkt"){
              Console.WriteLine("Wat temperatuur is het?");
                int userInputTemperature = Convert.ToInt32(Console.ReadLine());
                if (userInputTemperature >= 20)
                {
                    Console.WriteLine("Bewolkt, maar tenminste niet koud! hoeft niet echt een jas aan");
                }
                else if (userInputTemperature <= 19) { Console.WriteLine("Je hebt wel echt een jas nodig, het is fris"); };
            }
        }
}

    }

