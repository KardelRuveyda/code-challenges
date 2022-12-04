using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01EmailValidation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the email address you'd like to validate: ");
            var input = Console.ReadLine();

            //Validate Function
            ValidateEmail(input);
            Console.ReadKey();
        }

        public static void ValidateEmail(string email)
        {
            //Step 1
            char first = email[0];
            string atSymbol = "@";
            string dotCom = ".com";

            //Step 2

            if (Char.IsNumber(first) || Char.IsSymbol(first))
            {
                Console.WriteLine("\nSorry , emails can't start with numbers or symbols!!!");
                return;
            }

            //Step 3 

            if (!email.Contains("@"))
            {
                Console.WriteLine("\nYou have to include an '@' character!!");
                return;
            }

            //Step 4 

            if (email.Substring(email.Length - 4) != dotCom)
            {
                Console.WriteLine("\n You must use '.com' at the end");
            }

            //Step 5

            Console.WriteLine("\nEmail is valid.");
        }
    }
}
