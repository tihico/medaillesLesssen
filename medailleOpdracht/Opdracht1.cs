using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medailleOpdracht
{
    internal class Opdracht1
    {
        public void Start()
        {
            // Klaar
            Console.WriteLine("Wat is u gebruikers naam?");
            string userInput = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Nu type je password in");
            string userInputPassword = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"u gebruikers naam {userInput} en wachtwoord {userInputPassword} ");
            
            
        }
    }
}
