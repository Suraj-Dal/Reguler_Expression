using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace RegexProblems
{
    public class RegExpresion
    {
        const string FNAME = "^[A-Z]{1}[a-z]{2,}$";
        const string LNAME = "^[A-Z]{1}[a-z]{2,}$";
        public void RegexFirstNameChecker(string firstName)
        {
            if (Regex.IsMatch(firstName, FNAME))
            {
                Console.WriteLine("First name is valid.");
                return;
            }
            Console.WriteLine("First name is not valid.");
        }
        public void RegexLastNameChecker(string lastName)
        {
            if (Regex.IsMatch(lastName, LNAME))
            {
                Console.WriteLine("Last name is valid.");
                return;
            }
            Console.WriteLine("Last name is not valid.");
        }
    }
}
