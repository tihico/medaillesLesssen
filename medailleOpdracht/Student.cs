using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization.Configuration;

namespace medailleOpdracht
{
    internal class Student
    {



        private string _name;
        private int _leeftijd;
        private string _achternaam;
        private double _defense;
        

        public Student(string name, int leeftijd, string achternaam, double defense)

        {
            _name = name;
            _leeftijd = leeftijd;
            _achternaam = achternaam;
            _defense = defense;

            Console.WriteLine($"{name} {leeftijd} {achternaam} {defense}");
            
        }
    }
}
