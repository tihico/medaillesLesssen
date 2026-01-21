using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medailleOpdracht
{
    internal class Opdracht9
    {
        public void Start()
        {
           Weapon goudenPrikker = new Weapon("Gouden Prikker", 10);
            Weapon glock = new Weapon("Glock", 20);
            Weapon speer = new Weapon("Speer", 30);
            goudenPrikker.ShowStats();
            glock.ShowStats();
            speer.ShowStats();
            goudenPrikker.UpgradeWeapon(22);
            goudenPrikker.ShowStats();
        }
    }
    public class Weapon
    {
        private string _name;
        private int _damage;
        public Weapon(string name, int damage)
        {
            _name = name;
            _damage = damage;

        }
        public void ShowStats()
        {
            Console.WriteLine($"Name:{_name} Damage:{_damage}");
           // UpgradeWeapon(12);
           // Console.WriteLine($"Name:{_name} Damage:{_damage}");
        }

        public void UpgradeWeapon(int damageToAdd)
        {
            
            _damage += damageToAdd;
        }
    }
}     
