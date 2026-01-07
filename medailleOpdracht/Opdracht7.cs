using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medailleOpdracht
{


    internal class Opdracht7
    {
        public void Start()
        {
            Random rand = new Random();
            float numberone = 0;
            float numbertwo = 0;
            float numberthree = 0;
            float numberfour = 0;
            float numberfive = 0;
            float numbersix = 0;
            int diceroll = 0;
            float totaldice = 0;
            for (int i = 1; i <= 100; i++)
            {
                diceroll = rand.Next(1, 7);
                if (diceroll == 1) { numberone = numberone + 1; }
                if (diceroll == 2) { numbertwo = numbertwo + 1; }
                if (diceroll == 3) { numberthree = numberthree + 1; }
                if (diceroll == 4) { numberfour = numberfour + 1; }
                if (diceroll == 5) { numberfive = numberfive + 1; }
                if (diceroll == 6) { numbersix = numbersix + 1; }
                Console.WriteLine(diceroll);
            }
            Console.WriteLine($" 1 has been written {numberone} times");
            Console.WriteLine($" 2 has been written {numbertwo} times");
            Console.WriteLine($" 3 has been written {numberthree} times");
            Console.WriteLine($" 4 has been written {numberfour} times");
            Console.WriteLine($" 5 has been written {numberfive} times");
            Console.WriteLine($" 6 has been written {numbersix} times");
            totaldice = (numberone + numbertwo*2 + numberthree*3 + numberfour*4 + numberfive*5 + numbersix*6) / 100;
            Console.WriteLine($"The average of all dice rolls added up is {totaldice}");
        }

    }
}
