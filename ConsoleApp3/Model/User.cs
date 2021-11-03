using System;

namespace ConsoleApp3.Model
{
    public class User
    {
        public string Name { get; set; } 
        public string SurName { get; set; }

        public User(string name, string surName)
        {
            Name = name;
            SurName = surName;
            
        }

        public string Info()
        {
            return $"Name:{Name}\nSurname:{SurName} ";
        }
    }
}