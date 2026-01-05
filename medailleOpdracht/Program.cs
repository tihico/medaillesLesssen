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
        public static DateTime Now { get; }


        static void Main(string[] args)
        {
            Random rand = new Random();
            bool admin = false;
            Console.WriteLine("Als je een account wil maken schrijf een naam");
            for (int i = 0; i <= 100; i++)
            
                {
                    int result = 0;
                    result = rand.Next(1, 7);
                    Console.WriteLine(result);
                }
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
            }
             
        }
     

    }
    



