using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medailleOpdracht
{
    internal class Opdracht2
    {
        public void Start()
        {
            // Klaar
            // Woonkamer
            Console.WriteLine("Je bent nu in de woonkamer. Je hebt de keuze tussen 3 kamers om te zoeken voor je 19 dollar fortnite kaart");
            Console.WriteLine("Keuken");
            Console.WriteLine("Buiten");
            Console.WriteLine("De gang");
            string woonkamer = (Console.ReadLine());

            // De keuken
            if (woonkamer.ToLower() == "keuken")
            {
                Console.Clear();
                Console.WriteLine("Je bent nu in de keuken. Waar ga je nu naar toe?");
                Console.WriteLine("Woonkamer");
                Console.WriteLine("WC");
                Console.WriteLine("Achtertuin");
                string keuken = (Console.ReadLine());

                if (keuken.ToLower() == "wc")
                {
                    Console.Clear();
                    Console.WriteLine("Wat dacht je??? (Verloren)");
                }
                else if (keuken.ToLower() == "woonkamer")
                {
                    Console.Clear();
                    Console.WriteLine("Wow je bent terug. goet gedaan. (Verloren)");
                }
                else if (keuken.ToLower() == "achtertuin")
                {
                    Console.Clear();
                    Console.WriteLine("Je gaat naar de achtertuin. Je zag een trampoline en speelde erop voor 6 uren (Verloren)");
                }
            }
            // Buiten
          else if (woonkamer.ToLower() == "buiten")
            {
                Console.Clear();
                Console.WriteLine("Je bent nu in de buiten. Waar ga je nu naar toe?");
                Console.WriteLine("Buurman huis");
                Console.WriteLine("WC");
                Console.WriteLine("School");
                string Buiten = (Console.ReadLine());

                if (Buiten.ToLower() == "wc")
                {
                    Console.Clear();
                    Console.WriteLine("Alsjeblieft stop met naar de WC gaan. (Verloren)");
                }
                else if (Buiten.ToLower() == "buurman huis")
                {
                    Console.Clear();
                    Console.WriteLine("Je hebt ingebroken in de huis van je buurman en werd direct opgenomen door de politie. Goed gedaan. (Verloren)");
                }
                else if (Buiten.ToLower() == "school")
                {
                    Console.Clear();
                    Console.WriteLine("Er was niemand bij school om de deur te openen. (Verloren)");
                }
            }

            // De gang
            else if (woonkamer.ToLower() == "de gang")
            {
                Console.Clear();
                Console.WriteLine("Je bent nu in de gang. Waar ga je nu naar toe?");
                Console.WriteLine("De basement");
                Console.WriteLine("WC");
                Console.WriteLine("Trap naar boven");
                string deGang = (Console.ReadLine());

                if (deGang.ToLower() == "wc")
                {
                    Console.Clear();
                    Console.WriteLine("Ben je serieus???? (Verloren.)");
                }
                else if (deGang.ToLower() == "de basement")
                {
                    Console.Clear();
                    Console.WriteLine("Je bent nu in de basement. Je kan niet verder. (Verloren)");
                }
                else if (deGang.ToLower() == "trap naar boven")
                {
                    Console.Clear();
                    Console.WriteLine("Je bent nu een trap hoger. Waar ga je nu naar toe?");
                    Console.WriteLine("Je kamer");
                    Console.WriteLine("De zolder");
                    Console.WriteLine("WC");
                    string deTrap = Console.ReadLine();
                    if (deTrap.ToLower() == "je kamer")
                    {
                        Console.WriteLine("Je had je hele kamer gezocht. Niks. (Verloren)");
                    }
                    else if (deTrap.ToLower() == "de zolder")
                    {
                        Console.WriteLine("Nope. kan niet verder. (Verloren)");

                    }
                    else if (deTrap.ToLower() == "wc")
                    {
                        Console.WriteLine("Je hebt je 19 dollar fortnite kaart in de WC gevonden! Gewonnen! Ben je blij nu?");
                    }
                }
            }



        }
    }
}