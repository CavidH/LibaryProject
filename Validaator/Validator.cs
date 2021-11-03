using System.Text.RegularExpressions;
using MyException;

namespace Validaator
{
    public class Validator
    {
        public bool NameValiidator(string name)
        {
            bool result = Regex.IsMatch(name.ToLower(), @"^[a-zA-Z]+$");

            if (result)
            {
                return result;
                
            }
            else
            {
                throw new MyExeption("Name is invaid");
            }
        }
        public bool SurNameValiidator(string name)
        {
            bool result = Regex.IsMatch(name.ToLower(), @"^[a-zA-Z]+$");

            if (result)
            {
                return result;

            }
            else
            {
                throw new MyExeption("Surname is invaid");
            }
        }
    }
}