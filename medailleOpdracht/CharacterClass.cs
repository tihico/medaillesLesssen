using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medailleOpdracht
{
    internal class CharacterClass
    {
     
    
    
        private string _name;
        private int _hp;
        public CharacterClass(string name, int hp, float WalkSpeed, Boolean IsAlive)
        {
            _name = name;
            _hp = hp;

            Console.WriteLine($"hoi mijn naam is {_name} ");
        }
        public void SayHello()
        {
            Console.WriteLine("hallo 1");
        }

        public void TakeDamage(int damageAmount)
        {
            Console.WriteLine($"i lost {damageAmount}");
            _hp -= damageAmount;
            Console.WriteLine($"i have this amount of hp left {_hp}");
        }
    } }
