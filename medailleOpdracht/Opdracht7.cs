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
            float numberOne = 0;
            float numberTwo = 0;
            float numberThree = 0;
            float numberFour = 0;
            float numberFive = 0;
            float numberSix = 0;
            int diceRoll = 0;
            float totalDice = 0;
            for (int i = 1; i <= 100; i++)
            {
                diceRoll = rand.Next(1, 7);
                if (diceRoll == 1) { numberOne = numberOne + 1; }
                if (diceRoll == 2) { numberTwo = numberTwo + 1; }
                if (diceRoll == 3) { numberThree = numberThree + 1; }
                if (diceRoll == 4) { numberFour = numberFour + 1; }
                if (diceRoll == 5) { numberFive = numberFive + 1; }
                if (diceRoll == 6) { numberSix = numberSix + 1; }
                Console.WriteLine(diceRoll);
            }
            Console.WriteLine($" 1 has been written {numberOne} times");
            Console.WriteLine($" 2 has been written {numberTwo} times");
            Console.WriteLine($" 3 has been written {numberThree} times");
            Console.WriteLine($" 4 has been written {numberFour} times");
            Console.WriteLine($" 5 has been written {numberFive} times");
            Console.WriteLine($" 6 has been written {numberSix} times");
            totalDice = (numberOne + numberTwo*2 + numberThree*3 + numberFour*4 + numberFive*5 + numberSix*6) / 100;
            Console.WriteLine($"The average of all dice rolls added up is {totalDice}");
        }

    }
}
