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
        const string EMAIL = "^(abc).?[a-z]{3,}[@](bl).?(co).?[a-z]{2,}$";
        const string CONTACT = "^[0-9]{1,3}[ ][789][0-9]{9}$";
        const string PASSWORD = "^[a-z A-Z 0-9]{1,}[A-Z]{1,}[a-z A-Z 0-9]{1,}[!*@#$%^&+=]?[a-z A-Z 0-9]{1,}[0-9]{1,}[a-z A-Z 0-9]{1,}$";
        const string SAMPLE = "^[0-9A-Za-z]+([._+-][0-9A-Za-z]+)*[@][0-9A-Za-z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2,3})?$";
        public void RegexFirstNameChecker(string firstName)
        {
            if (Regex.IsMatch(firstName, FNAME))
            {
                Console.WriteLine("\nFirst name is valid.");
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
        public void RegexEmailChecker(string email)
        {
            if (Regex.IsMatch(email, EMAIL))
            {
                Console.WriteLine("E-Mail id is valid.");
                return;
            }
            Console.WriteLine("E-Mail id is not valid.");
        }
        public void RegexMobileChecker(string mobile)
        {
            if (Regex.IsMatch(mobile, CONTACT))
            {
                Console.WriteLine("Mobile no. is valid.");
                return;
            }
            Console.WriteLine("Mobile no. is not valid.");
        }
        public void RegexPasswordChecker(string pass)
        {
            if (Regex.IsMatch(pass, PASSWORD))
            {
                Console.WriteLine("Password is valid.");
                return;
            }
            Console.WriteLine("Password is not valid.");
        }
        public string RegexSampleMailChecker(string sample)
        {
            if (Regex.IsMatch(sample, SAMPLE))
            {
                return "Valid";
            }
            return "Not Valid";
        }
    }
}
