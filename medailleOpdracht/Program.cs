using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace medailleOpdracht
{

    internal class Program
    {
        


        static void Main(string[] args)
        {
            Opdracht1 opdracht = new Opdracht1();
            opdracht.Start();
            /*
            Random rand = new Random();
            bool admin = false;
            Console.WriteLine("Als je een account wil maken schrijf een naam");
          
                string userInput = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Nu type je password in");
                string userInputPassword = Console.ReadLine();
                Console.Clear();
                
                Console.WriteLine("Nu typ in hoe oud je bent");
                int userAge = Convert.ToInt32(Console.ReadLine());
                if (userInput.ToLower() == "de ei man")
                {
                    {
                        admin = true;
                    }
                }
                User user1 = new User(userInput, userInputPassword, 25, 1, admin);
                user1.Login();
            */
            }
             
        }
     

    }
    



