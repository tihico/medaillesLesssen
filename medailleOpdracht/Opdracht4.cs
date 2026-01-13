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
            long EpochTime = 63935421552L;
            Console.WriteLine("Voer je geboortedatum in");
            int geboorteDag = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Voer je geboortemaand in");
            int geboorteMaand = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Voer je geboorteJaar in");
            int geboorteJaar = Convert.ToInt32(Console.ReadLine());

            long totaalSecondenGeboorte = ((geboorteDag * 86400L) + (geboorteMaand * 2629746L - 1*geboorteMaand) + (geboorteJaar * 31536000L));
            long verschilInSeconden = EpochTime - totaalSecondenGeboorte;
            long hoeOud = verschilInSeconden / 31536000L;
            Console.WriteLine(hoeOud);


        }

    }
}
