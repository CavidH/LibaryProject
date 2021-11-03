using System;

namespace MyException
{
    public class MyExeption :Exception
    {
        public MyExeption(string message) : base(message)
        {
        }
    }
}