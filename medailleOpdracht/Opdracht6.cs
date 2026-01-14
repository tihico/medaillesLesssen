using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medailleOpdracht
{
    internal class Opdracht6
    {
        public void Start()
        {
            Random rand = new Random();
            int maxGetal = 11;
            int minGetal = 1;
            int failedGuess = 0;
            bool guessWin = false;
            int guessTheNumber = rand.Next(minGetal, maxGetal);
            Console.WriteLine(guessTheNumber);
            Console.WriteLine($"RAAD HET NUMMER! {minGetal}-{maxGetal-1}");
            
            while (true && !guessWin)
            {
                int userGuess = Convert.ToInt32(Console.ReadLine());
                if (userGuess > maxGetal - 1)
                {
                    failedGuess = failedGuess + 1;
                    Console.WriteLine($"Dat nummer is hoger dan de maximale! raad nog een keer {failedGuess} Failed Guesses");
                   
                }
                 else if (userGuess > guessTheNumber && userGuess <= 10)
                 {
                     failedGuess = failedGuess + 1;
                     Console.WriteLine($"GUESS LOWER!!!   {failedGuess} Failed Guesses");
                     
                 }
                 else if (userGuess < guessTheNumber && userGuess > 0)
                 {
                     failedGuess = failedGuess + 1;
                     Console.WriteLine($"GUESS HIGHER!!! {failedGuess} Failed Guesses");
                
                 }
                 else if (userGuess < minGetal)
                 {
                     failedGuess = failedGuess + 1;
                     Console.WriteLine($"Dat nummer is lager dan de minimale!    {failedGuess} Failed Guesses");
               
                 }
                else if (userGuess == guessTheNumber)
                {
                    Console.WriteLine("YOU WIN!");
                    guessWin = true;
                }
            }
        }
    }
}
