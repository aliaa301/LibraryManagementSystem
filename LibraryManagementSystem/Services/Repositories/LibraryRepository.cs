using LibraryManagementSystem.Models;
using LibraryManagementSystem.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Services.Repositories
{
    // This class implements the ILibraryRepository interface and provides functionality for managing the library
    public class LibraryRepository : ILibraryRepository
    {
        // List to store the books in the library
        private List<Book> _books = new List<Book>();

        public void AddBook(Book book)
        {
            _books.Add(book);
            Console.WriteLine("Book added successfully.");
        }

        public void RemoveBook(int id)
        {
            // Find the book with the given ID
            Book bookToRemove = _books.Find(b => b.Id == id);
            // Check if the book is found
            if (bookToRemove != null)
            {
                Console.WriteLine("Book details:");
                Console.WriteLine(bookToRemove);
                Console.Write("Are you sure you want to delete this book? (Y/N): ");
                string confirmation = Console.ReadLine().Trim().ToUpper();
                if (confirmation == "Y")
                {
                    _books.Remove(bookToRemove);
                    Console.WriteLine("Book removed successfully.");
                }
                else
                {
                    Console.WriteLine("Deletion canceled.");
                }
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }


        public IEnumerable<Book> GetAllBooks()
        {
            return _books;
        }

        public IEnumerable<Book> SearchBooks(string keyword)
        {
            keyword = keyword.ToLower(); // Convert keyword to lowercase for case-insensitive search
            return _books.FindAll(b => b.Title.ToLower().Contains(keyword) || b.Author.ToLower().Contains(keyword));
        }

        // Find the book with the given title
        public bool CheckAvailability(string title)
        {
            Book book = _books.Find(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            if (book != null)
            {
                if (book.IsCheckedOut)
                {
                    Console.WriteLine("Book is currently checked out.");
                    return false;
                }
                else
                {
                    Console.WriteLine("Book is available.");
                    return true;
                }
            }
            else
            {
                Console.WriteLine("Book not found.");
                return false;
            }
        }
        
        // Method to display all books in the library
        public void DisplayAllBooks()
        {        
            // Check if there are books in the library
            if (_books.Count == 0)
            {
                Console.WriteLine("No books in the library.");
            }
            else
            {
                Console.WriteLine("===== All Books =====");
                // Iterate over each book and print its details
                foreach (Book book in _books)                     
                {
                    Console.WriteLine(book);
                }
            }
        }

        
    }
}
