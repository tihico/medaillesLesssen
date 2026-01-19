using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace medailleOpdracht
{
    internal class Opdracht8
    {
        
     
        public void Start()
        {
            //  Console.WriteLine($"{_name} {_level} {_hp} {_lives}");
            Character Speler1 = new Character("Speler1", 5, 100, 3);
            Speler1.ShowStats();
        }
    }

    public class Character
    {
        private string _name;
        private int _level;
        private float _hp;
        private int _lives;
        public Character(string name, int level, float hp, int lives)
        {
            _name = name;
            _level = level;
            _hp = hp;
            _lives = lives;

        }
        public void ShowStats()
        {
            Console.WriteLine($"{_name} {_level} {_hp} {_lives}");
        }
    }


}
