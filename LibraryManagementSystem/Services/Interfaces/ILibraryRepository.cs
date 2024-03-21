using LibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Services.Interfaces
{
    // This interface defines methods for interacting with the library repository
    public interface ILibraryRepository
    {
        // Add a book to the repository
        void AddBook(Book book);
        
        // This interface defines methods for interacting with the library repository
        void RemoveBook(int id);
       
        // Get all books from the repository
        IEnumerable<Book> GetAllBooks();

        // Search for books in the repository based on a keyword
        IEnumerable<Book> SearchBooks(string keyword);

        // Check the availability of a book by its title
        bool CheckAvailability(string title);
    }
}
