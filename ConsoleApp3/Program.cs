using System;
using ConsoleApp3.Model;
using MyException;
using Validaator;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ad daxil edin:");
            string Name = Console.ReadLine();
            Console.Write("soyad daxil edin:");
            string SurName = Console.ReadLine();
            Validator validator = new Validator();
            try
            {
            if (validator.NameValiidator(Name)&&validator.SurNameValiidator(SurName))
                        {
                            User user = new User(Name, SurName);
                            Console.WriteLine(user.Info());
                        }
            }
            catch (MyExeption myExeption)
            {
                Console.WriteLine(myExeption.Message); 
            }
            
            


        }
    }
}