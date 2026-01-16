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
            Console.WriteLine("What year were you born?");
            int geboorteJaar = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Has it already been your birthday?");
            Console.WriteLine("Yes");
            Console.WriteLine("No");
            string Birthday = Console.ReadLine();
            if (Birthday.ToLower() == "yes")
            {
                Console.WriteLine($"Je bent {2026 - geboorteJaar}");
            }
            else if (Birthday.ToLower() == "no")
            {
                Console.WriteLine($"Je bent {2026 - geboorteJaar - 1}");
            }
            }
        }
        }
    
