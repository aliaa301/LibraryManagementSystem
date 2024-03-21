using LibraryManagementSystem.ExtensionMethods;
using LibraryManagementSystem.Models;
using LibraryManagementSystem.Services.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LibraryRepository libraryRepository = new LibraryRepository();
            //Menu
            while (true)
            {
                Console.WriteLine("===== Library Management System =====");
                Console.WriteLine("1. Add a book");
                Console.WriteLine("2. Remove a book");
                Console.WriteLine("3. Display all books");
                Console.WriteLine("4. Search for a book");
                Console.WriteLine("5. Check book availability");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddBook(libraryRepository);
                        break;
                    case "2":
                        RemoveBook(libraryRepository);
                        break;
                    case "3":
                        libraryRepository.DisplayAllBooks();
                        break;
                    case "4":
                        SearchBook(libraryRepository);
                        break;
                    case "5":
                        CheckAvailability(libraryRepository);
                        break;
                    case "6":
                        Console.WriteLine("Exiting the program.");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 6.");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void AddBook(LibraryRepository libraryRepository)
        {
            Console.WriteLine("===== Add a Book =====");
            string title = Validator.GetNonEmptyInput("Enter title: ");
            string author = Validator.GetNonEmptyInput("Enter author: ");
            string genre = Validator.GetNonEmptyInput("Enter genre: ");
            int publicationYear = Validator.GetValidPublicationYear();
            int id = libraryRepository.GetAllBooks().Count() + 1; // Generate ID based on current count
            Book newBook = new Book { Id = id, Title = title, Author = author, Genre = genre, PublicationYear = publicationYear, IsCheckedOut = false };
            libraryRepository.AddBook(newBook);
        }

        static void RemoveBook(LibraryRepository libraryRepository)
        {
            Console.WriteLine("===== Remove a Book =====");
            int id = Validator.GetValidId();
            libraryRepository.RemoveBook(id);
        }

        static void SearchBook(LibraryRepository libraryRepository)
        {
            Console.WriteLine("===== Search for a Book =====");
            string keyword = Validator.GetNonEmptyInput("Enter title or author to search: ");
            var foundBooks = libraryRepository.SearchBooks(keyword);
            if (foundBooks.Any())
            {
                Console.WriteLine("Found books:");
                foreach (var book in foundBooks)
                {
                    Console.WriteLine(book);
                }
            }
            else
            {
                Console.WriteLine("No books found matching the search criteria.");
            }
        }

        static void CheckAvailability(LibraryRepository libraryRepository)
        {
            Console.WriteLine("===== Check Book Availability =====");
            string title = Validator.GetNonEmptyInput("Enter title to check availability: ");
            libraryRepository.CheckAvailability(title);
        }
    }

}
    

