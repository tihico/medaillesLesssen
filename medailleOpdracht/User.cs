using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medailleOpdracht
{
    internal class User
    {
        private string _name;
        private string _password;
        private int _age;
        private int _id;
        private bool _admin;

        public User(string name, string password, int age, int id, bool admin)
        {
            _name = name;
            _password = password;
            _age = age;
            _id = id;
            _admin = admin;

            Console.WriteLine($"User: {_name} with password: {_password} and age{_age} has been made!");
        }
        public void Login()
        {
            Console.Clear();
            if (_admin)
            {
                Console.WriteLine($"Hoi admin {_admin} welcome");
            }
            else
            {

                Console.WriteLine($"Hoi gebruiker {_name} welcome");
            }
        }
    }
}