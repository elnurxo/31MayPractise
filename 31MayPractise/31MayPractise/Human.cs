using System;
using System.Collections.Generic;
using System.Text;

namespace _31MayPractise
{
    internal class Human
    {
        public Human(string fullname)
        {
            Name = fullname.Substring(0, fullname.IndexOf(' '));
            Surname = fullname.Substring(fullname.IndexOf(' ') + 1);
        }

        public string Name;
        public string Surname;
        public byte Age; 
        
        public string GeneratePassword()
        {
            int currentYear = 2022;

            string password = Name.Substring(0, 2).ToUpper() + Surname.Substring(0, 2).ToUpper() + (currentYear - Age);

            return password;
        }
    }
}
