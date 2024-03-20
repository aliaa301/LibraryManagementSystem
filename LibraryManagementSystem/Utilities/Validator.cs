using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.ExtensionMethods
{
    
    
        static class Validator
        {
        public static int GetValidPublicationYear()
        {
            int publicationYear;
            while (true)
            {
                Console.Write("Enter publication year: ");
                if (int.TryParse(Console.ReadLine(), out publicationYear) && publicationYear > 0 && publicationYear <= DateTime.Now.Year)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid publication year that is not in the future.");
                }
            }
            return publicationYear;
        }
        public static string GetNonEmptyInput(string prompt)
        {
            string input;
            while (true)
            {
                Console.Write(prompt);
                input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Input cannot be empty.");
                }
            }
            return input;
        }
        public static int GetValidId()
        {
            int id;
            while (true)
            {
                Console.Write("Enter the ID: ");
                if (int.TryParse(Console.ReadLine(), out id) && id > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid ID.");
                }
            }
            return id;
        }

    }
}

      