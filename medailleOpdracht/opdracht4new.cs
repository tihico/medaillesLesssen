using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medailleOpdracht
{
    internal class opdracht4new
    {
        public void Start()
        {
            int currentYear = 2026;
            int leeftijd = 0;
            Console.WriteLine("What year were you born?");

            int geboorteJaar = Convert.ToInt32(Console.ReadLine());
            leeftijd = currentYear - geboorteJaar;
            Console.Clear();
            Console.WriteLine("Has it already been your birthday?");
            Console.WriteLine("Yes");
            Console.WriteLine("No");
            string Birthday = Console.ReadLine();
            if(Birthday.ToLower() == "yes" && geboorteJaar >= 18 ) { Console.WriteLine("Je mag stemmen"); }
            if (Birthday.ToLower() == "yes")
            {
                Console.WriteLine($"Je bent {leeftijd}");
            }
            else if (Birthday.ToLower() == "no")
            {
                leeftijd -= 1;
                Console.WriteLine($"Je bent {leeftijd}");
            }
            CheckVotingAge(leeftijd);
        }

        public void CheckVotingAge(int leeftijd)
        {
            if (leeftijd >= 18)
            {
                Console.WriteLine("Je mag stemmen");
            }
            else if(leeftijd < 18) { Console.WriteLine("Je mag niet stemmen"); }
        }
    }
}
    
