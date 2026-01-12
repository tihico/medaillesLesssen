using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medailleOpdracht
{
    internal class Opdrachtweetniet
    {
     
    
    
        private string _name;
        private int _hp;
        private int _level;
        
        public Opdrachtweetniet(string name, int hp, float WalkSpeed, Boolean IsAlive)
        {
            _name = name;
            _hp = hp;

            Console.WriteLine($"hoi mijn naam is {_name} ");
        }

        public void TakeDamage(int damageAmount)
        {
            Console.WriteLine($"i lost {damageAmount}");
            _hp -= damageAmount;
            Console.WriteLine($"i have this amount of hp left {_hp}");
        }
    } }
