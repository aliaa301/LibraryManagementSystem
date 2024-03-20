using LibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Services.Interfaces
{
    public interface ILibraryRepository
    {
        void AddBook(Book book);
        void RemoveBook(int id);
        IEnumerable<Book> GetAllBooks();
        IEnumerable<Book> SearchBooks(string keyword);
        bool CheckAvailability(string title);
    }
}
