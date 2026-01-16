using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medailleOpdracht
{
    internal class Opdracht4
    {


        public void Start()
        {
            // Ask user year of birth
            // Ask if their birthday already happened Yes or no
            // if yes = currentyear - yearofbirth
            // if no = currentyear - yearofbirth -1;

            int yearOfNow = 2026;
            int monthOfNow = 1;
            int dayOfNow = 16;
            bool thirtyonedaymonth = false;
            bool februarymonth = false;
            bool leapYear = false;
            Console.WriteLine("Voer je geboortedatum in");
            int geboorteDag = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Voer je geboortemaand in");
            int geboorteMaand = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Voer je geboorteJaar in");
            int geboorteJaar = Convert.ToInt32(Console.ReadLine());

            int hoeOudJaar = yearOfNow - geboorteJaar;
            int hoeOudMaand = monthOfNow - geboorteMaand;
            bool negative = hoeOudMaand < 0;
            
            int hoeOudDag = dayOfNow - geboorteDag;
            bool negativeDays = hoeOudDag < 0;
            if (hoeOudMaand == 1 || hoeOudMaand == 3 || hoeOudMaand == 5 || hoeOudMaand == 7 || hoeOudMaand == 8 || hoeOudMaand == 9 || hoeOudMaand == 10 || hoeOudMaand == 12)
            {
                thirtyonedaymonth = true;
            }
            if (hoeOudMaand == 2)
            { februarymonth = true; }
            else if (hoeOudJaar == 2004 || hoeOudJaar == 2008 || hoeOudJaar == 2012 || hoeOudJaar == 2016 || hoeOudJaar == 2020 || hoeOudJaar == 2024)
            {
                leapYear = true;
            }



            if (negative) { hoeOudJaar = hoeOudJaar - 1; hoeOudMaand = hoeOudMaand + 12 - 1; }
            
            { hoeOudMaand = hoeOudMaand + 1; }
            if (negativeDays) { hoeOudMaand = hoeOudMaand - 1; hoeOudDag = hoeOudDag + 30; }
            else if (negativeDays && februarymonth) { hoeOudMaand = hoeOudMaand - 1; hoeOudDag += 28; }
            else if (negativeDays && thirtyonedaymonth) { hoeOudMaand = hoeOudMaand - 1; hoeOudDag += 31; }
            else if (negativeDays && leapYear) {  hoeOudMaand -= 1; hoeOudDag -= 31; }
                Console.WriteLine($"{hoeOudJaar} {hoeOudMaand} {hoeOudDag} ");


            if (geboorteDag <= 16 && geboorteMaand <= 1 && geboorteJaar <= 2008)
            {
                Console.WriteLine("Je bent ouder dan 18");
            }

        }

    }
}
