using LibraryManagementSystem.Models;
using LibraryManagementSystem.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Services.Repositories
{
    public class LibraryRepository : ILibraryRepository
    {
        private List<Book> _books = new List<Book>();

        public void AddBook(Book book)
        {
            _books.Add(book);
            Console.WriteLine("Book added successfully.");
        }

        public void RemoveBook(int id)
        {
            Book bookToRemove = _books.Find(b => b.Id == id);
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
        public void DisplayAllBooks()
        {
            if (_books.Count == 0)
            {
                Console.WriteLine("No books in the library.");
            }
            else
            {
                Console.WriteLine("===== All Books =====");
                foreach (Book book in _books)
                {
                    Console.WriteLine(book);
                }
            }
        }

        
    }
}
